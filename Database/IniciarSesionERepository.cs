using MySql.Data.MySqlClient;

namespace TiendaExaFinalS2.Database
{
    public class IniciarSesionERepository
    {
        private string connectionString = "Server=localhost;Database=PointOfSale;User ID=root;Password=admin123;";

        
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public bool ValidarUsuario(string usuario, string contrasena)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    string query = "SELECT PasswordHash FROM Employees WHERE Username = @Username";
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", usuario);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string contrasenaCifrada = result.ToString();
                            return BCrypt.Net.BCrypt.Verify(contrasena, contrasenaCifrada);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
           
                MessageBox.Show("Error al validar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
