using LendasClassic.DTO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LendasClassic.DAL
{
  
    public class ReservaDAL : Conexao
    {
        public void CadastrarReserva(ReservaDTO objCad)
        {
            try
            {
                string emailUsuario = HttpContext.Current.Session["Usuario"].ToString();
                Conectar();
                cmd = new MySqlCommand("INSERT INTO reservausuariocomum (nomeUsuario, emailUsuario, telefoneUsuario, cpfUsuario, dataReserva, statusReserva) VALUES (@nomeUsuario, @emailUsuario, @telefoneUsuario, @cpfUsuario, @dataReserva, @statusReserva)", conn);
                cmd.Parameters.AddWithValue("@nomeUsuario", objCad.nomeUsuario);
                cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);
                cmd.Parameters.AddWithValue("@telefoneUsuario", objCad.telefoneUsuario);
                cmd.Parameters.AddWithValue("@cpfUsuario", objCad.cpfUsuario);
                cmd.Parameters.AddWithValue("@dataReserva", objCad.dataReserva);
                cmd.Parameters.AddWithValue("@statusReserva", objCad.StatusReserva);


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar reserva !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void CadastrarReservaa(ReservaDTO objCad)
        {
            try
            {
              
                int idUsuario = ObterIdUsuarioLogado();
                Conectar();
                cmd = new MySqlCommand("INSERT INTO reserva (dataReserva, statusReserva, fkUsuario) VALUES (@dataReserva, @statusReserva, @fkUsuario)", conn);
                cmd.Parameters.AddWithValue("@dataReserva", objCad.dataReserva);
                cmd.Parameters.AddWithValue("@statusReserva", objCad.StatusReserva);
                cmd.Parameters.AddWithValue("@fkUsuario", idUsuario);


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar reserva !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void InativarReserva(ReservaDTO objEdita)
        {
            try
            {
                string emailUsuario = HttpContext.Current.Session["Usuario"].ToString();

                Conectar();
                cmd = new MySqlCommand("UPDATE reservaUsuarioComum SET statusReserva=@statusReserva WHERE emailUsuario=@emailUsuario", conn);

                cmd.Parameters.AddWithValue("@statusReserva", objEdita.StatusCancelado);
                //cmd.Parameters.AddWithValue("@idReserva", idReserva);
                cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao alterar status da reserva !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void VerificarStatusReserva()
        {
            // Obtém o email do usuário logado
            string emailUsuario = HttpContext.Current.Session["Usuario"].ToString();


            // Obtém a lista de reservas
            ReservaDAL objDAL = new ReservaDAL();
            List<ReservaDTO> listaReservas = objDAL.Listar();

            // Percorre a lista de reservas
            foreach (ReservaDTO reserva in listaReservas)
            {
                // Verifica se a data da reserva é anterior ou igual à data atual
                if (reserva.dataReserva.Date <= DateTime.Now.Date)
                {
                    // Altera o status da reserva para "INATIVO"
                    reserva.novoStatus = "INATIVO";

                    // Atualiza o registro no banco de dados
                    AlterarStatus(reserva.idReserva, reserva.novoStatus);
                }
            }

        }

        //(ReservaDTO objEdita)
        //objEdita.novoStatus);
        //    objEdita.idReserva);
        public void AlterarStatus(int idReserva, string novoStatus)
        {
            try
            {
                string emailUsuario = HttpContext.Current.Session["Usuario"].ToString();

                Conectar();
                cmd = new MySqlCommand("UPDATE reservaUsuarioComum SET statusReserva=@statusReserva WHERE idReserva=@IdReserva AND emailUsuario=@emailUsuario", conn);
             
                cmd.Parameters.AddWithValue("@statusReserva", novoStatus);
                cmd.Parameters.AddWithValue("@idReserva", idReserva);
                cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);
               
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao alterar status da reserva !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }




        //OBTER ID DO USUARIO LOGADO
        public int ObterIdUsuarioLogado()
        {
            string emailUsuario = HttpContext.Current.Session["Usuario"].ToString();

            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT idUsuario FROM usuario WHERE emailUsuario = @emailUsuario", conn);
                cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);

                int idUsuario = Convert.ToInt32(cmd.ExecuteScalar());

                return idUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o ID do usuário logado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


        //public int ObterIdUsuarioLogado()
        //{
        //    //string nomeUsuario = HttpContext.Current.User.Identity.Name;
        //    //int idUsuario = 0;

        //    try
        //    {
        //        Conectar();
        //        string nomeUsuario = HttpContext.Current.Session["Usuario"].ToString();
        //        cmd = new MySqlCommand("SELECT idUsuario FROM Usuario WHERE nomeUsuario = @nomeUsuario", conn);
        //        cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);

        //        object resultado = cmd.ExecuteScalar();

        //        if (resultado != null && resultado != DBNull.Value)
        //        {
        //            //idUsuario = Convert.ToInt32(resultado);
        //           nomeUsuario = resultado.ToString(); 
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro ao obter ID do usuário logado: " + ex.Message);
        //    }
        //    finally
        //    {
        //        Desconectar();
        //    }

        //    return idUsuario;
        //}


        // VERIFICAR SE USUARIO JA POSSUI UMA RESERVA   

        public bool UsuarioPossuiReserva(int idUsuario)
        {
            try
            {
                //AND statusReserva = 'ATIVO'
                Conectar();
                cmd = new MySqlCommand("SELECT COUNT(*) FROM reserva WHERE fkUsuario = @idUsuario ", conn);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar se o usuário possui reserva: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }



        //public bool UsuarioPossuiReserva(int idUsuario)
        //{
        //    try
        //    {
        //        Conectar();
        //        cmd = new MySqlCommand("SELECT COUNT(*) FROM reserva WHERE fkUsuario = @idUsuario AND statusReserva = 'ATIVO'", conn);
        //        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

        //        int count = Convert.ToInt32(cmd.ExecuteScalar());

        //        return count > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro ao verificar se o usuário possui reserva: " + ex.Message);
        //    }
        //    finally
        //    {
        //        Desconectar();
        //    }
        //}

        //Verificar se o usuario possui reserva se não o mesmo possa cadastrar uma nova reserva
        public void CadastrarReservaEin(ReservaDTO reserva)
        {
            int idUsuario = ObterIdUsuarioLogado();

            // verifica se o usuário já possui uma reserva ativa
            if (UsuarioPossuiReserva(idUsuario))
            {
                throw new Exception("Usuário já possui uma reserva ativa.");
            }

            // se o usuário não possui uma reserva ativa, permite que ele crie uma nova reserva
            reserva.fkUsuario = idUsuario;
            Cadastrar(reserva);
        }


        //CRUD

        //CREATE
        public void Cadastrar(ReservaDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("INSERT INTO reserva (dataReserva, statusReserva, fkUsuario) VALUES (@dataReserva, @statusReserva, @fkUsuario)", conn);
                cmd.Parameters.AddWithValue("@dataReserva", objCad.dataReserva);
                cmd.Parameters.AddWithValue("@statusReserva", "ATIVO");
                cmd.Parameters.AddWithValue("@fkUsuario", HttpContext.Current.Session["idUsuario"]);

                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar reserva !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //READ

        //Listar Reserva User Logador
        public List<ReservaDTO> Listar()
        {

            try
            {
               

                string emailUsuario = HttpContext.Current.Session["Usuario"].ToString();

                Conectar();
                cmd = new MySqlCommand("SELECT * FROM reservaUsuarioComum WHERE emailUsuario = @emailUsuario;", conn);
                //cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);
                dr = cmd.ExecuteReader();
                List<ReservaDTO> Lista = new List<ReservaDTO>(); // criando lista vazia

                while (dr.Read())
                {
                    ReservaDTO obj = new ReservaDTO();
                    //obj.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                    obj.nomeUsuario = dr["nomeUsuario"].ToString();
                    obj.emailUsuario = dr["emailUsuario"].ToString();
                    obj.telefoneUsuario = dr["telefoneUsuario"].ToString();
                    obj.cpfUsuario = dr["cpfUsuario"].ToString();
                    obj.idReserva = Convert.ToInt32(dr["idReserva"]);
                    obj.dataReserva = DateTime.Parse(dr["dataReserva"].ToString());
                    obj.StatusReserva = dr["statusReserva"].ToString();

                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar as reservas do usuário logado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

    }
}
