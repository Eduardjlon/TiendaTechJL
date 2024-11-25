using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TiendaExaFinalS2.InterfacesE
{
    public partial class CrearUsuarioE : Form
    {

        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDPI = new TextBox();
            txtCargo = new TextBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnAgregarEmpleado = new Button();
            LabelCreandoUsuario = new Label();
            labelNombre = new Label();
            labelApellido = new Label();
            labelDPI = new Label();
            labelCargo = new Label();
            labelUsuario = new Label();
            labelContraseña = new Label();
            panelImagenLogo = new Panel();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Black;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(205, 180);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.Black;
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(205, 225);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtDPI
            // 
            txtDPI.BackColor = Color.Black;
            txtDPI.ForeColor = Color.White;
            txtDPI.Location = new Point(205, 270);
            txtDPI.Name = "txtDPI";
            txtDPI.Size = new Size(253, 23);
            txtDPI.TabIndex = 2;
            // 
            // txtCargo
            // 
            txtCargo.BackColor = Color.Black;
            txtCargo.ForeColor = Color.White;
            txtCargo.Location = new Point(205, 315);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(253, 23);
            txtCargo.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Black;
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(205, 360);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.Black;
            txtContrasena.ForeColor = Color.White;
            txtContrasena.Location = new Point(205, 405);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(253, 23);
            txtContrasena.TabIndex = 5;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.BackColor = Color.Black;
            btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            btnAgregarEmpleado.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnAgregarEmpleado.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAgregarEmpleado.FlatStyle = FlatStyle.Flat;
            btnAgregarEmpleado.ForeColor = Color.White;
            btnAgregarEmpleado.Location = new Point(205, 447);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(253, 22);
            btnAgregarEmpleado.TabIndex = 6;
            btnAgregarEmpleado.Text = "Crear Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = false;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // LabelCreandoUsuario
            // 
            LabelCreandoUsuario.AutoSize = true;
            LabelCreandoUsuario.FlatStyle = FlatStyle.Flat;
            LabelCreandoUsuario.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCreandoUsuario.ForeColor = Color.White;
            LabelCreandoUsuario.Location = new Point(205, 107);
            LabelCreandoUsuario.Name = "LabelCreandoUsuario";
            LabelCreandoUsuario.Size = new Size(253, 31);
            LabelCreandoUsuario.TabIndex = 13;
            LabelCreandoUsuario.Text = "Creando Usuario";
            LabelCreandoUsuario.TextAlign = ContentAlignment.MiddleCenter;
            LabelCreandoUsuario.Click += LabelInicioSesion_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.FlatStyle = FlatStyle.Flat;
            labelNombre.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(205, 161);
            labelNombre.Margin = new Padding(0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(71, 16);
            labelNombre.TabIndex = 14;
            labelNombre.Text = "Nombre:";
            labelNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.FlatStyle = FlatStyle.Flat;
            labelApellido.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelApellido.ForeColor = Color.White;
            labelApellido.Location = new Point(205, 206);
            labelApellido.Margin = new Padding(0);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(79, 16);
            labelApellido.TabIndex = 15;
            labelApellido.Text = "Apellido:";
            labelApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDPI
            // 
            labelDPI.AutoSize = true;
            labelDPI.FlatStyle = FlatStyle.Flat;
            labelDPI.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDPI.ForeColor = Color.White;
            labelDPI.Location = new Point(205, 251);
            labelDPI.Margin = new Padding(0);
            labelDPI.Name = "labelDPI";
            labelDPI.Size = new Size(36, 16);
            labelDPI.TabIndex = 16;
            labelDPI.Text = "DPI:";
            labelDPI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.FlatStyle = FlatStyle.Flat;
            labelCargo.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCargo.ForeColor = Color.White;
            labelCargo.Location = new Point(205, 296);
            labelCargo.Margin = new Padding(0);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(58, 16);
            labelCargo.TabIndex = 17;
            labelCargo.Text = "CARGO:";
            labelCargo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.FlatStyle = FlatStyle.Flat;
            labelUsuario.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(205, 341);
            labelUsuario.Margin = new Padding(0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(74, 16);
            labelUsuario.TabIndex = 18;
            labelUsuario.Text = "Usuario:";
            labelUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.FlatStyle = FlatStyle.Flat;
            labelContraseña.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContraseña.ForeColor = Color.White;
            labelContraseña.Location = new Point(205, 386);
            labelContraseña.Margin = new Padding(0);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(104, 16);
            labelContraseña.TabIndex = 19;
            labelContraseña.Text = "Contraseña:";
            labelContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelImagenLogo
            // 
            panelImagenLogo.BackgroundImage = Properties.Resources.LogoEmpresa;
            panelImagenLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelImagenLogo.Location = new Point(226, 4);
            panelImagenLogo.Name = "panelImagenLogo";
            panelImagenLogo.Size = new Size(213, 100);
            panelImagenLogo.TabIndex = 35;
            // 
            // CrearUsuarioE
            // 
            BackColor = Color.Black;
            ClientSize = new Size(668, 522);
            Controls.Add(panelImagenLogo);
            Controls.Add(labelContraseña);
            Controls.Add(labelUsuario);
            Controls.Add(labelCargo);
            Controls.Add(labelDPI);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(LabelCreandoUsuario);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtCargo);
            Controls.Add(txtDPI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            MinimumSize = new Size(684, 561);
            Name = "CrearUsuarioE";
            Text = "Agregar Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnAgregarEmpleado;

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dpi = txtDPI.Text;
            string cargo = txtCargo.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(dpi) ||
                string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string contrasenaCifrada = BCrypt.Net.BCrypt.HashPassword(contrasena);

                DatabaseConnection dbConnection = new DatabaseConnection();

                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Employees (FirstName, LastName, IdentificationNumber, Position, Username, PasswordHash)
                             VALUES (@FirstName, @LastName, @IdentificationNumber, @Position, @Username, @PasswordHash)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", nombre);
                        cmd.Parameters.AddWithValue("@LastName", apellido);
                        cmd.Parameters.AddWithValue("@IdentificationNumber", dpi);
                        cmd.Parameters.AddWithValue("@Position", cargo);
                        cmd.Parameters.AddWithValue("@Username", usuario);
                        cmd.Parameters.AddWithValue("@PasswordHash", contrasenaCifrada);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Empleado agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Label LabelCreandoUsuario;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelDPI;
        private Label label1;
        private Label labelCargo;
        private Label labelUsuario;
        private Label labelContraseña;
        private Panel panelImagenLogo;
    }
}