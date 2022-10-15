using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPC2
{
    public abstract class Producto
    {
        private string nombre;
        private string categoria;
        private int cantidad;
        private double precio;

        public Producto( string nombre, string categoria, int cantidad, double precio)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public Producto( string nombre, string categoria, int cantidad)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.cantidad = cantidad;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getCategoria()
        {
            return categoria;
        }

        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }


        public abstract double getDescuento();
        public abstract void setDescuento(double descuento);
        public abstract double aplicarDescuento(double monto);
    }
}
