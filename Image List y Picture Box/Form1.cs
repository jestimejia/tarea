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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)

           
        {
            string ruta = @"C:\Users\rocka\Desktop\Image List y Picture Box\Fantasma.png.png";

            Image MiImagen = Image.FromFile(ruta);

            picimagen.Image = MiImagen;
            picimagen.SizeMode = PictureBoxSizeMode.StretchImage;



           
        }
    }
}
