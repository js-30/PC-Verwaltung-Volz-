using System.Collections.Generic;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace PC_Verwaltung_Ver4
{
    public class DbAdapterPCVerwaltung
    {
        /*SQL Querys aus MySql Workbench bekommen:
         * 1. Neues Sql Query öffnen
         * 2. Rechtsklick auf Tabelle
         * 3. "Sent to Sql Editor"
         * 4. Copy paste :P
         */


        //Select
        public List<PC> getAllPcs()
        {
            //1. Liste wird initialisiert und am ende zurückgegeben
            List<PC> allePcs = new List<PC>();

            //2. SQL Query und Command initialisieren
            string query = @"SELECT id, hdd, takt, ram FROM tblPCs; ";
            MySqlCommand sqlcommand = new MySqlCommand(query);

            //3. Connection mit Connectionstring initialisieren
            MySQLConnector mysqlConnector = new MySQLConnector();
            MySqlConnection connection = new MySqlConnection(mysqlConnector.ConnectionString);

            //4. Connection Eigenschaft des MySqlCommands setzen
            sqlcommand.Connection = connection;

            //5. Connection öffnen und schließen
            connection.Open();

            //6. DataReader initialisieren
            MySqlDataReader dataReader = sqlcommand.ExecuteReader();

            //7. Daten auslesen
            while (dataReader.Read())
            {
                //8. Objekt initialisieren
                PC neuerPC = new PC();

                //9. Eigenschaften setzen
                neuerPC.ID = dataReader.GetInt32("id");
                neuerPC.HDD = dataReader.GetDouble("hdd");
                neuerPC.RAM = dataReader.GetDouble("ram");
                neuerPC.Prozessorgeschwindigkeit = dataReader.GetDouble("takt");

                //10. Zur Liste hinzufügen
                allePcs.Add(neuerPC);
            }

            //5. siehe oben
            connection.Close();

            //1. siehe oben
            return allePcs;
        }

        //Insert
        public void insertPc(PC neuerPc)
        {
            //1. Sql Query und Command initialisieren
            string query = $"INSERT INTO tblpcs(hdd, takt, ram)VALUES({neuerPc.HDD.ToString(CultureInfo.InvariantCulture)},{neuerPc.Prozessorgeschwindigkeit.ToString(CultureInfo.InvariantCulture)},{neuerPc.RAM.ToString(CultureInfo.InvariantCulture)});";
            MySqlCommand sqlcommand = new MySqlCommand(query);

            //3. Connection mit Connectionstring initialisieren
            MySQLConnector mysqlConnector = new MySQLConnector();
            MySqlConnection connection = new MySqlConnection(mysqlConnector.ConnectionString);

            //4. Connection Eigenschaft des MySqlCommands setzen
            sqlcommand.Connection = connection;

            //5. Connection öffnen und schließen
            connection.Open();

            //6. Query ausführen
            sqlcommand.ExecuteNonQuery();

            //5. Siehe oben
            connection.Close();
        }

        //Delete
        public void deletePc(int id)
        {
            //1. Sql Query und Command initialisieren
            string query = $"DELETE FROM `pcverwaltung`.`tblpcs` WHERE id={id};";
            MySqlCommand sqlcommand = new MySqlCommand(query);

            //3. Connection mit Connectionstring initialisieren
            MySQLConnector mysqlConnector = new MySQLConnector();
            MySqlConnection connection = new MySqlConnection(mysqlConnector.ConnectionString);

            //4. Connection Eigenschaft des MySqlCommands setzen
            sqlcommand.Connection = connection;

            //5. Connection öffnen und schließen
            connection.Open();

            //6. Query ausführen
            sqlcommand.ExecuteNonQuery();

            //5. Siehe oben
            connection.Close();
        }

        //Update
        public void updatePc(PC neuerPc)
        {
            //1. Sql Query und Command initialisieren
            string query = $"UPDATE `pcverwaltung`.`tblpcs` SET `hdd`={neuerPc.HDD.ToString(CultureInfo.InvariantCulture)},`takt`={neuerPc.Prozessorgeschwindigkeit.ToString(CultureInfo.InvariantCulture)},`ram`={neuerPc.RAM.ToString(CultureInfo.InvariantCulture)} WHERE `id`={neuerPc.ID}; ";
            MySqlCommand sqlcommand = new MySqlCommand(query);

            //3. Connection mit Connectionstring initialisieren
            MySQLConnector mysqlConnector = new MySQLConnector();
            MySqlConnection connection = new MySqlConnection(mysqlConnector.ConnectionString);

            //4. Connection Eigenschaft des MySqlCommands setzen
            sqlcommand.Connection = connection;

            //5. Connection öffnen und schließen
            connection.Open();

            //6. Query ausführen
            sqlcommand.ExecuteNonQuery();

            //5. Siehe oben
            connection.Close();
        }
    }
}
