using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TiendaExaFinalS2.InterfacesC
{
    public partial class CrearUsuarioC : Form
    {

        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNIT = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnAgregarCliente = new Button();
            LabelCreandoCliente = new Label();
            labelNombre = new Label();
            labelApellido = new Label();
            labelNIT = new Label();
            labelTelefono = new Label();
            labelDireccion = new Label();
            panelImagenLogo = new Panel();
            SuspendLayout();

            // txtNombre
            txtNombre.BackColor = Color.Black;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(205, 180);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 0;

            // txtApellido
            txtApellido.BackColor = Color.Black;
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(205, 225);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 23);
            txtApellido.TabIndex = 1;

            // txtNIT
            txtNIT.BackColor = Color.Black;
            txtNIT.ForeColor = Color.White;
            txtNIT.Location = new Point(205, 270);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(253, 23);
            txtNIT.TabIndex = 2;

            // txtTelefono
            txtTelefono.BackColor = Color.Black;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(205, 315);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(253, 23);
            txtTelefono.TabIndex = 3;

            // txtDireccion
            txtDireccion.BackColor = Color.Black;
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(205, 360);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(253, 23);
            txtDireccion.TabIndex = 4;

            // btnAgregarCliente
            btnAgregarCliente.BackColor = Color.Black;
            btnAgregarCliente.FlatAppearance.BorderSize = 0;
            btnAgregarCliente.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnAgregarCliente.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(205, 410);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(253, 22);
            btnAgregarCliente.TabIndex = 5;
            btnAgregarCliente.Text = "Crear Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;

            // LabelCreandoCliente
            LabelCreandoCliente.AutoSize = true;
            LabelCreandoCliente.FlatStyle = FlatStyle.Flat;
            LabelCreandoCliente.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCreandoCliente.ForeColor = Color.White;
            LabelCreandoCliente.Location = new Point(205, 107);
            LabelCreandoCliente.Name = "LabelCreandoCliente";
            LabelCreandoCliente.Size = new Size(253, 31);
            LabelCreandoCliente.TabIndex = 13;
            LabelCreandoCliente.Text = "Creando Cliente";
            LabelCreandoCliente.TextAlign = ContentAlignment.MiddleCenter;

            // Labels
            labelNombre.Text = "Nombre:";
            labelApellido.Text = "Apellido:";
            labelNIT.Text = "NIT:";
            labelTelefono.Text = "Teléfono:";
            labelDireccion.Text = "Dirección:";
            LabelSetup(labelNombre, 161);
            LabelSetup(labelApellido, 206);
            LabelSetup(labelNIT, 251);
            LabelSetup(labelTelefono, 296);
            LabelSetup(labelDireccion, 341);

            // panelImagenLogo
            panelImagenLogo.BackgroundImage = Properties.Resources.LogoEmpresa;
            panelImagenLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelImagenLogo.Location = new Point(226, 4);
            panelImagenLogo.Name = "panelImagenLogo";
            panelImagenLogo.Size = new Size(213, 100);
            panelImagenLogo.TabIndex = 35;

            // CrearUsuarioC
            BackColor = Color.Black;
            ClientSize = new Size(668, 522);
            Controls.Add(panelImagenLogo);
            Controls.Add(labelDireccion);
            Controls.Add(labelTelefono);
            Controls.Add(labelNIT);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(LabelCreandoCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNIT);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            MinimumSize = new Size(684, 561);
            Name = "CrearUsuarioC";
            Text = "Agregar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        private void LabelSetup(Label label, int yPosition)
        {
            label.AutoSize = true;
            label.FlatStyle = FlatStyle.Flat;
            label.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(205, yPosition);
            label.Size = new Size(76, 16);
            label.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(label);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nit = txtNIT.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(nit) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();

                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Customers (NIT, FirstName, LastName, Address, Phone)
                                     VALUES (@NIT, @FirstName, @LastName, @Address, @Phone)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIT", nit);
                        cmd.Parameters.AddWithValue("@FirstName", nombre);
                        cmd.Parameters.AddWithValue("@LastName", apellido);
                        cmd.Parameters.AddWithValue("@Address", direccion);
                        cmd.Parameters.AddWithValue("@Phone", telefono);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cliente agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNIT;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button btnAgregarCliente;
        private Label LabelCreandoCliente;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelNIT;
        private Label labelTelefono;
        private Label labelDireccion;
        private Panel panelImagenLogo;
    }
}
