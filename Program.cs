using TiendaExaFinalS2;

namespace TiendaExaFinalS2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EmpleadoRepository empleadoRepo = new EmpleadoRepository();
            empleadoRepo.MostrarEmpleados();  // Llamada para mostrar los empleados
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
