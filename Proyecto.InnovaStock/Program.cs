using NLog;
using Proyecto.InnovaStock.Vistas;
using System;
using System.IO;
using System.Windows.Forms;

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
                MessageBox.Show("Advertencia: El archivo de configuración 'nllog.config' no se encontró.",
                                "Configuración de Log", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Inicializar la configuración de la aplicación
            ApplicationConfiguration.Initialize();

            // Aquí decides cuál formulario abrir
            // Si quieres abrir frmAgregarEmpleadoAdmin:
            // Application.Run(new frmAgregarEmpleadoAdmin());
            // Si quieres abrir frmSesionAdmin:
            Application.Run(new frmInicio());
        }
    }
}
