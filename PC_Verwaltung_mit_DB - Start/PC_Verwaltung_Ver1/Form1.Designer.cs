namespace PC_Verwaltung_Ver4
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txbProzGeschw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbRAM = new System.Windows.Forms.TextBox();
            this.txbHDD = new System.Windows.Forms.TextBox();
            this.txbDatenAusgabe = new System.Windows.Forms.TextBox();
            this.btnUebernehmen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dBVerbindungTestenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überPCVerwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDatensatz = new System.Windows.Forms.Label();
            this.btnNeuerDS = new System.Windows.Forms.Button();
            this.btnLetzterDS = new System.Windows.Forms.Button();
            this.btnNaechsterDS = new System.Windows.Forms.Button();
            this.btnVorherigerDS = new System.Windows.Forms.Button();
            this.btnErsterDS = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC Verwaltung Ver. 4";
            // 
            // txbProzGeschw
            // 
            this.txbProzGeschw.Location = new System.Drawing.Point(273, 118);
            this.txbProzGeschw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbProzGeschw.Name = "txbProzGeschw";
            this.txbProzGeschw.Size = new System.Drawing.Size(132, 22);
            this.txbProzGeschw.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prozessorgeschwindigkeit in GHz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arbeitsspeicher in GB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Festplattenkapazität in GB";
            // 
            // txbRAM
            // 
            this.txbRAM.Location = new System.Drawing.Point(273, 161);
            this.txbRAM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbRAM.Name = "txbRAM";
            this.txbRAM.Size = new System.Drawing.Size(132, 22);
            this.txbRAM.TabIndex = 5;
            // 
            // txbHDD
            // 
            this.txbHDD.Location = new System.Drawing.Point(273, 210);
            this.txbHDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbHDD.Name = "txbHDD";
            this.txbHDD.Size = new System.Drawing.Size(132, 22);
            this.txbHDD.TabIndex = 6;
            // 
            // txbDatenAusgabe
            // 
            this.txbDatenAusgabe.BackColor = System.Drawing.Color.White;
            this.txbDatenAusgabe.Location = new System.Drawing.Point(471, 118);
            this.txbDatenAusgabe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDatenAusgabe.Multiline = true;
            this.txbDatenAusgabe.Name = "txbDatenAusgabe";
            this.txbDatenAusgabe.ReadOnly = true;
            this.txbDatenAusgabe.Size = new System.Drawing.Size(393, 111);
            this.txbDatenAusgabe.TabIndex = 7;
            // 
            // btnUebernehmen
            // 
            this.btnUebernehmen.Location = new System.Drawing.Point(131, 266);
            this.btnUebernehmen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUebernehmen.Name = "btnUebernehmen";
            this.btnUebernehmen.Size = new System.Drawing.Size(216, 28);
            this.btnUebernehmen.TabIndex = 8;
            this.btnUebernehmen.Text = "Datensatz ändern";
            this.btnUebernehmen.UseVisualStyleBackColor = true;
            this.btnUebernehmen.Click += new System.EventHandler(this.btnUebernehmen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBVerbindungTestenToolStripMenuItem,
            this.überPCVerwaltungToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // dBVerbindungTestenToolStripMenuItem
            // 
            this.dBVerbindungTestenToolStripMenuItem.Name = "dBVerbindungTestenToolStripMenuItem";
            this.dBVerbindungTestenToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.dBVerbindungTestenToolStripMenuItem.Text = "DB-Verbindung testen";
            this.dBVerbindungTestenToolStripMenuItem.Click += new System.EventHandler(this.dBVerbindungTestenToolStripMenuItem_Click_1);
            // 
            // überPCVerwaltungToolStripMenuItem
            // 
            this.überPCVerwaltungToolStripMenuItem.Name = "überPCVerwaltungToolStripMenuItem";
            this.überPCVerwaltungToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.überPCVerwaltungToolStripMenuItem.Text = "Über PC Verwaltung";
            this.überPCVerwaltungToolStripMenuItem.Click += new System.EventHandler(this.überPCVerwaltungToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDatensatz);
            this.groupBox1.Controls.Add(this.btnNeuerDS);
            this.groupBox1.Controls.Add(this.btnLetzterDS);
            this.groupBox1.Controls.Add(this.btnNaechsterDS);
            this.groupBox1.Controls.Add(this.btnVorherigerDS);
            this.groupBox1.Controls.Add(this.btnErsterDS);
            this.groupBox1.Location = new System.Drawing.Point(471, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(395, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datensatzsteuerung";
            // 
            // lblDatensatz
            // 
            this.lblDatensatz.AutoSize = true;
            this.lblDatensatz.Location = new System.Drawing.Point(152, 30);
            this.lblDatensatz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatensatz.Name = "lblDatensatz";
            this.lblDatensatz.Size = new System.Drawing.Size(36, 17);
            this.lblDatensatz.TabIndex = 1;
            this.lblDatensatz.Text = "0 / 0";
            // 
            // btnNeuerDS
            // 
            this.btnNeuerDS.Location = new System.Drawing.Point(327, 23);
            this.btnNeuerDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNeuerDS.Name = "btnNeuerDS";
            this.btnNeuerDS.Size = new System.Drawing.Size(47, 28);
            this.btnNeuerDS.TabIndex = 0;
            this.btnNeuerDS.Text = ">*";
            this.btnNeuerDS.UseVisualStyleBackColor = true;
            this.btnNeuerDS.Click += new System.EventHandler(this.btnNeuerDS_Click);
            // 
            // btnLetzterDS
            // 
            this.btnLetzterDS.Location = new System.Drawing.Point(272, 23);
            this.btnLetzterDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLetzterDS.Name = "btnLetzterDS";
            this.btnLetzterDS.Size = new System.Drawing.Size(47, 28);
            this.btnLetzterDS.TabIndex = 0;
            this.btnLetzterDS.Text = ">|";
            this.btnLetzterDS.UseVisualStyleBackColor = true;
            this.btnLetzterDS.Click += new System.EventHandler(this.btnLetzterDS_Click);
            // 
            // btnNaechsterDS
            // 
            this.btnNaechsterDS.Location = new System.Drawing.Point(217, 23);
            this.btnNaechsterDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNaechsterDS.Name = "btnNaechsterDS";
            this.btnNaechsterDS.Size = new System.Drawing.Size(47, 28);
            this.btnNaechsterDS.TabIndex = 0;
            this.btnNaechsterDS.Text = ">";
            this.btnNaechsterDS.UseVisualStyleBackColor = true;
            this.btnNaechsterDS.Click += new System.EventHandler(this.btnNaechsterDS_Click);
            // 
            // btnVorherigerDS
            // 
            this.btnVorherigerDS.Location = new System.Drawing.Point(75, 23);
            this.btnVorherigerDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVorherigerDS.Name = "btnVorherigerDS";
            this.btnVorherigerDS.Size = new System.Drawing.Size(47, 28);
            this.btnVorherigerDS.TabIndex = 0;
            this.btnVorherigerDS.Text = "<";
            this.btnVorherigerDS.UseVisualStyleBackColor = true;
            this.btnVorherigerDS.Click += new System.EventHandler(this.btnVorherigerDS_Click);
            // 
            // btnErsterDS
            // 
            this.btnErsterDS.Location = new System.Drawing.Point(20, 23);
            this.btnErsterDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnErsterDS.Name = "btnErsterDS";
            this.btnErsterDS.Size = new System.Drawing.Size(47, 28);
            this.btnErsterDS.TabIndex = 0;
            this.btnErsterDS.Text = "|<";
            this.btnErsterDS.UseVisualStyleBackColor = true;
            this.btnErsterDS.Click += new System.EventHandler(this.btnErsterDS_Click);
            // 
            // dlgSave
            // 
            this.dlgSave.FileName = "allePCs.csv";
            this.dlgSave.Filter = "\"csv-Dateien|*.csv|Alle Dateien|*.*\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUebernehmen);
            this.Controls.Add(this.txbDatenAusgabe);
            this.Controls.Add(this.txbHDD);
            this.Controls.Add(this.txbRAM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbProzGeschw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "PC Verwaltung Ver 4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbProzGeschw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbRAM;
        private System.Windows.Forms.TextBox txbHDD;
        private System.Windows.Forms.TextBox txbDatenAusgabe;
        private System.Windows.Forms.Button btnUebernehmen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem überPCVerwaltungToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDatensatz;
        private System.Windows.Forms.Button btnNeuerDS;
        private System.Windows.Forms.Button btnLetzterDS;
        private System.Windows.Forms.Button btnNaechsterDS;
        private System.Windows.Forms.Button btnVorherigerDS;
        private System.Windows.Forms.Button btnErsterDS;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem dBVerbindungTestenToolStripMenuItem;
    }
}

