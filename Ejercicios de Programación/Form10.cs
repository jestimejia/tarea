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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double p1 = Convert.ToDouble(txtproducto1.Text);
            Double p2 = Convert.ToDouble(txtproducto2.Text);
            Double p3 = Convert.ToDouble(txtproducto3.Text);

            Double tasaISV = 15;

            Double total = p1 + p2 + p3;
            Double isv = (total * tasaISV) / 100;

            txtresultado.Text = isv.ToString("F2") + "%";
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtproducto1.Clear();
            txtproducto2.Clear();
            txtproducto3.Clear();
            txtresultado.Clear();
            txtproducto1.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
