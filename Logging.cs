using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übertragung_BDE
{ 
    internal class Logging
    {
        // Statische Instanz für Singleton
        private static Logging? _instance;
        // Zugriff auf die einzige Instanz
        public static Logging Instance => _instance ??= new Logging();
        // Privater Konstruktor verhindert direkte Instanziierung
        private Logging() { }   
        // ERROR in Datei 
        private static readonly string logFilePath = "error_log.txt";
        public static void ErrorLog(string message)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - ERROR: {message} {Environment.NewLine}";
            File.AppendAllText(logFilePath, logMessage);
        }
    }
  
}

