using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;

namespace Kosten__und_Nutzenanalyse_Aktienhandel
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        public DataTable table = new();
        readonly DataSet dataset = new();

        public DataRow dr;

        public Pool Pool;

        private void Form1_Load(object sender, EventArgs e)
        {            
            /*
            Chart chart = new Chart();
            chart.Location = new System.Drawing.Point(10,10);
            chart.Series.Add("Series1");
            chart.Series.Add("Default");
            for (double angle = 0.0; angle <= 360.0; angle += 10.0)
            {
                double yValue = (1.0 + Math.Sin(angle/180.0*Math.PI)) * 10.0;
                chart.Series["Series1"].Points.AddXY(angle, yValue);
            }
            chart.Series["Default"].ChartType = SeriesChartType.Polar;
            */

            ///Datatable erstellen
            table.Columns.Add("ID", typeof(int));                       //0
            table.Columns.Add("Datum", typeof(String));                 //1
            table.Columns.Add("Titel", typeof(String));                 //2
            table.Columns.Add("Aktion", typeof(String));                //3
            table.Columns.Add("Kosten", typeof(double));                //4
            table.Columns.Add("Kurs", typeof(double));                  //5
            table.Columns.Add("Anzahl der Aktien", typeof(int));        //6
            table.Columns.Add("Eingesetztes Kapital", typeof(double));  //7
            table.Columns.Add("Ertrag", typeof(double));                //8
            table.Columns.Add("Noch offen", typeof(bool));              //9
            table.Columns.Add("MetaID", typeof(int));                   //10

            dgv.DataSource = table; ///Der Inhalt der tabelle wird mit dem DGV verknüpft
            dataset.Tables.Add(table);

            dgv.Columns[0].Visible = false;           //AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;

            dgv.Sort(dgv.Columns["ID"], ListSortDirection.Descending);            

            // Disable sorting for the DataGridView.
            foreach (DataGridViewColumn i in dgv.Columns)
            {
                i.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            table.Clear();
                        
            Pool = new();
            Pool.Aktien = new();
        }

        

        protected void AddToTabel(List<Aktie> aktien)
        {
            table.Clear();
            foreach (Aktie a in aktien)
            {
                // Tabelle füllen
                dr = table.NewRow();
                dr[0] = 0;
                dr[1] = a.Datum;
                dr[2] = a.Name;
                dr[3] = a.Aktion;
                dr[4] = a.Kosten;
                dr[5] = Math.Round(a.Kurs, 2);
                dr[6] = a.NAktien;
                dr[7] = a.EingesetztesKap;
                dr[8] = a.Ernte;
                dr[9] = a.Aktiv;
                dr[10] = a.MetaID;

                table.Rows.Add(dr);
            }           

            DatumTb.Text = "";
            TitelCb.ResetText();
            KostenTb.Text = "";
            KursTb.Text = "";
            VerkaufCb.Checked = false;
            KaufCb.Checked = false;
            AnzahlAktienTb.Text = "";

            DatumTb.Focus();
        }

        private void SpeicherBtn_Click(object sender, EventArgs e)
        {
            DatumTb.Text = DatumTb.Text.Replace(".", "/");
            string name = TitelCb.Text;
            string datum = DateTime.ParseExact(DatumTb.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToShortDateString();            
            string Aktion = ""; if (KaufCb.Checked) Aktion = "Kauf"; if (VerkaufCb.Checked) Aktion = "Verkauf";
            double kosten = Convert.ToDouble(KostenTb.Text);
            double kurs = Convert.ToDouble(KursTb.Text);
            int nAktien = Convert.ToInt32(AnzahlAktienTb.Text);
            
            Aktie aktie = new(name, datum, Aktion, kosten, kurs, nAktien);
            int MetaID;
            if (Pool.Aktien.Count > 0)
            {
                //MessageBox.Show(Pool.Aktien[0].Kosten.ToString());
                List<Aktie> Poolaktie = Pool.Aktien;
                MetaID = Pool.CheckForMeta(Poolaktie, aktie);
                //MessageBox.Show(Pool.Aktien[0].Kosten.ToString());
            }
            else MetaID = 1;
            

            aktie.MetaID = MetaID;            

            Pool.Aktien.Add(aktie); 
            if (Pool.Aktien.Count > 0) Pool.Aktien = Pool.SortByDate(Pool.Aktien);            
            AddToTabel(Pool.Aktien);

            // ComboBox füllen
            int i = TitelCb.FindStringExact(TitelLbl.Text);                         
            if (i == -1)
            {
                TitelCb.Items.Add(TitelLbl.Text);
            }

            //List<int> index = Pool.GetAllAktien(TitelLbl.Text);
        }
                
        private void TabelleSpeichernBtn_Click(object sender, EventArgs e)
        {            
            Pool.SaveObj(Pool.Aktien);

            /*
            SFD.FileName = "Tabelle(Aktien)";
            SFD.DefaultExt = "xml";
            SFD.Filter = "XML-Datei (*.xml)|*.xml";
            if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                table.WriteXml(@SFD.FileName);
            }*/
            MessageBox.Show("Erfolgreich Gespeichert!");
        }

        private void TabelleÖffnenBtn_Click(object sender, EventArgs e)
        {
            table.Clear();
            Pool.Aktien = Pool.LoadObj();
            AddToTabel(Pool.Aktien);
            /*
            table.Clear();
            OFD.FileName = "Tabelle(Aktien)";
            OFD.DefaultExt = "xml";
            OFD.Filter = "XML-Datei (*.xml)|*.xml";
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                table.ReadXml(@OFD.FileName);
            }*/

            lock (TitelCb.Items)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    int i = TitelCb.FindStringExact(dgv.Rows[row.Index].Cells["Titel"].Value.ToString());
                    if (i == -1)
                    {
                        TitelCb.Items.Add(dgv.Rows[row.Index].Cells["Titel"].Value.ToString());
                    }
                }
            }
            DatumTb.Focus();
            return;
        }

        private void DelTabelleBtn_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string path2 = path + @"\Kfz-Kostenberechnung.exe";
            System.Diagnostics.Process.Start(path2);
            this.Close();
        }

        private void DelRowBtn_Click(object sender, EventArgs e)
        {
            int einträge = 0;
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Fügen sie bitte zuerst einen Eintrag hinzu!");
            }
            else
            {
                int row = dgv.CurrentCell.RowIndex;
                string subname = dgv.Rows[row].Cells["Subtitel"].Value.ToString();
                string titel = dgv.Rows[row].Cells["Titel"].Value.ToString();
                foreach (DataGridViewRow row2 in dgv.Rows)
                {
                    if (dgv.Rows[row2.Index].Cells["Subtitel"].Value.ToString() == subname)
                    {
                        einträge += 1;
                    }
                }

                if (einträge == 1)
                {                    
                    TitelCb.Items.Remove(titel);
                    dgv.Rows.RemoveAt(row);
                }
                else
                {
                    dgv.Rows.RemoveAt(row);
                }
            }            
        }

        private void KaufCb_Click(object sender, EventArgs e)
        {
            if(VerkaufCb.Checked == true)
            {
                VerkaufCb.Checked = false;                
            }
        }

        private void VerkaufCb_Click(object sender, EventArgs e)
        {
            if (KaufCb.Checked == true)
            {
                KaufCb.Checked = false;
            }
        }

        private void KaufCb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KaufCb.Checked = true;
                KaufCb_Click(KaufCb, null);                
            }
        }

        private void VerkaufCb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerkaufCb.Checked = true;
                VerkaufCb_Click(VerkaufCb, null);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Pool.Aktien[0].Datum);
            Pool.Aktien.RemoveAt(0);
        }

        private void RadioBtnVerlauf_Click(object sender, EventArgs e)
        {
            if (RadioBtnVerlauf.Checked)
            {
                table.Clear();
                Pool.Aktien = Pool.LoadObj();
                AddToTabel(Pool.Aktien);
            }

            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
        }

        private void RadioBtnUebersicht_Click(object sender, EventArgs e)
        {
            if (RadioBtnUebersicht.Checked)
            {
                table.Clear();                
                ReturnForUebersicht output = Pool.Uebersicht(Pool.Aktien, UebersichVonTb.Text, UebersichtBisTb.Text);
                          
                if (output != null)
                {
                    GsmKLbl2.Text = output.Kapital.ToString();
                    GewinnLbl2.Text = Math.Round(output.Gewinn, 2).ToString();
                    GsmKoLbl2.Text = output.Kosten.ToString();
                    Pool.Aktien = output.rAktien;

                    AddToTabel(Pool.Aktien);
                }
                else MessageBox.Show("Es ist ein Fehler unterlaufen");

                dgv.Columns[7].Visible = true;
                dgv.Columns[8].Visible = true;
                dgv.Columns[9].Visible = true;
                dgv.Columns[10].Visible = true;
            }
        }

        private void Dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            int index = (e.RowIndex );
            int cindex = e.ColumnIndex;
            var value = dgv.Rows[rindex].Cells[cindex].Value;

            switch (cindex)
            {
                case 1:
                    Pool.Aktien[index].Datum = value.ToString();
                    break;
                case 2:
                    Pool.Aktien[index].Name = value.ToString();
                    break;
                case 3:
                    Pool.Aktien[index].Aktion = value.ToString();
                    break;
                case 4:
                    Pool.Aktien[index].Kosten = Convert.ToDouble(value);
                    break;
                case 5:
                    Pool.Aktien[index].Kurs = Convert.ToDouble(value);
                    break;
                case 6:
                    Pool.Aktien[index].NAktien = Convert.ToInt32(value);
                    break;
                case 7:
                    MessageBox.Show("Dieser Wert wird automatisch errechnet");
                    Pool.Aktien[index].EingesetztesKap = Convert.ToDouble(value);
                    break;
                case 8:
                    MessageBox.Show("Dieser Wert wird automatisch errechnet");
                    break;
                case 9:
                    MessageBox.Show("Dieser Wert wird automatisch errechnet");
                    break;
                case 10:
                    Pool.Aktien[index].MetaID = Convert.ToInt32(value);
                    break;
            }

            /*
             table.Columns.Add("ID", typeof(String));                    //0
            table.Columns.Add("Datum", typeof(String));                 //1
            table.Columns.Add("Titel", typeof(String));                 //2
            table.Columns.Add("Aktion", typeof(String));                //3
            table.Columns.Add("Kosten", typeof(String));                //4
            table.Columns.Add("Kurs", typeof(String));                  //5
            table.Columns.Add("Anzahl der Aktien", typeof(String));     //6
            table.Columns.Add("Eingesetztes Kapital", typeof(double));  //7
            table.Columns.Add("Ertrag", typeof(double));                //8
            table.Columns.Add("Noch offen", typeof(bool));              //9
            table.Columns.Add("Subtitel", typeof(String));              //10
             */
        }
    }
}
