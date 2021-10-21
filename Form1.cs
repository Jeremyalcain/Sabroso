using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabrosoSoftware
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            MySqlConnection conectar = new MySqlConnection("Server=localhost; Database=bdsabroso; Uid=sabroso; pwd=123456789;");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;

            codigo.CommandText = ("SELECT * FROM admin WHERE nombreUsuario = '" + txtNombreUsuario.Text + "'and Password= '" + txtPassword.Text + "' ");

            MySqlDataReader leer = codigo.ExecuteReader();
           
            if (leer.Read())
            {

                new Main().Show();
                this.Hide();

            }

            else
            {

                MessageBox.Show("El nombre de usuario o la contraeña son incorrectos, intentalo de nuevo");
                txtNombreUsuario.Clear();
                txtPassword.Clear();
                txtNombreUsuario.Focus();
            }

            conectar.Close();

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
