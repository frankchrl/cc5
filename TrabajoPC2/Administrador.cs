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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();//inicializar los componentes de la IU (Interfaz de Usuario)
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (Inventario.indice < Inventario.tamanio)
            {
                if (cb_categoria1.Text == "" || txt_nombre.Text == "" || txt_cantidad.Text=="" || txt_precio.Text=="")
                {
                    MessageBox.Show("INGRESAR TODOS LOS CAMPOS");
                }
                else
                {
                    string categoria = cb_categoria1.Text;
                    string nombre = txt_nombre.Text;
                    int cantidad = int.Parse(txt_cantidad.Text);
                    double precio = double.Parse(txt_precio.Text);

                    if(cantidad>=0 && precio >= 0)
                    {
                        nombre = nombre.ToUpper();
                        if (categoria == "Bebidas")
                        {
                            int pos = Inventario.BuscarProductoRepetido(nombre, categoria);
                            if( pos == -1)
                            {
                                Inventario.Insertar(new Bebidas(nombre, categoria, cantidad, precio, 0));
                            }
                            else
                            {
                                Inventario.vProducto[pos].setPrecio(precio);
                                Inventario.vProducto[pos].setCantidad(Inventario.vProducto[pos].getCantidad() + cantidad);
                            }
                        }
                        else if (categoria == "Frutas")
                        {
                            int pos = Inventario.BuscarProductoRepetido(nombre, categoria);
                            if (pos == -1)
                            {
                                Inventario.Insertar(new Frutas(nombre, categoria, cantidad, precio, 0));
                            }
                            else
                            {
                                Inventario.vProducto[pos].setPrecio(precio);
                                Inventario.vProducto[pos].setCantidad(Inventario.vProducto[pos].getCantidad() + cantidad);
                            }
                        }
                        else if (categoria == "Verduras")
                        {
                            int pos = Inventario.BuscarProductoRepetido(nombre, categoria);
                            if (pos == -1)
                            {
                                Inventario.Insertar(new Verduras(nombre, categoria, cantidad, precio, 0));
                            }
                            else
                            {
                                Inventario.vProducto[pos].setPrecio(precio);
                                Inventario.vProducto[pos].setCantidad(Inventario.vProducto[pos].getCantidad() + cantidad);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR AL INGRESAR CATEGORIA");
                        }

                        txt_nombre.Clear();
                        txt_cantidad.Clear();
                        txt_precio.Clear();
                        MessageBox.Show("PRODUCTO AGREGADO AL INVENTARIO");
                    }
                    else
                    {
                        MessageBox.Show("INGRESE VALORES POSITIVOS");
                    }
                }
            }
            else
            {
                MessageBox.Show("LISTA DE PRODUCTOS EN EL INVENTARIO LLENO");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (cb_categoria1.Text == "" || txt_nombre.Text == "")
            {
                MessageBox.Show("INGRESAR TODOS LOS CAMPOS");
            }
            else
            {
                int pos = Inventario.Buscar(txt_nombre.Text);
                if(pos == -1)
                {
                    MessageBox.Show("NO SE ENCUENTRA EL PRODUCTO EN EL INVENTARIO");
                }
                else
                {
                    string nombre = txt_nombre.Text;
                    Inventario.Eliminar(pos);
                    MessageBox.Show("PRODUCTO ELIMINADO");
                }
            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            rth_salida.Clear();
            string mensaje = Inventario.ListaProductos();
            rth_salida.AppendText(mensaje);
        }

        private void btn_descuento_Click(object sender, EventArgs e)
        {
            if(cb_categoria2.Text==""|| txt_descuento.Text == "")
            {
                MessageBox.Show("INGRESAR TODOS LOS CAMPOS");
            }
            else
            {
                string categoria = cb_categoria2.Text;
                double descuento = double.Parse(txt_descuento.Text);
                if (descuento >= 0)
                {
                   for( int i = 0; i < Inventario.indice; i++)
                    {
                        if( Inventario.vProducto[i].getCategoria() == categoria)
                        {
                            Inventario.vProducto[i].setDescuento(descuento);
                        }
                    }
                    MessageBox.Show("DESCUENTO ACTUALIZADO");
                }
                else
                {
                    MessageBox.Show("EL DESCUENTO DEBE SER POSITIVO");
                }
            }
        }

        private void btn_listarcategoria_Click(object sender, EventArgs e)
        {
            string mensaje;
            rth_salida.Clear();
            rth_salida.AppendText("BEBIDAS:\n");
            mensaje = Inventario.ListarPorCategoria("Bebidas");
            rth_salida.AppendText(mensaje);
            rth_salida.AppendText("\nFRUTAS:\n");
            mensaje = Inventario.ListarPorCategoria("Frutas");
            rth_salida.AppendText(mensaje);
            rth_salida.AppendText("\nVERDURAS:\n");
            mensaje = Inventario.ListarPorCategoria("Verduras");
            rth_salida.AppendText(mensaje);
        }
    }
}
