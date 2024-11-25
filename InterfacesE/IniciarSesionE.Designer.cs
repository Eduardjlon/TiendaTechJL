using MySql.Data.MySqlClient;
using BCrypt.Net;
using System;
using System.Windows.Forms;

namespace TiendaExaFinalS2.InterfacesE
{
    public partial class IniciarSesionE : Form
    {
         
        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            LabelInicioSesion = new Label();
            UsuarioIngreso = new TextBox();
            labelIniciaSesionParaContinuar = new Label();
            labelUsuario = new Label();
            ContraseñaIngreso = new Label();
            textBoxContraI = new TextBox();
            OlvideContraseña = new Button();
            button1 = new Button();
            panelImagenLogo = new Panel();
            SuspendLayout();
            // 
            // LabelInicioSesion
            // 
            LabelInicioSesion.AutoSize = true;
            LabelInicioSesion.FlatStyle = FlatStyle.Flat;
            LabelInicioSesion.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelInicioSesion.ForeColor = Color.White;
            LabelInicioSesion.Location = new Point(240, 135);
            LabelInicioSesion.Name = "LabelInicioSesion";
            LabelInicioSesion.Size = new Size(206, 31);
            LabelInicioSesion.TabIndex = 0;
            LabelInicioSesion.Text = "Inicia Sesión";
            LabelInicioSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsuarioIngreso
            // 
            UsuarioIngreso.BackColor = Color.Black;
            UsuarioIngreso.ForeColor = Color.White;
            UsuarioIngreso.Location = new Point(240, 243);
            UsuarioIngreso.Name = "UsuarioIngreso";
            UsuarioIngreso.Size = new Size(206, 23);
            UsuarioIngreso.TabIndex = 1;
            UsuarioIngreso.TextAlign = HorizontalAlignment.Center;
            // 
            // labelIniciaSesionParaContinuar
            // 
            labelIniciaSesionParaContinuar.AutoSize = true;
            labelIniciaSesionParaContinuar.FlatStyle = FlatStyle.Flat;
            labelIniciaSesionParaContinuar.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIniciaSesionParaContinuar.ForeColor = Color.White;
            labelIniciaSesionParaContinuar.Location = new Point(224, 166);
            labelIniciaSesionParaContinuar.Margin = new Padding(0);
            labelIniciaSesionParaContinuar.Name = "labelIniciaSesionParaContinuar";
            labelIniciaSesionParaContinuar.Size = new Size(234, 16);
            labelIniciaSesionParaContinuar.TabIndex = 2;
            labelIniciaSesionParaContinuar.Text = "Inicia Sesión Para Continuar";
            labelIniciaSesionParaContinuar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.FlatStyle = FlatStyle.Flat;
            labelUsuario.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(240, 224);
            labelUsuario.Margin = new Padding(0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(69, 16);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario";
            labelUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContraseñaIngreso
            // 
            ContraseñaIngreso.AutoSize = true;
            ContraseñaIngreso.FlatStyle = FlatStyle.Flat;
            ContraseñaIngreso.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContraseñaIngreso.ForeColor = Color.White;
            ContraseñaIngreso.Location = new Point(240, 290);
            ContraseñaIngreso.Margin = new Padding(0);
            ContraseñaIngreso.Name = "ContraseñaIngreso";
            ContraseñaIngreso.Size = new Size(99, 16);
            ContraseñaIngreso.TabIndex = 5;
            ContraseñaIngreso.Text = "Contraseña";
            ContraseñaIngreso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxContraI
            // 
            textBoxContraI.BackColor = Color.Black;
            textBoxContraI.ForeColor = Color.White;
            textBoxContraI.Location = new Point(240, 309);
            textBoxContraI.Name = "textBoxContraI";
            textBoxContraI.Size = new Size(206, 23);
            textBoxContraI.TabIndex = 4;
            textBoxContraI.TextAlign = HorizontalAlignment.Center;
            // 
            // OlvideContraseña
            // 
            OlvideContraseña.BackColor = Color.Black;
            OlvideContraseña.FlatAppearance.BorderSize = 0;
            OlvideContraseña.FlatAppearance.MouseDownBackColor = Color.Blue;
            OlvideContraseña.FlatAppearance.MouseOverBackColor = Color.Red;
            OlvideContraseña.FlatStyle = FlatStyle.Flat;
            OlvideContraseña.ForeColor = Color.White;
            OlvideContraseña.Location = new Point(0, 499);
            OlvideContraseña.Name = "OlvideContraseña";
            OlvideContraseña.Size = new Size(141, 23);
            OlvideContraseña.TabIndex = 7;
            OlvideContraseña.Text = "Olvide Mi Contraseña :(";
            OlvideContraseña.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Blue;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(240, 338);
            button1.Name = "button1";
            button1.Size = new Size(206, 23);
            button1.TabIndex = 8;
            button1.Text = "Iniciar Sesion Empleado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new EventHandler(button1_Click);
            // 
            // panelImagenLogo
            // 
            panelImagenLogo.BackgroundImage = Properties.Resources.LogoEmpresa;
            panelImagenLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelImagenLogo.Location = new Point(242, 12);
            panelImagenLogo.Name = "panelImagenLogo";
            panelImagenLogo.Size = new Size(206, 121);
            panelImagenLogo.TabIndex = 9;
            // 
            // IniciarSesionE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(682, 547);
            Controls.Add(panelImagenLogo);
            Controls.Add(button1);
            Controls.Add(OlvideContraseña);
            Controls.Add(textBoxContraI);
            Controls.Add(ContraseñaIngreso);
            Controls.Add(labelUsuario);
            Controls.Add(labelIniciaSesionParaContinuar);
            Controls.Add(UsuarioIngreso);
            Controls.Add(LabelInicioSesion);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "IniciarSesionE";
            Text = "IniciarSesionE";
            ResumeLayout(false);
            PerformLayout();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioIngreso.Text;
            string contrasena = textBoxContraI.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingresa usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidarUsuario(usuario, contrasena))
            {

                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarUsuario(string usuario, string contrasena)
        {
            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                string query = "SELECT PasswordHash FROM Employees WHERE Username = @Username";

                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", usuario);

                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string contrasenaCifrada = result.ToString();

                            if (BCrypt.Net.BCrypt.Verify(contrasena, contrasenaCifrada))
                            {
                                return true;
                            }
                        }
                    }
                }

                return false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al validar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        private Label LabelInicioSesion;
        private TextBox UsuarioIngreso;
        private Label labelIniciaSesionParaContinuar;
        private Label labelUsuario;
        private Label ContraseñaIngreso;
        private TextBox textBoxContraI;
        private Button OlvideContraseña;
        private Button button1;
        private Panel panelImagenLogo;
    }
}
