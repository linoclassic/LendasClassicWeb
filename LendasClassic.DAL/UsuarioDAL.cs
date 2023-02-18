using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LendasClassic.DTO;
using Org.BouncyCastle.Utilities.Collections;

namespace LendasClassic.DAL
{
    public class UsuarioDAL:Conexao
    {
        //CRUD

        //CREATE
        public void Cadastrar(UsuarioDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("INSERT INTO clienteWeb (nomeCliente, fkTpUsuario, statusCliente, emailCliente, cpfCliente, senhaCliente, telefoneCliente, cidadeCliente, estadoCliente, bairroCliente, enderecoCliente, numeroCliente)\r\nVALUES (@nomeCliente, @fkTpUsuario, @statusCliente, @emailCliente,\r\n@cpfCliente, @senhaCliente, @telefoneCliente, @cidadeCliente,\r\n@estadoCliente, @bairroCliente, @enderecoCliente, @numeroCliente)", conn); //clienteWeb pois o nome no db esta assim, mas segue o padrão que seria para "Usuario" (Admin/Outros)
                cmd.Parameters.AddWithValue("@nomeCliente", objCad.NomeCliente);
                cmd.Parameters.AddWithValue("@fkTpUsuario", objCad.FkTpUsuario);
                cmd.Parameters.AddWithValue("@statusCliente", objCad.StatusCliente);
                cmd.Parameters.AddWithValue("@emailCliente", objCad.EmailCliente);
                cmd.Parameters.AddWithValue("@cpfCliente", objCad.CpfCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", objCad.SenhaCliente);
                cmd.Parameters.AddWithValue("@telefoneCliente", objCad.TelefoneCliente);
                cmd.Parameters.AddWithValue("@cidadeCliente", objCad.CidadeCliente);
                cmd.Parameters.AddWithValue("@estadoCliente", objCad.EstadoCliente);
                cmd.Parameters.AddWithValue("@bairroCliente", objCad.BairroCliente);
                cmd.Parameters.AddWithValue("@enderecoCliente", objCad.EnderecoCliente);
                cmd.Parameters.AddWithValue("@numeroCliente", objCad.NumeroCliente);

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
                cmd = new MySqlCommand("SELECT nomeCliente, fkTpUsuario, statusCliente, emailCliente, cpfCliente, senhaCliente, telefoneCliente, cidadeCliente, estadoCliente, bairroCliente, enderecoCliente, numeroCliente FROM clienteweb JOIN tpUsuario ON fkTpUsuario=idTpUsuario;", conn);
                dr= cmd.ExecuteReader();
                List<UsuarioDTO> Lista = new List<UsuarioDTO>(); // criando lista vazia

                while (dr.Read())
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    obj.NomeCliente = dr["NomeCliente"].ToString();
                    obj.FkTpUsuario = dr["descricaoTpUsuario"].ToString();
                    obj.StatusCliente = dr["StatusCliente"].ToString();
                    obj.EmailCliente = dr["EmailCliente"].ToString();
                    obj.CpfCliente = dr["CpfCliente"].ToString();
                    obj.SenhaCliente = dr["SenhaCliente"].ToString();
                    obj.TelefoneCliente = dr["TelefoneCliente"].ToString();
                    obj.CidadeCliente = dr["CidadeCliente"].ToString();
                    obj.EstadoCliente = dr["EstadoCliente"].ToString();
                    obj.BairroCliente = dr["BairroCliente"].ToString();
                    obj.EnderecoCliente = dr["EnderecoCliente"].ToString();
                    obj.NumeroCliente = dr["NumeroCliente"].ToString();
                  
                    
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

        //UPDATE
        public void Editar(UsuarioDTO objEdita)
        {
            try
            {
                cmd = new MySqlCommand(" UPDATE clienteweb SET nomeCliente = @nomeCliente, fkTpUsuario = @fkTpUsuario, statusCliente = @statusCliente, emailCliente = @emailCliente, cpfCliente = @cpfCliente, senhaCliente = @senhaCliente, telefoneCliente = @telefoneCliente, cidadeCliente = @cidadeCliente, estadoCliente = @estadoCliente, bairroCliente = @bairroCliente, enderecoCliente = @enderecoCliente, numeroCliente = @numeroCliente WHERE idCliente=@idCliente", conn); //clienteWeb pois o nome no db esta assim, mas segue o padrão que seria para "Usuario" (Admin/Outros)
                cmd.Parameters.AddWithValue("@nomeCliente", objEdita.NomeCliente);
                cmd.Parameters.AddWithValue("@fkTpUsuario", objEdita.FkTpUsuario);
                cmd.Parameters.AddWithValue("@statusCliente", objEdita.StatusCliente);
                cmd.Parameters.AddWithValue("@emailCliente", objEdita.EmailCliente);
                cmd.Parameters.AddWithValue("@cpfCliente", objEdita.CpfCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", objEdita.SenhaCliente);
                cmd.Parameters.AddWithValue("@telefoneCliente", objEdita.TelefoneCliente);
                cmd.Parameters.AddWithValue("@cidadeCliente", objEdita.CidadeCliente);
                cmd.Parameters.AddWithValue("@estadoCliente", objEdita.EstadoCliente);
                cmd.Parameters.AddWithValue("@bairroCliente", objEdita.BairroCliente);
                cmd.Parameters.AddWithValue("@enderecoCliente", objEdita.EnderecoCliente);
                cmd.Parameters.AddWithValue("@numeroCliente", objEdita.NumeroCliente);
                cmd.Parameters.AddWithValue("@idCliente", objEdita.IdCliente);
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
                cmd = new MySqlCommand("DELETE FROM clienteweb WHERE idCliente=@idCliente", conn);
                cmd.Parameters.AddWithValue("@idCliente", objExclui);
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

    }
}
