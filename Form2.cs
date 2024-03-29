﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AppFormEncargos;

namespace SabrosoSoftware
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void AbrirForms<T>() where T : Form, new()
        {

            Form formulario = panelForms.Controls.OfType<T>().FirstOrDefault();
            if(formulario == null)
            {
                formulario = new T();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;

                panelForms.Controls.Add(formulario);
                panelForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }

            else
            {
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
                formulario.BringToFront();

            }

        
        }

        private void CerrarForms<T>() where T : Form, new()
        {

            Form formulario = panelForms.Controls.OfType<T>().FirstOrDefault();

            
            if(formulario != null)
            {

                formulario.Close();

            }
            

        }
  
       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {


            if(WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;

            }

            else this.WindowState = FormWindowState.Maximized;


        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            
           CerrarForms<FormEncargos>();
           CerrarForms<FormProductos>();
            CerrarForms<FormAbout>();
            CerrarForms<FormResumen>();
            AbrirForms<FormClientes>();


         
        }

        private void panelForms_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnEncargos_Click(object sender, EventArgs e)
        {
            CerrarForms<FormAbout>();
            CerrarForms<FormClientes>();
            CerrarForms<FormResumen>();
            CerrarForms<FormProductos>();
            AbrirForms<FormEncargos>();


            //AbrirForm(new FormEncargos());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            CerrarForms<FormAbout>();
            CerrarForms<FormResumen>();
            CerrarForms<FormClientes>();
            CerrarForms<FormEncargos>();
            AbrirForms<FormProductos>();

            //AbrirForm(new FormProductos());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CerrarForms<FormClientes>();
            CerrarForms<FormEncargos>();
            CerrarForms<FormResumen>();
            CerrarForms<FormProductos>();
            CerrarForms<FormAbout>();


        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            CerrarForms<FormAbout>();
            CerrarForms<FormResumen>();
            CerrarForms<FormEncargos>();
            CerrarForms<FormProductos>();
            AbrirForms<FormClientes>();


        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            CerrarForms<FormResumen>();
            CerrarForms<FormClientes>();
            CerrarForms<FormEncargos>();
            CerrarForms<FormProductos>();
            AbrirForms<FormAbout>();

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarForms<FormAbout>();
            CerrarForms<FormClientes>();
            CerrarForms<FormEncargos>();
            CerrarForms<FormProductos>();
            AbrirForms<FormResumen>();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
