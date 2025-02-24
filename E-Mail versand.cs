using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;


namespace Übertragung_BDE
{
    public sealed class E_Mail_versand
    {
        private static readonly Lazy<E_Mail_versand> lazy =
        new(() => new E_Mail_versand());
        public static E_Mail_versand Instance => lazy.Value;
        private E_Mail_versand() { }
        public static void SendSimpleEmail(string subject, string body)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Dein Name", "deine-email@example.com"));
            emailMessage.To.Add(new MailboxAddress("Empfänger Name", "empfaenger@example.com"));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = body };

            try
            {
                // Verwende explizit MailKit's SmtpClient, um den Konflikt zu vermeiden
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.example.com", 587, false); // SMTP-Server und Port anpassen
                    client.Authenticate("deine-email@example.com", "dein-passwort");
                    client.Send(emailMessage);
                    client.Disconnect(true);
                }

              MessageBox.Show("E-Mail gesendet!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Senden der E-Mail: {ex.Message}");
            }
        }
        public static void SendEmail(string mailBetreff, string mailText)
        {
            string empfaengerString = Properties.Settings.Default.MailEmpfaenger;
            string[] empfaengerAdressen = empfaengerString.Split(';');
            var email = new MimeMessage();

            // Sender
            email.From.Add(new MailboxAddress(Properties.Settings.Default.NameMailAbsender, Properties.Settings.Default.AdresseMailAbsender));

            // Empfänger (Mehrere Empfänger mit Semikolon getrennt)
            foreach (var empfaenger in empfaengerAdressen)
            {
                email.To.Add(new MailboxAddress("", empfaenger.Trim()));
            }

            // Betreff
            email.Subject = mailBetreff;

            // Nachrichtentext
            var body = new TextPart("plain")
            {
                Text = mailText
            };

            email.Body = body;

            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect(Properties.Settings.Default.SmtpAdresse, Properties.Settings.Default.SmtpPort,true);  // SMTP-Server und Port
                    client.Authenticate(Properties.Settings.Default.AdresseMailAbsender, PasswortEncrypt.Decrypt(Properties.Settings.Default.MailPasswort));
                    client.Send(email);
                    client.Disconnect(true);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Senden der E-Mail: {ex.Message}");
            }
        }
    }
}

