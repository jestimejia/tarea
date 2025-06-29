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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double lado = Convert.ToDouble(txtlado.Text);

            Double area = (lado * lado);
            Double perimetro = lado * 4;

            txtperimetro.Text = perimetro.ToString();
            txtarea.Text = area.ToString();

            


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtarea.Clear();
            txtperimetro.Clear();
            txtlado.Clear();
            txtlado.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
