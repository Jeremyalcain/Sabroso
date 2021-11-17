
namespace SabrosoSoftware
{
    partial class FormResumen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResumen));
            this.btnMes = new System.Windows.Forms.Button();
            this.dtgvResumenEncargos = new System.Windows.Forms.DataGridView();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.lblEncargos = new System.Windows.Forms.Label();
            this.btnAño = new System.Windows.Forms.Button();
            this.btnDia = new System.Windows.Forms.Button();
            this.panelGrafica = new System.Windows.Forms.Panel();
            this.panelDiciembre = new System.Windows.Forms.Panel();
            this.panelNoviembre = new System.Windows.Forms.Panel();
            this.panelOctubre = new System.Windows.Forms.Panel();
            this.panelSeptiembre = new System.Windows.Forms.Panel();
            this.panelAgosto = new System.Windows.Forms.Panel();
            this.panelJulio = new System.Windows.Forms.Panel();
            this.panelJunio = new System.Windows.Forms.Panel();
            this.panelMayo = new System.Windows.Forms.Panel();
            this.panelAbril = new System.Windows.Forms.Panel();
            this.panelMarzo = new System.Windows.Forms.Panel();
            this.panelFebrero = new System.Windows.Forms.Panel();
            this.panelEnero = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResumenEncargos)).BeginInit();
            this.panelResumen.SuspendLayout();
            this.panelGrafica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMes
            // 
            this.btnMes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMes.ForeColor = System.Drawing.Color.White;
            this.btnMes.Location = new System.Drawing.Point(29, 154);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(206, 65);
            this.btnMes.TabIndex = 1;
            this.btnMes.Text = "Encargos del Mes";
            this.btnMes.UseVisualStyleBackColor = false;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // dtgvResumenEncargos
            // 
            this.dtgvResumenEncargos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvResumenEncargos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvResumenEncargos.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dtgvResumenEncargos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvResumenEncargos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvResumenEncargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvResumenEncargos.ColumnHeadersHeight = 35;
            this.dtgvResumenEncargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvResumenEncargos.EnableHeadersVisualStyles = false;
            this.dtgvResumenEncargos.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dtgvResumenEncargos.Location = new System.Drawing.Point(12, 29);
            this.dtgvResumenEncargos.Name = "dtgvResumenEncargos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvResumenEncargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvResumenEncargos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvResumenEncargos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvResumenEncargos.RowTemplate.Height = 25;
            this.dtgvResumenEncargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvResumenEncargos.Size = new System.Drawing.Size(748, 514);
            this.dtgvResumenEncargos.TabIndex = 30;
            // 
            // panelResumen
            // 
            this.panelResumen.BackColor = System.Drawing.Color.Transparent;
            this.panelResumen.Controls.Add(this.btnGrafica);
            this.panelResumen.Controls.Add(this.lblEncargos);
            this.panelResumen.Controls.Add(this.btnAño);
            this.panelResumen.Controls.Add(this.btnDia);
            this.panelResumen.Controls.Add(this.btnMes);
            this.panelResumen.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelResumen.Location = new System.Drawing.Point(775, 0);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(256, 571);
            this.panelResumen.TabIndex = 31;
            this.panelResumen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGrafica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGrafica.ForeColor = System.Drawing.Color.White;
            this.btnGrafica.Location = new System.Drawing.Point(29, 367);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(206, 65);
            this.btnGrafica.TabIndex = 27;
            this.btnGrafica.Text = "Grafica del Año";
            this.btnGrafica.UseVisualStyleBackColor = false;
            this.btnGrafica.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEncargos
            // 
            this.lblEncargos.AutoSize = true;
            this.lblEncargos.BackColor = System.Drawing.Color.Transparent;
            this.lblEncargos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEncargos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEncargos.Location = new System.Drawing.Point(29, 92);
            this.lblEncargos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncargos.Name = "lblEncargos";
            this.lblEncargos.Size = new System.Drawing.Size(0, 25);
            this.lblEncargos.TabIndex = 26;
            // 
            // btnAño
            // 
            this.btnAño.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAño.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAño.ForeColor = System.Drawing.Color.White;
            this.btnAño.Location = new System.Drawing.Point(29, 296);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(206, 65);
            this.btnAño.TabIndex = 25;
            this.btnAño.Text = "Encargos del Año";
            this.btnAño.UseVisualStyleBackColor = false;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // btnDia
            // 
            this.btnDia.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDia.ForeColor = System.Drawing.Color.White;
            this.btnDia.Location = new System.Drawing.Point(29, 225);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(206, 65);
            this.btnDia.TabIndex = 24;
            this.btnDia.Text = "Encargos del Dia";
            this.btnDia.UseVisualStyleBackColor = false;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // panelGrafica
            // 
            this.panelGrafica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGrafica.BackgroundImage")));
            this.panelGrafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGrafica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrafica.Controls.Add(this.panelDiciembre);
            this.panelGrafica.Controls.Add(this.panelNoviembre);
            this.panelGrafica.Controls.Add(this.panelOctubre);
            this.panelGrafica.Controls.Add(this.panelSeptiembre);
            this.panelGrafica.Controls.Add(this.panelAgosto);
            this.panelGrafica.Controls.Add(this.panelJulio);
            this.panelGrafica.Controls.Add(this.panelJunio);
            this.panelGrafica.Controls.Add(this.panelMayo);
            this.panelGrafica.Controls.Add(this.panelAbril);
            this.panelGrafica.Controls.Add(this.panelMarzo);
            this.panelGrafica.Controls.Add(this.panelFebrero);
            this.panelGrafica.Controls.Add(this.panelEnero);
            this.panelGrafica.Location = new System.Drawing.Point(12, 29);
            this.panelGrafica.Name = "panelGrafica";
            this.panelGrafica.Size = new System.Drawing.Size(747, 514);
            this.panelGrafica.TabIndex = 32;
            // 
            // panelDiciembre
            // 
            this.panelDiciembre.BackColor = System.Drawing.Color.LightCoral;
            this.panelDiciembre.Location = new System.Drawing.Point(690, 19);
            this.panelDiciembre.Name = "panelDiciembre";
            this.panelDiciembre.Size = new System.Drawing.Size(49, 20);
            this.panelDiciembre.TabIndex = 12;
            // 
            // panelNoviembre
            // 
            this.panelNoviembre.BackColor = System.Drawing.Color.LightCoral;
            this.panelNoviembre.Location = new System.Drawing.Point(628, 19);
            this.panelNoviembre.Name = "panelNoviembre";
            this.panelNoviembre.Size = new System.Drawing.Size(49, 20);
            this.panelNoviembre.TabIndex = 11;
            // 
            // panelOctubre
            // 
            this.panelOctubre.BackColor = System.Drawing.Color.LightCoral;
            this.panelOctubre.Location = new System.Drawing.Point(567, 19);
            this.panelOctubre.Name = "panelOctubre";
            this.panelOctubre.Size = new System.Drawing.Size(49, 20);
            this.panelOctubre.TabIndex = 10;
            // 
            // panelSeptiembre
            // 
            this.panelSeptiembre.BackColor = System.Drawing.Color.LightCoral;
            this.panelSeptiembre.Location = new System.Drawing.Point(503, 19);
            this.panelSeptiembre.Name = "panelSeptiembre";
            this.panelSeptiembre.Size = new System.Drawing.Size(49, 20);
            this.panelSeptiembre.TabIndex = 9;
            // 
            // panelAgosto
            // 
            this.panelAgosto.BackColor = System.Drawing.Color.LightCoral;
            this.panelAgosto.Location = new System.Drawing.Point(440, 19);
            this.panelAgosto.Name = "panelAgosto";
            this.panelAgosto.Size = new System.Drawing.Size(49, 20);
            this.panelAgosto.TabIndex = 8;
            // 
            // panelJulio
            // 
            this.panelJulio.BackColor = System.Drawing.Color.LightCoral;
            this.panelJulio.Location = new System.Drawing.Point(382, 19);
            this.panelJulio.Name = "panelJulio";
            this.panelJulio.Size = new System.Drawing.Size(49, 20);
            this.panelJulio.TabIndex = 7;
            // 
            // panelJunio
            // 
            this.panelJunio.BackColor = System.Drawing.Color.LightCoral;
            this.panelJunio.Location = new System.Drawing.Point(323, 19);
            this.panelJunio.Name = "panelJunio";
            this.panelJunio.Size = new System.Drawing.Size(49, 20);
            this.panelJunio.TabIndex = 6;
            // 
            // panelMayo
            // 
            this.panelMayo.BackColor = System.Drawing.Color.LightCoral;
            this.panelMayo.Location = new System.Drawing.Point(265, 19);
            this.panelMayo.Name = "panelMayo";
            this.panelMayo.Size = new System.Drawing.Size(49, 20);
            this.panelMayo.TabIndex = 5;
            // 
            // panelAbril
            // 
            this.panelAbril.BackColor = System.Drawing.Color.LightCoral;
            this.panelAbril.Location = new System.Drawing.Point(208, 19);
            this.panelAbril.Name = "panelAbril";
            this.panelAbril.Size = new System.Drawing.Size(49, 20);
            this.panelAbril.TabIndex = 4;
            // 
            // panelMarzo
            // 
            this.panelMarzo.BackColor = System.Drawing.Color.LightCoral;
            this.panelMarzo.Location = new System.Drawing.Point(150, 19);
            this.panelMarzo.Name = "panelMarzo";
            this.panelMarzo.Size = new System.Drawing.Size(49, 20);
            this.panelMarzo.TabIndex = 3;
            // 
            // panelFebrero
            // 
            this.panelFebrero.BackColor = System.Drawing.Color.LightCoral;
            this.panelFebrero.Location = new System.Drawing.Point(92, 19);
            this.panelFebrero.Name = "panelFebrero";
            this.panelFebrero.Size = new System.Drawing.Size(49, 20);
            this.panelFebrero.TabIndex = 2;
            // 
            // panelEnero
            // 
            this.panelEnero.BackColor = System.Drawing.Color.LightCoral;
            this.panelEnero.Location = new System.Drawing.Point(34, 19);
            this.panelEnero.Name = "panelEnero";
            this.panelEnero.Size = new System.Drawing.Size(49, 20);
            this.panelEnero.TabIndex = 1;
            // 
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1031, 571);
            this.Controls.Add(this.panelGrafica);
            this.Controls.Add(this.panelResumen);
            this.Controls.Add(this.dtgvResumenEncargos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResumen";
            this.Text = "FormResumen";
            this.Load += new System.EventHandler(this.FormResumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResumenEncargos)).EndInit();
            this.panelResumen.ResumeLayout(false);
            this.panelResumen.PerformLayout();
            this.panelGrafica.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.DataGridView dtgvResumenEncargos;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Label lblEncargos;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Panel panelGrafica;
        private System.Windows.Forms.Panel panelEnero;
        private System.Windows.Forms.Panel panelDiciembre;
        private System.Windows.Forms.Panel panelNoviembre;
        private System.Windows.Forms.Panel panelOctubre;
        private System.Windows.Forms.Panel panelSeptiembre;
        private System.Windows.Forms.Panel panelAgosto;
        private System.Windows.Forms.Panel panelJulio;
        private System.Windows.Forms.Panel panelJunio;
        private System.Windows.Forms.Panel panelMayo;
        private System.Windows.Forms.Panel panelAbril;
        private System.Windows.Forms.Panel panelMarzo;
        private System.Windows.Forms.Panel panelFebrero;
    }
}