using LendasClassic.BLL;
using LendasClassic.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LendasClassicWeb.Pages
{
    public partial class ReservaUserADM : System.Web.UI.Page
    {
        ReservaDTO objModelo = new ReservaDTO();
        ReservaBLL objBLL = new ReservaBLL();
        DataTable dt = new DataTable(); 

        public void PopularGV()
        {
            gv1.DataSource = objBLL.ListarReservas();
            gv1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopularGV();
            }

            //iniciando session
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            lblSessionMsg.Text = "Reservas cadastradas ";
        }


        protected void gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            objBLL.InativarReservaADM(objModelo);
            PopularGV();
            
        }


        protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["LendasClassicConnectionString"].ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT nomeUsuario, emailUsuario, idReserva, dataReserva, statusReserva FROM reservaUsuarioComum WHERE statusReserva='" + ddl1.SelectedItem.ToString() + "'", conn))
                    {
                        da.Fill(dt);
                    }
                    gv1.DataSource = dt;
                    gv1.DataBind();
                }
            }
        }

        protected void btnLimpaFiltro_Click(object sender, EventArgs e)
        {
            PopularGV();
        }
    }
}