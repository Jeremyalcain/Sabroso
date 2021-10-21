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
            cn.ModificarCliente(txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text);
            dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cn.EliminarCliente(id);
            dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //(nom,ape,tel,dire);
            cn.AgregarCliente(txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text);
            dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        public int EliminarCliente(string id)
        {
            
            return cn.EliminarCliente(id);

        }

        public int ModificarCliente(string nom, string ape, int tel, string dire)
        {

            return cn.ModificarCliente(nom, ape, tel, dire);

        }

        public int AgregarCliente(string nom, string ape, int tel, string dire)
        {


            return cn.AgregarCliente(nom,ape,tel,dire);
        }

    }






}
