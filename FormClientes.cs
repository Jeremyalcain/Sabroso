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
            if (txtNombre.Text == "" && txtTelefono.Text == "" && txtCi.Text == "" && txtDireccion.Text == "")
            {

                MessageBox.Show("No se ha ingresado ningun dato.");

            }

            else if (txtNombre.Text == "" && txtTelefono.Text != "" && txtCi.Text != "" && txtDireccion.Text != "")
            {

                cn.ModificarCliente2(int.Parse(ciCliente), int.Parse(txtTelefono.Text), txtDireccion.Text, int.Parse(txtCi.Text));


                //Se edita todo menos nombre
            }

            else if (txtCi.Text == "" && txtTelefono.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "")
            {

                cn.ModificarCliente3(int.Parse(ciCliente), txtNombre.Text, int.Parse(txtTelefono.Text), txtDireccion.Text);


                //Se edita todo menos ci
            }

            else if (txtTelefono.Text == "" && txtNombre.Text != "" && txtCi.Text != "" && txtDireccion.Text != "")
            {

                cn.ModificarCliente4(int.Parse(ciCliente), txtNombre.Text, txtDireccion.Text, int.Parse(txtCi.Text));


                //Se edita todo menos tel
            }

            else if (txtDireccion.Text == "" && txtTelefono.Text != "" && txtCi.Text != "" && txtNombre.Text != "")
            {

                cn.ModificarCliente5(int.Parse(ciCliente), txtNombre.Text, int.Parse(txtTelefono.Text), int.Parse(txtCi.Text));


                //Se edita todo menos dire
            }

            else if (txtNombre.Text != "" && txtDireccion.Text == "" && txtTelefono.Text == "" && txtCi.Text == "")
            {

                cn.ModificarCliente6(int.Parse(ciCliente), txtNombre.Text);


                //Se edita solo nombre
            }

            else if (txtCi.Text != "" && txtDireccion.Text == "" && txtTelefono.Text == "" && txtNombre.Text == "")
            {

                cn.ModificarCliente7(int.Parse(ciCliente), int.Parse(txtCi.Text));


                //Se edita solo ci
            }

            else if (txtTelefono.Text != "" && txtDireccion.Text == "" && txtCi.Text == "" && txtNombre.Text == "")
            {

                cn.ModificarCliente8(int.Parse(ciCliente), int.Parse(txtTelefono.Text));


                //Se edita solo telefono
            }

            else if (txtDireccion.Text != "" && txtTelefono.Text == "" && txtCi.Text == "" && txtNombre.Text == "")
            {

                cn.ModificarCliente9(int.Parse(ciCliente), txtDireccion.Text);


                //Se edita solo direccion
            }



            else cn.ModificarCliente1(int.Parse(ciCliente), txtNombre.Text, int.Parse(txtTelefono.Text), txtDireccion.Text, int.Parse(txtCi.Text));
            dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();
            txtCi.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCi.Focus();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;  
            result = MessageBox.Show("¿Esta seguro que quiere eliminar el cliente?", "Eliminar Cliente!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result != DialogResult.No)
            {

                cn.EliminarCliente(int.Parse(ciCliente));

            }

            dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();
            txtCi.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCi.Focus();

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //(ci, nom, ape, tel, dire);
            if (txtNombre.Text == "" && txtTelefono.Text == "" && txtDireccion.Text == "" && txtCi.Text == "")
            {

                MessageBox.Show("No se ha ingresado ningun dato.");

            }

            else cn.AgregarCliente(txtNombre.Text, int.Parse(txtTelefono.Text), txtDireccion.Text, int.Parse(txtCi.Text));
            dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();
            txtCi.Clear();
            txtNombre.Clear();
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

        public int ModificarCliente1(int id, string nom, int tel, string dire, int ci)
        {

            return cn.ModificarCliente1(id, nom, tel, dire, ci);

            //Se edita todo
        }

        public int ModificarCliente2(int id, int tel, string dire, int ci)
        {

            return cn.ModificarCliente2(id, tel, dire, ci);

            //Se edita todo menos nombre
        }

        public int ModificarCliente3(int id, string nom, int tel, string dire)
        {

            return cn.ModificarCliente3(id, nom, tel, dire);

            //Se edita todo menos ci
        }

        public int ModificarCliente4(int id, string nom, string dire, int ci)
        {

            return cn.ModificarCliente4(id, nom, dire, ci);

            //Se edita todo menos tel
        }

        public int ModificarCliente5(int id, string nom, int tel, int ci)
        {

            return cn.ModificarCliente5(id, nom, tel, ci);

            //Se edita todo menos dire
        }

        public int AgregarCliente(string nom, int tel, string dire,int ci)
        {


            return cn.AgregarCliente(nom,tel,dire,ci);

        }

        private void dtgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ciCliente = dtgvClientes.CurrentRow.Cells[0].Value.ToString();

        }

        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 127 && e.KeyChar <= 255) || (e.KeyChar >= 32 && e.KeyChar <=47) || (e.KeyChar >= 58 && e.KeyChar <= 126))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                e.Handled = true;
                return;

            }
    }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back && e.KeyChar != 32))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }

        }

        private void txtCi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtBuscar.Text == "")
            {

                dtgvClientes.DataSource = cn.ConsultarTablaClienteDG();

            }

            else dtgvClientes.DataSource = cn.ConsultarTablaClienteBusquedaDG(txtBuscar.Text);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }


}
