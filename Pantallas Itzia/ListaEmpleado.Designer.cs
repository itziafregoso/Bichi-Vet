namespace BichiVet
{
    partial class ListaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaEmpleado));
            this.dgvEmpleados = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnModificarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.Buscador = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblNombreVet = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.PnlEncabezado = new System.Windows.Forms.Panel();
            this.btnRegresar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pbLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Usuario = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.PnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.ColumnHeadersHeight = 29;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.dgvEmpleados.Location = new System.Drawing.Point(119, 175);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(711, 178);
            this.dgvEmpleados.TabIndex = 6;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.dgvEmpleados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.dgvEmpleados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleados.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpleados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmpleados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmpleados.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvEmpleados.ThemeStyle.ReadOnly = true;
            this.dgvEmpleados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleados.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpleados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmpleados.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEmpleados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre(s)";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellidos";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.BorderRadius = 10;
            this.GroupBox1.Controls.Add(this.dgvEmpleados);
            this.GroupBox1.Controls.Add(this.btnModificarEmpleado);
            this.GroupBox1.Controls.Add(this.btnAgregarEmpleado);
            this.GroupBox1.Controls.Add(this.btnEliminarEmpleado);
            this.GroupBox1.Controls.Add(this.Buscador);
            this.GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.GroupBox1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.GroupBox1.Location = new System.Drawing.Point(172, 119);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(968, 529);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.Text = "Empleados";
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarEmpleado.BorderRadius = 10;
            this.btnModificarEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.btnModificarEmpleado.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnModificarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.btnModificarEmpleado.Image = global::BichiVet.Properties.Resources.edit;
            this.btnModificarEmpleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(350, 466);
            this.btnModificarEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.PressedDepth = 0;
            this.btnModificarEmpleado.Size = new System.Drawing.Size(236, 31);
            this.btnModificarEmpleado.TabIndex = 5;
            this.btnModificarEmpleado.Text = "Modificar Empleado";
            this.btnModificarEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEmpleado.BorderRadius = 10;
            this.btnAgregarEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.btnAgregarEmpleado.Image = global::BichiVet.Properties.Resources.agregar;
            this.btnAgregarEmpleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(119, 466);
            this.btnAgregarEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.PressedDepth = 0;
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(215, 31);
            this.btnAgregarEmpleado.TabIndex = 5;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarEmpleado.BorderRadius = 10;
            this.btnEliminarEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.btnEliminarEmpleado.Image = global::BichiVet.Properties.Resources.eliminar;
            this.btnEliminarEmpleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(602, 466);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.PressedDepth = 0;
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(226, 31);
            this.btnEliminarEmpleado.TabIndex = 4;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Buscador
            // 
            this.Buscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscador.BackColor = System.Drawing.Color.Transparent;
            this.Buscador.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.Buscador.BorderRadius = 20;
            this.Buscador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Buscador.DefaultText = "";
            this.Buscador.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Buscador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Buscador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Buscador.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Buscador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.Buscador.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Buscador.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.Buscador.ForeColor = System.Drawing.Color.White;
            this.Buscador.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Buscador.IconLeft = global::BichiVet.Properties.Resources.Buscar;
            this.Buscador.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Buscador.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.Buscador.IconRight = ((System.Drawing.Image)(resources.GetObject("Buscador.IconRight")));
            this.Buscador.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Buscador.IconRightOffset = new System.Drawing.Point(10, 0);
            this.Buscador.Location = new System.Drawing.Point(119, 90);
            this.Buscador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Buscador.Name = "Buscador";
            this.Buscador.PlaceholderText = "Buscar Empleado: Nombre, Apellidos\r\n";
            this.Buscador.SelectedText = "";
            this.Buscador.Size = new System.Drawing.Size(711, 40);
            this.Buscador.TabIndex = 1;
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPuesto.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.lblPuesto.Location = new System.Drawing.Point(1009, 36);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(96, 17);
            this.lblPuesto.TabIndex = 1;
            this.lblPuesto.Text = "Veterinario";
            // 
            // lblNombreVet
            // 
            this.lblNombreVet.AutoSize = true;
            this.lblNombreVet.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreVet.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.lblNombreVet.Location = new System.Drawing.Point(166, 19);
            this.lblNombreVet.Name = "lblNombreVet";
            this.lblNombreVet.Size = new System.Drawing.Size(117, 30);
            this.lblNombreVet.TabIndex = 1;
            this.lblNombreVet.Text = "BichiVet";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.lblUsuario.Location = new System.Drawing.Point(1008, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(126, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Itzia Fregoso";
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEncabezado.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lblEncabezado.Location = new System.Drawing.Point(413, 13);
            this.lblEncabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(459, 40);
            this.lblEncabezado.TabIndex = 1;
            this.lblEncabezado.Text = "LISTA EMPLEADOS";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlEncabezado
            // 
            this.PnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.PnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlEncabezado.Controls.Add(this.btnRegresar);
            this.PnlEncabezado.Controls.Add(this.pbLogo);
            this.PnlEncabezado.Controls.Add(this.lblPuesto);
            this.PnlEncabezado.Controls.Add(this.lblNombreVet);
            this.PnlEncabezado.Controls.Add(this.lblUsuario);
            this.PnlEncabezado.Controls.Add(this.lblEncabezado);
            this.PnlEncabezado.Controls.Add(this.Usuario);
            this.PnlEncabezado.Controls.Add(this.btnMinimizar);
            this.PnlEncabezado.Controls.Add(this.btnMaximizar);
            this.PnlEncabezado.Controls.Add(this.btnSalir);
            this.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.PnlEncabezado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlEncabezado.Name = "PnlEncabezado";
            this.PnlEncabezado.Size = new System.Drawing.Size(1300, 70);
            this.PnlEncabezado.TabIndex = 8;
            this.PnlEncabezado.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlEncabezado_Paint);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::BichiVet.Properties.Resources.Regresar;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegresar.FillColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegresar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Location = new System.Drawing.Point(11, 13);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegresar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRegresar.Size = new System.Drawing.Size(40, 40);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.FillColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::BichiVet.Properties.Resources.logo;
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(120, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbLogo.Size = new System.Drawing.Size(40, 40);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // Usuario
            // 
            this.Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Usuario.BackgroundImage")));
            this.Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Usuario.Enabled = false;
            this.Usuario.FlatAppearance.BorderSize = 0;
            this.Usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuario.Location = new System.Drawing.Point(966, 18);
            this.Usuario.Margin = new System.Windows.Forms.Padding(5);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(35, 35);
            this.Usuario.TabIndex = 1;
            this.Usuario.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(1155, 16);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(1205, 16);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1255, 16);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ListaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.PnlEncabezado);
            this.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaEmpleado";
            this.Text = "ListaEmpleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.PnlEncabezado.ResumeLayout(false);
            this.PnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnModificarEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnAgregarEmpleado;
        private Guna.UI2.WinForms.Guna2TextBox Buscador;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2Button btnEliminarEmpleado;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBox1;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbLogo;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblNombreVet;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Button Usuario;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel PnlEncabezado;
    }
}