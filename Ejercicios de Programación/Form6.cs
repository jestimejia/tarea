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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double D = Convert.ToDouble(txtdiagonalmayor.Text);
            Double d = Convert.ToDouble(txtdiagonalmenor.Text);

            Double area = (D * d) / 2;

            txtarea.Text = area.ToString();
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtarea.Clear();
            txtdiagonalmayor.Clear();
            txtdiagonalmenor.Clear();
            txtdiagonalmayor.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
