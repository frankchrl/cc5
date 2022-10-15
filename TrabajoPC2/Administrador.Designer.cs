
namespace TrabajoPC2
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_categoria1 = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_descuento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.rth_salida = new System.Windows.Forms.RichTextBox();
            this.cb_categoria2 = new System.Windows.Forms.ComboBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_listarcategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_categoria1
            // 
            this.cb_categoria1.FormattingEnabled = true;
            this.cb_categoria1.Items.AddRange(new object[] {
            "Bebidas",
            "Frutas",
            "Verduras"});
            this.cb_categoria1.Location = new System.Drawing.Point(85, 125);
            this.cb_categoria1.Name = "cb_categoria1";
            this.cb_categoria1.Size = new System.Drawing.Size(185, 21);
            this.cb_categoria1.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(85, 160);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(185, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categoría";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(16, 264);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(269, 23);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "AGREGAR NUEVO PRODUCTO";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(16, 294);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(269, 23);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "ELIMINAR PRODUCTO";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_descuento
            // 
            this.btn_descuento.Location = new System.Drawing.Point(319, 77);
            this.btn_descuento.Name = "btn_descuento";
            this.btn_descuento.Size = new System.Drawing.Size(236, 23);
            this.btn_descuento.TabIndex = 9;
            this.btn_descuento.Text = "APLICAR DESCUENTO";
            this.btn_descuento.UseVisualStyleBackColor = true;
            this.btn_descuento.Click += new System.EventHandler(this.btn_descuento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio (S/)";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(85, 195);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(74, 20);
            this.txt_precio.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(85, 225);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(74, 20);
            this.txt_cantidad.TabIndex = 16;
            // 
            // rth_salida
            // 
            this.rth_salida.Location = new System.Drawing.Point(319, 166);
            this.rth_salida.Name = "rth_salida";
            this.rth_salida.Size = new System.Drawing.Size(234, 170);
            this.rth_salida.TabIndex = 17;
            this.rth_salida.Text = "";
            // 
            // cb_categoria2
            // 
            this.cb_categoria2.FormattingEnabled = true;
            this.cb_categoria2.Items.AddRange(new object[] {
            "Bebidas",
            "Frutas",
            "Verduras"});
            this.cb_categoria2.Location = new System.Drawing.Point(403, 23);
            this.cb_categoria2.Name = "cb_categoria2";
            this.cb_categoria2.Size = new System.Drawing.Size(150, 21);
            this.cb_categoria2.TabIndex = 18;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(403, 51);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(150, 20);
            this.txt_descuento.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Categoría";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Descuento (%)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabajoPC2.Properties.Resources._45c465da_fc69_4f80_93f3_a0f8ca72eb79;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(319, 107);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(234, 23);
            this.btn_listar.TabIndex = 23;
            this.btn_listar.Text = "LISTAR PRODUCTOS";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_listarcategoria
            // 
            this.btn_listarcategoria.Location = new System.Drawing.Point(319, 137);
            this.btn_listarcategoria.Name = "btn_listarcategoria";
            this.btn_listarcategoria.Size = new System.Drawing.Size(234, 23);
            this.btn_listarcategoria.TabIndex = 24;
            this.btn_listarcategoria.Text = "LISTAR POR CATEGORIAS";
            this.btn_listarcategoria.UseVisualStyleBackColor = true;
            this.btn_listarcategoria.Click += new System.EventHandler(this.btn_listarcategoria_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 348);
            this.Controls.Add(this.btn_listarcategoria);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.cb_categoria2);
            this.Controls.Add(this.rth_salida);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_descuento);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.cb_categoria1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Administrador";
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_categoria1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_descuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.RichTextBox rth_salida;
        private System.Windows.Forms.ComboBox cb_categoria2;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_listarcategoria;
    }
}