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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double radio = Convert.ToDouble(textBox1.Text);

            Double area = 3.14 * (radio * radio);
            Double circunferencia = 2 * 3.14 * radio;

            txtarea.Text = area.ToString();
            txtcircunferencia.Text = circunferencia.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtarea.Clear();
            txtcircunferencia.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
