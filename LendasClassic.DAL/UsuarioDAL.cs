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
                cmd = new MySqlCommand("INSERT INTO clienteWeb (nomeCliente, emailCliente, senhaCliente, telefoneCliente, enderecoCliente, bairroCliente, cidadeCliente, estadoCliente, numeroCliente, cpfCliente, statusCliente, dataCadCliente, fkTpUsuario) VALUES (@idCliente, @nomeCliente, @emailCliente, @senhaCliente,@telefoneCliente, @enderecoCliente, @bairroCliente, @cidadeCliente, @estadoCliente, @numeroCliente, @cpfCliente, @statusCliente, @dataCadCliente, @fkTpUsuario)", conn); //clienteWeb pois o nome no db esta assim, mas segue o padrão que seria para "Usuario" (Admin/Outros)
                cmd.Parameters.AddWithValue("@nomeCliente", objCad.NomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", objCad.EmailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", objCad.SenhaCliente);
                cmd.Parameters.AddWithValue("@telefoneCliente", objCad.TelefoneCliente);
                cmd.Parameters.AddWithValue("@enderecoCliente", objCad.EnderecoCliente);
                cmd.Parameters.AddWithValue("@bairroCliente", objCad.BairroCliente);
                cmd.Parameters.AddWithValue("@cidadeCliente", objCad.CidadeCliente);
                cmd.Parameters.AddWithValue("@estadoCliente", objCad.EstadoCliente);
                cmd.Parameters.AddWithValue("@numeroCliente", objCad.NumeroCliente);
                cmd.Parameters.AddWithValue("@cpfCliente", objCad.CpfCliente);
                cmd.Parameters.AddWithValue("@statusCliente", objCad.StatusCliente);
                cmd.Parameters.AddWithValue("@dataCadCliente", objCad.DataCadCliente);
                cmd.Parameters.AddWithValue("@fkTpUsuario", objCad.FkTpUsuario);
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
                cmd = new MySqlCommand("SELECT idCliente, nomeCliente, emailCliente, senhaCliente, telefoneCliente, enderecoCliente, bairroCliente, cidadeCliente, estadoCliente, numeroCliente, cpfCliente, statusCliente, dataCadCliente, descricaoTpUsuario FROM clienteweb JOIN tpUsuario ON fkTpUsuario=idTpUsuario;", conn);
                dr= cmd.ExecuteReader();
                List<UsuarioDTO> Lista = new List<UsuarioDTO>(); // criando lista vazia

                while (dr.Read())
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    obj.EmailCliente = dr["EmailCliente"].ToString();
                    obj.SenhaCliente = dr["SenhaCliente"].ToString();
                    obj.TelefoneCliente = dr["TelefoneCliente"].ToString();
                    obj.EnderecoCliente = dr["EnderecoCliente"].ToString();
                    obj.BairroCliente = dr["BairroCliente"].ToString();
                    obj.CidadeCliente = dr["CidadeCliente"].ToString();
                    obj.EstadoCliente = dr["EstadoCliente"].ToString();
                    obj.NumeroCliente = dr["NumeroCliente"].ToString();
                    obj.CpfCliente = dr["CpfCliente"].ToString();
                    obj.StatusCliente = dr["StatusCliente"].ToString();
                    obj.DataCadCliente = Convert.ToDateTime(dr["DataCadCliente"]);
                    obj.FkTpUsuario = dr["descricaoTpUsuario"].ToString();
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
                cmd = new MySqlCommand(" UPDATE clienteweb SET nomeCliente = @nomeCliente, emailCliente = @emailCliente, senhaCliente = @senhaCliente, telefoneCliente = @telefoneCliente, enderecoCliente = @enderecoCliente, bairroCliente = @bairroCliente, cidadeCliente = @cidadeCliente, estadoCliente = @estadoCliente, numeroCliente = @numeroCliente, cpfCliente = @cpfCliente, statusCliente = @statusCliente, dataCadCliente = @dataCadCliente, fkTpUsuario = @fkTpUsuario WHERE idCliente=@idCliente", conn); //clienteWeb pois o nome no db esta assim, mas segue o padrão que seria para "Usuario" (Admin/Outros)
                cmd.Parameters.AddWithValue("@nomeCliente", objEdita.NomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", objEdita.EmailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", objEdita.SenhaCliente);
                cmd.Parameters.AddWithValue("@telefoneCliente", objEdita.TelefoneCliente);
                cmd.Parameters.AddWithValue("@enderecoCliente", objEdita.EnderecoCliente);
                cmd.Parameters.AddWithValue("@bairroCliente", objEdita.BairroCliente);
                cmd.Parameters.AddWithValue("@cidadeCliente", objEdita.CidadeCliente);
                cmd.Parameters.AddWithValue("@estadoCliente", objEdita.EstadoCliente);
                cmd.Parameters.AddWithValue("@numeroCliente", objEdita.NumeroCliente);
                cmd.Parameters.AddWithValue("@cpfCliente", objEdita.CpfCliente);
                cmd.Parameters.AddWithValue("@statusCliente", objEdita.StatusCliente);
                cmd.Parameters.AddWithValue("@dataCadCliente", objEdita.DataCadCliente);
                cmd.Parameters.AddWithValue("@fkTpUsuario", objEdita.FkTpUsuario);
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
