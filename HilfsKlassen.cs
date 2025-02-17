using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        private static readonly string errorLogPfad = "error_log.txt";
        private static readonly string appLogPfad = "app_log.txt";
        private static readonly string infoLogPfad = "info_log.txt";
        public static void ErrorLog(string message)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - ERROR: {message} {Environment.NewLine}";
            File.AppendAllText(errorLogPfad, logMessage);
        }
        public static void AppLog(string message)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - INFO: {message} {Environment.NewLine}";
            File.AppendAllText(appLogPfad, logMessage);
        }
        public static void InfoLog(string message)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - INFO: {message} {Environment.NewLine}";
            File.AppendAllText(infoLogPfad, logMessage);
        }
    }

    public class PasswortEncrypt
    {
        private static readonly string encryptionKey = "sldWh8dWpFaWCE0KBH1uEQ3JJGzVcatFIV58eS9Khr8="; // Schlüssel für AES-Verschlüsselung
        // Methode zur Verschlüsselung eines Passworts
        public static string Encrypt(string plainText)
        {
            byte[] keyBytes = Convert.FromBase64String(encryptionKey);
            using Aes aes = Aes.Create();
            aes.Key = keyBytes;
            aes.GenerateIV(); // Zufälliger IV
            aes.Mode = CipherMode.CBC;
            using ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using MemoryStream ms = new();
            ms.Write(aes.IV, 0, aes.IV.Length); // IV speichern
            using (CryptoStream cs = new(ms, encryptor, CryptoStreamMode.Write))
            {
                using StreamWriter sw = new(cs);
                sw.Write(plainText);
            }
            return Convert.ToBase64String(ms.ToArray());
        }
        // Methode zum Entschlüsseln eines Passworts
        public static string Decrypt(string cipherText)
        {
            byte[] keyBytes = Convert.FromBase64String(encryptionKey);
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using Aes aes = Aes.Create();
            aes.Key = keyBytes;
            // IV vom Anfang der verschlüsselten Daten extrahieren
            byte[] iv = new byte[aes.BlockSize / 8];
            Array.Copy(cipherBytes, 0, iv, 0, iv.Length);
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            using ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using MemoryStream ms = new(cipherBytes, iv.Length, cipherBytes.Length - iv.Length);
            using CryptoStream cs = new(ms, decryptor, CryptoStreamMode.Read);
            using StreamReader sr = new(cs);
            return sr.ReadToEnd();
        }
    }

}

