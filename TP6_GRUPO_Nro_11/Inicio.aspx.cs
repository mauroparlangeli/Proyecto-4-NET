using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_Nro_11
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbEjercicio1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio1.aspx");
        }

        protected void lbEjercicio2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2.aspx");
        }
    }
}