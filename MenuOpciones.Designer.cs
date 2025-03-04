namespace BichiVet
{
    partial class MenuOpciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOpciones));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemAtencionCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIadministrarDueño = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIListEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIListTipoEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRecepcionista = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMICorteCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIHistorialCorteCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlEncabezado = new System.Windows.Forms.Panel();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreVet = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pbLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Usuario = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.PnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.pnlMenu.Controls.Add(this.menuStrip2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenu.Location = new System.Drawing.Point(0, 70);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1300, 35);
            this.pnlMenu.TabIndex = 9;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAtencionCliente,
            this.toolStripMenuItemEmpleados,
            this.toolStripMenuItemRecepcionista});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(707, 66);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItemAtencionCliente
            // 
            this.toolStripMenuItemAtencionCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIadministrarDueño});
            this.toolStripMenuItemAtencionCliente.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemAtencionCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.toolStripMenuItemAtencionCliente.Name = "toolStripMenuItemAtencionCliente";
            this.toolStripMenuItemAtencionCliente.Size = new System.Drawing.Size(254, 31);
            this.toolStripMenuItemAtencionCliente.Text = "Atencion al Cliente";
            // 
            // TSMIadministrarDueño
            // 
            this.TSMIadministrarDueño.BackColor = System.Drawing.Color.White;
            this.TSMIadministrarDueño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.TSMIadministrarDueño.Name = "TSMIadministrarDueño";
            this.TSMIadministrarDueño.Size = new System.Drawing.Size(314, 32);
            this.TSMIadministrarDueño.Text = "Administrar Dueño ";
            this.TSMIadministrarDueño.Click += new System.EventHandler(this.TSMIadministrarDueño_Click);
            // 
            // toolStripMenuItemEmpleados
            // 
            this.toolStripMenuItemEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.toolStripMenuItemEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIListEmpleados,
            this.TSMIListTipoEmpleado});
            this.toolStripMenuItemEmpleados.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.toolStripMenuItemEmpleados.Name = "toolStripMenuItemEmpleados";
            this.toolStripMenuItemEmpleados.Size = new System.Drawing.Size(134, 31);
            this.toolStripMenuItemEmpleados.Text = "Empleados";
            // 
            // TSMIListEmpleados
            // 
            this.TSMIListEmpleados.BackColor = System.Drawing.Color.White;
            this.TSMIListEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.TSMIListEmpleados.Name = "TSMIListEmpleados";
            this.TSMIListEmpleados.Size = new System.Drawing.Size(374, 32);
            this.TSMIListEmpleados.Text = "Lista Empleados";
            this.TSMIListEmpleados.Click += new System.EventHandler(this.TSMIListEmpleados_Click);
            // 
            // TSMIListTipoEmpleado
            // 
            this.TSMIListTipoEmpleado.BackColor = System.Drawing.Color.White;
            this.TSMIListTipoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.TSMIListTipoEmpleado.Name = "TSMIListTipoEmpleado";
            this.TSMIListTipoEmpleado.Size = new System.Drawing.Size(374, 32);
            this.TSMIListTipoEmpleado.Text = "Lista Tipo de Empleados";
            this.TSMIListTipoEmpleado.Click += new System.EventHandler(this.TSMIListTipoEmpleado_Click);
            // 
            // toolStripMenuItemRecepcionista
            // 
            this.toolStripMenuItemRecepcionista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMICorteCaja,
            this.TSMIHistorialCorteCaja});
            this.toolStripMenuItemRecepcionista.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemRecepcionista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.toolStripMenuItemRecepcionista.Name = "toolStripMenuItemRecepcionista";
            this.toolStripMenuItemRecepcionista.Size = new System.Drawing.Size(182, 31);
            this.toolStripMenuItemRecepcionista.Text = "Recepcionista";
            // 
            // TSMICorteCaja
            // 
            this.TSMICorteCaja.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.TSMICorteCaja.BackColor = System.Drawing.Color.White;
            this.TSMICorteCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.TSMICorteCaja.Name = "TSMICorteCaja";
            this.TSMICorteCaja.Size = new System.Drawing.Size(410, 32);
            this.TSMICorteCaja.Text = "Corte  de Caja";
            this.TSMICorteCaja.Click += new System.EventHandler(this.TSMICorteCaja_Click);
            // 
            // TSMIHistorialCorteCaja
            // 
            this.TSMIHistorialCorteCaja.BackColor = System.Drawing.Color.White;
            this.TSMIHistorialCorteCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.TSMIHistorialCorteCaja.Name = "TSMIHistorialCorteCaja";
            this.TSMIHistorialCorteCaja.Size = new System.Drawing.Size(410, 32);
            this.TSMIHistorialCorteCaja.Text = "Historial de Corte de Caja";
            this.TSMIHistorialCorteCaja.Click += new System.EventHandler(this.TSMIHistorialCorteCaja_Click);
            // 
            // PnlEncabezado
            // 
            this.PnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.PnlEncabezado.Controls.Add(this.pbLogo);
            this.PnlEncabezado.Controls.Add(this.pnlMenu);
            this.PnlEncabezado.Controls.Add(this.lblPuesto);
            this.PnlEncabezado.Controls.Add(this.lblTitulo);
            this.PnlEncabezado.Controls.Add(this.lblNombreVet);
            this.PnlEncabezado.Controls.Add(this.lblUsuario);
            this.PnlEncabezado.Controls.Add(this.Usuario);
            this.PnlEncabezado.Controls.Add(this.btnMinimizar);
            this.PnlEncabezado.Controls.Add(this.btnMaximizar);
            this.PnlEncabezado.Controls.Add(this.btnSalir);
            this.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.PnlEncabezado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlEncabezado.Name = "PnlEncabezado";
            this.PnlEncabezado.Size = new System.Drawing.Size(1300, 105);
            this.PnlEncabezado.TabIndex = 29;
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPuesto.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.lblPuesto.Location = new System.Drawing.Point(1011, 36);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(96, 17);
            this.lblPuesto.TabIndex = 1;
            this.lblPuesto.Text = "Veterinario";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(420, 5);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(459, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "MENU OPCIONES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblUsuario.Location = new System.Drawing.Point(1010, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(126, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Itzia Fregoso";
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
            this.Usuario.Location = new System.Drawing.Point(968, 18);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1157, 16);
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
            this.btnMaximizar.Location = new System.Drawing.Point(1207, 16);
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
            this.btnSalir.Location = new System.Drawing.Point(1257, 16);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PnlEncabezado);
            this.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuOpciones";
            this.Text = "MenuOpciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.PnlEncabezado.ResumeLayout(false);
            this.PnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel PnlEncabezado;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbLogo;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblNombreVet;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button Usuario;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAtencionCliente;
        private System.Windows.Forms.ToolStripMenuItem TSMIadministrarDueño;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEmpleados;
        private System.Windows.Forms.ToolStripMenuItem TSMIListEmpleados;
        private System.Windows.Forms.ToolStripMenuItem TSMIListTipoEmpleado;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRecepcionista;
        private System.Windows.Forms.ToolStripMenuItem TSMICorteCaja;
        private System.Windows.Forms.ToolStripMenuItem TSMIHistorialCorteCaja;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}