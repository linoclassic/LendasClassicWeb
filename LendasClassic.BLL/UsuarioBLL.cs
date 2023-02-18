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

        //UPDATE
        public void EditarUsuario(UsuarioDTO objEdita)
        {
            objBLL.Editar(objEdita);
        }

        //DELETE
        public void ExcluirUsuario(int objExclui)
        {
            objBLL.Excluir(objExclui);
        }

    }
}
