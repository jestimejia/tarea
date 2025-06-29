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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            Double celsius = Convert.ToDouble(txtingresar.Text);
            Double resultado = (celsius * 9 / 5) + 32;

            txtresultado.Text = resultado.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtingresar.Clear();
            txtresultado.Clear();
            txtingresar.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
