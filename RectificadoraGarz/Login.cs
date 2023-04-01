using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Visible = true;
            Visible = false;
        }
    }
}
