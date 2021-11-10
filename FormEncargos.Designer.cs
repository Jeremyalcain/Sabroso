
namespace AppFormEncargos
{
    partial class FormEncargos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEncargo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtgvEncargos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnConstancia = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEncargos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAñadir.Location = new System.Drawing.Point(23, 389);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(214, 53);
            this.btnAñadir.TabIndex = 15;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHorario.ForeColor = System.Drawing.Color.Black;
            this.lblHorario.Location = new System.Drawing.Point(14, 159);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(58, 17);
            this.lblHorario.TabIndex = 14;
            this.lblHorario.Text = "Horario:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(27, 127);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 17);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(14, 196);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 17);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblEncargo
            // 
            this.lblEncargo.AutoSize = true;
            this.lblEncargo.BackColor = System.Drawing.Color.Transparent;
            this.lblEncargo.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEncargo.ForeColor = System.Drawing.Color.Black;
            this.lblEncargo.Location = new System.Drawing.Point(70, 91);
            this.lblEncargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncargo.Name = "lblEncargo";
            this.lblEncargo.Size = new System.Drawing.Size(119, 20);
            this.lblEncargo.TabIndex = 10;
            this.lblEncargo.Text = "Añadir Encargo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(120, 448);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(24, 448);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 27);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtgvEncargos
            // 
            this.dtgvEncargos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvEncargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEncargos.Location = new System.Drawing.Point(24, 30);
            this.dtgvEncargos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgvEncargos.Name = "dtgvEncargos";
            this.dtgvEncargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvEncargos.Size = new System.Drawing.Size(534, 412);
            this.dtgvEncargos.TabIndex = 20;
            this.dtgvEncargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEncargos_CellClick);
            this.dtgvEncargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEncargos_CellContentClick_1);
            this.dtgvEncargos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dtgvEncargos_RowStateChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.cbHorario);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Controls.Add(this.lblHorario);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblEncargo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(587, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 525);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cbHorario.Location = new System.Drawing.Point(83, 156);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(121, 23);
            this.cbHorario.TabIndex = 20;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(83, 127);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFecha.Size = new System.Drawing.Size(93, 23);
            this.dtpFecha.TabIndex = 19;
            // 
            // btnConstancia
            // 
            this.btnConstancia.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnConstancia.Location = new System.Drawing.Point(470, 448);
            this.btnConstancia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConstancia.Name = "btnConstancia";
            this.btnConstancia.Size = new System.Drawing.Size(88, 27);
            this.btnConstancia.TabIndex = 24;
            this.btnConstancia.Text = "Constancia";
            this.btnConstancia.UseVisualStyleBackColor = true;
            this.btnConstancia.Click += new System.EventHandler(this.btnConstancia_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(14, 216);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(223, 96);
            this.txtDescripcion.TabIndex = 21;
            this.txtDescripcion.Text = "";
            // 
            // FormEncargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(837, 525);
            this.Controls.Add(this.btnConstancia);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dtgvEncargos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormEncargos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEncargos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEncargo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dtgvEncargos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnConstancia;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.RichTextBox txtDescripcion;
    }
}

