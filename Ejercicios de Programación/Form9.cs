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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double capital = Convert.ToDouble(txtcapital.Text);
            Double tasa = Convert.ToDouble(txttasa.Text);

            Double interes = (capital * tasa) / 100;

            txtinteres.Text = interes.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtcapital.Clear();
            txttasa.Clear();
            txtinteres.Clear();
            txtcapital.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
