
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEncargo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelEncargo = new System.Windows.Forms.Panel();
            this.lblSeleccionarProducto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCantidad6 = new System.Windows.Forms.TextBox();
            this.txtCantidad5 = new System.Windows.Forms.TextBox();
            this.txtCantidad4 = new System.Windows.Forms.TextBox();
            this.txtCantidad3 = new System.Windows.Forms.TextBox();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.cbxProducto6 = new System.Windows.Forms.ComboBox();
            this.cbxProducto5 = new System.Windows.Forms.ComboBox();
            this.cbxProducto4 = new System.Windows.Forms.ComboBox();
            this.cbxProducto3 = new System.Windows.Forms.ComboBox();
            this.cbxProducto2 = new System.Windows.Forms.ComboBox();
            this.cbxProducto1 = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarCliente = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnConstancia = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtgvEncargos = new System.Windows.Forms.DataGridView();
            this.panelEncargo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEncargos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAñadir.Font = new System.Drawing.Font("Segoe UI", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(23, 389);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(214, 53);
            this.btnAñadir.TabIndex = 15;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHorario.ForeColor = System.Drawing.Color.Black;
            this.lblHorario.Location = new System.Drawing.Point(23, 191);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(68, 20);
            this.lblHorario.TabIndex = 14;
            this.lblHorario.Text = "Horario:";
            this.lblHorario.Click += new System.EventHandler(this.lblHorario_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(38, 154);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblEncargo
            // 
            this.lblEncargo.AutoSize = true;
            this.lblEncargo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblEncargo.Font = new System.Drawing.Font("Segoe UI", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEncargo.ForeColor = System.Drawing.Color.White;
            this.lblEncargo.Location = new System.Drawing.Point(41, 55);
            this.lblEncargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncargo.Name = "lblEncargo";
            this.lblEncargo.Size = new System.Drawing.Size(164, 30);
            this.lblEncargo.TabIndex = 10;
            this.lblEncargo.Text = "Añadir Encargo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(134, 448);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(38, 448);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 27);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelEncargo
            // 
            this.panelEncargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEncargo.BackColor = System.Drawing.Color.Goldenrod;
            this.panelEncargo.Controls.Add(this.lblSeleccionarProducto);
            this.panelEncargo.Controls.Add(this.panel2);
            this.panelEncargo.Controls.Add(this.btnEliminar);
            this.panelEncargo.Controls.Add(this.btnEditar);
            this.panelEncargo.Controls.Add(this.lblSeleccionarCliente);
            this.panelEncargo.Controls.Add(this.cbxCliente);
            this.panelEncargo.Controls.Add(this.cbxHorario);
            this.panelEncargo.Controls.Add(this.dtpFecha);
            this.panelEncargo.Controls.Add(this.btnAñadir);
            this.panelEncargo.Controls.Add(this.lblHorario);
            this.panelEncargo.Controls.Add(this.lblFecha);
            this.panelEncargo.Controls.Add(this.lblEncargo);
            this.panelEncargo.Location = new System.Drawing.Point(774, 1);
            this.panelEncargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelEncargo.Name = "panelEncargo";
            this.panelEncargo.Size = new System.Drawing.Size(256, 571);
            this.panelEncargo.TabIndex = 23;
            this.panelEncargo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSeleccionarProducto
            // 
            this.lblSeleccionarProducto.AutoSize = true;
            this.lblSeleccionarProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionarProducto.ForeColor = System.Drawing.Color.Black;
            this.lblSeleccionarProducto.Location = new System.Drawing.Point(13, 238);
            this.lblSeleccionarProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionarProducto.Name = "lblSeleccionarProducto";
            this.lblSeleccionarProducto.Size = new System.Drawing.Size(169, 20);
            this.lblSeleccionarProducto.TabIndex = 39;
            this.lblSeleccionarProducto.Text = "Seleccionar Productos:";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.txtCantidad6);
            this.panel2.Controls.Add(this.txtCantidad5);
            this.panel2.Controls.Add(this.txtCantidad4);
            this.panel2.Controls.Add(this.txtCantidad3);
            this.panel2.Controls.Add(this.txtCantidad2);
            this.panel2.Controls.Add(this.txtCantidad1);
            this.panel2.Controls.Add(this.cbxProducto6);
            this.panel2.Controls.Add(this.cbxProducto5);
            this.panel2.Controls.Add(this.cbxProducto4);
            this.panel2.Controls.Add(this.cbxProducto3);
            this.panel2.Controls.Add(this.cbxProducto2);
            this.panel2.Controls.Add(this.cbxProducto1);
            this.panel2.Location = new System.Drawing.Point(13, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 89);
            this.panel2.TabIndex = 38;
            // 
            // txtCantidad6
            // 
            this.txtCantidad6.Location = new System.Drawing.Point(3, 148);
            this.txtCantidad6.Name = "txtCantidad6";
            this.txtCantidad6.Size = new System.Drawing.Size(18, 23);
            this.txtCantidad6.TabIndex = 45;
            // 
            // txtCantidad5
            // 
            this.txtCantidad5.Location = new System.Drawing.Point(3, 119);
            this.txtCantidad5.Name = "txtCantidad5";
            this.txtCantidad5.Size = new System.Drawing.Size(18, 23);
            this.txtCantidad5.TabIndex = 44;
            // 
            // txtCantidad4
            // 
            this.txtCantidad4.Location = new System.Drawing.Point(3, 90);
            this.txtCantidad4.Name = "txtCantidad4";
            this.txtCantidad4.Size = new System.Drawing.Size(18, 23);
            this.txtCantidad4.TabIndex = 43;
            // 
            // txtCantidad3
            // 
            this.txtCantidad3.Location = new System.Drawing.Point(3, 61);
            this.txtCantidad3.Name = "txtCantidad3";
            this.txtCantidad3.Size = new System.Drawing.Size(18, 23);
            this.txtCantidad3.TabIndex = 42;
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Location = new System.Drawing.Point(3, 32);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(18, 23);
            this.txtCantidad2.TabIndex = 41;
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(3, 3);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(18, 23);
            this.txtCantidad1.TabIndex = 40;
            // 
            // cbxProducto6
            // 
            this.cbxProducto6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto6.FormattingEnabled = true;
            this.cbxProducto6.Location = new System.Drawing.Point(25, 148);
            this.cbxProducto6.Name = "cbxProducto6";
            this.cbxProducto6.Size = new System.Drawing.Size(184, 23);
            this.cbxProducto6.TabIndex = 5;
            // 
            // cbxProducto5
            // 
            this.cbxProducto5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto5.FormattingEnabled = true;
            this.cbxProducto5.Location = new System.Drawing.Point(25, 119);
            this.cbxProducto5.Name = "cbxProducto5";
            this.cbxProducto5.Size = new System.Drawing.Size(184, 23);
            this.cbxProducto5.TabIndex = 4;
            // 
            // cbxProducto4
            // 
            this.cbxProducto4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto4.FormattingEnabled = true;
            this.cbxProducto4.Location = new System.Drawing.Point(25, 90);
            this.cbxProducto4.Name = "cbxProducto4";
            this.cbxProducto4.Size = new System.Drawing.Size(184, 23);
            this.cbxProducto4.TabIndex = 3;
            // 
            // cbxProducto3
            // 
            this.cbxProducto3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto3.FormattingEnabled = true;
            this.cbxProducto3.Location = new System.Drawing.Point(25, 61);
            this.cbxProducto3.Name = "cbxProducto3";
            this.cbxProducto3.Size = new System.Drawing.Size(184, 23);
            this.cbxProducto3.TabIndex = 2;
            // 
            // cbxProducto2
            // 
            this.cbxProducto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto2.FormattingEnabled = true;
            this.cbxProducto2.Location = new System.Drawing.Point(25, 32);
            this.cbxProducto2.Name = "cbxProducto2";
            this.cbxProducto2.Size = new System.Drawing.Size(184, 23);
            this.cbxProducto2.TabIndex = 1;
            // 
            // cbxProducto1
            // 
            this.cbxProducto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto1.FormattingEnabled = true;
            this.cbxProducto1.Location = new System.Drawing.Point(25, 3);
            this.cbxProducto1.Name = "cbxProducto1";
            this.cbxProducto1.Size = new System.Drawing.Size(184, 23);
            this.cbxProducto1.TabIndex = 0;
            // 
            // lblSeleccionarCliente
            // 
            this.lblSeleccionarCliente.AutoSize = true;
            this.lblSeleccionarCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionarCliente.ForeColor = System.Drawing.Color.Black;
            this.lblSeleccionarCliente.Location = new System.Drawing.Point(4, 99);
            this.lblSeleccionarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionarCliente.Name = "lblSeleccionarCliente";
            this.lblSeleccionarCliente.Size = new System.Drawing.Size(94, 40);
            this.lblSeleccionarCliente.TabIndex = 25;
            this.lblSeleccionarCliente.Text = "Seleccionar \r\ncliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(101, 116);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(144, 23);
            this.cbxCliente.TabIndex = 24;
            // 
            // cbxHorario
            // 
            this.cbxHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cbxHorario.Location = new System.Drawing.Point(101, 188);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(121, 23);
            this.cbxHorario.TabIndex = 20;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(101, 151);
            this.dtpFecha.MinDate = new System.DateTime(2021, 11, 25, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFecha.Size = new System.Drawing.Size(93, 23);
            this.dtpFecha.TabIndex = 19;
            this.dtpFecha.Value = new System.DateTime(2021, 11, 25, 0, 0, 0, 0);
            // 
            // btnConstancia
            // 
            this.btnConstancia.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConstancia.Font = new System.Drawing.Font("Segoe UI", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnConstancia.ForeColor = System.Drawing.Color.White;
            this.btnConstancia.Location = new System.Drawing.Point(592, 12);
            this.btnConstancia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConstancia.Name = "btnConstancia";
            this.btnConstancia.Size = new System.Drawing.Size(88, 27);
            this.btnConstancia.TabIndex = 24;
            this.btnConstancia.Text = "Constancia";
            this.btnConstancia.UseVisualStyleBackColor = false;
            this.btnConstancia.Click += new System.EventHandler(this.btnConstancia_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(211, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar Encargo";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(21, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(184, 23);
            this.txtBuscar.TabIndex = 27;
            // 
            // dtgvEncargos
            // 
            this.dtgvEncargos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvEncargos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvEncargos.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dtgvEncargos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvEncargos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEncargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvEncargos.ColumnHeadersHeight = 35;
            this.dtgvEncargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvEncargos.EnableHeadersVisualStyles = false;
            this.dtgvEncargos.GridColor = System.Drawing.Color.Black;
            this.dtgvEncargos.Location = new System.Drawing.Point(12, 55);
            this.dtgvEncargos.Name = "dtgvEncargos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEncargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvEncargos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvEncargos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvEncargos.RowTemplate.Height = 25;
            this.dtgvEncargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvEncargos.Size = new System.Drawing.Size(748, 488);
            this.dtgvEncargos.TabIndex = 29;
            this.dtgvEncargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEncargos_CellClick_1);
            // 
            // FormEncargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1031, 571);
            this.Controls.Add(this.dtgvEncargos);
            this.Controls.Add(this.btnConstancia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panelEncargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormEncargos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEncargo.ResumeLayout(false);
            this.panelEncargo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEncargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEncargo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panelEncargo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnConstancia;
        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblSeleccionarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblSeleccionarProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxProducto6;
        private System.Windows.Forms.ComboBox cbxProducto5;
        private System.Windows.Forms.ComboBox cbxProducto4;
        private System.Windows.Forms.ComboBox cbxProducto3;
        private System.Windows.Forms.ComboBox cbxProducto2;
        private System.Windows.Forms.ComboBox cbxProducto1;
        private System.Windows.Forms.DataGridView dtgvEncargos;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.TextBox txtCantidad6;
        private System.Windows.Forms.TextBox txtCantidad5;
        private System.Windows.Forms.TextBox txtCantidad4;
        private System.Windows.Forms.TextBox txtCantidad3;
        private System.Windows.Forms.TextBox txtCantidad2;
    }
}

