using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPC2
{
    public partial class Cliente : Form
    {
        Producto[] vProducto;
        int indice = 0;
        int tamanio = 10;
        bool descuento1vez = true;

        public Cliente()
        {
            vProducto = new Producto[tamanio];
            InitializeComponent();
        }

        public int Buscar_Inventario(string nombre)
        {
            int pos = -1;
            for (int i = 0; i < Inventario.indice; i++)
            {
                if (Inventario.vProducto[i].getNombre() == nombre)
                {
                    pos = i;
                }
            }
            return pos;
        }

        public int Buscar(string nombre)
        {
            int pos = -1;
            for( int i = 0; i < indice; i++)
            {
                if( vProducto[i].getNombre() == nombre)
                {
                    pos = i;
                }
            }
            return pos;
        }

        public int BuscarRepetido(string nombre, string categoria)
        {
            int pos = -1;
            for (int i = 0; i < indice; i++)
            {
                if (vProducto[i].getNombre() == nombre && vProducto[i].getCategoria() == categoria)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        public void Eliminar(int pos)
        {
            for( int i = pos+1; i < indice; i++)
            {
                vProducto[i - 1] = vProducto[i];
            }
            indice--;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (indice < tamanio)
            {
                if (cb_categoria.Text == "" || cb_producto.Text == "" || txt_cantidad.Text == "")
                {
                    MessageBox.Show("INGRESAR TODOS LOS CAMPOS");
                }
                else
                {
                    string nombre = cb_producto.Text;
                    string categoria = cb_categoria.Text;
                    int rep = BuscarRepetido(nombre, categoria);
                    if(rep == -1)
                    {
                        int cantidad = int.Parse(txt_cantidad.Text);

                        if (cantidad > 0)
                        {
                            int pos = Buscar_Inventario(nombre);

                            if (pos == -1)
                            {
                                MessageBox.Show("PRODUCTO NO ENCONTRADO");
                            }
                            else if (Inventario.vProducto[pos].getCantidad() < cantidad)
                            {
                                MessageBox.Show("NO TENEMOS SUFICIENTES UNIDADES PARA ESTE PRODUCTO");
                            }
                            else
                            {
                                if (categoria == "Bebidas")
                                {
                                    vProducto[indice] = new Bebidas(nombre, categoria, cantidad);
                                    vProducto[indice].setPrecio(Inventario.BuscarPrecio(vProducto[indice].getNombre()));
                                    indice++;
                                    MessageBox.Show("PRODUCTO AGREGADO");
                                }
                                else if (categoria == "Frutas")
                                {
                                    vProducto[indice] = new Frutas(nombre, categoria, cantidad);
                                    vProducto[indice].setPrecio(Inventario.BuscarPrecio(vProducto[indice].getNombre()));
                                    indice++;
                                    MessageBox.Show("PRODUCTO AGREGADO");
                                }
                                else if (categoria == "Verduras")
                                {
                                    vProducto[indice] = new Verduras(nombre, categoria, cantidad);
                                    vProducto[indice].setPrecio(Inventario.BuscarPrecio(vProducto[indice].getNombre()));
                                    indice++;
                                    MessageBox.Show("PRODUCTO AGREGADO");
                                }
                                else
                                {
                                    MessageBox.Show("CATEGORIA EQUIVOCADA");
                                }

                                txt_cantidad.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("INGRESE CANTIDAD POSITIVA");
                        }
                    }
                    else
                    {
                        MessageBox.Show("PRODUCTO REPETIDO. SI DESEA MODIFICARLO, ELIMINE Y VUELVA A AGREGAR");
                    }
                }
            }
            else
            {
                MessageBox.Show("VECTOR LLENO");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (cb_categoria.Text == "" || cb_producto.Text == "" )
            {
                MessageBox.Show("INGRESAR TODOS LOS CAMPOS");
            }
            else
            {
                string nombre = cb_producto.Text;
                string categoria = cb_categoria.Text;
                int pos = Buscar(nombre);
                if (pos == -1)
                {
                    MessageBox.Show("PRODUCTO NO ENCONTRADO");
                }
                else
                {
                    Eliminar(pos);
                    MessageBox.Show("PRODUCTO ELIMINADO");
                }
            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            double montoTotal = 0;
            rth_salida.Clear();
            rth_salida.AppendText("LISTADO DE PRODUCTOS:\n\n");
            for( int i = 0; i < indice; i++)
            {
                string nombre = vProducto[i].getNombre();
                string categoria = vProducto[i].getCategoria();
                double precio = vProducto[i].getPrecio();
                int cantidad = vProducto[i].getCantidad();

                rth_salida.AppendText(nombre + " (" + categoria + "):\n");
                rth_salida.AppendText("CANTIDAD: " + cantidad + " - PRECIO: S/" + precio + "\n");
                rth_salida.AppendText("TOTAL: " + cantidad * precio+"\n\n");
                montoTotal += vProducto[i].getCantidad() * precio;
            }

            rth_salida.AppendText("MONTO TOTAL: " + montoTotal);
        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = cb_categoria.Text;
            if (categoria != "")
            {
                cb_producto.Text = "";
                cb_producto.Items.Clear();
                for(int i = 0; i < Inventario.indice; i++)
                {
                    //rth_salida.AppendText(i + " - " + Inventario.vProducto[0].getCategoria()+"\n");
                    if(Inventario.vProducto[i].getCategoria() == categoria)
                    {
                        cb_producto.Items.Add(Inventario.vProducto[i].getNombre());
                    }
                }
            }
        }

        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            for( int i = 0; i < indice-1; i++)
            {
                for( int j = 0; j < indice-i-1; j++)
                {
                    double total_j = vProducto[j].getPrecio()*vProducto[j].getCantidad();
                    double total_j1 = vProducto[j + 1].getPrecio()*vProducto[j+1].getCantidad();
                    if (total_j > total_j1)
                    {
                        Producto aux = vProducto[j];
                        vProducto[j] = vProducto[j + 1];
                        vProducto[j + 1] = aux;
                    }
                }
            }
            MessageBox.Show("LISTA ORDENADA");
        }

        private void btn_descuento_Click(object sender, EventArgs e)
        {
            if (descuento1vez)
            {
                for ( int i = 0; i < indice; i++)
                {
                    string nombre = vProducto[i].getNombre();
                    string categoria = vProducto[i].getCategoria();
                    double descuento = Inventario.BuscarDescuento(nombre, categoria);
                    MessageBox.Show("EL DESCUENTO EXTRAIDO DEL INVENTARIO ES " + descuento);
                    vProducto[i].setDescuento(descuento);
                    MessageBox.Show("EL DESCUENTO DEL PRODUCTO ES " + vProducto[i].getDescuento());
                    vProducto[i].setPrecio(vProducto[i].aplicarDescuento(vProducto[i].getPrecio()));
                    MessageBox.Show("EL NUEVO PRECIO ES " + vProducto[i].getPrecio());
                }
                descuento1vez = false;
                MessageBox.Show("DESCUENTO APLICADO");
            }
            else
            {
                MessageBox.Show("YA SE APLICÓ EL DESCUENTO ANTERIORMENTE");
            }
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            for( int i = 0; i < indice; i++)
            {
                int pos = Buscar_Inventario(vProducto[i].getNombre());
                Inventario.vProducto[pos].setCantidad(Inventario.vProducto[pos].getCantidad() - vProducto[i].getCantidad());
            }
            MessageBox.Show("GRACIAS POR SU COMPRA");
        }
    }
}
