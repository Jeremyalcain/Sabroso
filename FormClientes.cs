using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SabrosoSoftware
{
    public partial class FormClientes : Form
    {
        string ciCliente;

        ConexionSQL cn = new ConexionSQL();

        public FormClientes()
        {
            InitializeComponent();
            dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();
        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DataTable ConsultarDT()
        {

            return cn.ConsultarTablaClienteDG();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cn.ModificarCliente(int.Parse(ciCliente), txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text, int.Parse(txtCi.Text));
            dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();
            txtCi.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCi.Focus();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //cn.EliminarCliente(id);
            cn.EliminarCliente(int.Parse(ciCliente));
            dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();
            txtCi.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCi.Focus();

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //(ci, nom, ape, tel, dire);
            cn.AgregarCliente(txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text, int.Parse(txtCi.Text));
            dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();
            txtCi.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCi.Focus();

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        public int EliminarCliente(int id)
        {
            
            return cn.EliminarCliente(id);

        }

        public int ModificarCliente(int id, string nom, string ape, int tel, string dire, int ci)
        {

            return cn.ModificarCliente(id, nom, ape, tel, dire, ci);

        }

        public int AgregarCliente(string nom, string ape, int tel, string dire,int ci)
        {


            return cn.AgregarCliente(nom,ape,tel,dire,ci);
        }

        private void dtgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ciCliente = dtgvClientes.CurrentRow.Cells[0].Value.ToString();

        }
    }






}
