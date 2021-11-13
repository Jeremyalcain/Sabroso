using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SabrosoSoftware
{
    public partial class FormProductos : Form
    {

        static string conexionstring = "Server=localhost; Database=bdsabroso; Uid=sabroso; pwd=123456789; port=3306";
        MySqlConnection con = new MySqlConnection(conexionstring);
        string idProducto;
        
        
        ConexionSQL cn = new ConexionSQL();
        public FormProductos()
        {
            InitializeComponent();
            dtgvProductos.DataSource = cn.ConsultarTablaProductosDG();
        }

        public DataTable ConsultarDT()
        {

            return cn.ConsultarTablaProductosDG();

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            dtgvProductos.DataSource = cn.ConsultarTablaProductosDG();
        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvProductos.DataSource = cn.ConsultarTablaProductosDG();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtPrecio.Text == "")
            {

                cn.ModificarProductos3(int.Parse(idProducto), txtNombre.Text);

            }

            else if (txtNombre.Text == "")
            {
                cn.ModificarProductos2(int.Parse(idProducto), txtPrecio.Text);

            }


            else cn.ModificarProductos(int.Parse(idProducto), txtNombre.Text, txtPrecio.Text);

            dtgvProductos.DataSource = cn.ConsultarTablaProductosDG();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtNombre.Focus();
        }

        public int AgregarProducto(string nom, string pre)
        {

            return cn.AgregarProducto(nom, pre);

        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            cn.AgregarProducto(txtNombre.Text, txtPrecio.Text);
            dtgvProductos.DataSource = cn.ConsultarTablaProductosDG();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtNombre.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult result = DialogResult.No;
            result = MessageBox.Show("¿Esta seguro que quiere eliminar el producto?", "Eliminar Producto!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result != DialogResult.No)
            {

                cn.EliminarProducto(idProducto);

            }


            dtgvProductos.DataSource = cn.ConsultarTablaProductosDG();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtNombre.Focus();
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            idProducto = dtgvProductos.CurrentRow.Cells[0].Value.ToString();
            

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtBuscar.Text == "")
            {

                dtgvProductos.DataSource = cn.ConsultarTablaProductosDG();

            }

            else dtgvProductos.DataSource = cn.ConsultarTablaProductosBusquedaDG(txtBuscar.Text);





        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
    }
}
