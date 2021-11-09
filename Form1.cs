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
using Microsoft.VisualBasic;
using System.Net;
using System.Net.Mail;

namespace SabrosoSoftware
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
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

        private void lblRecuperarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Random r = new Random();
            int numero = r.Next(100000, 1000000);
            MailMessage msg = new MailMessage();
            msg.To.Add("jerealcain@gmail.com");
            msg.Subject = "Correo de Verificacion";
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = "Su codigo de verificaion es " + numero + " porfavor ingreselo";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress("udesoftware@gmail.com");
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential("udesoftware@gmail.com", "udesoftware2021!");
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";

            try
            {
                client.Send(msg);
                MessageBox.Show("¡Mensaje enviado!");
            }
            catch (Exception error)
            {
                MessageBox.Show("No se ha podido enviar el correo\n\n" + error.ToString());
                numero = 0;
            }

            DialogResult result = DialogResult.No;

            do
            {
                int resultado = 0;
                if (numero != 0)
                {
                   
                        resultado = Convert.ToInt32(Interaction.InputBox("Ingrese el codigo de verificacion ", "Verificacion"));
                }
                
              if (numero == resultado)
                  {

                        MessageBox.Show("Acceso permitido, su contraseña es Uruguay1101");
                       
                        result = DialogResult.No;
                        new Main().Show();
                        this.Hide();

                    }

                else
                {
                    MessageBox.Show("Acceso Denegado");
                    result = MessageBox.Show("¿Desea reenviar el correo?", "CODIGO INCORRECTO!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }

            } while (result == DialogResult.Yes);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
