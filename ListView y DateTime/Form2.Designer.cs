namespace WindowsFormsApp4
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
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnoperaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(185, 58);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 16);
            this.lblfecha.TabIndex = 0;
            // 
            // btnoperaciones
            // 
            this.btnoperaciones.Location = new System.Drawing.Point(188, 196);
            this.btnoperaciones.Name = "btnoperaciones";
            this.btnoperaciones.Size = new System.Drawing.Size(107, 47);
            this.btnoperaciones.TabIndex = 1;
            this.btnoperaciones.Text = "Operaciones";
            this.btnoperaciones.UseVisualStyleBackColor = true;
            this.btnoperaciones.Click += new System.EventHandler(this.btnoperaciones_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 377);
            this.Controls.Add(this.btnoperaciones);
            this.Controls.Add(this.lblfecha);
            this.Name = "Form2";
            this.Text = "DateTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btnoperaciones;
    }
}