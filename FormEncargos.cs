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

namespace AppFormEncargos
{
    public partial class FormEncargos : Form
    {
        string id;

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
            cn.AgregarEncargo(txtNombre.Text, txtDireccion.Text, dtpFecha.Text);
            dtgvEncargos.DataSource = cn.ConsultarTablaClienteDG();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtgvEncargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvEncargos.DataSource = cn.ConsultarTablaEncargosDG();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dtgvEncargos.DataSource = cn.ConsultarTablaEncargosDG();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dtgvEncargos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void dtgvEncargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string valorPrimerCelda = dtgvEncargos.Rows[e.RowIndex].Cells[0].Value.ToString();
            valorPrimerCelda = id;

        }
    }
}
