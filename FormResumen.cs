using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabrosoSoftware
{
    public partial class FormResumen : Form
    {
        static string conexionstring = "Server=localhost; Database=bdsabroso; Uid=sabroso; pwd=123456789; port=3306";
        MySqlConnection con = new MySqlConnection(conexionstring);

        ConexionSQL cn = new ConexionSQL();
        public FormResumen()
        {
       
            InitializeComponent();

        }

        public int ConsultarDT(int mes)
        {

            return cn.ResumenMesDG(mes);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;

            }

            else this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {

        }

        private void dtgvResumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProductos_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("es-ES");

            DateTime fecha = DateTime.Now;

            string FechaEncargo = fecha.ToString("MMMM", ci);

            int mes = 0;
            if (FechaEncargo == "enero") mes = 1;
            if (FechaEncargo == "febrero") mes = 2;
            if (FechaEncargo == "marzo") mes = 3;
            if (FechaEncargo == "abril") mes = 4;
            if (FechaEncargo == "mayo") mes = 5;
            if (FechaEncargo == "junio") mes = 6;
            if (FechaEncargo == "julio") mes = 7;
            if (FechaEncargo == "agosto") mes = 8;
            if (FechaEncargo == "septiembre") mes = 9;
            if (FechaEncargo == "octubre") mes = 10;
            if (FechaEncargo == "noviembre") mes = 11;
            if (FechaEncargo == "diciembre") mes = 12;

            con.Open();
            string query = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '" + mes + "' AND eliminado = '0'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            int EncargosMes = tabla.Rows.Count;
            con.Close();

            lblEncargos.Text = ("Este mes se hicieron \n" +EncargosMes.ToString()+ " encargos");

            dtgvResumenEncargos.DataSource = cn.ConsultarTablaEncargosBusquedaResumenMesDG(mes);
            dtgvResumenEncargos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("es-ES");

            DateTime fecha = DateTime.Now;

            string FechaEncargo = fecha.ToString("dd", ci);

            int dia = int.Parse(FechaEncargo);

            con.Open();
            string query = "select id As Encargos_del_Dia from Encargos where substring(fecha, 1, 2) = '" + dia + "' AND eliminado = '0'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            int EncargosDia = tabla.Rows.Count;
            con.Close();

            lblEncargos.Text = ("Hoy se hicieron \n" + EncargosDia.ToString() + " encargos");

            dtgvResumenEncargos.DataSource = cn.ConsultarTablaEncargosBusquedaResumenDiaDG(dia);
            dtgvResumenEncargos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("es-ES");

            DateTime fecha = DateTime.Now;

            string FechaEncargo = fecha.ToString("yyyy", ci);

            int año = int.Parse(FechaEncargo);

            con.Open();
            string query = "select id As Encargos_del_Año from Encargos where substring(fecha, 7, 4) = '" + año + "' AND eliminado = '0'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);

            int EncargosAño = tabla.Rows.Count;
            con.Close();

            lblEncargos.Text = ("Este año se hicieron \n" + EncargosAño.ToString() + " encargos");

            dtgvResumenEncargos.DataSource = cn.ConsultarTablaEncargosBusquedaResumenAñoDG(año);
            dtgvResumenEncargos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
    }
}
