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
using System.Globalization;

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

            string Productos = (txtCantidad1.Text + " " + cbxProducto1.Text + " " + txtCantidad2.Text + " " + cbxProducto2.Text + " " + txtCantidad3.Text + " " + cbxProducto3.Text + " " + txtCantidad4.Text + " " + cbxProducto4.Text + " " + txtCantidad5.Text + " " + cbxProducto5.Text + " " + txtCantidad6.Text + " " + cbxProducto6.Text);
            string cliente = cbxCliente.Text;
            con.Open();
            string query = "select id from cliente where Nombre_y_Apellido='"+cliente+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.FillAsync(tabla);
            con.Close();

            if (cbxCliente.Text == "" && cbxHorario.Text == "" && cbxProducto1.Text == "" && cbxProducto2.Text == "" && cbxProducto3.Text == "" && cbxProducto4.Text == "" && cbxProducto5.Text == "" && cbxProducto6.Text == "")
            {

                MessageBox.Show("No se ha ingresado ningun dato.");

            }

            if (tabla.Rows.Count != 0)
            {
                cn.AgregarEncargo(cliente, dtpFecha.Text, cbxHorario.Text, Productos);
                dtgvEncargos.DataSource = cn.ConsultarTablaEncargosDG();

            }

            else
            {

                MessageBox.Show("El cliente no existe");

            }

            cbxCliente.DataSource = null;
            cbxHorario.DataSource = null;
            cbxProducto1.DataSource = null;
            cbxProducto2.DataSource = null;
            cbxProducto3.DataSource = null;
            cbxProducto4.DataSource = null;
            cbxProducto5.DataSource = null;
            cbxProducto6.DataSource = null;

            cbxCliente.Items.Clear();
            cbxHorario.Items.Clear();
            cbxProducto1.Items.Clear();
            cbxProducto2.Items.Clear();
            cbxProducto3.Items.Clear();
            cbxProducto4.Items.Clear();
            cbxProducto5.Items.Clear();
            cbxProducto6.Items.Clear();

            txtCantidad1.Clear();
            txtCantidad2.Clear();
            txtCantidad3.Clear();
            txtCantidad4.Clear();
            txtCantidad5.Clear();
            txtCantidad6.Clear();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dtgvEncargos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            MySqlCommand cmd1 = new MySqlCommand("Select Nombre_y_Apellido from Cliente where eliminados=0", con);
            con.Open();
            MySqlDataReader registro1 = cmd1.ExecuteReader();
            while (registro1.Read())
            {
                cbxCliente.Items.Add(registro1["Nombre_y_Apellido"]);
            }
            con.Close();

            MySqlCommand cmd2 = new MySqlCommand("Select Nombre, Precio from Stock where eliminados=0", con);
            con.Open();
            MySqlDataReader registro2 = cmd2.ExecuteReader();
            while (registro2.Read())
            {
                cbxProducto1.Items.Add(registro2["Nombre"]);
            }

            con.Close();

            MySqlCommand cmd3 = new MySqlCommand("Select Nombre, Precio from Stock where eliminados=0", con);
            con.Open();
            MySqlDataReader registro3 = cmd3.ExecuteReader();
            while (registro3.Read())
            {
                cbxProducto2.Items.Add(registro3["Nombre"]);
            }

            con.Close();

            MySqlCommand cmd4 = new MySqlCommand("Select Nombre, Precio from Stock where eliminados=0", con);
            con.Open();
            MySqlDataReader registro4 = cmd4.ExecuteReader();
            while (registro4.Read())
            {
                cbxProducto3.Items.Add(registro4["Nombre"]);
            }

            con.Close();

            MySqlCommand cmd5 = new MySqlCommand("Select Nombre, Precio from Stock where eliminados=0", con);
            con.Open();
            MySqlDataReader registro5 = cmd5.ExecuteReader();
            while (registro5.Read())
            {
                cbxProducto4.Items.Add(registro5["Nombre"]);
            }

            con.Close();

            MySqlCommand cmd6 = new MySqlCommand("Select Nombre, Precio from Stock where eliminados=0", con);
            con.Open();
            MySqlDataReader registro6 = cmd6.ExecuteReader();
            while (registro6.Read())
            {
                cbxProducto5.Items.Add(registro6["Nombre"]);
            }

            con.Close();

            MySqlCommand cmd7 = new MySqlCommand("Select Nombre, Precio from Stock where eliminados=0", con);
            con.Open();
            MySqlDataReader registro7 = cmd7.ExecuteReader();
            while (registro7.Read())
            {
                cbxProducto6.Items.Add(registro7["Nombre"]);
            }
            con.Close();
        }


        private void dtgvEncargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvEncargos.DataSource = cn.ConsultarTablaEncargosDG();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string Productos = (txtCantidad1.Text + " " + cbxProducto1.Text + " " + txtCantidad2.Text + " " + cbxProducto2.Text + " " + txtCantidad3.Text + " " + cbxProducto3.Text + " " + txtCantidad4.Text + " " + cbxProducto4.Text + " " + txtCantidad5.Text + " " + cbxProducto5.Text + " " + txtCantidad6.Text + " " + cbxProducto6.Text);
            cn.ModificarEncargos(int.Parse(idEncargos), cbxCliente.Text, dtpFecha.Text, cbxHorario.Text, Productos);
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

        private void dtgvEncargos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            idEncargos = dtgvEncargos.CurrentRow.Cells[0].Value.ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {

                dtgvEncargos.DataSource = cn.ConsultarTablaEncargosDG();

            }

            else dtgvEncargos.DataSource = cn.ConsultarTablaEncargosBusquedaDG(txtBuscar.Text);
        }
    }
}
