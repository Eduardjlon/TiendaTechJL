﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaExaFinalS2.InterfacesC;

namespace TiendaExaFinalS2.InterfacesE
{
    public partial class IniciarSesionE : Form
    {
        public IniciarSesionE()
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
            var recuperarContraseñaForm = new ContraOlvidadaE();

            // Llamar al método de Form1 para abrir el formulario en el panel
            var form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                // Pasar el formulario 'recuperarContraseñaForm' que es un tipo de 'Form'
                form1.AbrirFormularioEnPanel(recuperarContraseñaForm); // Mostrar en el panel
            }
        }
        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void OlvideContraseña_Click_1(object sender, EventArgs e)
        {
            var OlvideContraForm = new ContraOlvidadaE();
            AbrirFormularioEnPanel(OlvideContraForm);   // Mostrarlo en el panel
        }

        private void AbrirFormularioEnPanel(ContraOlvidadaE olvideContraForm)
        {
            throw new NotImplementedException();
        }
    }
        
    }

