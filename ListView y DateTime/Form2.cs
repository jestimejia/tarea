﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnoperaciones_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            string formato = "MMM ddd yy d, hh-> mm ";


            lblfecha.Text = fecha.ToString(formato);
        }
    }
}
