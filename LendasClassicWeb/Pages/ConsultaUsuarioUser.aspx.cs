using LendasClassic.BLL;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioBLL objBLL = new UsuarioBLL();
            gv1.DataSource = objBLL.ListarUsuario();
            gv1.DataBind();

            //iniciando session
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            lblSessionMsg.Text = "Seja bem vindo " + Session["Usuario"] + " ao Lendas Classic";

        }

 
    }
}