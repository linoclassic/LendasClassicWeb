using LendasClassic.BLL;
using LendasClassic.DTO;
using System;
using System.Collections.Generic;
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

        protected void gv1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gv1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gv1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void gv1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnLimpaFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}