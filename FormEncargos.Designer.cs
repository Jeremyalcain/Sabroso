
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblEncargo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtgvEncargos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listaProducto = new System.Windows.Forms.CheckedListBox();
            this.lblNombreyApellido = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnConstancia = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
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
            this.lblHorario.Location = new System.Drawing.Point(13, 199);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(58, 17);
            this.lblHorario.TabIndex = 14;
            this.lblHorario.Text = "Horario:";
            this.lblHorario.Click += new System.EventHandler(this.lblHorario_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(13, 157);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 17);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblProductos.ForeColor = System.Drawing.Color.Black;
            this.lblProductos.Location = new System.Drawing.Point(15, 233);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(111, 17);
            this.lblProductos.TabIndex = 11;
            this.lblProductos.Text = "Elegir Productos:";
            // 
            // lblEncargo
            // 
            this.lblEncargo.AutoSize = true;
            this.lblEncargo.BackColor = System.Drawing.Color.Transparent;
            this.lblEncargo.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEncargo.ForeColor = System.Drawing.Color.Black;
            this.lblEncargo.Location = new System.Drawing.Point(63, 61);
            this.lblEncargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncargo.Name = "lblEncargo";
            this.lblEncargo.Size = new System.Drawing.Size(119, 20);
            this.lblEncargo.TabIndex = 10;
            this.lblEncargo.Text = "Añadir Encargo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(134, 448);
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
            this.btnEditar.Location = new System.Drawing.Point(38, 448);
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
            this.dtgvEncargos.Location = new System.Drawing.Point(12, 55);
            this.dtgvEncargos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgvEncargos.Name = "dtgvEncargos";
            this.dtgvEncargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvEncargos.Size = new System.Drawing.Size(668, 442);
            this.dtgvEncargos.TabIndex = 20;
            this.dtgvEncargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEncargos_CellClick);
            this.dtgvEncargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEncargos_CellContentClick_1);
            this.dtgvEncargos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dtgvEncargos_RowStateChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.listaProducto);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.lblNombreyApellido);
            this.panel1.Controls.Add(this.cbxCliente);
            this.panel1.Controls.Add(this.cbHorario);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Controls.Add(this.lblHorario);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Controls.Add(this.lblEncargo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(701, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 525);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listaProducto
            // 
            this.listaProducto.FormattingEnabled = true;
            this.listaProducto.Location = new System.Drawing.Point(23, 263);
            this.listaProducto.Name = "listaProducto";
            this.listaProducto.Size = new System.Drawing.Size(159, 94);
            this.listaProducto.TabIndex = 27;
            this.listaProducto.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblNombreyApellido
            // 
            this.lblNombreyApellido.AutoSize = true;
            this.lblNombreyApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreyApellido.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNombreyApellido.ForeColor = System.Drawing.Color.Black;
            this.lblNombreyApellido.Location = new System.Drawing.Point(23, 96);
            this.lblNombreyApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreyApellido.Name = "lblNombreyApellido";
            this.lblNombreyApellido.Size = new System.Drawing.Size(126, 17);
            this.lblNombreyApellido.TabIndex = 25;
            this.lblNombreyApellido.Text = "Seleccionar cliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(23, 116);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(153, 23);
            this.cbxCliente.TabIndex = 24;
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cbHorario.Location = new System.Drawing.Point(78, 196);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(121, 23);
            this.cbHorario.TabIndex = 20;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(73, 157);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFecha.Size = new System.Drawing.Size(93, 23);
            this.dtpFecha.TabIndex = 19;
            // 
            // btnConstancia
            // 
            this.btnConstancia.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnConstancia.Location = new System.Drawing.Point(592, 8);
            this.btnConstancia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConstancia.Name = "btnConstancia";
            this.btnConstancia.Size = new System.Drawing.Size(88, 27);
            this.btnConstancia.TabIndex = 24;
            this.btnConstancia.Text = "Constancia";
            this.btnConstancia.UseVisualStyleBackColor = true;
            this.btnConstancia.Click += new System.EventHandler(this.btnConstancia_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(201, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar Encargo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(21, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(184, 23);
            this.txtBuscar.TabIndex = 27;
            // 
            // FormEncargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(951, 525);
            this.Controls.Add(this.btnConstancia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblEncargo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dtgvEncargos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnConstancia;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblNombreyApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckedListBox listaProducto;
    }
}

