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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double n1 = Convert.ToDouble(txt1.Text);
            Double n2 = Convert.ToDouble(txt2.Text);
            Double n3 = Convert.ToDouble(txt3.Text);
            Double n4 = Convert.ToDouble(txt4.Text);
            Double n5 = Convert.ToDouble(txt5.Text);

            Double media = (n1 + n2 + n3 + n4 + n5) / 5;

            txtmedia.Text = media.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txtmedia.Clear();
            txt1.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
