﻿using MySql.Data.MySqlClient;
using LendasClassic.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LendasClassic.DTO;

namespace LendasClassic.BLL
{
    public class ReservaBLL : Conexao
    {
        ReservaDAL objBLL = new ReservaDAL();

        public bool UsuarioPossuiReserva()
        {
            int idUsuario = objBLL.ObterIdUsuarioLogado();
            return objBLL.UsuarioPossuiReserva(idUsuario);
        }

        public void CadastrarReserva(ReservaDTO reserva)
        {

            objBLL.CadastrarReserva(reserva);
        }

        public int ObterIdDoUsuarioLogado()
        {
            //return objBLL.ObterIdUsuarioLogado();
            return objBLL.ObterIdUsuarioLogado();
        }

        public List<ReservaDTO> ListarUsLogado()
        {
            return objBLL.Listar();
        }


    }
}
