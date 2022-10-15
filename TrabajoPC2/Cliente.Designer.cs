
namespace TrabajoPC2
{
    partial class Cliente
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.cb_producto = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.rth_salida = new System.Windows.Forms.RichTextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.btn_descuento = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_comprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabajoPC2.Properties.Resources._45c465da_fc69_4f80_93f3_a0f8ca72eb79;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Items.AddRange(new object[] {
            "Bebidas",
            "Frutas",
            "Verduras"});
            this.cb_categoria.Location = new System.Drawing.Point(81, 118);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(210, 21);
            this.cb_categoria.TabIndex = 4;
            this.cb_categoria.SelectedIndexChanged += new System.EventHandler(this.cb_categoria_SelectedIndexChanged);
            // 
            // cb_producto
            // 
            this.cb_producto.FormattingEnabled = true;
            this.cb_producto.Location = new System.Drawing.Point(81, 155);
            this.cb_producto.Name = "cb_producto";
            this.cb_producto.Size = new System.Drawing.Size(210, 21);
            this.cb_producto.TabIndex = 5;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(81, 189);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(210, 20);
            this.txt_cantidad.TabIndex = 6;
            // 
            // rth_salida
            // 
            this.rth_salida.Location = new System.Drawing.Point(16, 222);
            this.rth_salida.Name = "rth_salida";
            this.rth_salida.Size = new System.Drawing.Size(275, 172);
            this.rth_salida.TabIndex = 7;
            this.rth_salida.Text = "";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(314, 12);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(187, 23);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "AGREGAR PRODUCTO";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(314, 42);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(187, 23);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "ELIMINAR PRODUCTO";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(314, 72);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(187, 23);
            this.btn_listar.TabIndex = 10;
            this.btn_listar.Text = "LISTAR PRODUCTOS";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Location = new System.Drawing.Point(314, 102);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(187, 23);
            this.btn_ordenar.TabIndex = 11;
            this.btn_ordenar.Text = "ORDENAR PRODUCTOS";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // btn_descuento
            // 
            this.btn_descuento.Location = new System.Drawing.Point(314, 132);
            this.btn_descuento.Name = "btn_descuento";
            this.btn_descuento.Size = new System.Drawing.Size(187, 23);
            this.btn_descuento.TabIndex = 12;
            this.btn_descuento.Text = "APLICAR DESCUENTO";
            this.btn_descuento.UseVisualStyleBackColor = true;
            this.btn_descuento.Click += new System.EventHandler(this.btn_descuento_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrabajoPC2.Properties.Resources.descarga__1_;
            this.pictureBox2.Location = new System.Drawing.Point(314, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(314, 368);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(187, 23);
            this.btn_comprar.TabIndex = 14;
            this.btn_comprar.Text = "COMPRAR";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 407);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_descuento);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.rth_salida);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.cb_producto);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.ComboBox cb_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.RichTextBox rth_salida;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.Button btn_descuento;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_comprar;
    }
}