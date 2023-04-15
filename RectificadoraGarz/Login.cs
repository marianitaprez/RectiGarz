using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RectificadoraGarz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-2IVQ0U0\\SQLEXPRESS;database=MyCompany; integrated security=true");


        private void btnAcceso_Click(object sender, EventArgs e)
        {

            conexion.Open();
            string consulta = "select * from Users where LoginName='" + txtuser.Text+ "' and Password='" + txtcontrasena.Text+"'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
             
            if (lector.HasRows == true)
            {

                Form1 frmPrincipal = new Form1();
                this.Hide();
                frmPrincipal.Show();
            }

            else {
                MessageBox.Show("Ususario o contraseña incorrecta");

            }

            conexion.Close();
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
