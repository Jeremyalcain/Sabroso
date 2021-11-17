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

        private void FormResumen_Load(object sender, EventArgs e)
        {
            panelGrafica.Hide();
            panelEnero.Hide();
            panelFebrero.Hide();
            panelMarzo.Hide();
            panelAbril.Hide();
            panelMayo.Hide();
            panelJunio.Hide();
            panelJulio.Hide();
            panelAgosto.Hide();
            panelSeptiembre.Hide();
            panelOctubre.Hide();
            panelNoviembre.Hide();
            panelDiciembre.Hide();

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
            panelGrafica.Hide();
            panelEnero.Hide();
            panelFebrero.Hide();
            panelMarzo.Hide();
            panelAbril.Hide();
            panelMayo.Hide();
            panelJunio.Hide();
            panelJulio.Hide();
            panelAgosto.Hide();
            panelSeptiembre.Hide();
            panelOctubre.Hide();
            panelNoviembre.Hide();
            panelDiciembre.Hide();
            dtgvResumenEncargos.Show();

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
            panelGrafica.Hide();
            panelEnero.Hide();
            panelFebrero.Hide();
            panelMarzo.Hide();
            panelAbril.Hide();
            panelMayo.Hide();
            panelJunio.Hide();
            panelJulio.Hide();
            panelAgosto.Hide();
            panelSeptiembre.Hide();
            panelOctubre.Hide();
            panelNoviembre.Hide();
            panelDiciembre.Hide();
            dtgvResumenEncargos.Show();

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
            panelGrafica.Hide();
            panelEnero.Hide();
            panelFebrero.Hide();
            panelMarzo.Hide();
            panelAbril.Hide();
            panelMayo.Hide();
            panelJunio.Hide();
            panelJulio.Hide();
            panelAgosto.Hide();
            panelSeptiembre.Hide();
            panelOctubre.Hide();
            panelNoviembre.Hide();
            panelDiciembre.Hide();
            dtgvResumenEncargos.Show();

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

        private void button1_Click(object sender, EventArgs e)
        {
            dtgvResumenEncargos.Hide();
            lblEncargos.Text = "";
            panelGrafica.Show();
            panelEnero.Show();
            panelFebrero.Show();
            panelMarzo.Show();
            panelAbril.Show();
            panelMayo.Show();
            panelJunio.Show();
            panelJulio.Show();
            panelAgosto.Show();
            panelSeptiembre.Show();
            panelOctubre.Show();
            panelNoviembre.Show();
            panelDiciembre.Show();
            int Envio = 1;
            int Enero = 0;
            int Febrero = 0;
            int Marzo = 0;
            int Abril = 0;
            int Mayo = 0;
            int Junio = 0;
            int Julio = 0;
            int Agosto = 0;
            int Septiembre = 0;
            int Octubre = 0;
            int Noviembre = 0;
            int Diciembre = 0;
            

            con.Open();
            string query1 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '1' AND eliminado = '0'";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            MySqlDataAdapter data1 = new MySqlDataAdapter(cmd1);
            DataTable tabla1 = new DataTable();
            data1.FillAsync(tabla1);

            int EncargosEnero = tabla1.Rows.Count;
            con.Close();

            con.Open();
            string query2 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '2' AND eliminado = '0'";
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter data2 = new MySqlDataAdapter(cmd2);
            DataTable tabla2 = new DataTable();
            data2.FillAsync(tabla2);

            int EncargosFebrero = tabla2.Rows.Count;
            con.Close();

            con.Open();
            string query3 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '3' AND eliminado = '0'";
            MySqlCommand cmd3 = new MySqlCommand(query3, con);
            MySqlDataAdapter data3 = new MySqlDataAdapter(cmd3);
            DataTable tabla3 = new DataTable();
            data3.FillAsync(tabla3);

            int EncargosMarzo = tabla3.Rows.Count;
            con.Close();

            con.Open();
            string query4 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '4' AND eliminado = '0'";
            MySqlCommand cmd4 = new MySqlCommand(query4, con);
            MySqlDataAdapter data4 = new MySqlDataAdapter(cmd4);
            DataTable tabla4 = new DataTable();
            data4.FillAsync(tabla4);

            int EncargosAbril = tabla4.Rows.Count;
            con.Close();

            con.Open();
            string query5 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '5' AND eliminado = '0'";
            MySqlCommand cmd5 = new MySqlCommand(query5, con);
            MySqlDataAdapter data5 = new MySqlDataAdapter(cmd5);
            DataTable tabla5 = new DataTable();
            data5.FillAsync(tabla5);

            int EncargosMayo = tabla5.Rows.Count;
            con.Close();

            con.Open();
            string query6 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '6' AND eliminado = '0'";
            MySqlCommand cmd6 = new MySqlCommand(query6, con);
            MySqlDataAdapter data6 = new MySqlDataAdapter(cmd6);
            DataTable tabla6 = new DataTable();
            data6.FillAsync(tabla6);

            int EncargosJunio = tabla6.Rows.Count;
            con.Close();

            con.Open();
            string query7 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '7' AND eliminado = '0'";
            MySqlCommand cmd7 = new MySqlCommand(query7, con);
            MySqlDataAdapter data7 = new MySqlDataAdapter(cmd7);
            DataTable tabla7 = new DataTable();
            data7.FillAsync(tabla7);

            int EncargosJulio = tabla7.Rows.Count;
            con.Close();

            con.Open();
            string query8 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '8' AND eliminado = '0'";
            MySqlCommand cmd8 = new MySqlCommand(query8, con);
            MySqlDataAdapter data8 = new MySqlDataAdapter(cmd8);
            DataTable tabla8 = new DataTable();
            data8.FillAsync(tabla8);

            int EncargosAgosto = tabla8.Rows.Count;
            con.Close();

            con.Open();
            string query9 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '9' AND eliminado = '0'";
            MySqlCommand cmd9 = new MySqlCommand(query9, con);
            MySqlDataAdapter data9 = new MySqlDataAdapter(cmd9);
            DataTable tabla9 = new DataTable();
            data9.FillAsync(tabla9);

            int EncargosSeptiembre = tabla9.Rows.Count;
            con.Close();

            con.Open();
            string query10 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '10' AND eliminado = '0'";
            MySqlCommand cmd10 = new MySqlCommand(query10, con);
            MySqlDataAdapter data10 = new MySqlDataAdapter(cmd10);
            DataTable tabla10 = new DataTable();
            data10.FillAsync(tabla10);

            int EncargosOctubre = tabla10.Rows.Count;
            con.Close();

            con.Open();
            string query11 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '11' AND eliminado = '0'";
            MySqlCommand cmd11 = new MySqlCommand(query11, con);
            MySqlDataAdapter data11 = new MySqlDataAdapter(cmd11);
            DataTable tabla11 = new DataTable();
            data11.FillAsync(tabla11);

            int EncargosNoviembre = tabla11.Rows.Count;
            con.Close();

            con.Open();
            string query12 = "select id As Encargos_del_Mes from Encargos where substring(fecha, 4, 2) = '12' AND eliminado = '0'";
            MySqlCommand cmd12 = new MySqlCommand(query12, con);
            MySqlDataAdapter data12 = new MySqlDataAdapter(cmd12);
            DataTable tabla12 = new DataTable();
            data12.FillAsync(tabla12);

            int EncargosDiciembre = tabla12.Rows.Count;
            con.Close();

            Enero = EncargosEnero;
            Febrero = EncargosFebrero;
            Marzo = EncargosMarzo;
            Abril = EncargosAbril;
            Mayo = EncargosMayo;
            Junio = EncargosJunio;
            Julio = EncargosJulio;
            Agosto = EncargosAgosto;
            Septiembre = EncargosSeptiembre;
            Octubre = EncargosOctubre;
            Noviembre = EncargosNoviembre;
            Diciembre = EncargosDiciembre;

            panelEnero.Height = Enero;
            panelFebrero.Height = Febrero;
            panelMarzo.Height = Marzo;
            panelAbril.Height = Abril;
            panelMayo.Height = Mayo;
            panelJunio.Height = Junio;
            panelJulio.Height = Julio;
            panelAgosto.Height = Agosto;
            panelSeptiembre.Height = Septiembre;
            panelOctubre.Height = Octubre;
            panelNoviembre.Height = Noviembre;
            panelDiciembre.Height = Diciembre;
        }
    }
}
