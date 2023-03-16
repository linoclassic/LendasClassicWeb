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
    public partial class RservaUser : System.Web.UI.Page
    {

        ReservaDTO objModelo = new ReservaDTO();
        ReservaBLL objBLL = new ReservaBLL();


        public void PopularGv()
        {
            int idUsuario = objBLL.ObterIdDoUsuarioLogado();

            gv1.DataSource = objBLL.ListarUsLogado  ();
                gv1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Verifica se o usuário está logado
                if (HttpContext.Current.Session["Usuario"] != null)
                {
                    string nomeUsuario = HttpContext.Current.Session["Usuario"].ToString();

                    // Obtém o ID do usuário correspondente ao nome de usuário
                    int idUsuario = objBLL.ObterIdDoUsuarioLogado();

                    // Verifica se o usuário possui uma reserva ativa
                    if (objBLL.UsuarioPossuiReserva())
                    {
                        // Exibe as informações da reserva
                        //lblMensagem.Visible = false;
                        lblMensagem.Visible = true;
                        lblMensagem.Text = "Sua Reserva ";
                      
                        gv1.Visible = true;
                        PopularGv();
                     
                    }
                    else
                    {
                        // Exibe mensagem informando que o usuário não possui uma reserva ativa
                        Response.Redirect("CadastroReserva.aspx");
                    }
                }

                //// verifica se o usuário já possui uma reserva ativa
                //if (!objBLL.UsuarioPossuiReserva())

                //{
                //    lblMensagem.Text = "Você não tem uma reserva ativa. Deseja realizar uma nova reserva?";

                //}

            }
        }

        protected void calDataReserva_SelectionChanged(object sender, EventArgs e)
        {
            TextBox txtDataReserva = (TextBox)gv1.Rows[gv1.EditIndex].FindControl("txtDataReserva");
            //txtDataReserva.Text = calDataReserva.SelectedDate.ToString("dd/MM/yyyy");
            //calDataReserva.Visible = false;
        }

        protected void gv1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv1.EditIndex = e.NewEditIndex;
            PopularGv();
        }

        protected void gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int idReserva = Convert.ToInt32(gv1.DataKeys[e.RowIndex].Value);
                GridViewRow row = gv1.Rows[e.RowIndex];
                string dataReserva = ((TextBox)row.FindControl("txtDataReserva")).Text;

                // validar a data da reserva

                //ReservaDTO objReserva = new ReservaDTO();
                objModelo.idReserva = idReserva;
                objModelo.dataReserva = Convert.ToDateTime(dataReserva);

                //ReservaBLL objReservaBLL = new ReservaBLL();
                //objBLL.Atualizar(objModelo);

                gv1.EditIndex = -1;
                PopularGv();
            }
            catch (Exception ex)
            {
                // tratar exceção
            }
        }

        protected void gv1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv1.EditIndex = -1;
            PopularGv();
        }

        protected void gv1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

       

        protected void btnNovaReserva_Click(object sender, EventArgs e)
        {
            gv1.Visible = true;
        }
    }
}