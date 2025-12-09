using NLog;
using System;

namespace Proyecto.InnovaStock
{
    public static class LogEventos
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        //DEBE CREAR UNA CARPETA LLAMADAS "logs" en c:
        public static void Info(string mensaje)
        {
            logger.Info(mensaje);
        }

        public static void Debug(string mensaje)
        {
            logger.Debug(mensaje);
        }

        public static void Warn(string mensaje)
        {
            logger.Warn(mensaje);
        }

        public static void Error(Exception ex, string mensaje)
        {
            logger.Error(ex, mensaje);
        }

        public static void Fatal(Exception ex, string mensaje)
        {
            logger.Fatal(ex, mensaje);
        }
    }
}