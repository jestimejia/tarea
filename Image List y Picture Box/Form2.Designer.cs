namespace WindowsFormsApp2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.imglfotos = new System.Windows.Forms.ImageList(this.components);
            this.lblfoto = new System.Windows.Forms.Label();
            this.btncambio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imglfotos
            // 
            this.imglfotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglfotos.ImageStream")));
            this.imglfotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglfotos.Images.SetKeyName(0, "i1.png");
            this.imglfotos.Images.SetKeyName(1, "i3.png");
            this.imglfotos.Images.SetKeyName(2, "i4.png");
            // 
            // lblfoto
            // 
            this.lblfoto.ImageIndex = 0;
            this.lblfoto.ImageList = this.imglfotos;
            this.lblfoto.Location = new System.Drawing.Point(80, 125);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(100, 100);
            this.lblfoto.TabIndex = 0;
            this.lblfoto.Click += new System.EventHandler(this.lblfoto_Click);
            // 
            // btncambio
            // 
            this.btncambio.Location = new System.Drawing.Point(57, 61);
            this.btncambio.Name = "btncambio";
            this.btncambio.Size = new System.Drawing.Size(158, 44);
            this.btncambio.TabIndex = 1;
            this.btncambio.Text = "Cambiar Imagen";
            this.btncambio.UseVisualStyleBackColor = true;
            this.btncambio.Click += new System.EventHandler(this.btncambio_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 318);
            this.Controls.Add(this.btncambio);
            this.Controls.Add(this.lblfoto);
            this.Name = "Form2";
            this.Text = "Image List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imglfotos;
        private System.Windows.Forms.Label lblfoto;
        private System.Windows.Forms.Button btncambio;
    }
}