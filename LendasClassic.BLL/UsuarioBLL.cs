using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LendasClassic.DTO;
using LendasClassic.DAL;

namespace LendasClassic.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL objBLL = new UsuarioDAL();   

        //CREATE
        public void CadastraUsuario(UsuarioDTO objCad)
        {
            objBLL.Cadastrar(objCad);
        }

        //READ
        public List<UsuarioDTO> ListarUsuario()
        {
            return objBLL.Listar();
        }

        public List<UsuarioDTO> ListarUsLogado()
        {
            return objBLL.ListarUserLogado();
        }

        //UPDATE
        public void EditarUsuario(UsuarioDTO objEdita)
        {
            objBLL.Editar(objEdita);
        }

        public void EditarUsLogado(UsuarioDTO objEdita)
        {
            objBLL.EditarUserLogado(objEdita);
        }

        //DELETE
        public void ExcluirUsuario(int objExclui)
        {
            objBLL.Excluir(objExclui);
        }

        //AUNTENTICACAO

        public AutenticaUserDTO AutenticarUser(string objNome, string objSenha)
        {
            return objBLL.Autenticar(objNome, objSenha);
        }

    }
}
