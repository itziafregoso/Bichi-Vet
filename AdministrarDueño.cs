using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BichiVet
{
    public partial class AdministarDueño: Form
    {
        public AdministarDueño()
        {
            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?",
                                                  "Confirmación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AdministarDueño_Load(object sender, EventArgs e)
        {
         
            dgvDueños.Rows.Add("Juan", "Pérez", "123456789", "juan@mail.com", "Calle 123");
            dgvDueños.Rows.Add("María", "López", "987654321", "maria@mail.com", "Av. Central 456");
            dgvDueños.Rows.Add("Carlos", "Gómez", "555666777", "carlos@mail.com", "Plaza Norte 789");
            dgvDueños.Rows.Add("Juan", "Pérez", "123456789", "juan@mail.com", "Calle 123");
            dgvDueños.Rows.Add("María", "López", "987654321", "maria@mail.com", "Av. Central 456");
            dgvDueños.Rows.Add("Carlos", "Gómez", "555666777", "carlos@mail.com", "Plaza Norte 789");
            dgvDueños.ClearSelection();

        }

        private void btnAdministrarMascota_Click(object sender, EventArgs e)
        {
            VistaDueño vistaDueño = new VistaDueño(); // Crear instancia del formulario
            vistaDueño.Show(); // Mostrar el formulario
        }

        private void btnAgregarDueño_Click(object sender, EventArgs e)
        {
            AgregarDueño agregarDueño = new AgregarDueño();
            agregarDueño.Show();
        }

        private void btnModificarDueño_Click(object sender, EventArgs e)
        {
            ModificarDueño modificarDueño = new ModificarDueño();
            modificarDueño.Show();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuOpciones menuOpciones = new MenuOpciones();
            menuOpciones.Show();
        }

        private void btnEliminarDueño_Click(object sender, EventArgs e)
        {

        }

        private void Buscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }
    }
}

