using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.util;
using SabrosoSoftware.Properties;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    public partial class CrearPDF : Form
    {
        static string conexionstring = "Server=localhost; Database=bdsabroso; Uid=sabroso; pwd=123456789; port=3306";
        MySqlConnection con = new MySqlConnection(conexionstring);
        public CrearPDF()
        {
            InitializeComponent();
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            
            string PaginaHTML_Texto = Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", cbxCliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", lblCI.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Importe"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
           


            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4,25,25,25,25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Resources.logo_s_sabroso, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

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

            MySqlCommand cmd2 = new MySqlCommand("Select Nombre, Precio from Stock where eliminados=0", con);
            con.Open();
            MySqlDataReader registro2 = cmd2.ExecuteReader();
            while (registro2.Read())
            {
                cbxProducto.Items.Add(registro2["Nombre"]);
            }

            con.Close();

            dgvproductos.Columns.Add("Cantidad", "Cantidad");
            dgvproductos.Columns.Add("Descripcion", "Descripcion");
            dgvproductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvproductos.Columns.Add("Importe", "Importe");


        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int indice_fila = dgvproductos.Rows.Add();
            DataGridViewRow row = dgvproductos.Rows[indice_fila];

            row.Cells["Cantidad"].Value = txtcantidad.Text;
            row.Cells["Descripcion"].Value = cbxProducto.Text;
            row.Cells["PrecioUnitario"].Value = lblPrecio.Text;
            row.Cells["Importe"].Value = decimal.Parse(txtcantidad.Text) * decimal.Parse(lblPrecio.Text);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = cbxCliente.Text;

            MySqlCommand cmd1 = new MySqlCommand("Select CI from Cliente where eliminados=0 AND Nombre_y_Apellido ='"+nombre+"'", con);
            con.Open();
            MySqlDataReader registro1 = cmd1.ExecuteReader();
            while (registro1.Read())
            {
                lblCI.Text = registro1["CI"].ToString();
            }
            con.Close();


        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            string producto = cbxProducto.Text;

            MySqlCommand cmd1 = new MySqlCommand("Select Precio from Stock where eliminados=0 AND Nombre='" + producto + "'", con);
            con.Open();
            MySqlDataReader registro1 = cmd1.ExecuteReader();
            while (registro1.Read())
            {
                lblPrecio.Text = registro1["Precio"].ToString();
            }
            con.Close();

        }
    }
}
