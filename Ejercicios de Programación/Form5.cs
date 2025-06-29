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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double basse = Convert.ToDouble(txtbase.Text);
            Double altura = Convert.ToDouble(txtaltura.Text);

            Double area = (basse * altura) / 2;

            txtarea.Text = area.ToString();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtbase.Clear();
            txtarea.Clear();
            txtbase.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
