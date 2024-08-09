using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_Nro_11
{
    public partial class EliminarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["ProductoSeleccionado"] = null;
         
            Response.Redirect("Ejercicio2.aspx");     
    }
    }
}