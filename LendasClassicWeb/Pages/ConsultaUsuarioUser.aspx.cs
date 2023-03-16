using LendasClassic.BLL;
using LendasClassic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LendasClassicWeb.Pages
{
    public partial class ConsultaUser : System.Web.UI.Page
    {
        UsuarioDTO objModelo = new UsuarioDTO();
        UsuarioBLL objBLL = new UsuarioBLL();

        public void PopularGvUser()
        {
            gv1.DataSource = objBLL.ListarUsLogado();
            gv1.DataBind();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (!IsPostBack)
                {
                    PopularGvUser();
                }

                //iniciando session
                if (Session["Usuario"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                lblSessionMsg.Text = "O que gostaria de fazer hoje?";

            }


        }

        protected void gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            objModelo.nomeUsuario = (gv1.Rows[e.RowIndex].FindControl("txtNomeUsuario") as TextBox).Text.Trim();

            objModelo.emailUsuario = (gv1.Rows[e.RowIndex].FindControl("txtEmailUsuario") as TextBox).Text.Trim();

            objModelo.senhaUsuario = (gv1.Rows[e.RowIndex].FindControl("txtSenhaUsuario") as TextBox).Text.Trim();

            objModelo.cpfUsuario = (gv1.Rows[e.RowIndex].FindControl("txtCpfUsuario") as TextBox).Text.Trim();

            objModelo.telefoneUsuario = (gv1.Rows[e.RowIndex].FindControl("txtTelefoneUsuario") as TextBox).Text.Trim();

            objModelo.idUsuario = Convert.ToInt32(gv1.DataKeys[e.RowIndex].Value.ToString());

            objBLL.EditarUsLogado(objModelo);
            gv1.EditIndex = -1;
            PopularGvUser();
            lblMessage.Text = "Usuário editado com sucesso !!!";
        }

        protected void gv1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv1.EditIndex = e.NewEditIndex;
            PopularGvUser();
        }

        protected void gv1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv1.EditIndex = -1;
            PopularGvUser();
        }

        protected void gv1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }
}