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
                cmd = new MySqlCommand("INSERT INTO clienteWeb (nomeCliente, fkTpUsuario, fkTpStatus, emailCliente, senhaCliente, cpfCliente, telefoneCliente, cidadeCliente, estadoCliente, bairroCliente, enderecoCliente, numeroCliente) VALUES (@nomeCliente, @fkTpUsuario, @fkTpStatus, @emailCliente, @senhaCliente,  @cpfCliente, @telefoneCliente, @cidadeCliente, @estadoCliente, @bairroCliente, @enderecoCliente, @numeroCliente)", conn); //clienteWeb pois o nome no db esta assim, mas segue o padrão que seria para "Usuario" (Admin/Outros)
                cmd.Parameters.AddWithValue("@nomeCliente", objCad.nomeCliente);
                cmd.Parameters.AddWithValue("@fkTpUsuario", objCad.fkTpUsuario);
                cmd.Parameters.AddWithValue("@fkTpStatus", objCad.fkTpStatus);
                cmd.Parameters.AddWithValue("@emailCliente", objCad.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", objCad.senhaCliente);
                cmd.Parameters.AddWithValue("@cpfCliente", objCad.cpfCliente);
                cmd.Parameters.AddWithValue("@telefoneCliente", objCad.telefoneCliente);
                cmd.Parameters.AddWithValue("@cidadeCliente", objCad.cidadeCliente);
                cmd.Parameters.AddWithValue("@estadoCliente", objCad.estadoCliente);
                cmd.Parameters.AddWithValue("@bairroCliente", objCad.bairroCliente);
                cmd.Parameters.AddWithValue("@enderecoCliente", objCad.enderecoCliente);
                cmd.Parameters.AddWithValue("@numeroCliente", objCad.numeroCliente);

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
                cmd = new MySqlCommand("SELECT  idCliente, nomeCliente, descricaoTpUsuario, descricaoStatus, emailCliente, senhaCliente, cpfCliente, telefoneCliente, cidadeCliente, estadoCliente, bairroCliente, enderecoCliente, numeroCliente FROM clienteweb JOIN tpUsuario ON FkTpUsuario=idTpUsuario JOIN tpStatus ON fkTpStatus=idStatus;", conn);
                dr= cmd.ExecuteReader();
                List<UsuarioDTO> Lista = new List<UsuarioDTO>(); // criando lista vazia

                while (dr.Read())
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.idCliente = Convert.ToInt32(dr["idCliente"]);
                    obj.nomeCliente = dr["NomeCliente"].ToString();
                    obj.fkTpUsuario = dr["descricaoTpUsuario"].ToString();
                    obj.fkTpStatus = dr["descricaoStatus"].ToString();
                    obj.emailCliente = dr["EmailCliente"].ToString();
                    obj.senhaCliente = dr["SenhaCliente"].ToString();
                    obj.cpfCliente = dr["CpfCliente"].ToString();
                    obj.telefoneCliente = dr["TelefoneCliente"].ToString();
                    obj.cidadeCliente = dr["CidadeCliente"].ToString();
                    obj.estadoCliente = dr["EstadoCliente"].ToString();
                    obj.bairroCliente = dr["BairroCliente"].ToString();
                    obj.enderecoCliente = dr["EnderecoCliente"].ToString();
                    obj.numeroCliente = dr["NumeroCliente"].ToString();
                  
                    
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

           //     UPDATE clienteweb SET nomeCliente = 'Eric', fkTpUsuario = 2, fkTpStatus = 1, emailCliente = 'eric@gmail.com', senhaCliente = '1111', cpfCliente = '412.403.258-78', telefoneCliente = '(11)95882-3482', cidadeCliente = 'São Paulo', estadoCliente = 'SP', bairroCliente = 'Vila Rosana', enderecoCliente = 'Rua Curupíra', numeroCliente = 12 WHERE idCliente = 1;



                Conectar();
                cmd = new MySqlCommand("UPDATE clienteweb SET nomeCliente=@nomeCliente, fkTpUsuario=@fkTpUsuario, fkTpStatus=@fkTpStatus, emailCliente=@emailCliente, senhaCliente=@senhaCliente, cpfCliente=@cpfCliente, telefoneCliente=@telefoneCliente, cidadeCliente=@cidadeCliente, estadoCliente=@estadoCliente, bairroCliente=@bairroCliente, enderecoCliente=@enderecoCliente, numeroCliente=@numeroCliente WHERE idCliente=@idCliente", conn); //clienteWeb pois o nome no db esta assim, mas segue o padrão que seria para "Usuario" (Admin/Outros)
                cmd.Parameters.AddWithValue("@nomeCliente", objEdita.nomeCliente);
                cmd.Parameters.AddWithValue("@fkTpUsuario", objEdita.fkTpUsuario);
                cmd.Parameters.AddWithValue("@fkTpStatus", objEdita.fkTpStatus);
                cmd.Parameters.AddWithValue("@emailCliente", objEdita.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", objEdita.senhaCliente);
                cmd.Parameters.AddWithValue("@cpfCliente", objEdita.cpfCliente);
                cmd.Parameters.AddWithValue("@telefoneCliente", objEdita.telefoneCliente);
                cmd.Parameters.AddWithValue("@cidadeCliente", objEdita.cidadeCliente);
                cmd.Parameters.AddWithValue("@estadoCliente", objEdita.estadoCliente);
                cmd.Parameters.AddWithValue("@bairroCliente", objEdita.bairroCliente);
                cmd.Parameters.AddWithValue("@enderecoCliente", objEdita.enderecoCliente);
                cmd.Parameters.AddWithValue("@numeroCliente", objEdita.numeroCliente);
                cmd.Parameters.AddWithValue("@idCliente", objEdita.idCliente);
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
