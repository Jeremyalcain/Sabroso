﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SabrosoSoftware
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblInformacionIngles_Click(object sender, EventArgs e)
        {

        }

        private void linkManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var Abrir = new Process();
            Abrir.StartInfo = new ProcessStartInfo("https://drive.google.com/file/d/1YSr0Q5Bg6KwmBHJohA6_5qivHBjKgEss/view?usp=sharing")
            {
                UseShellExecute = true
            };
            Abrir.Start();
        }
    }
}
