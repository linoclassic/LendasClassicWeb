using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LendasClassicWeb.Pages
{
    public partial class RservaUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int idUsuario = ObterIdUsuarioLogado(); // função que retorna o id do usuário logado

                if (UsuarioPossuiReserva(idUsuario))
                {
                    // o usuário já possui uma reserva, então exibimos os detalhes
                    ReservaDTO reserva = ObterReservaDoUsuario(idUsuario);

                    // exibir as informações da reserva
                    lblDataReserva.Text = reserva.dataReserva.ToString("dd/MM/yyyy");
                    lblStatusReserva.Text = reserva.statusReserva;
                    // exibir as informações do usuário (que já estão armazenadas no banco de dados)
                    lblNomeUsuario.Text = reserva.nomeUsuario;
                    lblEmailUsuario.Text = reserva.emailUsuario;
                    lblTelefoneUsuario.Text = reserva.telefoneUsuario;
                    lblCpfUsuario.Text = reserva.cpfUsuario;
                }
                else
                {
                    // o usuário não possui uma reserva, então exibimos um formulário para criar uma
                    pnlCriarReserva.Visible = true;
                }
            }
        }

        protected void btnCriarReserva_Click(object sender, EventArgs e)
        {
            // obter a data da reserva do formulário
            DateTime dataReserva = DateTime.Parse(txtDataReserva.Text);

            // obter o id do usuário logado
            int idUsuario = ObterIdUsuarioLogado();

            // criar a reserva
            ReservaDTO reserva = new ReservaDTO();
            reserva.dataReserva = dataReserva;
            reserva.statusReserva = "ATIVO";
            reserva.fkUsuario = idUsuario;
            ReservaDAO dao = new ReservaDAO();
            dao.Cadastrar(reserva);

            // exibir as informações da reserva criada
            lblDataReserva.Text = reserva.dataReserva.ToString("dd/MM/yyyy");
            lblStatusReserva.Text = reserva.statusReserva;
            // exibir as informações do usuário (que já estão armazenadas no banco de dados)
            lblNomeUsuario.Text = ObterNomeUsuarioLogado();
            lblEmailUsuario.Text = ObterEmailUsuarioLogado();
            lblTelefoneUsuario.Text = ObterTelefoneUsuarioLogado();
            lblCpfUsuario.Text = ObterCpfUsuarioLogado();

            // esconder o formulário de criação da reserva
            pnlCriarReserva.Visible = false;

        }
    }
}