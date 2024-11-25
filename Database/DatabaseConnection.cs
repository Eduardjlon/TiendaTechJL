using MySql.Data.MySqlClient;

namespace TiendaExaFinalS2
{
    public class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection()
        {
     
            connectionString = "Server=localhost;Database=PointOfSale;User ID=root;Password=admin123;";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
