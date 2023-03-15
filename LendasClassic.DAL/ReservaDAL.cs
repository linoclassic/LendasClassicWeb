using LendasClassic.DTO;
using MySql.Data.MySqlClient;
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
        //OBTER ID DO USUARIO LOGADO
        public int ObterIdUsuarioLogado()
        {
            string nomeUsuario = HttpContext.Current.Session["Usuario"].ToString();

            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT idUsuario FROM usuario WHERE nomeUsuario = @nomeUsuario", conn);
                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);

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
                Conectar();
                cmd = new MySqlCommand("SELECT COUNT(*) FROM reserva WHERE fkUsuario = @idUsuario AND statusReserva = 'ATIVO'", conn);
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
        public void CadastrarReserva(ReservaDTO reserva)
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
                //// Obter o id do usuário logado
                //int idUsuario = ObterIdUsuarioLogado();

                string nomeUsuario = HttpContext.Current.Session["Usuario"].ToString();

                Conectar();
                cmd = new MySqlCommand("SELECT * FROM reservaUsuarioComum WHERE nomeUsuario = @nomeUsuario;", conn);
                //cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
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
