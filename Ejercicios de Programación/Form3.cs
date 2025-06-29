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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double basse = Convert.ToDouble(txtbase.Text);
            Double altura = Convert.ToDouble(txtaltura.Text);

            Double area = basse * altura;
            Double perimetro = 2 * (basse + altura);

            txtarea.Text = area.ToString();
            txtperimetro.Text = perimetro.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtarea.Clear();
            txtperimetro.Clear();
            txtbase.Clear();
            txtbase.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
