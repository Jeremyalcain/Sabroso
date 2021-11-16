using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabrosoSoftware
{
    public partial class FormResumen : Form
    {
        ConexionSQL cn = new ConexionSQL();
        public FormResumen()
        {
            InitializeComponent();
            dtgvResumen.DataSource = cn.ResumenDG();
        }

        public DataTable ConsultarDT()
        {

            return cn.ResumenDG();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;

            }

            else this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {
            

            {
                
            }
        }

        private void dtgvResumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
