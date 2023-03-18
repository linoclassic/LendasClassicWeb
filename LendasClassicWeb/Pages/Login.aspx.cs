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
    public partial class Loginn : System.Web.UI.Page
    {
        public void Limpar()
        {
            txtUsuario.Text = txtSenha.Text = string.Empty;
            txtUsuario.Focus();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string objEmail = txtUsuario.Text.Trim();
            string objSenha = txtSenha.Text.Trim();


            AutenticaUserDTO objModelo = new AutenticaUserDTO();
            UsuarioBLL ObjAutentica = new UsuarioBLL();
            objModelo = ObjAutentica.AutenticarUser(objEmail, objSenha);
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
                        Response.Redirect("ReservaUser.aspx");
                        break;
                }
            }
            else
            {
                Limpar();
                lblErro.Text = "*Usuário ou senha incorretos. Por favor, tente novamente.";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}