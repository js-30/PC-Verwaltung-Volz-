using MySql.Data.MySqlClient;
using System;

namespace PC_Verwaltung_Ver4
{
    public class MySQLConnector
    {
        // Attribute
        private string dBHost = "localhost"; // kann auch IP-Adresse sein
        private string dBUser = "root";
        private string dBPasswort = "";
        private string dBName = "pcverwaltung";

        // Gekapselte Attribute
        public string DBHost { get => dBHost; set => dBHost = value; }
        public string DBUser { get => dBUser; set => dBUser = value; }
        public string DBPasswort { get => dBPasswort; set => dBPasswort = value; }
        public string DBName { get => dBName; set => dBName = value; }

        // ConnectionStringBuilder wird in der ConnectionString Property verwendet,
        // um mit den gesetzten Eigenschaften den Connectionstring zusammenzusetzen.
        private MySqlConnectionStringBuilder mysqlConnectionStringBuilder = new MySqlConnectionStringBuilder();

        // ConnectionStringProperty
        public string ConnectionString
        {
            get
            {
                mysqlConnectionStringBuilder.Server = DBHost;
                mysqlConnectionStringBuilder.UserID = DBUser;
                mysqlConnectionStringBuilder.Password = DBPasswort;
                mysqlConnectionStringBuilder.Database = DBName;
                return mysqlConnectionStringBuilder.ConnectionString;
            }
        }


        // Verbindung zur Datenbank öffnen und anschließend wieder schließen
        // => Bei nicht erfolgreicher Verbindung wird eine Exception geworfen
        public string testConnection()
        {
            string msg = "DB-Verbindung erfolgreich";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                msg = ex.GetBaseException().Message;
            }

            // Rückgabe der msg oder der geworfenen Exception
            return msg;
        }
    }
}
