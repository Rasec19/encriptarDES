namespace Encriptar
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
            this.txtImprimir = new System.Windows.Forms.TextBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDesEncriptar = new System.Windows.Forms.Button();
            this.btnArchivos_Images = new System.Windows.Forms.Button();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImprimir
            // 
            this.txtImprimir.Location = new System.Drawing.Point(36, 174);
            this.txtImprimir.Multiline = true;
            this.txtImprimir.Name = "txtImprimir";
            this.txtImprimir.ReadOnly = true;
            this.txtImprimir.Size = new System.Drawing.Size(264, 131);
            this.txtImprimir.TabIndex = 1;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(91, 74);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(152, 20);
            this.txtDato.TabIndex = 2;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(187, 136);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 3;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.BtnEncriptar_Click);
            // 
            // btnDesEncriptar
            // 
            this.btnDesEncriptar.Location = new System.Drawing.Point(67, 136);
            this.btnDesEncriptar.Name = "btnDesEncriptar";
            this.btnDesEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnDesEncriptar.TabIndex = 4;
            this.btnDesEncriptar.Text = "Desencriptar";
            this.btnDesEncriptar.UseVisualStyleBackColor = true;
            this.btnDesEncriptar.Click += new System.EventHandler(this.BtnDesEncriptar_Click);
            // 
            // btnArchivos_Images
            // 
            this.btnArchivos_Images.Location = new System.Drawing.Point(249, 74);
            this.btnArchivos_Images.Name = "btnArchivos_Images";
            this.btnArchivos_Images.Size = new System.Drawing.Size(31, 20);
            this.btnArchivos_Images.TabIndex = 5;
            this.btnArchivos_Images.Text = "...";
            this.btnArchivos_Images.UseVisualStyleBackColor = true;
            this.btnArchivos_Images.Click += new System.EventHandler(this.BtnArchivos_Images_Click);
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(129, 100);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(75, 23);
            this.txtGuardar.TabIndex = 6;
            this.txtGuardar.Text = "Guardar";
            this.txtGuardar.UseVisualStyleBackColor = true;
            this.txtGuardar.Click += new System.EventHandler(this.TxtGuardar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.Gainsboro;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImagen.Location = new System.Drawing.Point(322, 12);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(283, 226);
            this.pbImagen.TabIndex = 7;
            this.pbImagen.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(420, 244);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(75, 23);
            this.btnImagen.TabIndex = 8;
            this.btnImagen.Text = "Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.BtnImagen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(637, 332);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.btnArchivos_Images);
            this.Controls.Add(this.btnDesEncriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.txtImprimir);
            this.Name = "Form1";
            this.Text = "Encriptacion(Algoritmo DES)";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtImprimir;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDesEncriptar;
        private System.Windows.Forms.Button btnArchivos_Images;
        private System.Windows.Forms.Button txtGuardar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnImagen;
    }
}

