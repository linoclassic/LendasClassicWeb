﻿using System;
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

        //Cadastrar Usuario na página de login
        public void CadUser(CadUserDTO objCadUser)
        {
            objBLL.CadUser(objCadUser);
        }



        //READ
        public List<UsuarioDTO> ListarUsuario()
        {
            return objBLL.Listar();
        }

        //FILTRAR
        public List<FiltroUsuarioDTO> FiltrarUsuario()
        {
            return objBLL.Filtrar();
        }


        public List<UsuarioDTO> ListarUsLogado()
        {
            return objBLL.ListarUserLogado();
        }

        public void InativarStatus(UsuarioDTO objEdita)
        {
            objBLL.AlterarStatus(objEdita);
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

        public AutenticaUserDTO AutenticarUser(string objEmail, string objSenha)
        {
            return objBLL.Autenticar(objEmail, objSenha);
        }

    }
}
