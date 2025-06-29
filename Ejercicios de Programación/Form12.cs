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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double distancia = Convert.ToDouble(txtdistancia.Text);
            Double velocidad = Convert.ToDouble(txtvelocidad.Text);

            Double tiempo = distancia / velocidad;

            txttiempo.Text = tiempo.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtdistancia.Clear();
            txtvelocidad.Clear();
            txttiempo.Clear();
            txtdistancia.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
