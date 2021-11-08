using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SabrosoSoftware
{
    public partial class FormProductos : Form
    {
       
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
            cn.ModificarProductos(int.Parse(idProducto), txtNombre.Text, txtPrecio.Text, txtCantidad.Text);
            dtgvProductos.DataSource = cn.ConsultarTablaProductosDG();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtNombre.Focus();
        }

        public int AgregarProducto(string nom, int pre, string can)
        {

            return cn.AgregarProducto(nom, pre, can);

        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            cn.AgregarProducto(txtNombre.Text, int.Parse(txtPrecio.Text), txtCantidad.Text);
            dtgvProductos.DataSource = cn.ConsultarTablaProductosDG();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
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
            cn.EliminarProducto(idProducto);
            dtgvProductos.DataSource = cn.ConsultarTablaProductosDG();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtNombre.Focus();
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            idProducto = dtgvProductos.CurrentRow.Cells[0].Value.ToString();
            

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
