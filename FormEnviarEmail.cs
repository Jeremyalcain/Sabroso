using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net; 
using System.Net.Mail;
using Microsoft.VisualBasic;


namespace SabrosoSoftware
{
    public partial class FormEnviarEmail : Form
    {
        public FormEnviarEmail()
        {
            InitializeComponent();
        }
        public int enviarCorreo(string emisor, string password, string receptor, string mensaje)
        {
            Random r = new Random();
            int numero = r.Next(100000, 1000000);
            MailMessage msg = new MailMessage();
            msg.To.Add(receptor);
            msg.Subject = "Correo de Verificacion";
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = "Su codigo de verificaion es " + numero + " porfavor ingreselo";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress(emisor);
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential(emisor, password);
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

            return numero;
        }

     private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEnviarEmail_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            {
                if (btnMostrar.Text == "Mostrar")
                {
                    txtPassword.PasswordChar = '\0'; // \0 = Char vacío
                    btnMostrar.Text = "Ocultar";
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                    btnMostrar.Text = "Mostrar";
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            int resultado = 0;
            do
            {
                int numero = enviarCorreo(txtEmisor.Text, txtPassword.Text, txtReceptor.Text, txtMensaje.Text);
                if (numero != 0)
                {
                    try
                    {
                         resultado = Convert.ToInt32(Interaction.InputBox("Ingrese el digito", "Verificaion"));
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Caracteres no validos");
                        result = MessageBox.Show("¿Desea reenviar el correo?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    if(numero == resultado)
                    {

                        MessageBox.Show("Los numeros coinciden");
                        result = DialogResult.No;

                    }
                }

                else
                {

                    result = MessageBox.Show("¿Desea reenviar el correo?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }
            } while (result == DialogResult.Yes);

            MessageBox.Show("PROCESO TERMINADO");


        }
    }
}
