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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double p1 = Convert.ToDouble(txtprecio1.Text);
            Double p2 = Convert.ToDouble(txtprecio2.Text);
            Double p3 = Convert.ToDouble(txtprecio3.Text);
            Double p4 = Convert.ToDouble(txtprecio4.Text);
            Double p5 = Convert.ToDouble(txtprecio5.Text);

            Double descuento = Convert.ToDouble(txtdescuento.Text);

            Double d1 = p1 - (p1 * descuento / 100);
            Double d2 = p2 - (p2 * descuento / 100);
            Double d3 = p3 - (p3 * descuento / 100);
            Double d4 = p4 - (p4 * descuento / 100);
            Double d5 = p5 - (p5 * descuento / 100);

            Double media = (d1 + d2 + d3 + d4 + d5) / 5;

            Double preciofinal = d1 + d2 + d3 + d4 + d5;

            txtpreciofinal.Text = "Precios con descuento:\r\n" + d1.ToString("F2") + "," + d2.ToString("F2") + "," +
                d3.ToString("F2") + "," + d4.ToString("F2") + "," + d5.ToString("F2") + "\r\n\r\n" + "media" + media.ToString("F2")
                + "\r\n" + "Precio final total:L." + preciofinal.ToString("F2");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtdescuento.Clear();
            txtpreciofinal.Clear();
            txtprecio1.Clear();
            txtprecio2.Clear();
            txtprecio3.Clear();
            txtprecio4.Clear();
            txtprecio5.Clear();
            txtprecio1.Focus();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
