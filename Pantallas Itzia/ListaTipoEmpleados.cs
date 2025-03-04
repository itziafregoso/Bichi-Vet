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
    public partial class ListaTipoEmpleados: Form
    {
        public ListaTipoEmpleados()
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
            MenuOpciones menuOpciones = new MenuOpciones();
            menuOpciones.Show();
        }

        private void ListaTipoEmpleados_Load(object sender, EventArgs e)
        {
           
            dgvTipoEmpleados.Rows.Add("Administrador", "Supervisa, coordina, gestiona.", "Ventas, Inventario, Citas Médicas, Consultas, Recetas");
            dgvTipoEmpleados.Rows.Add("Medico", "Diagnostica, trata, previene.", "Citas Médicas, Consultas, Recetas, Historial Médico");
            dgvTipoEmpleados.Rows.Add("Acicalador", "Limpia, corta, embellece.", "Citas Médicas, Historial Médico");
            dgvTipoEmpleados.ClearSelection();
        }

        private void btnAgregarTipoE_Click(object sender, EventArgs e)
        {
            AgregarTipoEmpleado agregarTipo = new AgregarTipoEmpleado();
            agregarTipo.Show();
        }
    }
}
