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
        private List<string> facturas = new List<string>();

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        // Función para obtener la ruta 
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
            var productos = new List<(string Codigo, string Nombre, decimal Precio, string RutaImagen, int Cantidad)>
{
    ("0001", "Eva", 49.99m, ObtenerRutaRelativa("Eva.jpg"), 50),
    ("0002", "Batman Completo", 139.99m, ObtenerRutaRelativa("BatmanCompleto.jpg"), 30),
    ("0003", "Batman Estatua", 99.99m, ObtenerRutaRelativa("BatmanEstatua.jpg"), 20),
    ("0004", "Messi FCB", 69.99m, ObtenerRutaRelativa("MessiFCB.jpg"), 15),
    ("0005", "Reloj y Cargador Magnetico", 199.99m, ObtenerRutaRelativa("RelojYCargadorMagnetico.jpg"), 10),
    ("0006", "Spiderman", 129.99m, ObtenerRutaRelativa("Spiderman.jpg"), 25),
    ("0007", "Spiderman Vs Venom", 99.99m, ObtenerRutaRelativa("SpidermanVSVenom.jpg"), 10),
    ("0008", "Wall-E", 79.99m, ObtenerRutaRelativa("Wall-E.jpg"), 5)
};


            foreach (var producto in productos)
            {
                // Crear panel para el producto
                Panel panel = new Panel
                {
                    Width = 195,
                    Height = 225 // Ajustado para que se ajuste a la imagen
                };
                panel.Tag = producto.Codigo;

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

                // Agregar Label de cantidad disponible
                Label lblCantidad = new Label
                {
                    Text = $"Cantidad: {producto.Cantidad}",
                    AutoSize = false,
                    Width = pictureBox.Width,
                    Height = 25,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Location = new Point((panel.Width - pictureBox.Width) / 2, lblPrecio.Bottom) // Justo debajo del precio
                };

                // Agregar botón para agregar al carrito
                Button btnAgregar = new Button
                {
                    Text = "Agregar al Carrito",
                    Width = 195,
                    Height = 25,
                    Location = new Point(0, lblCantidad.Bottom), // Justo debajo de la cantidad
                    ForeColor = Color.White
                };

                // Evento para el clic en el botón de agregar al carrito
                btnAgregar.Click += (sender, e) =>
                {
                    // Aquí podrías añadir lógica para agregar el producto al carrito
                    AgregarAlCarrito(producto.Nombre, producto.Precio);
                };

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(lblNombre);
                panel.Controls.Add(lblPrecio);
                panel.Controls.Add(lblCantidad); // Agregar el Label de cantidad
                panel.Controls.Add(btnAgregar); // Agregar el botón de agregar

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

        // Evento para el clic del botón de búsqueda
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarTexto = txtBuscar.Text.ToLower();  // Obtener el texto en minúsculas para hacer la búsqueda sin importar mayúsculas/minúsculas

            // Iterar sobre los controles en flowLayoutPanel1 y mostrar u ocultar los productos según la búsqueda
            foreach (Panel panelProducto in flowLayoutPanel1.Controls)
            {
                // Obtener el nombre y el código del producto (supongo que el nombre es un Label y el código es almacenado como un Tag o en otro control)
                Label lblNombreProducto = panelProducto.Controls.OfType<Label>().FirstOrDefault();
                string codigoProducto = panelProducto.Tag?.ToString() ?? "";  // Asumo que el código se almacena en el Tag del Panel

                if (lblNombreProducto != null)
                {
                    // Comprobar si el nombre o el código del producto contiene el texto de búsqueda
                    if (lblNombreProducto.Text.ToLower().Contains(buscarTexto) || codigoProducto.Contains(buscarTexto))
                    {
                        panelProducto.Visible = true;  // Mostrar el producto si hay una coincidencia
                    }
                    else
                    {
                        panelProducto.Visible = false; // Ocultar el producto si no coincide
                    }
                }
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Ingresa Id/Nombre")
            {
                txtBuscar.Text = string.Empty; // Borra el texto predeterminado
                txtBuscar.ForeColor = Color.White; // Cambia el color del texto si es necesario
            }
        }


        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el beep
                btnBuscar.PerformClick(); // Simula clic en el botón buscar
            }
        }

        // Deja esto vacío si no lo necesitas.
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void FinalizarCompra_Click(object sender, EventArgs e)
        {
            // Buscar el ListBox de carrito
            ListBox listBoxCarrito = (ListBox)this.Controls.Find("listBoxCarrito", true)[0];
            List<string> productosSeleccionados = new List<string>();
            foreach (var item in listBoxCarrito.Items)
            {
                productosSeleccionados.Add(item.ToString());
            }

            // Crear formulario de Facturas
            Facturas facturasForm = new Facturas(productosSeleccionados, montoTotal, facturas);

            // Llamar a Form1 para abrir el formulario en el panel
            var form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                form1.AbrirFormularioEnPanel(facturasForm); // Método de Form1
            }
        }

        private void QuitarFiltro_Click(object sender, EventArgs e)
        {
            // Limpiar el texto del cuadro de búsqueda
            txtBuscar.Text = string.Empty;

            // Llamar al método de búsqueda (para que se muestren todos los productos)
            btnBuscar.PerformClick();
        }
    

        public void LimpiarDatosFactura()
        {
            // Asegúrate de que la ListBox tenga el nombre correcto
            ListBox listBoxProductos = (ListBox)this.Controls["ListBoxProductos"];
            if (listBoxProductos != null)
            {
                listBoxProductos.Items.Clear(); // Limpiar los productos seleccionados
            }
        }
    }
}
