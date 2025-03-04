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
    public partial class NuevaConsulta: Form
    {
        public NuevaConsulta()
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

        private void NuevaConsulta_Load(object sender, EventArgs e)
        {
            dgvDueños.Rows.Add("Juan", "Pérez", "123456789");
            dgvMascotas.Rows.Add("Charlie", "Perro", "Bulldog", "3");
            dgvDueños.ClearSelection();
            dgvMascotas.ClearSelection();
        }

        private void btnLlenarReceta_Click(object sender, EventArgs e)
        {
            Receta receta = new Receta();
            receta.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            consultar.Show();
        }
    }
}
