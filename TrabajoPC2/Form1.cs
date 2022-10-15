using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TrabajoPC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
        private void btn_admin_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string contrasena = txt_contraseña.Text;

            if( usuario == "HOLA" && contrasena == "123")
            {
                lbl_error.ForeColor = Color.Green;
                lbl_error.Text = "BIENVENIDO";

                SoundPlayer Player = new SoundPlayer();
                Player.SoundLocation = "D:/Documentos unmsm/cc5/practica/Trabajo CC3/TrabajoPC2/TrabajoPC2/LaTienditaDeDonPepe.wav";
                Player.Play();

                Form formulario = new Administrador();
                formulario.Show();
            }
            else
            {
                lbl_error.ForeColor = Color.Red;
                lbl_error.Text = "USUARIO O CONTRASEÑA INCORRECTA";
            }
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            
                        SoundPlayer Player = new SoundPlayer();
                        Player.SoundLocation = "D:/Documentos unmsm/cc5/practica/Trabajo CC3/TrabajoPC2/TrabajoPC2/LaTienditaDeDonPepe.wav";
                        Player.Play();
            
            Form formulario = new Cliente();
            formulario.Show();
        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
