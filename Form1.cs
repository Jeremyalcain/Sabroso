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
using System.Security.Cryptography;

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

            string login_pass = txtPassword.Text;
            SHA256 Sha256 = SHA256.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
            byte[] hash = Sha256.ComputeHash(inputBytes);
            login_pass = BitConverter.ToString(hash).Replace("-", "");

            codigo.CommandText = ("SELECT * FROM admin WHERE nombreUsuario = '" + txtNombreUsuario.Text + "'and Password= '" + login_pass + "' ");


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
