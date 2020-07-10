namespace Proyecto_AlgebraLineal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Difuminado = new System.Windows.Forms.Button();
            this.Sobel_Inferior = new System.Windows.Forms.Button();
            this.Sobel_Izq = new System.Windows.Forms.Button();
            this.Contorno = new System.Windows.Forms.Button();
            this.Original = new System.Windows.Forms.Button();
            this.Realzar = new System.Windows.Forms.Button();
            this.Sobel_Superior = new System.Windows.Forms.Button();
            this.Sobel_Derecho = new System.Windows.Forms.Button();
            this.Afilar = new System.Windows.Forms.Button();
            this.Personalizado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.subir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ConvertirGris = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Difuminado
            // 
            this.Difuminado.Location = new System.Drawing.Point(194, 285);
            this.Difuminado.Name = "Difuminado";
            this.Difuminado.Size = new System.Drawing.Size(75, 23);
            this.Difuminado.TabIndex = 0;
            this.Difuminado.Text = "Difuminado";
            this.Difuminado.UseVisualStyleBackColor = true;
            this.Difuminado.Click += new System.EventHandler(this.Difuminado_Click);
            // 
            // Sobel_Inferior
            // 
            this.Sobel_Inferior.Location = new System.Drawing.Point(342, 284);
            this.Sobel_Inferior.Name = "Sobel_Inferior";
            this.Sobel_Inferior.Size = new System.Drawing.Size(101, 23);
            this.Sobel_Inferior.TabIndex = 1;
            this.Sobel_Inferior.Text = "Sobel Inferior";
            this.Sobel_Inferior.UseVisualStyleBackColor = true;
            this.Sobel_Inferior.Click += new System.EventHandler(this.Sobel_Inferior_Click);
            // 
            // Sobel_Izq
            // 
            this.Sobel_Izq.Location = new System.Drawing.Point(487, 284);
            this.Sobel_Izq.Name = "Sobel_Izq";
            this.Sobel_Izq.Size = new System.Drawing.Size(95, 23);
            this.Sobel_Izq.TabIndex = 2;
            this.Sobel_Izq.Text = "Sobel Izquierdo";
            this.Sobel_Izq.UseVisualStyleBackColor = true;
            this.Sobel_Izq.Click += new System.EventHandler(this.Sobel_Izq_Click);
            // 
            // Contorno
            // 
            this.Contorno.Location = new System.Drawing.Point(641, 284);
            this.Contorno.Name = "Contorno";
            this.Contorno.Size = new System.Drawing.Size(75, 23);
            this.Contorno.TabIndex = 3;
            this.Contorno.Text = "Contorno";
            this.Contorno.UseVisualStyleBackColor = true;
            this.Contorno.Click += new System.EventHandler(this.Contorno_Click);
            // 
            // Original
            // 
            this.Original.Location = new System.Drawing.Point(777, 284);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(75, 23);
            this.Original.TabIndex = 4;
            this.Original.Text = "Original";
            this.Original.UseVisualStyleBackColor = true;
            this.Original.Click += new System.EventHandler(this.Original_Click);
            // 
            // Realzar
            // 
            this.Realzar.Location = new System.Drawing.Point(264, 313);
            this.Realzar.Name = "Realzar";
            this.Realzar.Size = new System.Drawing.Size(75, 23);
            this.Realzar.TabIndex = 5;
            this.Realzar.Text = "Realzar";
            this.Realzar.UseVisualStyleBackColor = true;
            this.Realzar.Click += new System.EventHandler(this.Realzar_Click);
            // 
            // Sobel_Superior
            // 
            this.Sobel_Superior.Location = new System.Drawing.Point(419, 313);
            this.Sobel_Superior.Name = "Sobel_Superior";
            this.Sobel_Superior.Size = new System.Drawing.Size(90, 23);
            this.Sobel_Superior.TabIndex = 6;
            this.Sobel_Superior.Text = "Sobel Superior";
            this.Sobel_Superior.UseVisualStyleBackColor = true;
            this.Sobel_Superior.Click += new System.EventHandler(this.Sobel_Superior_Click);
            // 
            // Sobel_Derecho
            // 
            this.Sobel_Derecho.Location = new System.Drawing.Point(561, 313);
            this.Sobel_Derecho.Name = "Sobel_Derecho";
            this.Sobel_Derecho.Size = new System.Drawing.Size(99, 20);
            this.Sobel_Derecho.TabIndex = 7;
            this.Sobel_Derecho.Text = "Sobel Derecho";
            this.Sobel_Derecho.UseVisualStyleBackColor = true;
            this.Sobel_Derecho.Click += new System.EventHandler(this.Sobel_Derecho_Click);
            // 
            // Afilar
            // 
            this.Afilar.Location = new System.Drawing.Point(715, 313);
            this.Afilar.Name = "Afilar";
            this.Afilar.Size = new System.Drawing.Size(75, 23);
            this.Afilar.TabIndex = 8;
            this.Afilar.Text = "Afilar";
            this.Afilar.UseVisualStyleBackColor = true;
            this.Afilar.Click += new System.EventHandler(this.Afilar_Click);
            // 
            // Personalizado
            // 
            this.Personalizado.Location = new System.Drawing.Point(942, 360);
            this.Personalizado.Name = "Personalizado";
            this.Personalizado.Size = new System.Drawing.Size(101, 23);
            this.Personalizado.TabIndex = 9;
            this.Personalizado.Text = "Personalizado";
            this.Personalizado.UseVisualStyleBackColor = true;
            this.Personalizado.Click += new System.EventHandler(this.Personalizado_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(31, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(920, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(968, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1016, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(920, 293);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(968, 293);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(42, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1016, 293);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(42, 20);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(920, 319);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(42, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(968, 318);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(42, 20);
            this.textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1016, 319);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(42, 20);
            this.textBox9.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // subir
            // 
            this.subir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subir.Location = new System.Drawing.Point(31, 13);
            this.subir.Name = "subir";
            this.subir.Size = new System.Drawing.Size(97, 23);
            this.subir.TabIndex = 22;
            this.subir.Text = "Subir Imagen";
            this.subir.UseVisualStyleBackColor = true;
            this.subir.Click += new System.EventHandler(this.subir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(437, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // ConvertirGris
            // 
            this.ConvertirGris.Location = new System.Drawing.Point(338, 131);
            this.ConvertirGris.Name = "ConvertirGris";
            this.ConvertirGris.Size = new System.Drawing.Size(93, 23);
            this.ConvertirGris.TabIndex = 24;
            this.ConvertirGris.Text = "Escala Grises ->";
            this.ConvertirGris.UseVisualStyleBackColor = true;
            this.ConvertirGris.Click += new System.EventHandler(this.ConvertirGris_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(801, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(301, 210);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(532, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Filtros Digitales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Filtrada ->";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(1027, 12);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 28;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1138, 401);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ConvertirGris);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.subir);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Personalizado);
            this.Controls.Add(this.Afilar);
            this.Controls.Add(this.Sobel_Derecho);
            this.Controls.Add(this.Sobel_Superior);
            this.Controls.Add(this.Realzar);
            this.Controls.Add(this.Original);
            this.Controls.Add(this.Contorno);
            this.Controls.Add(this.Sobel_Izq);
            this.Controls.Add(this.Sobel_Inferior);
            this.Controls.Add(this.Difuminado);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Form1";
            this.Text = "Proyecto Algebra Lineal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Difuminado;
        private System.Windows.Forms.Button Sobel_Inferior;
        private System.Windows.Forms.Button Sobel_Izq;
        private System.Windows.Forms.Button Contorno;
        private System.Windows.Forms.Button Original;
        private System.Windows.Forms.Button Realzar;
        private System.Windows.Forms.Button Sobel_Superior;
        private System.Windows.Forms.Button Sobel_Derecho;
        private System.Windows.Forms.Button Afilar;
        private System.Windows.Forms.Button Personalizado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button subir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ConvertirGris;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

