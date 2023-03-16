using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LendasClassic.DTO;
using Org.BouncyCastle.Utilities.Collections;
using System.Web;
using MySqlX.XDevAPI;

namespace LendasClassic.DAL
{
    public class UsuarioDAL : Conexao
    {
        //CRUD

        //CREATE
        public void Cadastrar(UsuarioDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("INSERT INTO usuario (nomeUsuario, fkTpUsuario, statusUsuario, emailUsuario, senhaUsuario, cpfUsuario, telefoneUsuario) VALUES (@nomeUsuario, @fkTpUsuario, @statusUsuario, @emailUsuario, @senhaUsuario,  @cpfUsuario, @telefoneUsuario)", conn);
                cmd.Parameters.AddWithValue("@nomeUsuario", objCad.nomeUsuario);
                cmd.Parameters.AddWithValue("@fkTpUsuario", objCad.fkTpUsuario);
                cmd.Parameters.AddWithValue("@statusUsuario","ATIVO");
                cmd.Parameters.AddWithValue("@emailUsuario", objCad.emailUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", objCad.senhaUsuario);
                cmd.Parameters.AddWithValue("@cpfUsuario", objCad.cpfUsuario);
                cmd.Parameters.AddWithValue("@telefoneUsuario", objCad.telefoneUsuario);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar Usuário !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void CadUser(CadUserDTO objCadUser)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("INSERT INTO usuario (nomeUsuario, fkTpUsuario, statusUsuario, emailUsuario, senhaUsuario, cpfUsuario, telefoneUsuario) VALUES (@nomeUsuario, @fkTpUsuario, @statusUsuario, @emailUsuario, @senhaUsuario,  @cpfUsuario, @telefoneUsuario)", conn);
                cmd.Parameters.AddWithValue("@nomeUsuario", objCadUser.nomeUsuario);
                cmd.Parameters.AddWithValue("@fkTpUsuario", objCadUser.fkTpUsuario);
                cmd.Parameters.AddWithValue("@statusUsuario", "ATIVO");
                cmd.Parameters.AddWithValue("@emailUsuario", objCadUser.emailUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", objCadUser.senhaUsuario);
                cmd.Parameters.AddWithValue("@cpfUsuario", objCadUser.cpfUsuario);
                cmd.Parameters.AddWithValue("@telefoneUsuario", objCadUser.telefoneUsuario);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar Usuário !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


        //READ
        public List<UsuarioDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT idUsuario, nomeUsuario, descricaoTpUsuario, statusUsuario, emailUsuario, senhaUsuario, cpfUsuario, telefoneUsuario FROM usuario JOIN tpUsuario ON fkTpUsuario=idTpUsuario;", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> Lista = new List<UsuarioDTO>(); // criando lista vazia

                while (dr.Read())
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                    obj.nomeUsuario = dr["nomeUsuario"].ToString();
                    obj.fkTpUsuario = dr["descricaoTpUsuario"].ToString();
                    obj.statusUsuario = dr["statusUsuario"].ToString();
                    obj.emailUsuario = dr["emailUsuario"].ToString();
                    obj.senhaUsuario = dr["senhaUsuario"].ToString();
                    obj.cpfUsuario = dr["cpfUsuario"].ToString();
                    obj.telefoneUsuario = dr["telefoneUsuario"].ToString();
                    Lista.Add(obj);
                }
                return Lista;


            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar Usuário !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //Read User logado
        public List<UsuarioDTO> ListarUserLogado()
        {
          
            try
            {
                Conectar();
                string nomeUsuario = HttpContext.Current.Session["Usuario"].ToString();
                cmd = new MySqlCommand("SELECT idUsuario, nomeUsuario, emailUsuario, senhaUsuario, cpfUsuario, telefoneUsuario FROM usuario WHERE nomeUsuario = @nomeUsuario", conn);
                //cmd = new MySqlCommand("SELECT * FROM usuario WHERE idUsuario = @idUsuario AND nomeUsuario = @nomeUsuario", conn);
                //cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                //cmd.Parameters.AddWithValue("@nomeUsuario", HttpContext.Current.Session["Usuario"].ToString());
                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);

                dr = cmd.ExecuteReader();
                List<UsuarioDTO> ListaUsuario = new List<UsuarioDTO>(); // criando lista vazia

                while (dr.Read())
                {
                    UsuarioDTO usuario = new UsuarioDTO();
                    usuario.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                    usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                    //usuario.fkTpUsuario = Convert.ToInt32(dr["fkTpUsuario"]);
                    //usuario.statusUsuario = dr["statusUsuario"].ToString();
                    usuario.emailUsuario = dr["emailUsuario"].ToString();
                    usuario.senhaUsuario = dr["senhaUsuario"].ToString();
                    usuario.cpfUsuario = dr["cpfUsuario"].ToString();
                    usuario.telefoneUsuario = dr["telefoneUsuario"].ToString();
                    ListaUsuario.Add(usuario);
                }
                return ListaUsuario;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar usuário logado !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }

        //UPDATE
        public void Editar(UsuarioDTO objEdita)
        {
            try
            {

                //     UPDATE clienteweb SET nomeCliente = 'Eric', fkTpUsuario = 2, fkTpStatus = 1, emailCliente = 'eric@gmail.com', senhaCliente = '1111', cpfCliente = '412.403.258-78', telefoneCliente = '(11)95882-3482', cidadeCliente = 'São Paulo', estadoCliente = 'SP', bairroCliente = 'Vila Rosana', enderecoCliente = 'Rua Curupíra', numeroCliente = 12 WHERE idCliente = 1;



                Conectar();
                cmd = new MySqlCommand("UPDATE usuario SET nomeUsuario=@nomeUsuario, fkTpUsuario=@fkTpUsuario, statusUsuario=@statusUsuario, emailUsuario=@emailUsuario, senhaUsuario=@senhaUsuario, cpfUsuario=@cpfUsuario, telefoneUsuario=@telefoneUsuario WHERE idUsuario=@idUsuario", conn);
                cmd.Parameters.AddWithValue("@nomeUsuario", objEdita.nomeUsuario);
                cmd.Parameters.AddWithValue("@fkTpUsuario", objEdita.fkTpUsuario);
                cmd.Parameters.AddWithValue("@statusUsuario", objEdita.statusUsuario);
                cmd.Parameters.AddWithValue("@emailUsuario", objEdita.emailUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", objEdita.senhaUsuario);
                cmd.Parameters.AddWithValue("@cpfUsuario", objEdita.cpfUsuario);
                cmd.Parameters.AddWithValue("@telefoneUsuario", objEdita.telefoneUsuario);
                cmd.Parameters.AddWithValue("@idUsuario", objEdita.idUsuario);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao editar usuário !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //Update User Logado

        public void EditarUserLogado(UsuarioDTO objEdita)
        {
            try
            {

                Conectar();
                cmd = new MySqlCommand("UPDATE usuario SET nomeUsuario=@nomeUsuario, emailUsuario=@emailUsuario, senhaUsuario=@senhaUsuario, cpfUsuario=@cpfUsuario, telefoneUsuario=@telefoneUsuario WHERE idUsuario=@idUsuario", conn);
                cmd.Parameters.AddWithValue("@nomeUsuario", objEdita.nomeUsuario);
                cmd.Parameters.AddWithValue("@emailUsuario", objEdita.emailUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", objEdita.senhaUsuario);
                cmd.Parameters.AddWithValue("@cpfUsuario", objEdita.cpfUsuario);
                cmd.Parameters.AddWithValue("@telefoneUsuario", objEdita.telefoneUsuario);
                cmd.Parameters.AddWithValue("@idUsuario", objEdita.idUsuario);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao editar usuário !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //DELETE
        public void Excluir(int objExclui)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("DELETE FROM usuario WHERE idUsuario=@idUsuario", conn);
                cmd.Parameters.AddWithValue("@idUsuario", objExclui);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


        //Autentica User
        public AutenticaUserDTO Autenticar(string objNome, string objSenha)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT nomeUsuario, senhaUsuario, fkTpUsuario, statusUsuario FROM usuario WHERE nomeUsuario=@nomeUsuario AND senhaUsuario=@senhaUsuario AND statusUsuario='ATIVO'", conn);
                cmd.Parameters.AddWithValue("@nomeUsuario", objNome);
                cmd.Parameters.AddWithValue("@senhaUsuario", objSenha);
                dr = cmd.ExecuteReader();

                AutenticaUserDTO obj = null;
                if (dr.Read())
                {

                    obj = new AutenticaUserDTO();
                    obj.nomeUsuario = dr["nomeUsuario"].ToString();
                    obj.senhaUsuario = dr["senhaUsuario"].ToString();
                    obj.fkTpUsuario = dr["fkTpUsuario"].ToString();
                    obj.statusUsuario = dr["statusUsuario"].ToString();

                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception("Usuário não cadastrado !!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


      
    }
}
