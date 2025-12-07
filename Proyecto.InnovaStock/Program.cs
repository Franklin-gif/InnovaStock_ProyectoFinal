<<<<<<< HEAD
using NLog;
=======
using Proyecto.InnovaStock.Vistas;
>>>>>>> 4d10fae4c1214ae0a694647818768d8efeff5f50

namespace Proyecto.InnovaStock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Obtener la ruta del archivo de configuración personalizado
            string configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nllog.config");

            if (File.Exists(configFile))
            {
                // Cargar la configuración de NLog desde el archivo personalizado
                LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(configFile);
            }
            else
            {
                // Opcional: Loggear o informar si el archivo no se encuentra
                MessageBox.Show("Advertencia: El archivo de configuración 'nllog.config' no se encontró.", "Configuración de Log", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new frmAgregarEmpleadoAdmin ());

=======
            Application.Run(new frmSesionAdmin());
>>>>>>> 4d10fae4c1214ae0a694647818768d8efeff5f50
        }
    }
}