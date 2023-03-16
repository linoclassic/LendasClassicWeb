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
    public partial class CadastroUser : System.Web.UI.Page
    {
        UsuarioBLL objBLL = new UsuarioBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btCadastrar_Click(object sender, EventArgs e)
        {
            CadUserDTO objCadUser = new CadUserDTO();
            objCadUser.nomeUsuario = txtUsuario.Text;
            objCadUser.fkTpUsuario = 2;
            objCadUser.emailUsuario = txtEmail.Text;
            objCadUser.senhaUsuario = txtSenha.Text;
            objCadUser.cpfUsuario = txtCpf.Text;
            objCadUser.telefoneUsuario = txtTelefone.Text;

         
            objBLL.CadUser(objCadUser);

            lblMsg.Text = "Usuário cadastrado com sucesso!";
            Response.Redirect("Login.aspx");
        }
    }
}