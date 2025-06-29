using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private int indice;

        public Form2()
        {
            InitializeComponent();
            indice = 0; 
        }

        private void lblfoto_Click(object sender, EventArgs e)
        {

        }

        private void btncambio_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 2)
                indice = 0;

            lblfoto.ImageIndex = indice;
        }
    }
}
