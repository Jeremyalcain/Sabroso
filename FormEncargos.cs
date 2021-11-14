using Proyecto;
using SabrosoSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppFormEncargos
{
    public partial class FormEncargos : Form
    {

        static string conexionstring = "Server=localhost; Database=bdsabroso; Uid=sabroso; pwd=123456789; port=3306";
        MySqlConnection con = new MySqlConnection(conexionstring);

        string idEncargos;

        ConexionSQL cn = new ConexionSQL();
        public FormEncargos()
        {
            InitializeComponent();
            dtgvEncargos.DataSource = cn.ConsultarTablaEncargosDG();
        }
        public DataTable ConsultarDT()
        {

            return cn.ConsultarTablaEncargosDG();

        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string cliente = cbxCliente.Text;
            con.Open();
            string query = "select id from cliente where Nombre_y_Apellido='"+cliente+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);
            con.Close();

            if (tabla.Rows.Count != 0)
            {
                cn.AgregarEncargo(cliente, dtpFecha.Text, cbHorario.Text);
                dtgvEncargos.DataSource = cn.ConsultarTablaEncargosDG();

            }

            else
            {

                MessageBox.Show("El cliente no existe");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlCommand cmd1 = new MySqlCommand("Select Nombre_y_Apellido from Cliente where eliminados=0", con);
            con.Open();
            MySqlDataReader registro1 = cmd1.ExecuteReader();
            while (registro1.Read())
            {
                cbxCliente.Items.Add(registro1["Nombre_y_Apellido"]);
            }
            con.Close();

            /*  MySqlCommand cmd3 = new MySqlCommand("Select Nombre, Precio from Stock where eliminados=0", con);
              con.Open();
              MySqlDataReader registro3 = cmd3.ExecuteReader();
              while (registro3.Read())
              {
                  listaProducto.Items.Add(registro3["Nombre"]);
              }
              con.Close();*/
        }
          

        private void dtgvEncargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvEncargos.DataSource = cn.ConsultarTablaEncargosDG();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cn.ModificarEncargos(int.Parse(idEncargos), dtpFecha.Text, cbHorario.Text);
            dtgvEncargos.DataSource = cn.ConsultarTablaEncargosDG();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            result = MessageBox.Show("¿Esta seguro que quiere eliminar el encargo?", "Eliminar Encargo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result != DialogResult.No)
            {

                cn.EliminarEncargo(idEncargos);

            }

            
            dtgvEncargos.DataSource = cn.ConsultarTablaEncargosDG();

        }

        private void dtgvEncargos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void dtgvEncargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idEncargos = dtgvEncargos.CurrentRow.Cells[0].Value.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvEncargos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnConstancia_Click(object sender, EventArgs e)
        {
            new CrearPDF().Show(); 
        }

        private void cbxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblHorario_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
