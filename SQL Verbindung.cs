using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übertragung_BDE
{
    public class DbHelper
    {
        public static string GetConnectionString()
        {                     
            string pass = PasswortEncrypt.Decrypt(Properties.Settings.Default.PasswortDB);
            //string pass = Properties.Settings.Default.PasswortDB;
            return $"server={Properties.Settings.Default.IpAdresseDB};" +
                   $"database={Properties.Settings.Default.Datenbankname};" +
                   $"port={Properties.Settings.Default.PortDB};" +
                   $"uid={Properties.Settings.Default.BenutzerDB};" +
                   $"pwd={pass};";
        }
        // Statische Instanz der Klasse
        private static DbHelper _instance = new();
        private readonly string connectionString; //= "DeineVerbindungszeichenkette";
        // Privater Konstruktor verhindert externe Instanziierung
        private DbHelper()
        {
            connectionString = GetConnectionString();
        }
        // Öffentliche statische Methode für den Zugriff auf die Instanz
        public static DbHelper Instance
        {
            get
            {
                _instance ??= new DbHelper();
                return _instance;
            }
        }
        public DataTable ExecuteSelectQuery(string query, MySqlParameter[]? parameters = null)
        {
            DataTable result = new();
            using (MySqlConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    using MySqlCommand command = new(query, connection);
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using MySqlDataAdapter adapter = new(command);
                    adapter.Fill(result);
                }
                catch (Exception ex)
                {
                    Logging.ErrorLog($" Fehler DB SELECT :{ex.Message}");
                    //MessageBox.Show($"Ein Fehler ist aufgetreten. Details wurden protokolliert. {ex.Message}" );
                    throw;
                }
            }
            return result;
        }
        // Methode für INSERT/UPDATE/DELETE-Abfragen       
        public bool ExecuteNonQuery(string query, MySqlParameter[]? parameters = null)
        {
            int rowsAffected;
            using MySqlConnection connection = new(connectionString);
            try
            {
                connection.Open();
                using MySqlCommand command = new(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                rowsAffected = command.ExecuteNonQuery();
                return true; // Erfolg
            }
            catch (Exception ex)
            {
                Logging.ErrorLog($" Fehler DB Änderung :{ex.Message}");
                return false; // Fehler
            }
        }     
    }
}
