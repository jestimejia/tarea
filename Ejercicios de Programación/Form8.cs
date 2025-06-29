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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double año = Convert.ToDouble(txtaño.Text);
            Double edad = 2025 - año;

            txtedad.Text = edad.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtaño.Clear();
            txtedad.Clear();
            txtaño.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
