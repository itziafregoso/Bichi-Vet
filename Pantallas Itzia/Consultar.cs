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
    public partial class Consultar: Form
    {
        public Consultar()
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

        private void Consultar_Load(object sender, EventArgs e)
        {
            dgvDueños.Rows.Add("Juan", "Pérez", "123456789");
            dgvMascotas.Rows.Add("Charlie", "Perro", "Bulldog", "3");
            // Suponiendo que ya tienes tu DataGridView configurado con una columna para las fechas
            // Asegúrate de que la columna donde se agregan las fechas esté configurada para mostrar solo la fecha
            dgvConsultasFecha.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Ahora agregamos las fechas sin la hora
            dgvConsultasFecha.Rows.Add(new DateTime(2023, 2, 14).ToString("dd/MM/yyyy"));
            dgvConsultasFecha.Rows.Add(new DateTime(2021, 9, 5).ToString("dd/MM/yyyy"));
            dgvConsultasFecha.Rows.Add(new DateTime(2020, 11, 22).ToString("dd/MM/yyyy"));
            dgvConsultasFecha.Rows.Add(new DateTime(2022, 6, 17).ToString("dd/MM/yyyy"));
            dgvConsultasFecha.Rows.Add(new DateTime(2024, 1, 30).ToString("dd/MM/yyyy"));

            dgvConsultasFecha.ClearSelection();
            dgvDueños.ClearSelection();
            dgvMascotas.ClearSelection();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VistaDueño vistaDueño = new VistaDueño();
            vistaDueño.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            NuevaConsulta nuevaConsulta = new NuevaConsulta();
            nuevaConsulta.Show();
        }

        
    }
}
