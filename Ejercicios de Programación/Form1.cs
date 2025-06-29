using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_de_Programación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            Double lps = Convert.ToDouble(txtcantidad.Text);
            Double resultado = lps * 25.90;

            label1.Text = resultado.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
