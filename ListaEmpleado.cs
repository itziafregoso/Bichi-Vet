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
    public partial class ListaEmpleado: Form
    {
        public ListaEmpleado()
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

        private void ListaEmpleado_Load(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Add("Juan", "Pérez López", "Veterinario", "664-123-4567");
            dgvEmpleados.Rows.Add("Ana", "García Mendoza", "Recepcionista", "664-987-6543");
            dgvEmpleados.Rows.Add("Carlos", "Rodríguez Díaz", "Asistente", "664-555-7788");
            dgvEmpleados.Rows.Add("María", "Hernández Soto", "Veterinario", "664-333-2222");
            dgvEmpleados.ClearSelection();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuOpciones menuOpciones = new MenuOpciones();
            menuOpciones.Show();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            agregarEmpleado.Show();
        }

        private void PnlEncabezado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            ModificarEmpleado modificarEmpleado = new ModificarEmpleado();
            modificarEmpleado.Show();
        }
    }
}
