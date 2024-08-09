using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_Nro_11.Clases;
using System.Data;

namespace TP6_GRUPO_Nro_11
{
    public partial class SeleccionarProductos : System.Web.UI.Page
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
            grdSeleccionarProductos.DataSource = gProductos.ObtenerProductosParaSeleccion();
            grdSeleccionarProductos.DataBind();

        }

        protected void grdSeleccionarProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string s_producto = ((Label)grdSeleccionarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdSeleccionarProducto")).Text;
            string s_NombreProducto = ((Label)grdSeleccionarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_SelectNombreProducto")).Text;
            string s_IdProveedor = ((Label)grdSeleccionarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_SelectIdProveedor")).Text;
            string s_PrecioUnidad = ((Label)grdSeleccionarProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_SelectPrecioUnitario")).Text;

            LblProductoAgregado.Text = "Productos agregados: " + s_NombreProducto;

            if(Session["ProductoSeleccionado"] == null)
            {
                Session["ProductoSeleccionado"] = crearTabla();
            }

            agregarFila((DataTable)Session["ProductoSeleccionado"], s_producto, s_NombreProducto, s_IdProveedor, s_PrecioUnidad);

        }

        protected void grdSeleccionarProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdSeleccionarProductos.PageIndex = e.NewPageIndex;
            cargarGrillaProductos();
        }

        public DataTable crearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn columna = new DataColumn("Id Producto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("Nombre Producto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("Id Proveedor", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("Precio Unitario", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            return dt;
        }

        public void agregarFila(DataTable tabla, String IdProducto, String nombre, String IdProveedor, String precio)
        {
            DataRow dr =  tabla.NewRow();
            dr["Id Producto"] = IdProducto;
            dr["Nombre Producto"] = nombre;
            dr["Id Proveedor"] = IdProveedor;
            dr["Precio Unitario"] = precio;
            tabla.Rows.Add(dr);
        }
         
    }
}