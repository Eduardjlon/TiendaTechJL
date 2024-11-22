using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TiendaExaFinalS2.InterfacesC
{
    public partial class MenuCliente : Form
    {
        private decimal montoTotal = 0.00m; // Variable para el monto total

        public MenuCliente()
        {
            InitializeComponent();
            CargarProductos();
            CrearPanelCarrito();
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

        // Crear el panel del carrito
        private void CrearPanelCarrito()
        {
            // Crear el panel para el carrito
            Panel panelCarrito = new Panel
            {
                Width = 250,
                Height = 400,
                Location = new Point(400, 10),  // Ajusta la ubicación según lo desees
                AutoScroll = true,
                BackColor = Color.Black // Agregar un color de fondo para mejor visibilidad
            };
            this.Controls.Add(panelCarrito);

            // Agregar una lista para los productos del carrito
            ListBox listBoxCarrito = new ListBox
            {
                Width = 250,
                Height = 300,
                BackColor = Color.Black, // Establecer el fondo del ListBox como negro
                ForeColor = Color.White, // Cambiar el color del texto a blanco para mayor visibilidad
                BorderStyle = BorderStyle.None // Eliminar el borde del ListBox si lo deseas
            };
            listBoxCarrito.SelectionMode = SelectionMode.One;
            panelCarrito.Controls.Add(listBoxCarrito);

            // Etiqueta para el monto total
            Label lblMontoTotal = new Label
            {
                Name = "lblMontoTotal", // Para referenciarlo luego
                Text = "Total: Q0.00",
                Width = 250,
                Height = 25,
                Location = new Point(0, 310),  // Ajusta según lo necesites
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White // Asegurarse de que el texto sea visible
            };
            panelCarrito.Controls.Add(lblMontoTotal);
        }


        // Función para cargar los productos
        private void CargarProductos()
        {
            // Lista de productos con código, nombre, precio e imagen
            var productos = new List<(string Codigo, string Nombre, decimal Precio, string RutaImagen)>
            {
                ("0001", "Eva", 49.99m, ObtenerRutaRelativa("Eva.jpg")),
                ("0002", "Batman Completo", 139.99m, ObtenerRutaRelativa("BatmanCompleto.jpg")),
                ("0003", "Batman Estatua", 99.99m, ObtenerRutaRelativa("BatmanEstatua.jpg")),
                ("0004", "Messi FCB", 69.99m, ObtenerRutaRelativa("MessiFCB.jpg")),
                ("0005", "Reloj y Cargador Magnetico", 199.99m, ObtenerRutaRelativa("RelojYCargadorMagnetico.jpg")),
                ("0006", "Spiderman", 129.99m, ObtenerRutaRelativa("Spiderman.jpg")),
                ("0007", "Spiderman Vs Venom", 99.99m, ObtenerRutaRelativa("SpidermanVSVenom.jpg")),
                ("0008", "Wall-E", 79.99m, ObtenerRutaRelativa("Wall-E.jpg"))
            };

            foreach (var producto in productos)
            {
                // Crear panel para el producto
                Panel panel = new Panel
                {
                    Width = 195,
                    Height = 225 // Ajustado para que se ajuste a la imagen
                };

                // Agregar imagen
                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(producto.RutaImagen),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 195,
                    Height = 100
                };

                // Agregar nombre
                Label lblNombre = new Label
                {
                    Text = producto.Nombre,
                    AutoSize = false,
                    Width = pictureBox.Width, // Asegura que el label tenga el mismo ancho que la imagen
                    Height = 25,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Location = new Point((panel.Width - pictureBox.Width) / 2, pictureBox.Bottom) // Justo debajo de la imagen
                };

                // Agregar precio
                Label lblPrecio = new Label
                {
                    Text = $"Q{producto.Precio}",
                    AutoSize = false,
                    Width = pictureBox.Width,
                    Height = 25,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Location = new Point((panel.Width - pictureBox.Width) / 2, lblNombre.Bottom) // Justo debajo del nombre
                };

                // Agregar botón para agregar al carrito
                Button btnAgregar = new Button
                {
                    Text = "Agregar al Carrito",
                    Width = 195,
                    Height = 25,
                    Location = new Point(0, lblPrecio.Bottom),
                    ForeColor = Color.White
                };
                btnAgregar.Click += (sender, e) => AgregarAlCarrito(producto.Nombre, producto.Precio); // Agregar producto al carrito
                panel.Controls.Add(btnAgregar);

                // Agregar controles al panel
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(lblNombre);
                panel.Controls.Add(lblPrecio);

                // Agregar el panel al FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        // Función para agregar producto al carrito
        private void AgregarAlCarrito(string nombre, decimal precio)
        {
            // Acceder al ListBox dentro del panelCarrito
            ListBox listBoxCarrito = (ListBox)this.Controls.Find("panelCarrito", true)[0].Controls.Find("listBoxCarrito", true)[0];

            // Agregar producto al ListBox
            listBoxCarrito.Items.Add($"{nombre} - Q{precio}");

            // Actualizar el monto total
            montoTotal += precio;
            Label lblMontoTotal = (Label)this.Controls.Find("lblMontoTotal", true)[0];
            lblMontoTotal.Text = $"Total: Q{montoTotal:F2}";
        }

        // Función para eliminar un producto del carrito al seleccionarlo
        private void ListBoxCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCarrito.SelectedItem != null)
            {
                string productoSeleccionado = listBoxCarrito.SelectedItem.ToString();
                decimal precio = decimal.Parse(productoSeleccionado.Split('-')[1].Replace("Q", "").Trim());

                // Eliminar el producto seleccionado del carrito
                listBoxCarrito.Items.RemoveAt(listBoxCarrito.SelectedIndex);

                // Actualizar el monto total
                montoTotal -= precio;
                Label lblMontoTotal = (Label)this.Controls.Find("lblMontoTotal", true)[0];
                lblMontoTotal.Text = $"Total: Q{montoTotal:F2}";
            }
        }


        private void MenuCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un ítem seleccionado en el ListBox
            if (listBoxCarrito.SelectedItem != null)
            {
                // Obtener el nombre del producto y su precio desde el ítem seleccionado
                string productoSeleccionado = listBoxCarrito.SelectedItem.ToString();
                decimal precio = ObtenerPrecioDelProducto(productoSeleccionado);

                // Eliminar el producto seleccionado del carrito
                listBoxCarrito.Items.Remove(listBoxCarrito.SelectedItem);

                // Actualizar el monto total
                montoTotal -= precio;

                // Actualizar la etiqueta de monto total
                Label lblMontoTotal = (Label)this.Controls.Find("lblMontoTotal", true)[0];
                lblMontoTotal.Text = $"Total: Q{montoTotal:F2}";
            }
        }

        // Función para obtener el precio de un producto desde el formato del ListBox
        private decimal ObtenerPrecioDelProducto(string producto)
        {
            string[] partes = producto.Split('-');
            if (partes.Length == 2)
            {
                string precioStr = partes[1].Replace("Q", "").Trim();
                decimal precio = decimal.Parse(precioStr);
                return precio;
            }
            return 0;
        }
    }
}
