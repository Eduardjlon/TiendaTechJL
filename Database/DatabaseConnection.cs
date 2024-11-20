using MySql.Data.MySqlClient;

namespace TiendaExaFinalS2
{
    public class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection()
        {
            // Cadena de conexión a la base de datos MySQL
            connectionString = "Server=localhost;Database=pos_system;User ID=root;Password=admin123;";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
