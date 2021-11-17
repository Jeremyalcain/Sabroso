
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMes = new System.Windows.Forms.Button();
            this.dtgvResumenEncargos = new System.Windows.Forms.DataGridView();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.lblEncargos = new System.Windows.Forms.Label();
            this.btnAño = new System.Windows.Forms.Button();
            this.btnDia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResumenEncargos)).BeginInit();
            this.panelResumen.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvResumenEncargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvResumenEncargos.ColumnHeadersHeight = 35;
            this.dtgvResumenEncargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvResumenEncargos.EnableHeadersVisualStyles = false;
            this.dtgvResumenEncargos.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dtgvResumenEncargos.Location = new System.Drawing.Point(12, 29);
            this.dtgvResumenEncargos.Name = "dtgvResumenEncargos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvResumenEncargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvResumenEncargos.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvResumenEncargos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvResumenEncargos.RowTemplate.Height = 25;
            this.dtgvResumenEncargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvResumenEncargos.Size = new System.Drawing.Size(668, 468);
            this.dtgvResumenEncargos.TabIndex = 30;
            // 
            // panelResumen
            // 
            this.panelResumen.BackColor = System.Drawing.Color.Transparent;
            this.panelResumen.Controls.Add(this.lblEncargos);
            this.panelResumen.Controls.Add(this.btnAño);
            this.panelResumen.Controls.Add(this.btnDia);
            this.panelResumen.Controls.Add(this.btnMes);
            this.panelResumen.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelResumen.Location = new System.Drawing.Point(695, 0);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(256, 525);
            this.panelResumen.TabIndex = 31;
            this.panelResumen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(951, 525);
            this.Controls.Add(this.panelResumen);
            this.Controls.Add(this.dtgvResumenEncargos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResumen";
            this.Text = "FormResumen";
            this.Load += new System.EventHandler(this.FormResumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResumenEncargos)).EndInit();
            this.panelResumen.ResumeLayout(false);
            this.panelResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.DataGridView dtgvResumenEncargos;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Label lblEncargos;
    }
}