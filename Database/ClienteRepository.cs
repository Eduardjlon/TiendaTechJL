using MySql.Data.MySqlClient;
using System;

namespace TiendaExaFinalS2
{
    public class ClienteRepository
    {
        private readonly string connectionString = "Server=localhost;Database=PointOfSale;User ID=root;Password=admin123;";

        public void MostrarClientes()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SELECT * FROM PointOfSale.Customers"; 

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Console.WriteLine("NIT: {0}, Nombres: {1}, Apellidos: {2}, Dirección: {3}, Teléfono: {4}",
                                reader["NIT"], reader["FirstName"], reader["LastName"], reader["Address"], reader["Phone"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
