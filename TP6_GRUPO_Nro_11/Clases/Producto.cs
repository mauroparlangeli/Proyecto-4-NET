using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_Nro_11.Clases
{
    public class Producto
    {
        private int i_IdProducto;
        private string s_NombreProducto;
        private string s_CantPorUnidad;
        private decimal d_PrecioUnidad;          

        public Producto()
        {
        }

        public Producto(int i_IdProducto, string s_NombreProducto, string s_CantPorUnidad, decimal d_PrecioUnidad)
        {
            this.i_IdProducto = i_IdProducto;
            this.s_NombreProducto = s_NombreProducto;
            this.s_CantPorUnidad = s_CantPorUnidad;
            this.d_PrecioUnidad = d_PrecioUnidad;          
        }

        public int IdProducto
        {
            get { return i_IdProducto; }
            set { i_IdProducto = value; }
        }

        public string NombreProducto
        {
            get { return s_NombreProducto; }
            set { s_NombreProducto = value; }
        }

        public string CantPorUnidad
        {
            get { return s_CantPorUnidad; }
            set { s_CantPorUnidad = value; }
        }

        public decimal PrecioUnidad
        {
            get { return d_PrecioUnidad; }
            set { d_PrecioUnidad = value; }
        }
    }
}