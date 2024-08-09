using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;




namespace TP6_GRUPO_Nro_11
{
    public partial class Mostrarproductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         if(IsPostBack == false)
            {
                grdProductosSeleccionados.DataSource = (DataTable)Session["ProductoSeleccionado"];
                grdProductosSeleccionados.DataBind();
                
            }
        }

        protected void grdProductosSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}