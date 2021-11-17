
namespace SabrosoSoftware
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.picLogoUtu = new System.Windows.Forms.PictureBox();
            this.lblInformacionEspañol = new System.Windows.Forms.Label();
            this.lblInformacionIngles = new System.Windows.Forms.Label();
            this.picLogoUDE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoUtu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoUDE)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogoUtu
            // 
            this.picLogoUtu.Image = ((System.Drawing.Image)(resources.GetObject("picLogoUtu.Image")));
            this.picLogoUtu.Location = new System.Drawing.Point(603, 35);
            this.picLogoUtu.Name = "picLogoUtu";
            this.picLogoUtu.Size = new System.Drawing.Size(202, 128);
            this.picLogoUtu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoUtu.TabIndex = 7;
            this.picLogoUtu.TabStop = false;
            // 
            // lblInformacionEspañol
            // 
            this.lblInformacionEspañol.AutoSize = true;
            this.lblInformacionEspañol.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInformacionEspañol.Location = new System.Drawing.Point(42, 237);
            this.lblInformacionEspañol.Name = "lblInformacionEspañol";
            this.lblInformacionEspañol.Size = new System.Drawing.Size(441, 225);
            this.lblInformacionEspañol.TabIndex = 8;
            this.lblInformacionEspañol.Text = resources.GetString("lblInformacionEspañol.Text");
            this.lblInformacionEspañol.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblInformacionIngles
            // 
            this.lblInformacionIngles.AutoSize = true;
            this.lblInformacionIngles.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInformacionIngles.Location = new System.Drawing.Point(413, 237);
            this.lblInformacionIngles.Name = "lblInformacionIngles";
            this.lblInformacionIngles.Size = new System.Drawing.Size(572, 250);
            this.lblInformacionIngles.TabIndex = 9;
            this.lblInformacionIngles.Text = resources.GetString("lblInformacionIngles.Text");
            this.lblInformacionIngles.Click += new System.EventHandler(this.lblInformacionIngles_Click);
            // 
            // picLogoUDE
            // 
            this.picLogoUDE.Image = ((System.Drawing.Image)(resources.GetObject("picLogoUDE.Image")));
            this.picLogoUDE.Location = new System.Drawing.Point(165, 35);
            this.picLogoUDE.Name = "picLogoUDE";
            this.picLogoUDE.Size = new System.Drawing.Size(204, 128);
            this.picLogoUDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoUDE.TabIndex = 3;
            this.picLogoUDE.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1031, 571);
            this.Controls.Add(this.lblInformacionEspañol);
            this.Controls.Add(this.lblInformacionIngles);
            this.Controls.Add(this.picLogoUtu);
            this.Controls.Add(this.picLogoUDE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoUtu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoUDE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoUtu;
        private System.Windows.Forms.Label lblInformacionEspañol;
        private System.Windows.Forms.Label lblInformacionIngles;
        private System.Windows.Forms.PictureBox picLogoUDE;
    }
}