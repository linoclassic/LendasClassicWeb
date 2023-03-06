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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string objNome = txtUsuario.Text.Trim();
            string objSenha = txtSenha.Text.Trim();

            AutenticaUserDTO objModelo = new AutenticaUserDTO();
            UsuarioBLL ObjAutentica = new UsuarioBLL();
            objModelo = ObjAutentica.AutenticarUser(objNome, objSenha);

            if (objModelo != null && objModelo.statusUsuario == "ATIVO")
            {
                switch (objModelo.fkTpUsuario)
                {
                    case "1":
                        Session["Usuario"] = txtUsuario.Text.Trim();
                        Response.Redirect("ManagerUsuarioADM.aspx");
                        break;

                    case "2":
                        Session["Usuario"] = txtUsuario.Text.Trim();
                        Response.Redirect("ConsultaUser.aspx");
                        break;
                }
            }
            else
            {
                lblMensagem.Text = "Usuário não cadastrado ou inativo!";
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}