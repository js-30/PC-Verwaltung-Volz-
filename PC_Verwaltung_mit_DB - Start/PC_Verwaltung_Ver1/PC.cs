using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_Verwaltung_Ver4
{
    public class PC
    {

        #region Attributdeklarationen
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        private double prozessorgeschwindigkeit = 0;

        public double Prozessorgeschwindigkeit
        {
            get { return prozessorgeschwindigkeit; }
            set
            {
                if (value > 0)
                {
                    prozessorgeschwindigkeit = value;
                }
            }
        }

        private double ram = 0;

        public double RAM
        {
            get { return ram; }
            set
            {
                if (value > 0)
                {
                    ram = value;
                }
            }
        }

        private double hdd = 0;

        public double HDD
        {
            get { return hdd; }
            set
            {
                if (value > 0)
                {
                    hdd = value;
                }
            }
        }
        #endregion


        public double berechneLeistungsindex()
        {
            return prozessorgeschwindigkeit * ram * hdd;
        }

        public void setDaten(double prozGeschw, double ram, double hdd)
        {   // setzt alle Daten in einer Methode
            Prozessorgeschwindigkeit = prozGeschw;
            RAM = ram;
            HDD = hdd;
        }

        /*
         * gibt die Daten formatiert aus
         */
        public String zeigeDaten()
        {
            String daten="------------------------------------------------------"+Environment.NewLine+
                         "Prozessorgeschwindigkeit:\t" + String.Format("{0:0.0}", prozessorgeschwindigkeit) +" GHz"+ Environment.NewLine +
                         "Arbeitsspeicher:\t\t"+String.Format("{0:0.0}", ram) +" GB"+ Environment.NewLine +
                         "Festplattenkapazität:\t"+String.Format("{0:0.0}", hdd) +" GB"+ Environment.NewLine +
                         "Leistungsindex:\t\t" + berechneLeistungsindex();

            return daten;
        }

        /*
         * gibt die Daten des aktuellen PC als strichpunkt-separierte Zeile aus
         */
        public String getDatenAsCSV()
        {
            return "" + Prozessorgeschwindigkeit + ";" + RAM + ";" + HDD;
        }

        /*
         * liest die Daten des aktuellen PC als strichpunktseparierte Zeile ein
         */
        public void setzeDatenAusCSV(String csvString)
        {
            String[] daten;
            daten = csvString.Split(';');
            Prozessorgeschwindigkeit=Convert.ToDouble(daten[0]);
            RAM = Convert.ToDouble(daten[1]);
            HDD = Convert.ToDouble(daten[2]);
        }

    }
}
