
namespace SabrosoSoftware
{
    partial class FormEnviarEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnviarEmail));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblEmisor = new System.Windows.Forms.Label();
            this.txtEmisor = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.Label();
            this.lblReceptor = new System.Windows.Forms.Label();
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(205, 96);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(192, 412);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblEmisor
            // 
            this.lblEmisor.AutoSize = true;
            this.lblEmisor.BackColor = System.Drawing.Color.Transparent;
            this.lblEmisor.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEmisor.Location = new System.Drawing.Point(12, 9);
            this.lblEmisor.Name = "lblEmisor";
            this.lblEmisor.Size = new System.Drawing.Size(62, 20);
            this.lblEmisor.TabIndex = 2;
            this.lblEmisor.Text = "Emisor:";
            this.lblEmisor.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmisor
            // 
            this.txtEmisor.Location = new System.Drawing.Point(12, 32);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Size = new System.Drawing.Size(260, 23);
            this.txtEmisor.TabIndex = 3;
            this.txtEmisor.Text = "udesoftware@gmail.com";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(184, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "udesoftware2021!";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.BackColor = System.Drawing.Color.Transparent;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.Location = new System.Drawing.Point(12, 73);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(95, 20);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.Text = "Contraseña:";
            // 
            // lblReceptor
            // 
            this.lblReceptor.AutoSize = true;
            this.lblReceptor.BackColor = System.Drawing.Color.Transparent;
            this.lblReceptor.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblReceptor.Location = new System.Drawing.Point(12, 153);
            this.lblReceptor.Name = "lblReceptor";
            this.lblReceptor.Size = new System.Drawing.Size(76, 20);
            this.lblReceptor.TabIndex = 6;
            this.lblReceptor.Text = "Receptor:";
            // 
            // txtReceptor
            // 
            this.txtReceptor.Location = new System.Drawing.Point(12, 176);
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(255, 23);
            this.txtReceptor.TabIndex = 7;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(7, 219);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(71, 20);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(21, 242);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(251, 149);
            this.txtMensaje.TabIndex = 6;
            // 
            // FormEnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtReceptor);
            this.Controls.Add(this.lblReceptor);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmisor);
            this.Controls.Add(this.lblEmisor);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEnviarEmail";
            this.Text = "FormEnviarEmail";
            this.Load += new System.EventHandler(this.FormEnviarEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblEmisor;
        private System.Windows.Forms.TextBox txtEmisor;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label txtContraseña;
        private System.Windows.Forms.Label lblReceptor;
        private System.Windows.Forms.TextBox txtReceptor;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}