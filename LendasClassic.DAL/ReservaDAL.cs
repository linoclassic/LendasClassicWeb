using LendasClassic.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LendasClassic.DAL
{
    public class ReservaDAL : Conexao
    {
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
        public List<ReservaDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT * FROM reservausuario;", conn);
                dr = cmd.ExecuteReader();
                List<ReservaDTO> Lista = new List<ReservaDTO>(); // criando lista vazia

                while (dr.Read())
                {
                    ReservaDTO obj = new ReservaDTO();
                    obj.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                    obj.nomeUsuario = dr["nomeUsuario"].ToString(); 
                    obj.emailUsuario = dr["emailUsuario"].ToString();
                    obj.telefoneUsuario = dr["telefoneUsuario"].ToString();
                    obj.cpfUsuario = dr["cpfUsuario"].ToString();
                    obj.dataReserva = dr["cpfUsuario"].ToString();
                    
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

    }
}
