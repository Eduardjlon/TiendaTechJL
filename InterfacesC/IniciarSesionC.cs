using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaExaFinalS2.InterfacesE;

namespace TiendaExaFinalS2.InterfacesC
{
    public partial class IniciarSesionC : Form
    {
        public IniciarSesionC()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            //..
        }

        private void OlvideContraseña_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario de IniciarSesion
            this.Close();

            // Crear una nueva instancia de ContraOlvidada
            var OlvideContraForm = new InterfacesC.ContraOlvidadaC();

            // Llamar al método de Form1 para abrir el formulario en el panel
            var form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                // Pasar el formulario 'OlvideContraForm' que es un tipo de 'Form'
                form1.AbrirFormularioEnPanel(OlvideContraForm); // Mostrar en el panel
            }
        }
        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario de IniciarSesion
            this.Close();

            // Crear una nueva instancia de ContraOlvidada
            var MenuClientesForm = new InterfacesC.MenuCliente();

            // Llamar al método de Form1 para abrir el formulario en el panel
            var form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                // Pasar el formulario 'MenuClienteForm' que es un tipo de 'Form'
                form1.AbrirFormularioEnPanel(MenuClientesForm); // Mostrar en el panel
            }
        }
    }
}
