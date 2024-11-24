using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TiendaExaFinalS2.InterfacesC
{
    public partial class Facturas : Form
    {
        private List<string> productos;
        private decimal total;
        private List<string> facturasGuardadas;

        // Constructor de la clase Facturas
        public Facturas(List<string> productosSeleccionados, decimal montoTotal, List<string> facturas)
        {
            InitializeComponent();
            productos = productosSeleccionados;
            total = montoTotal;
            facturasGuardadas = facturas;

            ConfigurarInterfaz();
            MostrarFactura();
        }

        private void ConfigurarInterfaz()
        {
            this.Text = "Facturación";
            this.Size = new Size(684, 561); // Tamaño fijo del formulario
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla

            // Ajustar el PanelLogo
            Panel panelLogo = (Panel)this.Controls["PanelLogo"];
            if (panelLogo != null)
            {
                int ladoLogo = 150; // Tamaño cuadrado para evitar distorsión
                panelLogo.Size = new Size(ladoLogo, ladoLogo);
                panelLogo.Location = new Point((this.ClientSize.Width - panelLogo.Width) / 2, 20); // Centrado horizontal
                panelLogo.BackColor = Color.Transparent; // Sin color de fondo (si aplica)
            }

            // Nombre de la empresa
            Label lblEmpresa = new Label
            {
                Text = "TECHJL",
                Font = new Font("Arial", 20, FontStyle.Bold),
                AutoSize = true,
                Location = new Point((this.ClientSize.Width - 200) / 2, 190), // Centrado horizontal debajo del logo
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblEmpresa);

            // FlowLayoutPanel para los productos
            FlowLayoutPanel flowPanel = new FlowLayoutPanel
            {
                Width = 640,
                Height = 200,
                Location = new Point((this.ClientSize.Width - 640) / 2, 230), // Centrado horizontal
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };
            flowPanel.Name = "flowFactura";
            this.Controls.Add(flowPanel);

            // Etiqueta para el total
            Label lblTotal = new Label
            {
                Text = $"Total: Q{total:F2}",
                Font = new Font("Arial", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point((this.ClientSize.Width - 150) / 2, 440), // Centrado horizontal
                TextAlign = ContentAlignment.MiddleCenter
            };
            lblTotal.Name = "lblTotal";
            this.Controls.Add(lblTotal);

            // Campos para NIT y nombre
            TextBox txtNit = new TextBox
            {
                PlaceholderText = "Ingrese NIT o 'CF'",
                Location = new Point((this.ClientSize.Width - 350) / 2, 470),
                Width = 350
            };
            txtNit.Name = "txtNit";
            this.Controls.Add(txtNit);

            TextBox txtNombre = new TextBox
            {
                PlaceholderText = "Ingrese Nombre del Cliente",
                Location = new Point((this.ClientSize.Width - 350) / 2, 500),
                Width = 350
            };
            txtNombre.Name = "txtNombre";
            this.Controls.Add(txtNombre);

            // Botón para finalizar la factura
            Button btnFinalizar = new Button
            {
                Text = "Finalizar Factura",
                Location = new Point((this.ClientSize.Width - 350) / 2, 530),
                Width = 350
            };
            btnFinalizar.Click += BtnFinalizar_Click;
            this.Controls.Add(btnFinalizar);
        }

        private void MostrarFactura()
        {
            FlowLayoutPanel flowPanel = (FlowLayoutPanel)this.Controls["flowFactura"];

            foreach (var producto in productos)
            {
                Label lblProducto = new Label
                {
                    Text = producto,
                    AutoSize = true
                };
                flowPanel.Controls.Add(lblProducto);
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            // Validar datos del cliente
            TextBox txtNit = (TextBox)this.Controls["txtNit"];
            TextBox txtNombre = (TextBox)this.Controls["txtNombre"];

            if (string.IsNullOrWhiteSpace(txtNit.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar factura
            string factura = $"NIT: {txtNit.Text}, Cliente: {txtNombre.Text}, Total: Q{total:F2}";
            facturasGuardadas.Add(factura);

            MessageBox.Show("Factura generada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Obtener la instancia de Form1 y cargar el formulario SobreNosotros
            var form1 = Application.OpenForms["Form1"] as Form1; // Obtener la instancia de Form1
            if (form1 != null)
            {
                form1.CargarFormularioInicial(); // Llamar el método que carga SobreNosotros en el panel
            }

            // Cerrar el formulario de facturación
            this.Close();
        }

    }
}
