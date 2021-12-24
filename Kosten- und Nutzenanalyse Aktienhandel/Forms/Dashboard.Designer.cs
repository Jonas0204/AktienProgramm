
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
        public void InitializeComponent()
        {
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
            this.KaufCb = new System.Windows.Forms.CheckBox();
            this.VerkaufCb = new System.Windows.Forms.CheckBox();
            this.TitelCb = new System.Windows.Forms.ComboBox();
            this.AnzahlAktienTb = new System.Windows.Forms.TextBox();
            this.AnzahlAktienLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panelEingabe = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
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
            this.DelRowBtn = new System.Windows.Forms.Button();
            this.DelTabelleBtn = new System.Windows.Forms.Button();
            this.TabelleÖffnenBtn = new System.Windows.Forms.Button();
            this.TabelleSpeichernBtn = new System.Windows.Forms.Button();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelEingabe.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.AnsichtGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // DatumTb
            // 
            this.DatumTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatumTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.DatumTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatumTb.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DatumTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.DatumTb.Location = new System.Drawing.Point(12, 33);
            this.DatumTb.Name = "DatumTb";
            this.DatumTb.Size = new System.Drawing.Size(100, 27);
            this.DatumTb.TabIndex = 1;
            // 
            // DatumLbl
            // 
            this.DatumLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatumLbl.AutoSize = true;
            this.DatumLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DatumLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.DatumLbl.Location = new System.Drawing.Point(12, 12);
            this.DatumLbl.Name = "DatumLbl";
            this.DatumLbl.Size = new System.Drawing.Size(56, 17);
            this.DatumLbl.TabIndex = 2;
            this.DatumLbl.Text = "Datum:";
            // 
            // TitelLbl
            // 
            this.TitelLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitelLbl.AutoSize = true;
            this.TitelLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitelLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TitelLbl.Location = new System.Drawing.Point(118, 12);
            this.TitelLbl.Name = "TitelLbl";
            this.TitelLbl.Size = new System.Drawing.Size(44, 17);
            this.TitelLbl.TabIndex = 4;
            this.TitelLbl.Text = "Titel:";
            // 
            // AktionLbl
            // 
            this.AktionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AktionLbl.AutoSize = true;
            this.AktionLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AktionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.AktionLbl.Location = new System.Drawing.Point(224, 12);
            this.AktionLbl.Name = "AktionLbl";
            this.AktionLbl.Size = new System.Drawing.Size(58, 17);
            this.AktionLbl.TabIndex = 7;
            this.AktionLbl.Text = "Aktion:";
            // 
            // KostenTb
            // 
            this.KostenTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KostenTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.KostenTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KostenTb.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KostenTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.KostenTb.Location = new System.Drawing.Point(296, 33);
            this.KostenTb.Name = "KostenTb";
            this.KostenTb.Size = new System.Drawing.Size(100, 27);
            this.KostenTb.TabIndex = 8;
            // 
            // KostenLbl
            // 
            this.KostenLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KostenLbl.AutoSize = true;
            this.KostenLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KostenLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.KostenLbl.Location = new System.Drawing.Point(296, 12);
            this.KostenLbl.Name = "KostenLbl";
            this.KostenLbl.Size = new System.Drawing.Size(61, 17);
            this.KostenLbl.TabIndex = 9;
            this.KostenLbl.Text = "Kosten:";
            // 
            // KursTb
            // 
            this.KursTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KursTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.KursTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KursTb.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KursTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.KursTb.Location = new System.Drawing.Point(402, 33);
            this.KursTb.Name = "KursTb";
            this.KursTb.Size = new System.Drawing.Size(100, 27);
            this.KursTb.TabIndex = 10;
            // 
            // KursLbl
            // 
            this.KursLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KursLbl.AutoSize = true;
            this.KursLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KursLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.KursLbl.Location = new System.Drawing.Point(402, 12);
            this.KursLbl.Name = "KursLbl";
            this.KursLbl.Size = new System.Drawing.Size(46, 17);
            this.KursLbl.TabIndex = 11;
            this.KursLbl.Text = "Kurs:";
            // 
            // SpeicherBtn
            // 
            this.SpeicherBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpeicherBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.SpeicherBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.SpeicherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeicherBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpeicherBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.SpeicherBtn.Location = new System.Drawing.Point(12, 104);
            this.SpeicherBtn.Name = "SpeicherBtn";
            this.SpeicherBtn.Size = new System.Drawing.Size(155, 44);
            this.SpeicherBtn.TabIndex = 14;
            this.SpeicherBtn.Text = "Einfügen";
            this.SpeicherBtn.UseVisualStyleBackColor = false;
            this.SpeicherBtn.Click += new System.EventHandler(this.EinfuegenBtn_Click);
            // 
            // CopyrightLbl
            // 
            this.CopyrightLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CopyrightLbl.AutoSize = true;
            this.CopyrightLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.CopyrightLbl.Location = new System.Drawing.Point(12, 182);
            this.CopyrightLbl.Name = "CopyrightLbl";
            this.CopyrightLbl.Size = new System.Drawing.Size(126, 15);
            this.CopyrightLbl.TabIndex = 21;
            this.CopyrightLbl.Text = "© 2020 by Jonas Hülse";
            // 
            // KaufCb
            // 
            this.KaufCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KaufCb.AutoSize = true;
            this.KaufCb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KaufCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.KaufCb.Location = new System.Drawing.Point(224, 33);
            this.KaufCb.Name = "KaufCb";
            this.KaufCb.Size = new System.Drawing.Size(58, 21);
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
            this.VerkaufCb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VerkaufCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.VerkaufCb.Location = new System.Drawing.Point(224, 58);
            this.VerkaufCb.Name = "VerkaufCb";
            this.VerkaufCb.Size = new System.Drawing.Size(78, 21);
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
            this.TitelCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.TitelCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitelCb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitelCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TitelCb.FormattingEnabled = true;
            this.TitelCb.Location = new System.Drawing.Point(118, 33);
            this.TitelCb.Name = "TitelCb";
            this.TitelCb.Size = new System.Drawing.Size(100, 27);
            this.TitelCb.TabIndex = 3;
            // 
            // AnzahlAktienTb
            // 
            this.AnzahlAktienTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnzahlAktienTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.AnzahlAktienTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnzahlAktienTb.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnzahlAktienTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.AnzahlAktienTb.Location = new System.Drawing.Point(508, 33);
            this.AnzahlAktienTb.Name = "AnzahlAktienTb";
            this.AnzahlAktienTb.Size = new System.Drawing.Size(119, 27);
            this.AnzahlAktienTb.TabIndex = 12;
            // 
            // AnzahlAktienLbl
            // 
            this.AnzahlAktienLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnzahlAktienLbl.AutoSize = true;
            this.AnzahlAktienLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnzahlAktienLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.AnzahlAktienLbl.Location = new System.Drawing.Point(508, 12);
            this.AnzahlAktienLbl.Name = "AnzahlAktienLbl";
            this.AnzahlAktienLbl.Size = new System.Drawing.Size(131, 17);
            this.AnzahlAktienLbl.TabIndex = 13;
            this.AnzahlAktienLbl.Text = "Anzahl der Aktien:";
            // 
            // panelTable
            // 
            this.panelTable.AutoSize = true;
            this.panelTable.Controls.Add(this.dgv);
            this.panelTable.Location = new System.Drawing.Point(0, 0);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(777, 340);
            this.panelTable.TabIndex = 37;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(777, 340);
            this.dgv.TabIndex = 1;
            // 
            // panelEingabe
            // 
            this.panelEingabe.AutoSize = true;
            this.panelEingabe.Controls.Add(this.DatumLbl);
            this.panelEingabe.Controls.Add(this.DatumTb);
            this.panelEingabe.Controls.Add(this.TitelLbl);
            this.panelEingabe.Controls.Add(this.AktionLbl);
            this.panelEingabe.Controls.Add(this.AnzahlAktienLbl);
            this.panelEingabe.Controls.Add(this.KostenTb);
            this.panelEingabe.Controls.Add(this.AnzahlAktienTb);
            this.panelEingabe.Controls.Add(this.KostenLbl);
            this.panelEingabe.Controls.Add(this.CopyrightLbl);
            this.panelEingabe.Controls.Add(this.TitelCb);
            this.panelEingabe.Controls.Add(this.SpeicherBtn);
            this.panelEingabe.Controls.Add(this.KursTb);
            this.panelEingabe.Controls.Add(this.VerkaufCb);
            this.panelEingabe.Controls.Add(this.KursLbl);
            this.panelEingabe.Controls.Add(this.KaufCb);
            this.panelEingabe.Location = new System.Drawing.Point(0, 343);
            this.panelEingabe.Name = "panelEingabe";
            this.panelEingabe.Size = new System.Drawing.Size(773, 203);
            this.panelEingabe.TabIndex = 0;
            // 
            // panelOptions
            // 
            this.panelOptions.AutoSize = true;
            this.panelOptions.Controls.Add(this.AnsichtGB);
            this.panelOptions.Controls.Add(this.DelRowBtn);
            this.panelOptions.Controls.Add(this.DelTabelleBtn);
            this.panelOptions.Controls.Add(this.TabelleÖffnenBtn);
            this.panelOptions.Controls.Add(this.TabelleSpeichernBtn);
            this.panelOptions.ForeColor = System.Drawing.Color.DarkGray;
            this.panelOptions.Location = new System.Drawing.Point(797, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(294, 546);
            this.panelOptions.TabIndex = 38;
            // 
            // AnsichtGB
            // 
            this.AnsichtGB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnsichtGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
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
            this.AnsichtGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnsichtGB.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AnsichtGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.AnsichtGB.Location = new System.Drawing.Point(4, 77);
            this.AnsichtGB.Name = "AnsichtGB";
            this.AnsichtGB.Size = new System.Drawing.Size(276, 337);
            this.AnsichtGB.TabIndex = 41;
            this.AnsichtGB.TabStop = false;
            this.AnsichtGB.Text = "Ansicht:";
            // 
            // GsmKoLbl2
            // 
            this.GsmKoLbl2.AutoSize = true;
            this.GsmKoLbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GsmKoLbl2.Location = new System.Drawing.Point(142, 296);
            this.GsmKoLbl2.Name = "GsmKoLbl2";
            this.GsmKoLbl2.Size = new System.Drawing.Size(29, 15);
            this.GsmKoLbl2.TabIndex = 51;
            this.GsmKoLbl2.Text = "N/A";
            // 
            // GewinnLbl2
            // 
            this.GewinnLbl2.AutoSize = true;
            this.GewinnLbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GewinnLbl2.Location = new System.Drawing.Point(142, 281);
            this.GewinnLbl2.Name = "GewinnLbl2";
            this.GewinnLbl2.Size = new System.Drawing.Size(29, 15);
            this.GewinnLbl2.TabIndex = 50;
            this.GewinnLbl2.Text = "N/A";
            // 
            // GsmKLbl2
            // 
            this.GsmKLbl2.AutoSize = true;
            this.GsmKLbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GsmKLbl2.Location = new System.Drawing.Point(142, 266);
            this.GsmKLbl2.Name = "GsmKLbl2";
            this.GsmKLbl2.Size = new System.Drawing.Size(29, 15);
            this.GsmKLbl2.TabIndex = 49;
            this.GsmKLbl2.Text = "N/A";
            // 
            // GsmKoLbl
            // 
            this.GsmKoLbl.AutoSize = true;
            this.GsmKoLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GsmKoLbl.Location = new System.Drawing.Point(5, 296);
            this.GsmKoLbl.Name = "GsmKoLbl";
            this.GsmKoLbl.Size = new System.Drawing.Size(136, 15);
            this.GsmKoLbl.TabIndex = 48;
            this.GsmKoLbl.Text = "- Gesamt Kosten :            ";
            // 
            // GewinnLbl
            // 
            this.GewinnLbl.AutoSize = true;
            this.GewinnLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GewinnLbl.Location = new System.Drawing.Point(5, 281);
            this.GewinnLbl.Name = "GewinnLbl";
            this.GewinnLbl.Size = new System.Drawing.Size(112, 15);
            this.GewinnLbl.TabIndex = 47;
            this.GewinnLbl.Text = "- Gewinn:                  ";
            // 
            // GsmKLbl
            // 
            this.GsmKLbl.AutoSize = true;
            this.GsmKLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GsmKLbl.Location = new System.Drawing.Point(5, 266);
            this.GsmKLbl.Name = "GsmKLbl";
            this.GsmKLbl.Size = new System.Drawing.Size(135, 15);
            this.GsmKLbl.TabIndex = 46;
            this.GsmKLbl.Text = "- Gebundenes Kapital :   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ergebnis:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Jahresbetrachtung",
            "All-Time Betrachtung"});
            this.checkedListBox1.Location = new System.Drawing.Point(17, 106);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(226, 40);
            this.checkedListBox1.TabIndex = 44;
            // 
            // Bindestrich1
            // 
            this.Bindestrich1.AutoSize = true;
            this.Bindestrich1.BackColor = System.Drawing.Color.Transparent;
            this.Bindestrich1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.Bindestrich1.Location = new System.Drawing.Point(129, 180);
            this.Bindestrich1.Name = "Bindestrich1";
            this.Bindestrich1.Size = new System.Drawing.Size(22, 30);
            this.Bindestrich1.TabIndex = 43;
            this.Bindestrich1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(157, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Bis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Von:";
            // 
            // UebersichtBisTb
            // 
            this.UebersichtBisTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.UebersichtBisTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UebersichtBisTb.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UebersichtBisTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.UebersichtBisTb.Location = new System.Drawing.Point(157, 183);
            this.UebersichtBisTb.Name = "UebersichtBisTb";
            this.UebersichtBisTb.Size = new System.Drawing.Size(113, 27);
            this.UebersichtBisTb.TabIndex = 39;
            this.UebersichtBisTb.Text = "01.01.2022";
            // 
            // UebersichVonTb
            // 
            this.UebersichVonTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.UebersichVonTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UebersichVonTb.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UebersichVonTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.UebersichVonTb.Location = new System.Drawing.Point(17, 183);
            this.UebersichVonTb.Name = "UebersichVonTb";
            this.UebersichVonTb.Size = new System.Drawing.Size(106, 27);
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
            // DelRowBtn
            // 
            this.DelRowBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.DelRowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.DelRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelRowBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelRowBtn.Location = new System.Drawing.Point(4, 435);
            this.DelRowBtn.Name = "DelRowBtn";
            this.DelRowBtn.Size = new System.Drawing.Size(276, 47);
            this.DelRowBtn.TabIndex = 39;
            this.DelRowBtn.Text = "Zeile löschen";
            this.DelRowBtn.UseVisualStyleBackColor = false;
            this.DelRowBtn.Click += new System.EventHandler(this.DelRowBtn_Click);
            // 
            // DelTabelleBtn
            // 
            this.DelTabelleBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelTabelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.DelTabelleBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.DelTabelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelTabelleBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelTabelleBtn.Location = new System.Drawing.Point(4, 491);
            this.DelTabelleBtn.Name = "DelTabelleBtn";
            this.DelTabelleBtn.Size = new System.Drawing.Size(276, 28);
            this.DelTabelleBtn.TabIndex = 40;
            this.DelTabelleBtn.Text = "Tabelle löschen";
            this.DelTabelleBtn.UseVisualStyleBackColor = false;
            this.DelTabelleBtn.Click += new System.EventHandler(this.DelTabelleBtn_Click);
            // 
            // TabelleÖffnenBtn
            // 
            this.TabelleÖffnenBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabelleÖffnenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.TabelleÖffnenBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TabelleÖffnenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabelleÖffnenBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TabelleÖffnenBtn.Location = new System.Drawing.Point(147, 12);
            this.TabelleÖffnenBtn.Name = "TabelleÖffnenBtn";
            this.TabelleÖffnenBtn.Size = new System.Drawing.Size(133, 59);
            this.TabelleÖffnenBtn.TabIndex = 38;
            this.TabelleÖffnenBtn.Text = "Tabelle Öffnen";
            this.TabelleÖffnenBtn.UseVisualStyleBackColor = false;
            this.TabelleÖffnenBtn.Click += new System.EventHandler(this.TabelleÖffnenBtn_Click);
            // 
            // TabelleSpeichernBtn
            // 
            this.TabelleSpeichernBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabelleSpeichernBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.TabelleSpeichernBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TabelleSpeichernBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabelleSpeichernBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TabelleSpeichernBtn.Location = new System.Drawing.Point(4, 12);
            this.TabelleSpeichernBtn.Name = "TabelleSpeichernBtn";
            this.TabelleSpeichernBtn.Size = new System.Drawing.Size(133, 59);
            this.TabelleSpeichernBtn.TabIndex = 37;
            this.TabelleSpeichernBtn.Text = "Tabelle Speichern";
            this.TabelleSpeichernBtn.UseVisualStyleBackColor = false;
            this.TabelleSpeichernBtn.Click += new System.EventHandler(this.TabelleSpeichernBtn_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1090, 547);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.panelEingabe);
            this.Controls.Add(this.panelTable);
            this.Name = "FormDashboard";
            this.Text = "Das beste Aktien Programm was es gibt!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelEingabe.ResumeLayout(false);
            this.panelEingabe.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.AnsichtGB.ResumeLayout(false);
            this.AnsichtGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.CheckBox KaufCb;
        private System.Windows.Forms.CheckBox VerkaufCb;
        private System.Windows.Forms.ComboBox TitelCb;
        private System.Windows.Forms.TextBox AnzahlAktienTb;
        private System.Windows.Forms.Label AnzahlAktienLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Panel panelEingabe;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.GroupBox AnsichtGB;
        private System.Windows.Forms.Label GsmKoLbl2;
        private System.Windows.Forms.Label GewinnLbl2;
        private System.Windows.Forms.Label GsmKLbl2;
        private System.Windows.Forms.Label GsmKoLbl;
        private System.Windows.Forms.Label GewinnLbl;
        private System.Windows.Forms.Label GsmKLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label Bindestrich1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UebersichtBisTb;
        private System.Windows.Forms.TextBox UebersichVonTb;
        private System.Windows.Forms.RadioButton RadioBtnVerlauf;
        private System.Windows.Forms.RadioButton RadioBtnUebersicht;
        private System.Windows.Forms.Button DelRowBtn;
        private System.Windows.Forms.Button DelTabelleBtn;
        private System.Windows.Forms.Button TabelleÖffnenBtn;
        private System.Windows.Forms.Button TabelleSpeichernBtn;
    }
}

