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
    public partial class MenuOpciones: Form
    {
        public MenuOpciones()
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

     

        private void TSMIadministrarDueño_Click(object sender, EventArgs e)
        {
            AdministarDueño administarDueño = new AdministarDueño();
            administarDueño.Show();
            this.Hide();

        }

        private void TSMIListEmpleados_Click(object sender, EventArgs e)
        {
            ListaEmpleado listaEmpleado = new ListaEmpleado();
            listaEmpleado.Show();
            this.Hide();
        }

        private void TSMIListTipoEmpleado_Click(object sender, EventArgs e)
        {
            ListaTipoEmpleados listaTipo = new ListaTipoEmpleados();
            listaTipo.Show();
            this.Hide();
        }

        private void TSMICorteCaja_Click(object sender, EventArgs e)
        {

            CorteDeCaja corteDeCaja = new CorteDeCaja();
            corteDeCaja.Show();
            this.Hide();
        }

        private void TSMIHistorialCorteCaja_Click(object sender, EventArgs e)
        {
            HistorialDeCortes historialDeCortes = new HistorialDeCortes();
            historialDeCortes.Show();
            this.Hide();
        }
    }
}
