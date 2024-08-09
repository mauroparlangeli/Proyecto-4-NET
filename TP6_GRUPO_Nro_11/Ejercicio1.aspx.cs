using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_Nro_11.Clases;

namespace TP6_GRUPO_Nro_11
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrillaProductos();
            }
        }

        public void cargarGrillaProductos()
        {
            GestionProductos gProductos = new GestionProductos();
            grdProductos.DataSource = gProductos.ObtenerTodosLosProductos();
            grdProductos.DataBind();

        }

        protected void grdProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdProductos.EditIndex = e.NewEditIndex;
            cargarGrillaProductos();
        }

        protected void grdProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s_IdProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_it_idproducto")).Text;
            Producto prod = new Producto();
            prod.IdProducto = Convert.ToInt32(s_IdProducto);
            GestionProductos gproductos = new GestionProductos();
            gproductos.EliminarProducto(prod);

            cargarGrillaProductos();

        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            cargarGrillaProductos();
        }

        protected void grdProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string s_IdProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_eit_IdProducto")).Text;
            string s_NombreProducto = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_NombreProducto")).Text;
            string s_CantPorUnidad = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_CantidadPorUnidad")).Text;
            string s_PrecioUnidad = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_PrecioUnidad")).Text;

            Producto prod = new Producto();
            prod.IdProducto = Convert.ToInt32(s_IdProducto);
            prod.NombreProducto = s_NombreProducto;
            prod.CantPorUnidad = s_CantPorUnidad;
            prod.PrecioUnidad = Convert.ToDecimal(s_PrecioUnidad);

            GestionProductos gproductos = new GestionProductos();
            gproductos.ActualizarProducto(prod);

            grdProductos.EditIndex = -1;
            cargarGrillaProductos();
        }

        protected void grdProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdProductos.EditIndex = -1;
            cargarGrillaProductos();
        }
    }
}