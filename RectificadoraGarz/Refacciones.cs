﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectificadoraGarz
{
    public partial class Refacciones : Form
    {
        public Refacciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close()
;        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void btnRefa_Click(object sender, EventArgs e)
        {
            Form formulario = new Servicios();
            formulario.Show();
        }
    }
}
