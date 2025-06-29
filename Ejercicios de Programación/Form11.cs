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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double numero = Convert.ToDouble(txtnumero.Text);

            Double cuadrado = numero * numero;
            Double cubo = numero * numero * numero;

            txtcuadrado.Text = cuadrado.ToString();
            txtcubo.Text = cubo.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtcuadrado.Clear();
            txtcubo.Clear();
            txtnumero.Clear();
            txtnumero.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
