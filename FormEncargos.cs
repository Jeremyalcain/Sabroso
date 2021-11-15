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
            string combo1 = cbxProducto1.Text;
            string combo2 = cbxProducto2.Text;
            string combo3 = cbxProducto3.Text;
            string combo4 = cbxProducto4.Text;
            string combo5 = cbxProducto5.Text;
            string combo6 = cbxProducto6.Text;
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

                if (combo2 == "" && combo3 == "" && combo4 == "" && combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo1 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();


                    //Caso solo combo1
                }

                else if (combo1 == "" && combo3 == "" && combo4 == "" && combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo2 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();

                    //Caso solo combo2

                }

                else if (combo1 == "" && combo2 == "" && combo4 == "" && combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo3 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();

                    //Caso solo combo3

                }

                else if (combo1 == "" && combo2 == "" && combo3 == "" && combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo4 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();

                    //Caso solo combo4

                }

                else if (combo1 == "" && combo2 == "" && combo3 == "" && combo4 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo5 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();

                    //Caso solo combo5

                }

                else if (combo1 == "" && combo2 == "" && combo3 == "" && combo4 == "" && combo5 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo6 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();

                    //Caso solo combo6

                }

                else if (combo3 == "" && combo4 == "" && combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo1 + "," + combo2 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();


                    //Caso solo combo1 y 2
                }

                else if (combo2 == "" && combo4 == "" && combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo1 + "," + combo3 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();


                    //Caso solo combo1 y 3
                }

                else if (combo2 == "" && combo3 == "" && combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo1 + "," + combo4 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();


                    //Caso solo combo1 y 4
                }

                else if (combo2 == "" && combo3 == "" && combo4 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo1 + "," + combo5 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();


                    //Caso solo combo1 y 5
                }

                else if (combo2 == "" && combo3 == "" && combo5 == "" && combo5 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo1 + "," + combo6 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();


                    //Caso solo combo1 y 6
                }

                else if (combo4 == "" && combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo1 + "," + combo2 + "," + combo3 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();


                    //Caso combo1, 2 y 3
                }

                else if (combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo1 + "," + combo2 + "," + combo3 + "," + combo4 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();


                    //Caso combo1, 2, 3 y 4
                }

                else if (combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo1 + "," + combo2 + "," + combo3 + "," + combo4 + "," + combo5 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();


                    //Caso combo1, 2, 3, 4 y 5
                }

                else if (combo1 == "" && combo4 == "" && combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo2 + "," + combo3 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();

                    //Caso solo combo2 y 3

                }

                else if (combo1 == "" && combo5 == "" && combo6 == "")
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo2 + "," + combo3 + "," + combo4 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();

                    //Caso combo2, 3 y 4

                }

                else
                {

                    con.Open();
                    string query1 = "insert into Encargos (Productos) values ('" + combo1 + "," + combo2 + "," + combo3 + "," + combo4 + "," + combo5 + "," + combo6 + "') where nombre_cliente ='" + cliente + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Close();

                    //Caso todos

                }   

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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
