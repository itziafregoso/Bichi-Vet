namespace BichiVet
{
    partial class AdministarDueño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministarDueño));
            this.PnlEncabezado = new System.Windows.Forms.Panel();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblNombreVet = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvDueños = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarDueño = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarDueño = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdministrarMascota = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarDueño = new Guna.UI2.WinForms.Guna2Button();
            this.Buscador = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegresar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pbLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Usuario = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PnlEncabezado.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
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
            this.PnlEncabezado.TabIndex = 0;
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
            this.lblEncabezado.Text = "ADMINISTRAR DUEÑO";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.BorderRadius = 10;
            this.GroupBox1.Controls.Add(this.dgvDueños);
            this.GroupBox1.Controls.Add(this.btnModificarDueño);
            this.GroupBox1.Controls.Add(this.btnAgregarDueño);
            this.GroupBox1.Controls.Add(this.btnAdministrarMascota);
            this.GroupBox1.Controls.Add(this.btnEliminarDueño);
            this.GroupBox1.Controls.Add(this.Buscador);
            this.GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.GroupBox1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.GroupBox1.Location = new System.Drawing.Point(172, 115);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(968, 529);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.Text = "Dueños";
            // 
            // dgvDueños
            // 
            this.dgvDueños.AllowUserToAddRows = false;
            this.dgvDueños.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.dgvDueños.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDueños.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDueños.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDueños.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDueños.ColumnHeadersHeight = 29;
            this.dgvDueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDueños.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDueños.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDueños.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.dgvDueños.Location = new System.Drawing.Point(119, 175);
            this.dgvDueños.Name = "dgvDueños";
            this.dgvDueños.ReadOnly = true;
            this.dgvDueños.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDueños.RowHeadersVisible = false;
            this.dgvDueños.RowHeadersWidth = 51;
            this.dgvDueños.RowTemplate.Height = 24;
            this.dgvDueños.Size = new System.Drawing.Size(711, 178);
            this.dgvDueños.TabIndex = 6;
            this.dgvDueños.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDueños.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDueños.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDueños.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDueños.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDueños.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.dgvDueños.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.dgvDueños.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDueños.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDueños.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDueños.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDueños.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDueños.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvDueños.ThemeStyle.ReadOnly = true;
            this.dgvDueños.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDueños.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDueños.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDueños.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDueños.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDueños.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDueños.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Correo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dirección";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnModificarDueño
            // 
            this.btnModificarDueño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarDueño.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarDueño.BorderRadius = 10;
            this.btnModificarDueño.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarDueño.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarDueño.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarDueño.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarDueño.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.btnModificarDueño.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnModificarDueño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.btnModificarDueño.Image = global::BichiVet.Properties.Resources.edit;
            this.btnModificarDueño.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnModificarDueño.Location = new System.Drawing.Point(322, 466);
            this.btnModificarDueño.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificarDueño.Name = "btnModificarDueño";
            this.btnModificarDueño.PressedDepth = 0;
            this.btnModificarDueño.Size = new System.Drawing.Size(212, 31);
            this.btnModificarDueño.TabIndex = 5;
            this.btnModificarDueño.Text = "Modificar Dueño";
            this.btnModificarDueño.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModificarDueño.Click += new System.EventHandler(this.btnModificarDueño_Click);
            // 
            // btnAgregarDueño
            // 
            this.btnAgregarDueño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarDueño.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDueño.BorderRadius = 10;
            this.btnAgregarDueño.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarDueño.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarDueño.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarDueño.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarDueño.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.btnAgregarDueño.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarDueño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.btnAgregarDueño.Image = global::BichiVet.Properties.Resources.agregar;
            this.btnAgregarDueño.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarDueño.Location = new System.Drawing.Point(119, 466);
            this.btnAgregarDueño.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarDueño.Name = "btnAgregarDueño";
            this.btnAgregarDueño.PressedDepth = 0;
            this.btnAgregarDueño.Size = new System.Drawing.Size(188, 31);
            this.btnAgregarDueño.TabIndex = 5;
            this.btnAgregarDueño.Text = "Agregar Dueño";
            this.btnAgregarDueño.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregarDueño.Click += new System.EventHandler(this.btnAgregarDueño_Click);
            // 
            // btnAdministrarMascota
            // 
            this.btnAdministrarMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdministrarMascota.BackColor = System.Drawing.Color.Transparent;
            this.btnAdministrarMascota.BorderRadius = 10;
            this.btnAdministrarMascota.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdministrarMascota.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdministrarMascota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdministrarMascota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdministrarMascota.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.btnAdministrarMascota.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAdministrarMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.btnAdministrarMascota.Image = global::BichiVet.Properties.Resources.lista;
            this.btnAdministrarMascota.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdministrarMascota.Location = new System.Drawing.Point(594, 466);
            this.btnAdministrarMascota.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdministrarMascota.Name = "btnAdministrarMascota";
            this.btnAdministrarMascota.PressedDepth = 0;
            this.btnAdministrarMascota.Size = new System.Drawing.Size(236, 31);
            this.btnAdministrarMascota.TabIndex = 4;
            this.btnAdministrarMascota.Text = "Administar Mascota";
            this.btnAdministrarMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdministrarMascota.Click += new System.EventHandler(this.btnAdministrarMascota_Click);
            // 
            // btnEliminarDueño
            // 
            this.btnEliminarDueño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarDueño.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDueño.BorderRadius = 10;
            this.btnEliminarDueño.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarDueño.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarDueño.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarDueño.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarDueño.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.btnEliminarDueño.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarDueño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.btnEliminarDueño.Image = global::BichiVet.Properties.Resources.eliminar;
            this.btnEliminarDueño.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEliminarDueño.Location = new System.Drawing.Point(550, 466);
            this.btnEliminarDueño.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarDueño.Name = "btnEliminarDueño";
            this.btnEliminarDueño.PressedDepth = 0;
            this.btnEliminarDueño.Size = new System.Drawing.Size(188, 31);
            this.btnEliminarDueño.TabIndex = 4;
            this.btnEliminarDueño.Text = "Eliminar Dueño";
            this.btnEliminarDueño.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminarDueño.Click += new System.EventHandler(this.btnEliminarDueño_Click);
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
            this.Buscador.PlaceholderText = "Buscar Dueño: Nombre, Apellidos, Telefono....";
            this.Buscador.SelectedText = "";
            this.Buscador.Size = new System.Drawing.Size(711, 40);
            this.Buscador.TabIndex = 1;
            this.Buscador.TextChanged += new System.EventHandler(this.Buscador_TextChanged);
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
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
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
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click);
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
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
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
            // AdministarDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.PnlEncabezado);
            this.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdministarDueño";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdministarDueño_Load);
            this.PnlEncabezado.ResumeLayout(false);
            this.PnlEncabezado.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlEncabezado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Button Usuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblNombreVet;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnEliminarDueño;
        private Guna.UI2.WinForms.Guna2TextBox Buscador;
        private Guna.UI2.WinForms.Guna2Button btnAgregarDueño;
        private Guna.UI2.WinForms.Guna2Button btnModificarDueño;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDueños;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2Button btnAdministrarMascota;
    }
}

