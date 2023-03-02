﻿using LendasClassic.BLL;
using LendasClassic.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LendasClassicWeb.Pages
{
    public partial class ManagerUsuarioADM : System.Web.UI.Page
    {
        UsuarioDTO objModelo = new UsuarioDTO();
        UsuarioBLL objBLL = new UsuarioBLL();

        public void PopularGV()
        {
            gv1.DataSource = objBLL.ListarUsuario();
            gv1.DataBind();
        }

        //messageBox
         public void MsgBox(String ex, Page pg, Object obj)
            {
               string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
             Type cstype = obj.GetType();
           ClientScriptManager cs = pg.ClientScript;
         cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        //validacao User
        private bool ValidaPage()
        {
            bool PageValido;



            if (string.IsNullOrEmpty((gv1.FooterRow.FindControl("txtNomeUsuarioFooter") as TextBox).Text.Trim()))
            {
                //(dgv1.FooterRow.FindControl("txtNomeUsuarioFooter") as TextBox).BackColor= Color.Red;
                MsgBox("Digite o nome!", Page, this);
                //(dgv1.FooterRow.FindControl("txtNomeUsuarioFooter") as TextBox).BackColor = Color.White;
                (gv1.FooterRow.FindControl("txtNomeUsuarioFooter") as TextBox).Focus();
                PageValido = false;
            }



            else if (string.IsNullOrEmpty((gv1.FooterRow.FindControl("txtEmailUsuarioFooter") as TextBox).Text.Trim()))
            {
                MsgBox("Digite o email!", this.Page, this);
                (gv1.FooterRow.FindControl("txtEmailUsuarioFooter") as TextBox).Focus();
                PageValido = false;
            }




            else if ((gv1.FooterRow.FindControl("rbl1") as RadioButtonList).SelectedIndex < 0)
            {
                MsgBox("Escolha uma das opções!", this.Page, this);
                (gv1.FooterRow.FindControl("rbl1") as RadioButtonList).Focus();
                PageValido = false;
            }



            else if (string.IsNullOrEmpty((gv1.FooterRow.FindControl("txtStatusUsuarioFooter") as TextBox).Text.Trim()))
            {
                MsgBox("Digite o status do usuário!", this.Page, this);
                (gv1.FooterRow.FindControl("txtStatusUsuarioFooter") as TextBox).Focus();
                PageValido = false;
            }
            else if (string.IsNullOrEmpty((gv1.FooterRow.FindControl("txtEmailUsuarioFooter") as TextBox).Text.Trim()))
            {
                MsgBox("Digita o email do usuário!", this.Page, this);
                (gv1.FooterRow.FindControl("txtEmailUsuarioFooter") as TextBox).Focus();
                PageValido = false;
            }
            else if (string.IsNullOrEmpty((gv1.FooterRow.FindControl("txtSenhaUsuarioFooter") as TextBox).Text.Trim()))
            {
                MsgBox("Digita a senha do usuário!", this.Page, this);
                (gv1.FooterRow.FindControl("txtSenhaUsuarioFooter") as TextBox).Focus();
                PageValido = false;
            }
            else if (string.IsNullOrEmpty((gv1.FooterRow.FindControl("txtCpfUsuarioFooter") as TextBox).Text.Trim()))
            {
                MsgBox("Digita o cpf do usuário!", this.Page, this);
                (gv1.FooterRow.FindControl("txtCpfUsuarioFooter") as TextBox).Focus();
                PageValido = false;
            }
            else if (string.IsNullOrEmpty((gv1.FooterRow.FindControl("txtTelefoneUsuarioFooter") as TextBox).Text.Trim()))
            {
                MsgBox("Digita o telefone do usuário!", this.Page, this);
                (gv1.FooterRow.FindControl("txtTelefoneUsuarioFooter") as TextBox).Focus();
                PageValido = false;
            }
            else
            {
                PageValido = true;
            }
            return PageValido;



        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopularGV();
            }
        }

        protected void gv1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Add"))
            {
                if (ValidaPage())
                {

                    objModelo.nomeUsuario = (gv1.FooterRow.FindControl("txtNomeUsuarioFooter") as TextBox).Text.Trim();

                    objModelo.fkTpUsuario = (gv1.FooterRow.FindControl("rbl1") as RadioButtonList).Text.Trim();

                    objModelo.statusUsuario = (gv1.FooterRow.FindControl("txtStatusUsuarioFooter") as TextBox).Text.Trim();

                    objModelo.emailUsuario = (gv1.FooterRow.FindControl("txtEmailUsuarioFooter") as TextBox).Text.Trim();

                    objModelo.senhaUsuario = (gv1.FooterRow.FindControl("txtSenhaUsuarioFooter") as TextBox).Text.Trim();

                    objModelo.cpfUsuario = (gv1.FooterRow.FindControl("txtCpfUsuarioFooter") as TextBox).Text.Trim();

                    objModelo.telefoneUsuario = (gv1.FooterRow.FindControl("txtTelefoneUsuarioFooter") as TextBox).Text.Trim();

                    objBLL.CadastraUsuario(objModelo);
                    PopularGV();
                    (gv1.FooterRow.FindControl("txtNomeUsuarioFooter") as TextBox).Focus();
                    lblMessage.Text = "Usuário " + objModelo.nomeUsuario + " cadastrado com sucesso !!!";

                }


            }
        }

        protected void gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
          
                objModelo.nomeUsuario = (gv1.Rows[e.RowIndex].FindControl("txtNomeUsuario") as TextBox).Text.Trim();

                objModelo.fkTpUsuario = (gv1.Rows[e.RowIndex].FindControl("rbl1") as RadioButtonList).Text.Trim();

                objModelo.statusUsuario = (gv1.Rows[e.RowIndex].FindControl("txtStatusUsuario") as TextBox).Text.Trim();

                objModelo.emailUsuario = (gv1.Rows[e.RowIndex].FindControl("txtEmailUsuario") as TextBox).Text.Trim();

                objModelo.senhaUsuario = (gv1.Rows[e.RowIndex].FindControl("txtSenhaUsuario") as TextBox).Text.Trim();

                objModelo.cpfUsuario = (gv1.Rows[e.RowIndex].FindControl("txtCpfUsuario") as TextBox).Text.Trim();

                objModelo.telefoneUsuario = (gv1.Rows[e.RowIndex].FindControl("txtTelefoneUsuario") as TextBox).Text.Trim();

                objModelo.idUsuario = Convert.ToInt32(gv1.DataKeys[e.RowIndex].Value.ToString());

                objBLL.EditarUsuario(objModelo);
                gv1.EditIndex = -1;
                PopularGV();
                lblMessage.Text = "Usuário " + objModelo.nomeUsuario + " editado com sucesso !!!" + objModelo.idUsuario;
        }

        protected void gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            objModelo.idUsuario = Convert.ToInt32(gv1.DataKeys[e.RowIndex].Value.ToString());

            objBLL.ExcluirUsuario(objModelo.idUsuario);
            PopularGV();
            lblMessage.Text = "Usuário " + objModelo.nomeUsuario + " eliminado com sucesso !!!";
        }

        protected void gv1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv1.EditIndex = e.NewEditIndex;
            PopularGV();
        }

        protected void gv1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv1.EditIndex = -1;
            PopularGV();
        }
    }
}