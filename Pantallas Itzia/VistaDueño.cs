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
    public partial class VistaDueño: Form
    {
        public VistaDueño()
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

        private void VistaDueño_Load(object sender, EventArgs e)
        {
            dgvDueños.Rows.Add("Juan", "Pérez", "123456789", "juan@mail.com", "Calle 123");

            // Asumiendo que ya tienes tu DataGridView configurado
            dgvMascotas.Rows.Add("Max", "Perro", "Labrador", "2021-04-10", "Macho", 30.5, "1234567890", "Sí", "Saludable");
            dgvMascotas.Rows.Add("Luna", "Gato", "Siamés", "2020-07-15", "Hembra", 4.2, "0987654321", "No", "Vacunada");
            dgvMascotas.Rows.Add("Charlie", "Perro", "Bulldog", "2019-11-20", "Macho", 22.3, "1122334455", "Sí", "En recuperación");

            dgvDueños.ClearSelection();
            dgvMascotas.ClearSelection();
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            AgregarMascota agregarMascota = new AgregarMascota();
            agregarMascota.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AdministarDueño administarDueño = new AdministarDueño();
            administarDueño.Show();
        }

        private void btnModificarM_Click(object sender, EventArgs e)
        {
            ModificarMascota modificarMascota = new ModificarMascota();
            modificarMascota.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            consultar.Show();
        }
    }
}
