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
    public partial class Receta: Form
    {
        public Receta()
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            NuevaConsulta Nuevaconsulta = new NuevaConsulta();
            Nuevaconsulta.Show();
        }

        private void Receta_Load(object sender, EventArgs e)
        {
            dgvDueños.Rows.Add("Carlos", "Gómez", "555666777", "carlos@mail.com", "Plaza Norte 789");
            dgvMascotas.Rows.Add("Luna", "Gato", "Siamés", "2020-07-15", "Hembra", 4.2, "0987654321", "No", "Vacunada");
            dgvMascotas.ClearSelection();
            dgvDueños.ClearSelection();
        }
    }
}
