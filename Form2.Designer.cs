
namespace SabrosoSoftware
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnResumen = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnEncargos = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.Controls.Add(this.btnResumen);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.btnEncargos);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(191, 571);
            this.panelMenu.TabIndex = 8;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnResumen
            // 
            this.btnResumen.BackColor = System.Drawing.Color.Goldenrod;
            this.btnResumen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResumen.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResumen.ForeColor = System.Drawing.Color.White;
            this.btnResumen.Location = new System.Drawing.Point(30, 359);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(131, 53);
            this.btnResumen.TabIndex = 11;
            this.btnResumen.Text = "Resumen de Encargos";
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(30, 133);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(131, 47);
            this.btnClientes.TabIndex = 10;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(65, 535);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(80, 24);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = " Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEncargos
            // 
            this.btnEncargos.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEncargos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEncargos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEncargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncargos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncargos.ForeColor = System.Drawing.Color.White;
            this.btnEncargos.Location = new System.Drawing.Point(30, 282);
            this.btnEncargos.Name = "btnEncargos";
            this.btnEncargos.Size = new System.Drawing.Size(131, 47);
            this.btnEncargos.TabIndex = 7;
            this.btnEncargos.Text = "Encargos";
            this.btnEncargos.UseVisualStyleBackColor = false;
            this.btnEncargos.Click += new System.EventHandler(this.btnEncargos_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Goldenrod;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(30, 206);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(131, 47);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(8, 535);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(51, 24);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panelForms
            // 
            this.panelForms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelForms.BackgroundImage")));
            this.panelForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelForms.Location = new System.Drawing.Point(189, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1033, 571);
            this.panelForms.TabIndex = 9;
            this.panelForms.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForms_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 571);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelForms);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Menu";
            this.Text = "Sabroso Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnEncargos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnResumen;
    }
}