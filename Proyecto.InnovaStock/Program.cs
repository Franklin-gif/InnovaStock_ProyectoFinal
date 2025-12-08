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
                MessageBox.Show("Advertencia: El archivo de configuración 'nllog.config' no se encontró.",
                                "Configuración de Log", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ApplicationConfiguration.Initialize();

            Application.Run(new frmInicio());
        }
    }
}
