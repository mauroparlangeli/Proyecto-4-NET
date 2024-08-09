using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP6_GRUPO_Nro_11.Clases
{
    public class GestionProductos
    {
        public GestionProductos()
        {
            ///constructor
        }

        private DataTable ObtenerTabla(String nombre, String consulta)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adaptador = datos.ObtenerAdaptador(consulta);
            adaptador.Fill(ds, nombre);
            return ds.Tables[nombre];
        }
        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("Productos", "select IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad from Productos");
        }

        public DataTable ObtenerProductosParaSeleccion() ///Para Ejercicio 2
        {
            return ObtenerTabla("Productos", "select IdProducto, NombreProducto, IdProveedor, PrecioUnidad from Productos");
        }

        private void ArmarParametrosProductos(ref SqlCommand Comando, Producto producto)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = producto.IdProducto;
            SqlParametros = Comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 40);
            SqlParametros.Value = producto.NombreProducto;
            SqlParametros = Comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.NVarChar, 20);
            SqlParametros.Value = producto.CantPorUnidad;
            SqlParametros = Comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
            SqlParametros.Value = producto.PrecioUnidad;
        }

        private void ParametroParaEliminarProducto(ref SqlCommand Comando, Producto producto)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = producto.IdProducto;
        }

        public bool EliminarProducto(Producto producto)
        {
            SqlCommand Comando = new SqlCommand();
            ParametroParaEliminarProducto(ref Comando, producto);
            AccesoDatos con = new AccesoDatos();
            int FilasInsertadas = con.EjecutarProcedimientoAlmacenado(Comando, "spEliminarProducto");
            if (FilasInsertadas == 1)
            { return true; }
            else 
            { return false; }
        }

        public bool ActualizarProducto(Producto producto)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosProductos(ref Comando, producto);
            AccesoDatos con = new AccesoDatos();
            int FilasInsertadas = con.EjecutarProcedimientoAlmacenado(Comando, "spActualizarProducto");
            if (FilasInsertadas == 1)
            { return true; }
            else 
            { return false; }
        }
    }
}