namespace BichiVet
{
    partial class ModificarMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarMascota));
            this.DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblVacunas = new System.Windows.Forms.Label();
            this.lblAlergias = new System.Windows.Forms.Label();
            this.lblNombreVet = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblMicrochip = new System.Windows.Forms.Label();
            this.lblPesoA = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.txtVacunas = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtAlergias = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRaza = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnlEncabezado = new System.Windows.Forms.Panel();
            this.txtPesoA = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreM = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMicrochip = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEspecie = new Guna.UI2.WinForms.Guna2TextBox();
            this.GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnRegresar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pbLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Usuario = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarDueño = new Guna.UI2.WinForms.Guna2Button();
            this.cbDesparacitado = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbCastrado = new Guna.UI2.WinForms.Guna2CheckBox();
            this.PnlEncabezado.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimePicker1.Animated = true;
            this.DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePicker1.BorderColor = System.Drawing.Color.Transparent;
            this.DateTimePicker1.BorderRadius = 10;
            this.DateTimePicker1.Checked = true;
            this.DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.DateTimePicker1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.DateTimePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker1.Location = new System.Drawing.Point(772, 89);
            this.DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(330, 36);
            this.DateTimePicker1.TabIndex = 7;
            this.DateTimePicker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateTimePicker1.Value = new System.DateTime(2025, 2, 28, 0, 0, 0, 0);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNac.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(768, 63);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(210, 22);
            this.lblFechaNac.TabIndex = 6;
            this.lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // lblRaza
            // 
            this.lblRaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRaza.AutoSize = true;
            this.lblRaza.BackColor = System.Drawing.Color.Transparent;
            this.lblRaza.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaza.Location = new System.Drawing.Point(540, 63);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(60, 22);
            this.lblRaza.TabIndex = 6;
            this.lblRaza.Text = "Raza:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecie.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(279, 63);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(90, 22);
            this.lblEspecie.TabIndex = 6;
            this.lblEspecie.Text = "Especie:";
            // 
            // lblVacunas
            // 
            this.lblVacunas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVacunas.AutoSize = true;
            this.lblVacunas.BackColor = System.Drawing.Color.Transparent;
            this.lblVacunas.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacunas.Location = new System.Drawing.Point(39, 230);
            this.lblVacunas.Name = "lblVacunas";
            this.lblVacunas.Size = new System.Drawing.Size(90, 22);
            this.lblVacunas.TabIndex = 6;
            this.lblVacunas.Text = "Vacunas:";
            // 
            // lblAlergias
            // 
            this.lblAlergias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlergias.AutoSize = true;
            this.lblAlergias.BackColor = System.Drawing.Color.Transparent;
            this.lblAlergias.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlergias.Location = new System.Drawing.Point(540, 146);
            this.lblAlergias.Name = "lblAlergias";
            this.lblAlergias.Size = new System.Drawing.Size(100, 22);
            this.lblAlergias.TabIndex = 6;
            this.lblAlergias.Text = "Alergias:";
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
            this.lblEncabezado.Location = new System.Drawing.Point(423, 13);
            this.lblEncabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(459, 40);
            this.lblEncabezado.TabIndex = 1;
            this.lblEncabezado.Text = "MODIFICAR MASCOTA";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMicrochip
            // 
            this.lblMicrochip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMicrochip.AutoSize = true;
            this.lblMicrochip.BackColor = System.Drawing.Color.Transparent;
            this.lblMicrochip.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicrochip.Location = new System.Drawing.Point(279, 146);
            this.lblMicrochip.Name = "lblMicrochip";
            this.lblMicrochip.Size = new System.Drawing.Size(110, 22);
            this.lblMicrochip.TabIndex = 6;
            this.lblMicrochip.Text = "Microchip:";
            // 
            // lblPesoA
            // 
            this.lblPesoA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesoA.AutoSize = true;
            this.lblPesoA.BackColor = System.Drawing.Color.Transparent;
            this.lblPesoA.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoA.Location = new System.Drawing.Point(42, 146);
            this.lblPesoA.Name = "lblPesoA";
            this.lblPesoA.Size = new System.Drawing.Size(130, 22);
            this.lblPesoA.TabIndex = 6;
            this.lblPesoA.Text = "Peso Actual:";
            // 
            // lblNombreM
            // 
            this.lblNombreM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreM.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.lblNombreM.Location = new System.Drawing.Point(42, 63);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(80, 22);
            this.lblNombreM.TabIndex = 6;
            this.lblNombreM.Text = "Nombre:";
            // 
            // txtVacunas
            // 
            this.txtVacunas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVacunas.BackColor = System.Drawing.Color.Transparent;
            this.txtVacunas.BorderColor = System.Drawing.Color.Transparent;
            this.txtVacunas.BorderRadius = 10;
            this.txtVacunas.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtVacunas.BorderThickness = 0;
            this.txtVacunas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVacunas.DefaultText = "";
            this.txtVacunas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVacunas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVacunas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVacunas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVacunas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.txtVacunas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVacunas.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.txtVacunas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.txtVacunas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVacunas.Location = new System.Drawing.Point(43, 256);
            this.txtVacunas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVacunas.Name = "txtVacunas";
            this.txtVacunas.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.txtVacunas.PlaceholderText = "Vacunas:";
            this.txtVacunas.SelectedText = "";
            this.txtVacunas.Size = new System.Drawing.Size(201, 36);
            this.txtVacunas.TabIndex = 5;
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
            // txtAlergias
            // 
            this.txtAlergias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlergias.BackColor = System.Drawing.Color.Transparent;
            this.txtAlergias.BorderColor = System.Drawing.Color.Transparent;
            this.txtAlergias.BorderRadius = 10;
            this.txtAlergias.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtAlergias.BorderThickness = 0;
            this.txtAlergias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlergias.DefaultText = "";
            this.txtAlergias.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlergias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlergias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlergias.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlergias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.txtAlergias.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlergias.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.txtAlergias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.txtAlergias.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlergias.Location = new System.Drawing.Point(544, 172);
            this.txtAlergias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.txtAlergias.PlaceholderText = "Alergias:";
            this.txtAlergias.SelectedText = "";
            this.txtAlergias.Size = new System.Drawing.Size(201, 36);
            this.txtAlergias.TabIndex = 5;
            // 
            // txtRaza
            // 
            this.txtRaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRaza.AutoSize = true;
            this.txtRaza.BackColor = System.Drawing.Color.Transparent;
            this.txtRaza.BorderColor = System.Drawing.Color.Transparent;
            this.txtRaza.BorderRadius = 10;
            this.txtRaza.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtRaza.BorderThickness = 0;
            this.txtRaza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRaza.DefaultText = "";
            this.txtRaza.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRaza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRaza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRaza.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRaza.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.txtRaza.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRaza.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.txtRaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.txtRaza.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRaza.Location = new System.Drawing.Point(544, 89);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.txtRaza.PlaceholderText = "Raza";
            this.txtRaza.SelectedText = "";
            this.txtRaza.Size = new System.Drawing.Size(201, 36);
            this.txtRaza.TabIndex = 5;
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
            this.PnlEncabezado.TabIndex = 12;
            // 
            // txtPesoA
            // 
            this.txtPesoA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoA.BackColor = System.Drawing.Color.Transparent;
            this.txtPesoA.BorderColor = System.Drawing.Color.Transparent;
            this.txtPesoA.BorderRadius = 10;
            this.txtPesoA.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtPesoA.BorderThickness = 0;
            this.txtPesoA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesoA.DefaultText = "";
            this.txtPesoA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesoA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesoA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesoA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesoA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.txtPesoA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesoA.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.txtPesoA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.txtPesoA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesoA.Location = new System.Drawing.Point(43, 172);
            this.txtPesoA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesoA.Name = "txtPesoA";
            this.txtPesoA.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.txtPesoA.PlaceholderText = "Peso Actual";
            this.txtPesoA.SelectedText = "";
            this.txtPesoA.Size = new System.Drawing.Size(201, 36);
            this.txtPesoA.TabIndex = 5;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreM.AutoScroll = true;
            this.txtNombreM.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreM.BorderColor = System.Drawing.Color.Transparent;
            this.txtNombreM.BorderRadius = 10;
            this.txtNombreM.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtNombreM.BorderThickness = 0;
            this.txtNombreM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreM.DefaultText = "";
            this.txtNombreM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.txtNombreM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreM.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.txtNombreM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.txtNombreM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreM.Location = new System.Drawing.Point(43, 89);
            this.txtNombreM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.txtNombreM.PlaceholderText = "Nombre";
            this.txtNombreM.SelectedText = "";
            this.txtNombreM.Size = new System.Drawing.Size(201, 36);
            this.txtNombreM.TabIndex = 5;
            // 
            // txtMicrochip
            // 
            this.txtMicrochip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMicrochip.BackColor = System.Drawing.Color.Transparent;
            this.txtMicrochip.BorderColor = System.Drawing.Color.Transparent;
            this.txtMicrochip.BorderRadius = 10;
            this.txtMicrochip.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtMicrochip.BorderThickness = 0;
            this.txtMicrochip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMicrochip.DefaultText = "";
            this.txtMicrochip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMicrochip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMicrochip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMicrochip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMicrochip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.txtMicrochip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMicrochip.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.txtMicrochip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.txtMicrochip.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMicrochip.Location = new System.Drawing.Point(283, 172);
            this.txtMicrochip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMicrochip.Name = "txtMicrochip";
            this.txtMicrochip.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.txtMicrochip.PlaceholderText = "Microchip";
            this.txtMicrochip.SelectedText = "";
            this.txtMicrochip.Size = new System.Drawing.Size(201, 36);
            this.txtMicrochip.TabIndex = 5;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEspecie.AutoSize = true;
            this.txtEspecie.BackColor = System.Drawing.Color.Transparent;
            this.txtEspecie.BorderColor = System.Drawing.Color.Transparent;
            this.txtEspecie.BorderRadius = 10;
            this.txtEspecie.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtEspecie.BorderThickness = 0;
            this.txtEspecie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEspecie.DefaultText = "";
            this.txtEspecie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEspecie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEspecie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEspecie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEspecie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.txtEspecie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEspecie.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.txtEspecie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.txtEspecie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEspecie.Location = new System.Drawing.Point(283, 89);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.txtEspecie.PlaceholderText = "Especie";
            this.txtEspecie.SelectedText = "";
            this.txtEspecie.Size = new System.Drawing.Size(201, 36);
            this.txtEspecie.TabIndex = 5;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBox1.BorderRadius = 10;
            this.GroupBox1.Controls.Add(this.cbDesparacitado);
            this.GroupBox1.Controls.Add(this.cbCastrado);
            this.GroupBox1.Controls.Add(this.DateTimePicker1);
            this.GroupBox1.Controls.Add(this.btnAgregarDueño);
            this.GroupBox1.Controls.Add(this.lblFechaNac);
            this.GroupBox1.Controls.Add(this.lblRaza);
            this.GroupBox1.Controls.Add(this.lblEspecie);
            this.GroupBox1.Controls.Add(this.lblVacunas);
            this.GroupBox1.Controls.Add(this.lblAlergias);
            this.GroupBox1.Controls.Add(this.lblMicrochip);
            this.GroupBox1.Controls.Add(this.lblPesoA);
            this.GroupBox1.Controls.Add(this.lblNombreM);
            this.GroupBox1.Controls.Add(this.txtVacunas);
            this.GroupBox1.Controls.Add(this.txtAlergias);
            this.GroupBox1.Controls.Add(this.txtRaza);
            this.GroupBox1.Controls.Add(this.txtPesoA);
            this.GroupBox1.Controls.Add(this.txtNombreM);
            this.GroupBox1.Controls.Add(this.txtMicrochip);
            this.GroupBox1.Controls.Add(this.txtEspecie);
            this.GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.GroupBox1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.GroupBox1.Location = new System.Drawing.Point(90, 180);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1130, 326);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.Text = "Informacion de la Mascota";
            this.GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // btnAgregarDueño
            // 
            this.btnAgregarDueño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarDueño.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDueño.BorderRadius = 10;
            this.btnAgregarDueño.DefaultAutoSize = true;
            this.btnAgregarDueño.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarDueño.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarDueño.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarDueño.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarDueño.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.btnAgregarDueño.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarDueño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.btnAgregarDueño.Image = global::BichiVet.Properties.Resources.guardar;
            this.btnAgregarDueño.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarDueño.Location = new System.Drawing.Point(916, 266);
            this.btnAgregarDueño.Name = "btnAgregarDueño";
            this.btnAgregarDueño.Size = new System.Drawing.Size(123, 31);
            this.btnAgregarDueño.TabIndex = 4;
            this.btnAgregarDueño.Text = "Guardar ";
            this.btnAgregarDueño.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbDesparacitado
            // 
            this.cbDesparacitado.AutoSize = true;
            this.cbDesparacitado.BackColor = System.Drawing.Color.Transparent;
            this.cbDesparacitado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDesparacitado.CheckedState.BorderRadius = 0;
            this.cbDesparacitado.CheckedState.BorderThickness = 0;
            this.cbDesparacitado.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDesparacitado.Location = new System.Drawing.Point(544, 256);
            this.cbDesparacitado.Name = "cbDesparacitado";
            this.cbDesparacitado.Size = new System.Drawing.Size(190, 31);
            this.cbDesparacitado.TabIndex = 10;
            this.cbDesparacitado.Text = "Desparasitado";
            this.cbDesparacitado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbDesparacitado.UncheckedState.BorderRadius = 0;
            this.cbDesparacitado.UncheckedState.BorderThickness = 0;
            this.cbDesparacitado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbDesparacitado.UseVisualStyleBackColor = false;
            // 
            // cbCastrado
            // 
            this.cbCastrado.AutoSize = true;
            this.cbCastrado.BackColor = System.Drawing.Color.Transparent;
            this.cbCastrado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCastrado.CheckedState.BorderRadius = 0;
            this.cbCastrado.CheckedState.BorderThickness = 0;
            this.cbCastrado.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCastrado.Location = new System.Drawing.Point(283, 256);
            this.cbCastrado.Name = "cbCastrado";
            this.cbCastrado.Size = new System.Drawing.Size(130, 31);
            this.cbCastrado.TabIndex = 11;
            this.cbCastrado.Text = "Castrado";
            this.cbCastrado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbCastrado.UncheckedState.BorderRadius = 0;
            this.cbCastrado.UncheckedState.BorderThickness = 0;
            this.cbCastrado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbCastrado.UseVisualStyleBackColor = false;
            // 
            // ModificarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PnlEncabezado);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarMascota";
            this.Text = "ModificarMascota";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlEncabezado.ResumeLayout(false);
            this.PnlEncabezado.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button btnAgregarDueño;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblVacunas;
        private System.Windows.Forms.Label lblAlergias;
        private System.Windows.Forms.Label lblNombreVet;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Button Usuario;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblMicrochip;
        private System.Windows.Forms.Label lblPesoA;
        private System.Windows.Forms.Label lblNombreM;
        private Guna.UI2.WinForms.Guna2TextBox txtVacunas;
        private System.Windows.Forms.Label lblPuesto;
        private Guna.UI2.WinForms.Guna2TextBox txtAlergias;
        private System.Windows.Forms.Button btnSalir;
        private Guna.UI2.WinForms.Guna2TextBox txtRaza;
        private System.Windows.Forms.Panel PnlEncabezado;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar;
        private System.Windows.Forms.Button btnMaximizar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesoA;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreM;
        private Guna.UI2.WinForms.Guna2TextBox txtMicrochip;
        private Guna.UI2.WinForms.Guna2TextBox txtEspecie;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBox1;
        private Guna.UI2.WinForms.Guna2CheckBox cbDesparacitado;
        private Guna.UI2.WinForms.Guna2CheckBox cbCastrado;
    }
}