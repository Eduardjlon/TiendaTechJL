using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TiendaExaFinalS2.InterfacesC
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        // Función para obtener la ruta relativa
        private string ObtenerRutaRelativa(string nombreArchivo)
        {
            // Obtiene el directorio base del ejecutable y construye la ruta completa
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(basePath, "ImagenesProductos", nombreArchivo);
        }

        private void CargarProductos()
        {
            var productos = new List<(string Nombre, decimal Precio, string RutaImagen)>
            {
                ("Eva", 50.00m, ObtenerRutaRelativa("Eva.jpg"))
                // Puedes agregar más productos si lo necesitas
            };

            foreach (var producto in productos)
            {
                // Crear panel para el producto
                Panel panel = new Panel
                {
                    Width = 200,
                    Height = 250,
                    Margin = new Padding(10)
                };

                // Agregar imagen
                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(producto.RutaImagen),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 200,
                    Height = 150
                };

                Label lblNombre = new Label
                {
                    Text = producto.Nombre,
                    AutoSize = false,
                    Width = 200,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Margin = new Padding(0, -5, 0, 0) // Ajusta los márgenes según sea necesario
                };

                // Agregar precio
                Label lblPrecio = new Label
                {
                    Text = $"Q{producto.Precio}",
                    AutoSize = false,
                    Width = 200,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Margin = new Padding(0, -5, 0, 0) // Ajusta los márgenes según sea necesario

                };

                // Ajustar la posición debajo de la imagen para nombre
                lblNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                lblNombre.Location = new Point(0, pictureBox.Bottom + 5); // 5 píxeles debajo de la imagen

                // Ajustar la posición debajo del nombre para precio
                lblPrecio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                lblPrecio.Location = new Point(0, lblNombre.Bottom + 5); // 5 píxeles debajo del nombre

                // Agregar controles al panel
                panel.Controls.Add(lblPrecio);
                panel.Controls.Add(lblNombre);
                panel.Controls.Add(pictureBox);

                // Agregar el panel al FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(panel);
            }
        }
    }
}
