﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            bool error = false;

            foreach(char caracter in txtdato.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            // Verificamos la condición del error
            if (error)
            {
                errorProvider1.SetError(txtdato, "No se admiten números");
            }
            else
                errorProvider1.Clear();
        }

        private void txtdato_TextChanged(object sender, EventArgs e)
        {
            bool error = false;

            foreach (char caracter in txtdato.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            // Verificamos la condición del error
            if (error)
            {
                errorProvider1.SetError(txtdato, "No se admiten números");
            }
            else
                errorProvider1.Clear();
        }
    }
}
