using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace TiendaExaFinalS2
{
    public class ProductoRepository
    {
        private DatabaseConnection databaseConnection;

        public ProductoRepository()
        {
            databaseConnection = new DatabaseConnection();
        }

        public List<string> ObtenerProductos()
        {
            var productos = new List<string>();

            try
            {
                using (var connection = databaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT Nombre FROM Productos";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                productos.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return productos;
        }
    }
}
