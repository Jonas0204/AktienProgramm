
namespace Kosten__und_Nutzenanalyse_Aktienhandel
{
    partial class FormDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.DatumTb = new System.Windows.Forms.TextBox();
            this.DatumLbl = new System.Windows.Forms.Label();
            this.TitelLbl = new System.Windows.Forms.Label();
            this.AktionLbl = new System.Windows.Forms.Label();
            this.KostenTb = new System.Windows.Forms.TextBox();
            this.KostenLbl = new System.Windows.Forms.Label();
            this.KursTb = new System.Windows.Forms.TextBox();
            this.KursLbl = new System.Windows.Forms.Label();
            this.SpeicherBtn = new System.Windows.Forms.Button();
            this.CopyrightLbl = new System.Windows.Forms.Label();
            this.TabelleSpeichernBtn = new System.Windows.Forms.Button();
            this.TabelleÖffnenBtn = new System.Windows.Forms.Button();
            this.DelTabelleBtn = new System.Windows.Forms.Button();
            this.DelRowBtn = new System.Windows.Forms.Button();
            this.KaufCb = new System.Windows.Forms.CheckBox();
            this.VerkaufCb = new System.Windows.Forms.CheckBox();
            this.TitelCb = new System.Windows.Forms.ComboBox();
            this.AnzahlAktienTb = new System.Windows.Forms.TextBox();
            this.AnzahlAktienLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AnsichtGB = new System.Windows.Forms.GroupBox();
            this.GsmKoLbl2 = new System.Windows.Forms.Label();
            this.GewinnLbl2 = new System.Windows.Forms.Label();
            this.GsmKLbl2 = new System.Windows.Forms.Label();
            this.GsmKoLbl = new System.Windows.Forms.Label();
            this.GewinnLbl = new System.Windows.Forms.Label();
            this.GsmKLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Bindestrich1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UebersichtBisTb = new System.Windows.Forms.TextBox();
            this.UebersichVonTb = new System.Windows.Forms.TextBox();
            this.RadioBtnVerlauf = new System.Windows.Forms.RadioButton();
            this.RadioBtnUebersicht = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.AnsichtGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(1, 1);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(776, 344);
            this.dgv.TabIndex = 0;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellValueChanged);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // DatumTb
            // 
            this.DatumTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatumTb.Location = new System.Drawing.Point(1, 412);
            this.DatumTb.Name = "DatumTb";
            this.DatumTb.Size = new System.Drawing.Size(100, 23);
            this.DatumTb.TabIndex = 1;
            // 
            // DatumLbl
            // 
            this.DatumLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatumLbl.AutoSize = true;
            this.DatumLbl.Location = new System.Drawing.Point(1, 391);
            this.DatumLbl.Name = "DatumLbl";
            this.DatumLbl.Size = new System.Drawing.Size(46, 15);
            this.DatumLbl.TabIndex = 2;
            this.DatumLbl.Text = "Datum:";
            // 
            // TitelLbl
            // 
            this.TitelLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitelLbl.AutoSize = true;
            this.TitelLbl.Location = new System.Drawing.Point(107, 394);
            this.TitelLbl.Name = "TitelLbl";
            this.TitelLbl.Size = new System.Drawing.Size(32, 15);
            this.TitelLbl.TabIndex = 4;
            this.TitelLbl.Text = "Titel:";
            // 
            // AktionLbl
            // 
            this.AktionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AktionLbl.AutoSize = true;
            this.AktionLbl.Location = new System.Drawing.Point(213, 394);
            this.AktionLbl.Name = "AktionLbl";
            this.AktionLbl.Size = new System.Drawing.Size(45, 15);
            this.AktionLbl.TabIndex = 7;
            this.AktionLbl.Text = "Aktion:";
            // 
            // KostenTb
            // 
            this.KostenTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KostenTb.Location = new System.Drawing.Point(285, 412);
            this.KostenTb.Name = "KostenTb";
            this.KostenTb.Size = new System.Drawing.Size(100, 23);
            this.KostenTb.TabIndex = 8;
            // 
            // KostenLbl
            // 
            this.KostenLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KostenLbl.AutoSize = true;
            this.KostenLbl.Location = new System.Drawing.Point(285, 394);
            this.KostenLbl.Name = "KostenLbl";
            this.KostenLbl.Size = new System.Drawing.Size(46, 15);
            this.KostenLbl.TabIndex = 9;
            this.KostenLbl.Text = "Kosten:";
            // 
            // KursTb
            // 
            this.KursTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KursTb.Location = new System.Drawing.Point(391, 412);
            this.KursTb.Name = "KursTb";
            this.KursTb.Size = new System.Drawing.Size(100, 23);
            this.KursTb.TabIndex = 10;
            // 
            // KursLbl
            // 
            this.KursLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KursLbl.AutoSize = true;
            this.KursLbl.Location = new System.Drawing.Point(391, 394);
            this.KursLbl.Name = "KursLbl";
            this.KursLbl.Size = new System.Drawing.Size(33, 15);
            this.KursLbl.TabIndex = 11;
            this.KursLbl.Text = "Kurs:";
            // 
            // SpeicherBtn
            // 
            this.SpeicherBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpeicherBtn.Location = new System.Drawing.Point(622, 412);
            this.SpeicherBtn.Name = "SpeicherBtn";
            this.SpeicherBtn.Size = new System.Drawing.Size(155, 44);
            this.SpeicherBtn.TabIndex = 14;
            this.SpeicherBtn.Text = "Einfügen";
            this.SpeicherBtn.UseVisualStyleBackColor = true;
            this.SpeicherBtn.Click += new System.EventHandler(this.SpeicherBtn_Click);
            // 
            // CopyrightLbl
            // 
            this.CopyrightLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CopyrightLbl.AutoSize = true;
            this.CopyrightLbl.Location = new System.Drawing.Point(13, 551);
            this.CopyrightLbl.Name = "CopyrightLbl";
            this.CopyrightLbl.Size = new System.Drawing.Size(126, 15);
            this.CopyrightLbl.TabIndex = 21;
            this.CopyrightLbl.Text = "© 2020 by Jonas Hülse";
            // 
            // TabelleSpeichernBtn
            // 
            this.TabelleSpeichernBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabelleSpeichernBtn.Location = new System.Drawing.Point(793, 8);
            this.TabelleSpeichernBtn.Name = "TabelleSpeichernBtn";
            this.TabelleSpeichernBtn.Size = new System.Drawing.Size(111, 59);
            this.TabelleSpeichernBtn.TabIndex = 22;
            this.TabelleSpeichernBtn.Text = "Tabelle Speichern";
            this.TabelleSpeichernBtn.UseVisualStyleBackColor = true;
            this.TabelleSpeichernBtn.Click += new System.EventHandler(this.TabelleSpeichernBtn_Click);
            // 
            // TabelleÖffnenBtn
            // 
            this.TabelleÖffnenBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabelleÖffnenBtn.Location = new System.Drawing.Point(936, 8);
            this.TabelleÖffnenBtn.Name = "TabelleÖffnenBtn";
            this.TabelleÖffnenBtn.Size = new System.Drawing.Size(111, 59);
            this.TabelleÖffnenBtn.TabIndex = 23;
            this.TabelleÖffnenBtn.Text = "Tabelle Öffnen";
            this.TabelleÖffnenBtn.UseVisualStyleBackColor = true;
            this.TabelleÖffnenBtn.Click += new System.EventHandler(this.TabelleÖffnenBtn_Click);
            // 
            // DelTabelleBtn
            // 
            this.DelTabelleBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelTabelleBtn.Location = new System.Drawing.Point(793, 538);
            this.DelTabelleBtn.Name = "DelTabelleBtn";
            this.DelTabelleBtn.Size = new System.Drawing.Size(254, 28);
            this.DelTabelleBtn.TabIndex = 25;
            this.DelTabelleBtn.Text = "Tabelle löschen";
            this.DelTabelleBtn.UseVisualStyleBackColor = true;
            this.DelTabelleBtn.Click += new System.EventHandler(this.DelTabelleBtn_Click);
            // 
            // DelRowBtn
            // 
            this.DelRowBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelRowBtn.Location = new System.Drawing.Point(793, 485);
            this.DelRowBtn.Name = "DelRowBtn";
            this.DelRowBtn.Size = new System.Drawing.Size(254, 47);
            this.DelRowBtn.TabIndex = 24;
            this.DelRowBtn.Text = "Zeile löschen";
            this.DelRowBtn.UseVisualStyleBackColor = true;
            this.DelRowBtn.Click += new System.EventHandler(this.DelRowBtn_Click);
            // 
            // KaufCb
            // 
            this.KaufCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KaufCb.AutoSize = true;
            this.KaufCb.Location = new System.Drawing.Point(213, 412);
            this.KaufCb.Name = "KaufCb";
            this.KaufCb.Size = new System.Drawing.Size(50, 19);
            this.KaufCb.TabIndex = 5;
            this.KaufCb.Text = "Kauf";
            this.KaufCb.UseVisualStyleBackColor = true;
            this.KaufCb.Click += new System.EventHandler(this.KaufCb_Click);
            this.KaufCb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KaufCb_KeyDown);
            // 
            // VerkaufCb
            // 
            this.VerkaufCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VerkaufCb.AutoSize = true;
            this.VerkaufCb.Location = new System.Drawing.Point(213, 437);
            this.VerkaufCb.Name = "VerkaufCb";
            this.VerkaufCb.Size = new System.Drawing.Size(65, 19);
            this.VerkaufCb.TabIndex = 6;
            this.VerkaufCb.Text = "Verkauf";
            this.VerkaufCb.UseVisualStyleBackColor = true;
            this.VerkaufCb.Click += new System.EventHandler(this.VerkaufCb_Click);
            this.VerkaufCb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VerkaufCb_KeyDown);
            // 
            // TitelCb
            // 
            this.TitelCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitelCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TitelCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TitelCb.FormattingEnabled = true;
            this.TitelCb.Location = new System.Drawing.Point(107, 412);
            this.TitelCb.Name = "TitelCb";
            this.TitelCb.Size = new System.Drawing.Size(100, 23);
            this.TitelCb.TabIndex = 3;
            // 
            // AnzahlAktienTb
            // 
            this.AnzahlAktienTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnzahlAktienTb.Location = new System.Drawing.Point(497, 412);
            this.AnzahlAktienTb.Name = "AnzahlAktienTb";
            this.AnzahlAktienTb.Size = new System.Drawing.Size(119, 23);
            this.AnzahlAktienTb.TabIndex = 12;
            // 
            // AnzahlAktienLbl
            // 
            this.AnzahlAktienLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnzahlAktienLbl.AutoSize = true;
            this.AnzahlAktienLbl.Location = new System.Drawing.Point(497, 394);
            this.AnzahlAktienLbl.Name = "AnzahlAktienLbl";
            this.AnzahlAktienLbl.Size = new System.Drawing.Size(103, 15);
            this.AnzahlAktienLbl.TabIndex = 13;
            this.AnzahlAktienLbl.Text = "Anzahl der Aktien:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(639, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AnsichtGB
            // 
            this.AnsichtGB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnsichtGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AnsichtGB.Controls.Add(this.GsmKoLbl2);
            this.AnsichtGB.Controls.Add(this.GewinnLbl2);
            this.AnsichtGB.Controls.Add(this.GsmKLbl2);
            this.AnsichtGB.Controls.Add(this.GsmKoLbl);
            this.AnsichtGB.Controls.Add(this.GewinnLbl);
            this.AnsichtGB.Controls.Add(this.GsmKLbl);
            this.AnsichtGB.Controls.Add(this.label3);
            this.AnsichtGB.Controls.Add(this.checkedListBox1);
            this.AnsichtGB.Controls.Add(this.Bindestrich1);
            this.AnsichtGB.Controls.Add(this.label2);
            this.AnsichtGB.Controls.Add(this.label1);
            this.AnsichtGB.Controls.Add(this.UebersichtBisTb);
            this.AnsichtGB.Controls.Add(this.UebersichVonTb);
            this.AnsichtGB.Controls.Add(this.RadioBtnVerlauf);
            this.AnsichtGB.Controls.Add(this.RadioBtnUebersicht);
            this.AnsichtGB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AnsichtGB.Location = new System.Drawing.Point(793, 97);
            this.AnsichtGB.Name = "AnsichtGB";
            this.AnsichtGB.Size = new System.Drawing.Size(254, 382);
            this.AnsichtGB.TabIndex = 36;
            this.AnsichtGB.TabStop = false;
            this.AnsichtGB.Text = "Ansicht:";
            // 
            // GsmKoLbl2
            // 
            this.GsmKoLbl2.AutoSize = true;
            this.GsmKoLbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GsmKoLbl2.Location = new System.Drawing.Point(143, 337);
            this.GsmKoLbl2.Name = "GsmKoLbl2";
            this.GsmKoLbl2.Size = new System.Drawing.Size(29, 15);
            this.GsmKoLbl2.TabIndex = 51;
            this.GsmKoLbl2.Text = "N/A";
            // 
            // GewinnLbl2
            // 
            this.GewinnLbl2.AutoSize = true;
            this.GewinnLbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GewinnLbl2.Location = new System.Drawing.Point(143, 322);
            this.GewinnLbl2.Name = "GewinnLbl2";
            this.GewinnLbl2.Size = new System.Drawing.Size(29, 15);
            this.GewinnLbl2.TabIndex = 50;
            this.GewinnLbl2.Text = "N/A";
            // 
            // GsmKLbl2
            // 
            this.GsmKLbl2.AutoSize = true;
            this.GsmKLbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GsmKLbl2.Location = new System.Drawing.Point(143, 307);
            this.GsmKLbl2.Name = "GsmKLbl2";
            this.GsmKLbl2.Size = new System.Drawing.Size(29, 15);
            this.GsmKLbl2.TabIndex = 49;
            this.GsmKLbl2.Text = "N/A";
            // 
            // GsmKoLbl
            // 
            this.GsmKoLbl.AutoSize = true;
            this.GsmKoLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GsmKoLbl.Location = new System.Drawing.Point(6, 337);
            this.GsmKoLbl.Name = "GsmKoLbl";
            this.GsmKoLbl.Size = new System.Drawing.Size(136, 15);
            this.GsmKoLbl.TabIndex = 48;
            this.GsmKoLbl.Text = "- Gesamt Kosten :            ";
            // 
            // GewinnLbl
            // 
            this.GewinnLbl.AutoSize = true;
            this.GewinnLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GewinnLbl.Location = new System.Drawing.Point(6, 322);
            this.GewinnLbl.Name = "GewinnLbl";
            this.GewinnLbl.Size = new System.Drawing.Size(112, 15);
            this.GewinnLbl.TabIndex = 47;
            this.GewinnLbl.Text = "- Gewinn:                  ";
            // 
            // GsmKLbl
            // 
            this.GsmKLbl.AutoSize = true;
            this.GsmKLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GsmKLbl.Location = new System.Drawing.Point(6, 307);
            this.GsmKLbl.Name = "GsmKLbl";
            this.GsmKLbl.Size = new System.Drawing.Size(135, 15);
            this.GsmKLbl.TabIndex = 46;
            this.GsmKLbl.Text = "- Gebundenes Kapital :   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ergebnis:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Jahresbetrachtung",
            "All-Time Betrachtung"});
            this.checkedListBox1.Location = new System.Drawing.Point(17, 158);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(226, 44);
            this.checkedListBox1.TabIndex = 44;
            // 
            // Bindestrich1
            // 
            this.Bindestrich1.AutoSize = true;
            this.Bindestrich1.BackColor = System.Drawing.Color.Transparent;
            this.Bindestrich1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.Bindestrich1.Location = new System.Drawing.Point(120, 226);
            this.Bindestrich1.Name = "Bindestrich1";
            this.Bindestrich1.Size = new System.Drawing.Size(22, 30);
            this.Bindestrich1.TabIndex = 43;
            this.Bindestrich1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(143, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Bis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Von:";
            // 
            // UebersichtBisTb
            // 
            this.UebersichtBisTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UebersichtBisTb.Location = new System.Drawing.Point(143, 227);
            this.UebersichtBisTb.Name = "UebersichtBisTb";
            this.UebersichtBisTb.Size = new System.Drawing.Size(100, 29);
            this.UebersichtBisTb.TabIndex = 39;
            this.UebersichtBisTb.Text = "01.01.2022";
            // 
            // UebersichVonTb
            // 
            this.UebersichVonTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UebersichVonTb.Location = new System.Drawing.Point(17, 227);
            this.UebersichVonTb.Name = "UebersichVonTb";
            this.UebersichVonTb.Size = new System.Drawing.Size(100, 29);
            this.UebersichVonTb.TabIndex = 38;
            this.UebersichVonTb.Text = "01.01.2021";
            // 
            // RadioBtnVerlauf
            // 
            this.RadioBtnVerlauf.AutoSize = true;
            this.RadioBtnVerlauf.Checked = true;
            this.RadioBtnVerlauf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioBtnVerlauf.Location = new System.Drawing.Point(17, 32);
            this.RadioBtnVerlauf.Name = "RadioBtnVerlauf";
            this.RadioBtnVerlauf.Size = new System.Drawing.Size(145, 23);
            this.RadioBtnVerlauf.TabIndex = 36;
            this.RadioBtnVerlauf.TabStop = true;
            this.RadioBtnVerlauf.Text = "=> Aktien Verlauf";
            this.RadioBtnVerlauf.UseVisualStyleBackColor = true;
            this.RadioBtnVerlauf.Click += new System.EventHandler(this.RadioBtnVerlauf_Click);
            // 
            // RadioBtnUebersicht
            // 
            this.RadioBtnUebersicht.AutoSize = true;
            this.RadioBtnUebersicht.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioBtnUebersicht.Location = new System.Drawing.Point(17, 61);
            this.RadioBtnUebersicht.Name = "RadioBtnUebersicht";
            this.RadioBtnUebersicht.Size = new System.Drawing.Size(161, 23);
            this.RadioBtnUebersicht.TabIndex = 37;
            this.RadioBtnUebersicht.Text = "=> Aktien Übersicht";
            this.RadioBtnUebersicht.UseVisualStyleBackColor = true;
            this.RadioBtnUebersicht.Click += new System.EventHandler(this.RadioBtnUebersicht_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 572);
            this.Controls.Add(this.AnsichtGB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnzahlAktienLbl);
            this.Controls.Add(this.AnzahlAktienTb);
            this.Controls.Add(this.TitelCb);
            this.Controls.Add(this.VerkaufCb);
            this.Controls.Add(this.KaufCb);
            this.Controls.Add(this.DelRowBtn);
            this.Controls.Add(this.DelTabelleBtn);
            this.Controls.Add(this.TabelleÖffnenBtn);
            this.Controls.Add(this.TabelleSpeichernBtn);
            this.Controls.Add(this.CopyrightLbl);
            this.Controls.Add(this.SpeicherBtn);
            this.Controls.Add(this.KursLbl);
            this.Controls.Add(this.KursTb);
            this.Controls.Add(this.KostenLbl);
            this.Controls.Add(this.KostenTb);
            this.Controls.Add(this.AktionLbl);
            this.Controls.Add(this.TitelLbl);
            this.Controls.Add(this.DatumLbl);
            this.Controls.Add(this.DatumTb);
            this.Controls.Add(this.dgv);
            this.Name = "FormDashboard";
            this.Text = "Das beste Aktien Programm was es gibt!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.AnsichtGB.ResumeLayout(false);
            this.AnsichtGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.TextBox DatumTb;
        private System.Windows.Forms.Label DatumLbl;
        private System.Windows.Forms.Label TitelLbl;
        private System.Windows.Forms.Label AktionLbl;
        private System.Windows.Forms.TextBox KostenTb;
        private System.Windows.Forms.Label KostenLbl;
        private System.Windows.Forms.TextBox KursTb;
        private System.Windows.Forms.Label KursLbl;
        private System.Windows.Forms.Button SpeicherBtn;
        private System.Windows.Forms.Label CopyrightLbl;
        private System.Windows.Forms.Button TabelleSpeichernBtn;
        private System.Windows.Forms.Button TabelleÖffnenBtn;
        private System.Windows.Forms.Button DelTabelleBtn;
        private System.Windows.Forms.Button DelRowBtn;
        private System.Windows.Forms.CheckBox KaufCb;
        private System.Windows.Forms.CheckBox VerkaufCb;
        private System.Windows.Forms.ComboBox TitelCb;
        private System.Windows.Forms.TextBox AnzahlAktienTb;
        private System.Windows.Forms.Label AnzahlAktienLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox AnsichtGB;
        private System.Windows.Forms.RadioButton RadioBtnVerlauf;
        private System.Windows.Forms.RadioButton RadioBtnUebersicht;
        private System.Windows.Forms.Label Bindestrich1;
        private System.Windows.Forms.TextBox UebersichtBisTb;
        private System.Windows.Forms.TextBox UebersichVonTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GsmKLbl;
        private System.Windows.Forms.Label GewinnLbl;
        private System.Windows.Forms.Label GsmKoLbl;
        private System.Windows.Forms.Label GsmKoLbl2;
        private System.Windows.Forms.Label GewinnLbl2;
        private System.Windows.Forms.Label GsmKLbl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

