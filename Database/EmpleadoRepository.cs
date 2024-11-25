using MySql.Data.MySqlClient;
using System;

namespace TiendaExaFinalS2
{
    public class EmpleadoRepository
    {
        private readonly string connectionString = "Server=localhost;Database=PointOfSale;User ID=root;Password=admin123;";

        // Método para consultar todos los empleados
        public void MostrarEmployees()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SELECT * FROM PointOfSale.Employees"; // Cambiar "Empleados" a "Employees"

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        // Mostrar los resultados
                        while (reader.Read())
                        {
                            Console.WriteLine("ID: {0}, Nombre: {1}, Apellido: {2}, Usuario: {3}",
                                reader["EmployeeID"], reader["FirstName"], reader["LastName"], reader["Username"]);
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
