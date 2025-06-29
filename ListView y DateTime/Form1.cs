using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Left);
            ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Left);

            lstvalimentos.Items.Add(new ListViewItem("Manzana", frutas));
            lstvalimentos.Items.Add(new ListViewItem("Pera", frutas));
            lstvalimentos.Items.Add(new ListViewItem("Sandía", frutas));
            lstvalimentos.Items.Add(new ListViewItem("Banana", frutas));
            lstvalimentos.Items.Add(new ListViewItem("Melón", frutas));
            lstvalimentos.Items.Add(new ListViewItem("Ciruela", frutas));


            ListViewItem miElemento = new ListViewItem("Pollo", carnes);
            lstvalimentos.Items.Add(miElemento);


            lstvalimentos.Items.Add(new ListViewItem("Res", carnes));
            lstvalimentos.Items.Add(new ListViewItem("Pescado", carnes));
            lstvalimentos.Items.Add(new ListViewItem("Cerdo", carnes));
            lstvalimentos.Items.Add(new ListViewItem("Codorniz", carnes));

            lstvalimentos.Groups.Add(frutas);
            lstvalimentos.Groups.Add(carnes);

        }
    }
}
