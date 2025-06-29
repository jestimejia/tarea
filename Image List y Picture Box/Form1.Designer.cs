namespace WindowsFormsApp2
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
            this.picimagen = new System.Windows.Forms.PictureBox();
            this.btncargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // picimagen
            // 
            this.picimagen.Image = global::WindowsFormsApp2.Properties.Resources.Spiderman;
            this.picimagen.Location = new System.Drawing.Point(94, 128);
            this.picimagen.Name = "picimagen";
            this.picimagen.Size = new System.Drawing.Size(315, 293);
            this.picimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimagen.TabIndex = 0;
            this.picimagen.TabStop = false;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(228, 66);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 1;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 474);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.picimagen);
            this.Name = "Form1";
            this.Text = "Picture Box";
            ((System.ComponentModel.ISupportInitialize)(this.picimagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picimagen;
        private System.Windows.Forms.Button btncargar;
    }
}

