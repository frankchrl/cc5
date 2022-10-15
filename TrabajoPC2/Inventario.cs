using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPC2
{
    public class Inventario
    {
        public static int tamanio = 100;
        public static Producto[] vProducto =  new Producto[tamanio];
        public static int indice = 0;

        public static void Insertar(Producto p)
        {
            vProducto[indice] = p;
            indice++;
        }
       
        public static double BuscarDescuento(string nombre, string categoria)
        {
            for (int i = 0; i < indice; i++)
            {
                if (vProducto[i].getNombre() == nombre && vProducto[i].getCategoria() == categoria)
                {
                    return vProducto[i].getDescuento();
                }
            }
            return 0;
        }

        public static int BuscarProductoRepetido(string nombre, string categoria)
        {
            int pos = -1;
            for( int i = 0; i < indice; i++)
            {
                if(vProducto[i].getNombre() == nombre && vProducto[i].getCategoria() == categoria)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        public static int Buscar(string nombre)
        {
            int pos = -1;
            for (int i = 0; i < indice; i++)
            {
                if(vProducto[i].getNombre() == nombre)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        public static double BuscarPrecio(string nombre)
        {
            for( int i = 0; i < indice; i++)
            {
                if (vProducto[i].getNombre() == nombre)
                {
                    return vProducto[i].getPrecio();
                }
            }
            return -1;
        }

        public static void Eliminar(int pos)
        {
            for( int i = pos+1; i < indice; i++)
            {
                vProducto[i - 1] = vProducto[i];
            }
            indice--;
        }

        public static string ListaProductos()
        {
            string mensaje = "";
            for( int i = 0; i < indice; i++)
            {
                mensaje += "Nombre: " + vProducto[i].getNombre() + "("+ vProducto[i].getCategoria()+")\n";
                mensaje += "Cantidad: " + vProducto[i].getCantidad() + " - Precio: " + vProducto[i].getPrecio() + "\n";
            }
            return mensaje;
        }

        public static string ListarPorCategoria(string categoria)
        {
            string mensaje = "";
            for( int i = 0; i < indice; i++)
            {
                if (vProducto[i].getCategoria() == categoria)
                {
                    mensaje += "Nombre: " + vProducto[i].getNombre() + "(" + vProducto[i].getCategoria() + ")\n";
                    mensaje += "Cantidad: " + vProducto[i].getCantidad() + " - Precio: " + vProducto[i].getPrecio() + "\n";
                }
            }
            return mensaje;
        }
    }
}
