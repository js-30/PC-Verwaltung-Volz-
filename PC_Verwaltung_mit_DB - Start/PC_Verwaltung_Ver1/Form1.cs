using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace PC_Verwaltung_Ver4
{
    public partial class Form1 : Form
    {
        
        // gibt den aktuellen Datensatz an, der angezeigt werden soll
        // wenn kein Datensatz vorhanden ist, zeigt er 0 an, für den ersten
        // anzulegenden Datensatz.
        private int aktuellerDatensatz =0;

 
        // Liste (Container) für alle PCs
        private List<PC> allePC = new List<PC>();


        public Form1()
        {
            InitializeComponent();
            initPCListe();
            aktualisiereOberflaeche();
        }


        private void initPCListe()
        {
            DbAdapterPCVerwaltung adapter = new DbAdapterPCVerwaltung();

            allePC = adapter.getAllPcs();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void überPCVerwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String msg="PC Verwaltung 4.0"+Environment.NewLine+Environment.NewLine+
                        "(C) ErVo-Software 2013";
            MessageBox.Show(msg);
        }

        private void btnUebernehmen_Click(object sender, EventArgs e)
        {
            try
            {
                DbAdapterPCVerwaltung adapter = new DbAdapterPCVerwaltung();

                // TextBoxes mit den PC-Daten werden ausgelesen
                double ram = Convert.ToDouble(txbRAM.Text);
                double hdd = Convert.ToDouble(txbHDD.Text);
                double prozgeschw = Convert.ToDouble(txbProzGeschw.Text);
                PC einPC;
                if (aktuellerDatensatz == allePC.Count)
                {   // wenn ein neuer PC angelegt werden soll, wird ein PC-Objekt erzeugt und
                    // in die Liste eingefügt
                    einPC = new PC();
                }
                else  // PC wird geändert
                {
                    einPC = allePC[aktuellerDatensatz];
                }

                // die in den TextBoxes stehenden Daten werden in das PC-Objekt zurückgeschrieben.
                einPC.Prozessorgeschwindigkeit = prozgeschw;
                einPC.RAM = ram;
                einPC.HDD = hdd;
                if (aktuellerDatensatz == allePC.Count)
                {   // wenn ein neuer PC angelegt werden soll, wird ein PC-Objekt erzeugt und
                    // in die Liste eingefügt
                    allePC.Add(einPC);
                    adapter.insertPc(einPC);
                }
                else  // PC wird geändert
                {
                    einPC.ID = allePC[aktuellerDatensatz].ID;
                    allePC[aktuellerDatensatz] = einPC;
                    adapter.updatePc(einPC);
                }
                aktualisiereOberflaeche();
            }
            catch (Exception)
            {
                MessageBox.Show("Geben Sie eine Zahl für die PC-Daten ein!");
            } 
        }


        private void aktualisiereOberflaeche()
        {

            // Steuerung der Knöpfe; 
            // Grundzustand: alle Knöpfe sind funktionsfähig
            btnErsterDS.Enabled = true;
            btnLetzterDS.Enabled = true;
            btnVorherigerDS.Enabled = true;
            btnNaechsterDS.Enabled = true;

            if (aktuellerDatensatz<=0)
            {   // wenn der erste Datensatz erreicht ist werden die Knöpfe ausgegraut, 
                // die zurückblättern 
                btnErsterDS.Enabled = false;
                btnVorherigerDS.Enabled = false;
            }
            if (aktuellerDatensatz>=allePC.Count-1)
            {   // wenn der letzte Datensatz erreicht ist werden die Knöpfe ausgegraut, 
                // die vorblättern 
                btnLetzterDS.Enabled = false;
                btnNaechsterDS.Enabled = false;
            }

            // Aktualisierung des Datensatzanzeigers
            lblDatensatz.Text = "" + (aktuellerDatensatz + 1) + "/" + allePC.Count;

            
            if (aktuellerDatensatz >= 0 && aktuellerDatensatz < allePC.Count)
            {   // Inhalt der Textfelder falls ein Datensatz vorhanden ist
                btnUebernehmen.Text = "Datensatz ändern";
                txbDatenAusgabe.Text = allePC[aktuellerDatensatz].zeigeDaten();
                txbHDD.Text = String.Format("{0:0.0}", allePC[aktuellerDatensatz].HDD);
                txbRAM.Text = String.Format("{0:0.0}", allePC[aktuellerDatensatz].RAM);
                txbProzGeschw.Text = String.Format("{0:0.0}", allePC[aktuellerDatensatz].Prozessorgeschwindigkeit);
            }
            else if ( aktuellerDatensatz==allePC.Count)
            {   // Inhalt der Textfelder, falls kein Datensatz vorhanden ist, oder 
                // ein neuer angelegt werden soll            
                btnUebernehmen.Text = "Datensatz übernehmen";
                txbDatenAusgabe.Clear();
                txbRAM.Clear();
                txbProzGeschw.Clear();
                txbHDD.Clear();
            }
        }

        private void btnErsterDS_Click(object sender, EventArgs e)
        {
            aktuellerDatensatz = 0;
            aktualisiereOberflaeche();
        }

        private void btnVorherigerDS_Click(object sender, EventArgs e)
        {
            aktuellerDatensatz--;
            aktualisiereOberflaeche();

        }

        private void btnNaechsterDS_Click(object sender, EventArgs e)
        {
            aktuellerDatensatz++;
            aktualisiereOberflaeche();

        }

        private void btnLetzterDS_Click(object sender, EventArgs e)
        {
            aktuellerDatensatz = allePC.Count-1;
            aktualisiereOberflaeche();

        }

        private void btnNeuerDS_Click(object sender, EventArgs e)
        {
            // aktuellerDatensatz==allePC.Count ist das das Signal in der 
            // Anwendung, dass ein neuer Datensatz angelegt wird.
            aktuellerDatensatz = allePC.Count ;
            aktualisiereOberflaeche();
        }

        private void alleLoeschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allePC.Clear();
            aktuellerDatensatz = 0;
            aktualisiereOberflaeche();
        }


 

        private void dBVerbindungTestenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MySQLConnector connector = new MySQLConnector();
            MessageBox.Show(connector.testConnection());
        }
    }
}
