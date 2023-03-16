using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LendasClassicWeb.Pages
{
    public partial class CadastroReservaa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                calDataReserva.Attributes["min"] = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");



            if (!Page.IsPostBack)
            {
                lblNot.Visible = true;
                lblNot.Text = "VOCÊ NÃO POSSUI UMA RESERVA ATIVA";
                lblPergunta.Visible = true;
                lblPergunta.Text = "Gostaria de realizar uma reserva?";

                btnNovaReserva.Visible = true;

                calDataReserva.Visible = false;
                btnCadastrar.Visible = false;
            }
        }

        protected void btnNovaReserva_Click(object sender, EventArgs e)
        {
            lblNot.Visible = true;
            lblNot.Text = "Escolha uma data para conhecer a melhor academia de SP";
            lblPergunta.Visible = false;

            btnNovaReserva.Visible = false;
            calDataReserva.Visible = true;
            btnCadastrar.Visible = true;
            btnCancelar.Visible = true;
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            calDataReserva.Visible = false;
            btnCadastrar.Visible = false;
            btnCancelar.Visible = false;

            lblNot.Visible = true;
            lblNot.Text = "VOCÊ NÃO POSSUI UMA RESERVA ATIVA";
            lblPergunta.Visible = true;
            lblPergunta.Text = "Gostaria de realizar uma reserva?";
            btnNovaReserva.Visible = true;
        }

        protected void calDataReserva_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Today.AddDays(1))
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Gray;
            }
            else if (e.Day.Date >= DateTime.Today)
            {
                e.Cell.BackColor = System.Drawing.Color.Green; // Dias futuros em verde
            }

            // Mantém a cor de fundo verde nos dias selecionados
            if (e.Day.Date == ((Calendar)sender).SelectedDate)
            {
                e.Cell.BackColor = System.Drawing.Color.Green;
            }
        }
    }
}