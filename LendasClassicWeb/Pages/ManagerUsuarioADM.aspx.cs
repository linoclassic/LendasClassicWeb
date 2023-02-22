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
                objModelo.NomeCliente = (gv1.FooterRow.FindControl("txtNomeUsuarioFooter") as TextBox).Text.Trim();

                objModelo.FkTpUsuario = (gv1.FooterRow.FindControl("rbl1") as RadioButtonList).Text.Trim();

                objModelo.StatusCliente = (gv1.FooterRow.FindControl("txtStatusfUsuarioFooter") as TextBox).Text.Trim();

                objModelo.EmailCliente = (gv1.FooterRow.FindControl("txtEmailUsuarioFooter") as TextBox).Text.Trim();

                objModelo.SenhaCliente = (gv1.FooterRow.FindControl("txtSenhaUsuarioFooter") as TextBox).Text.Trim();

                objModelo.CpfCliente = (gv1.FooterRow.FindControl("txtCpfUsuarioFooter") as TextBox).Text.Trim();

                objModelo.TelefoneCliente = (gv1.FooterRow.FindControl("txtTelefoneUsuarioFooter") as TextBox).Text.Trim();

                objModelo.CidadeCliente = (gv1.FooterRow.FindControl("txtCidadeUsuarioFooter") as TextBox).Text.Trim();

                objModelo.EstadoCliente = (gv1.FooterRow.FindControl("txtEstadoUsuarioFooter") as TextBox).Text.Trim();

                objModelo.BairroCliente = (gv1.FooterRow.FindControl("txtBairroUsuarioFooter") as TextBox).Text.Trim();

                objModelo.EnderecoCliente = (gv1.FooterRow.FindControl("txtEnderecoUsuarioFooter") as TextBox).Text.Trim();

                objModelo.NumeroCliente = (gv1.FooterRow.FindControl("txtNumeroUsuarioFooter") as TextBox).Text.Trim();

                objBLL.CadastraUsuario(objModelo);
                PopularGV();
                (gv1.FooterRow.FindControl("txtNomeUsuarioFooter") as TextBox).Focus();
                lblMessage.Text = "Usuário " + objModelo.NomeCliente + " cadastrado com sucesso !!!";



            }
        }

        protected void gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            objModelo.NomeCliente = (gv1.Rows[e.RowIndex].FindControl("txtNomeUsuario") as TextBox).Text.Trim();

            objModelo.FkTpUsuario = (gv1.Rows[e.RowIndex].FindControl("rbl1") as RadioButtonList).Text.Trim();

            objModelo.StatusCliente = (gv1.Rows[e.RowIndex].FindControl("txtStatusUsuario") as TextBox).Text.Trim();

            objModelo.EmailCliente = (gv1.Rows[e.RowIndex].FindControl("txtEmailUsuario") as TextBox).Text.Trim();

            objModelo.SenhaCliente = (gv1.Rows[e.RowIndex].FindControl("txtSenhaUsuario") as TextBox).Text.Trim();

            objModelo.CpfCliente = (gv1.Rows[e.RowIndex].FindControl("txtCpfUsuario") as TextBox).Text.Trim();

            objModelo.TelefoneCliente = (gv1.Rows[e.RowIndex].FindControl("txtTelefoneUsuario") as TextBox).Text.Trim();

            objModelo.CidadeCliente = (gv1.Rows[e.RowIndex].FindControl("txtCidadeUsuario") as TextBox).Text.Trim();

            objModelo.EstadoCliente = (gv1.Rows[e.RowIndex].FindControl("txtEstadoUsuario") as TextBox).Text.Trim();

            objModelo.BairroCliente = (gv1.Rows[e.RowIndex].FindControl("txtBairroUsuario") as TextBox).Text.Trim();

            objModelo.EnderecoCliente = (gv1.Rows[e.RowIndex].FindControl("txtEnderecoUsuario") as TextBox).Text.Trim();

            objModelo.NumeroCliente = (gv1.Rows[e.RowIndex].FindControl("txtNumeroUsuario") as TextBox).Text.Trim();

            objModelo.IdCliente = Convert.ToInt32(gv1.DataKeys[e.RowIndex].Value.ToString());

            objBLL.EditarUsuario(objModelo);
            gv1.EditIndex = -1;
            PopularGV();
            lblMessage.Text = "Usuário " + objModelo.NomeCliente + " editado com sucesso !!!";

        }

        protected void gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            objModelo.IdCliente = Convert.ToInt32(gv1.DataKeys[e.RowIndex].Value.ToString());

            objBLL.ExcluirUsuario(objModelo.IdCliente);
            PopularGV();
            lblMessage.Text = "Usuário " + objModelo.NomeCliente + " eliminado com sucesso !!!";
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