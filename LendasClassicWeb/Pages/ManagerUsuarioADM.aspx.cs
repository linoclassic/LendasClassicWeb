using LendasClassic.BLL;
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
                objModelo.nomeCliente = (gv1.FooterRow.FindControl("txtNomeUsuarioFooter") as TextBox).Text.Trim();

                objModelo.fkTpUsuario = (gv1.FooterRow.FindControl("rbl1") as RadioButtonList).Text.Trim();

                objModelo.fkTpStatus = (gv1.FooterRow.FindControl("rbl2") as RadioButtonList).Text.Trim();

                objModelo.emailCliente = (gv1.FooterRow.FindControl("txtEmailUsuarioFooter") as TextBox).Text.Trim();

                objModelo.senhaCliente = (gv1.FooterRow.FindControl("txtSenhaUsuarioFooter") as TextBox).Text.Trim();

                objModelo.cpfCliente = (gv1.FooterRow.FindControl("txtCpfUsuarioFooter") as TextBox).Text.Trim();

                objModelo.telefoneCliente = (gv1.FooterRow.FindControl("txtTelefoneUsuarioFooter") as TextBox).Text.Trim();

                objModelo.cidadeCliente = (gv1.FooterRow.FindControl("txtCidadeUsuarioFooter") as TextBox).Text.Trim();

                objModelo.estadoCliente = (gv1.FooterRow.FindControl("txtEstadoUsuarioFooter") as TextBox).Text.Trim();

                objModelo.bairroCliente = (gv1.FooterRow.FindControl("txtBairroUsuarioFooter") as TextBox).Text.Trim();

                objModelo.enderecoCliente = (gv1.FooterRow.FindControl("txtEnderecoUsuarioFooter") as TextBox).Text.Trim();

                objModelo.numeroCliente = (gv1.FooterRow.FindControl("txtNumeroUsuarioFooter") as TextBox).Text.Trim();

                objBLL.CadastraUsuario(objModelo);
                PopularGV();
                (gv1.FooterRow.FindControl("txtNomeUsuarioFooter") as TextBox).Focus();
                lblMessage.Text = "Usuário " + objModelo.nomeCliente + " cadastrado com sucesso !!!";



            }
        }

        protected void gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            objModelo.nomeCliente = (gv1.Rows[e.RowIndex].FindControl("txtNomeUsuario") as TextBox).Text.Trim();

            objModelo.fkTpUsuario = (gv1.Rows[e.RowIndex].FindControl("rbl1") as RadioButtonList).Text.Trim();

            objModelo.fkTpStatus = (gv1.Rows[e.RowIndex].FindControl("rbl2") as RadioButtonList).Text.Trim();

            objModelo.emailCliente = (gv1.Rows[e.RowIndex].FindControl("txtEmailUsuario") as TextBox).Text.Trim();

            objModelo.senhaCliente = (gv1.Rows[e.RowIndex].FindControl("txtSenhaUsuario") as TextBox).Text.Trim();

            objModelo.cpfCliente = (gv1.Rows[e.RowIndex].FindControl("txtCpfUsuario") as TextBox).Text.Trim();

            objModelo.telefoneCliente = (gv1.Rows[e.RowIndex].FindControl("txtTelefoneUsuario") as TextBox).Text.Trim();

            objModelo.cidadeCliente = (gv1.Rows[e.RowIndex].FindControl("txtCidadeUsuario") as TextBox).Text.Trim();

            objModelo.estadoCliente = (gv1.Rows[e.RowIndex].FindControl("txtEstadoUsuario") as TextBox).Text.Trim();

            objModelo.bairroCliente = (gv1.Rows[e.RowIndex].FindControl("txtBairroUsuario") as TextBox).Text.Trim();

            objModelo.enderecoCliente = (gv1.Rows[e.RowIndex].FindControl("txtEnderecoUsuario") as TextBox).Text.Trim();

            objModelo.numeroCliente = (gv1.Rows[e.RowIndex].FindControl("txtNumeroUsuario") as TextBox).Text.Trim();

            objModelo.idCliente = Convert.ToInt32(gv1.DataKeys[e.RowIndex].Value.ToString());

            objBLL.EditarUsuario(objModelo);
            gv1.EditIndex = -1;
            PopularGV();
            lblMessage.Text = "Usuário " + objModelo.nomeCliente + " editado com sucesso !!!";

        }

        protected void gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            objModelo.idCliente = Convert.ToInt32(gv1.DataKeys[e.RowIndex].Value.ToString());

            objBLL.ExcluirUsuario(objModelo.idCliente);
            PopularGV();
            lblMessage.Text = "Usuário " + objModelo.nomeCliente + " eliminado com sucesso !!!" + objModelo.idCliente;
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