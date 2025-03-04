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
    public partial class HistorialDeCortes: Form
    {
        public HistorialDeCortes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuOpciones menuOpciones = new MenuOpciones();
            menuOpciones.Show();
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

        private void HistorialDeCortes_Load(object sender, EventArgs e)
        {
            dgvCortesCaja.Rows.Add("2025-03-01 08:00", "Juan Pérez", "Matutino", 1000.00, 5000.00, 2000.00, 4000.00, 1000.00);
            dgvCortesCaja.Rows.Add("2025-03-01 16:00", "Ana López", "Vespertino", 4000.00, 3000.00, 1500.00, 5500.00, 500.00);
            dgvCortesCaja.Rows.Add("2025-03-02 08:00", "Carlos Martínez", "Matutino", 5500.00, 7000.00, 2500.00, 10000.00, 500.00);
            dgvCortesCaja.ClearSelection();
        }
    }
}
