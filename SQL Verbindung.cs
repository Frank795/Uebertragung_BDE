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
            
            
            //string pass = PasswortEncrypt.Decrypt(AppConfig.SQL_Passwort);
            string pass = Properties.Settings.Default.PasswortDB;

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
        // Beispiel einer Methode für eine SELECT-Abfrage
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
                    //Logging.ErrorLog(ex.Message);
                    MessageBox.Show($"Ein Fehler ist aufgetreten. Details wurden protokolliert. {ex.Message}" );
                    throw;
                }
            }
            return result;
        }
        // Methode für INSERT/UPDATE/DELETE-Abfragen
        // bool statt int
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
              //  Logging.ErrorLog(ex.Message);
                MessageBox.Show("Ein Fehler ist aufgetreten. Details wurden protokolliert.");
                return false; // Fehler
            }

            //return rowsAffected;
        }
        // Methode für ein einzelnes Feld
        public string GetSingleField(string query, MySqlParameter[] parameters, string columnName)
        {
            // Wir verwenden hier ExecuteSelectQuery statt ExecuteQuery
            DataTable result = ExecuteSelectQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0][columnName]?.ToString() ?? string.Empty; // Rückgabe des Werts als String
            }
            else
            {
                //Logging.Instance.Log("0", "DB", $"Fehler bei GetSingleField : Keine Daten gefunden.");
                throw new Exception("Keine Daten gefunden.");
            }
        }
        // Methode zur Befüllung von Comboboxen
        public void PopulateComboBox(ComboBox comboBox, string query, string valueMember, string? displayMember1 = null, string? displayMember2 = null)
        {
            // Hole die Daten
            DataTable data = ExecuteSelectQuery(query);
            // Wenn keine DisplayMember-Spalte angegeben ist, verwende valueMember für Anzeige
            if (string.IsNullOrEmpty(displayMember1) && string.IsNullOrEmpty(displayMember2))
            {
                comboBox.DisplayMember = valueMember;
            }
            else if (!string.IsNullOrEmpty(displayMember1) && string.IsNullOrEmpty(displayMember2)) // Eine Spalte anzeigen
            {
                comboBox.DisplayMember = displayMember1;
            }
            else if (!string.IsNullOrEmpty(displayMember1) && !string.IsNullOrEmpty(displayMember2)) // Zwei Spalten kombinieren
            {
                string combinedColumnName = "CombinedDisplay";
                if (!data.Columns.Contains(combinedColumnName))
                {
                    data.Columns.Add(combinedColumnName, typeof(string));
                }
                foreach (DataRow row in data.Rows)
                {
                    row[combinedColumnName] = $"{row[displayMember1]} - {row[displayMember2]}";
                }
                comboBox.DisplayMember = combinedColumnName; // Kombinierte Anzeige
            }
            else
            {
               // Logging.Instance.Log("0", "DB", $"Ungültige Kombination von DisplayMember-Parametern.");
                throw new ArgumentException("Ungültige Kombination von DisplayMember-Parametern.");
            }
            comboBox.ValueMember = valueMember; // Setze die ID als Wert
            comboBox.DataSource = data;        // Setze die Datenquelle
            comboBox.SelectedIndex = -1;       // Nichts auswählen
        }
        // Methode für Liste Combobox Rechte
        public List<KeyValuePair<int, string>> GetRollenListe()
        {
            List<KeyValuePair<int, string>> rollenListe = [];
            string query = "SELECT id_rolle, name_rolle FROM rollen";
            try
            {
                DataTable result = ExecuteSelectQuery(query);
                foreach (DataRow row in result.Rows)
                {
                    int id = Convert.ToInt32(row["id_rolle"]);
                    string name = row["name_rolle"]?.ToString() ?? string.Empty;
                    rollenListe.Add(new KeyValuePair<int, string>(id, name));
                }
            }
            catch (Exception ex)
            {
               // Logging.ErrorLog(ex.Message);
                MessageBox.Show("Fehler beim Laden der Rollenliste.");
            }
            return rollenListe;
        }
        public List<KeyValuePair<int, string>> GetAppListe()
        {
            List<KeyValuePair<int, string>> rollenListe = [];
            string query = "SELECT id_app_beriech, name_app_bereich FROM app_bereiche";
            try
            {
                DataTable result = ExecuteSelectQuery(query);
                foreach (DataRow row in result.Rows)
                {
                    int id = Convert.ToInt32(row["id_app_bereich"]);
                    string name = row["name_app_bereich"]?.ToString() ?? string.Empty;
                    rollenListe.Add(new KeyValuePair<int, string>(id, name));
                }
            }
            catch (Exception ex)
            {
              //  Logging.ErrorLog(ex.Message);
                MessageBox.Show("Fehler beim Laden der App Liste .");
            }
            return rollenListe;
        }
    }

}
