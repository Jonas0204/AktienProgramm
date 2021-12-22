using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;

namespace Kosten__und_Nutzenanalyse_Aktienhandel
{
    [Serializable]
    public class Pool
    {
        public List<Aktie> Aktien;
        
        public static void SaveObj(List<Aktie> pAktien)
        {               
            BinaryFormatter formatter = new();
            FileStream fs = new(Application.StartupPath + "Pool.csv", FileMode.Create, FileAccess.Write);

            #pragma warning disable SYSLIB0011 // Typ oder Element ist veraltet
            formatter.Serialize(fs, pAktien);
            #pragma warning restore SYSLIB0011 // Typ oder Element ist veraltet
            fs.Close();            
        }

        public List<Aktie> LoadObj()
        {
            BinaryFormatter formatter = new();
            FileStream fs = new(Application.StartupPath + "Pool.csv", FileMode.Open, FileAccess.Read);
            #pragma warning disable SYSLIB0011 // Typ oder Element ist veraltet
            Aktien = new((List<Aktie>)formatter.Deserialize(fs));
            #pragma warning restore SYSLIB0011 // Typ oder Element ist veraltet
            fs.Close();            
            return Aktien;  
        }

        public static ReturnForUebersicht Uebersicht(List<Aktie> pAktien, string pVon, string pBis)
        {
            pVon = pVon.Replace('.', '/');
            pBis = pBis.Replace('.', '/');
            
            List<Aktie> list = new();
            // Alle Kauf Aktien miteinandner verrechnen            
            foreach (Aktie a in pAktien)
            {                
                string cName = a.Name;

                if (list.Count == 0 && a.Aktion == "Kauf")
                {
                    list.Add(a);
                    continue;
                }

                bool Vorhanden = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Name == cName && a.Aktion == "Kauf" && list[i].MetaID == a.MetaID)
                    {                        
                        list[i].Kurs = ((list[i].Kurs * list[i].NAktien) + (a.Kurs * a.NAktien)) / (list[i].NAktien + a.NAktien);
                        list[i].Kosten += a.Kosten;
                        list[i].NAktien += a.NAktien;                        
                        list[i].Datum = a.Datum;
                        list[i].EingesetztesKap += a.Kurs * a.NAktien;
                        Vorhanden = true;
                    }
                }
                if (!Vorhanden && a.Aktion == "Kauf")
                {
                    list.Add(a);
                }                
            }

            // Alle Käufe mit den Verkäufen verrechnen
            foreach (Aktie a in pAktien)
            {
                for (int i = 0;i < list.Count; i++)
                {
                    if (list[i].Name == a.Name && a.Aktion == "Verkauf" && list[i].MetaID == a.MetaID)
                    {
                        if (list[i].NAktien - a.NAktien >= 0)
                        {
                            list[i].NAktien -= a.NAktien;
                            list[i].Kosten += a.Kosten;
                            list[i].Ernte += a.NAktien * (a.Kurs - list[i].Kurs);
                            list[i].Datum = a.Datum;
                            if (list[i].NAktien == 0) list[i].Aktiv = false;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Du hast zu viel verkauft. Der Verkauf von {0} überschreitet die Anzahl der noch übrigen {0} AKtien." + Environment.NewLine + "Bitte ändere zuerst die Werte, bevor du erneut auf Übersicht klickst.", a.Name);
                            return null;
                        }
                    }
                }
            }

            List<Aktie> ResultList = new();
            // Liste aufräumen
            foreach (Aktie a in list)
            {
                string cAktieDatum = a.Datum.Replace('.', '/');                
                DateTime dtVon = DateTime.ParseExact(pVon, "dd/MM/yyyy", CultureInfo.InvariantCulture).Date;
                DateTime dtBis = DateTime.ParseExact(pBis, "dd/MM/yyyy", CultureInfo.InvariantCulture).Date;                
                DateTime dtVerkauf = DateTime.ParseExact(cAktieDatum, "dd/MM/yyyy", CultureInfo.InvariantCulture).Date;                

                // Alle Verkauf Aktien im Zeitraum
                if (DateTime.Compare(dtVon, dtVerkauf) <= 0 && DateTime.Compare(dtBis, dtVerkauf) >= 0)
                {
                    ResultList.Add(a);
                }                
                if (a.Aktiv == false && DateTime.Compare(dtBis, dtVerkauf) <= 0)
                {
                    ResultList.Add(a);
                }
            }

            double GesKapital = 0;
            double GesKosten = 0;
            foreach (Aktie a in ResultList)
            {
                GesKapital += a.EingesetztesKap;
                GesKosten += a.Kosten;                
            }

            double GesGewinn = 0;
            for (int i = 0; i < ResultList.Count; i++)
            {
                GesGewinn += ResultList[i].Ernte;
            }

            ReturnForUebersicht output = new(ResultList, GesGewinn, GesKosten, GesKapital);            
            return output;
        }        
        
        public static int CheckForMeta(List<Aktie> paktien, Aktie paktie)    // Noch nicht auf richtigkeit geprüft    // Liste muss erst nach Datum sortiert werden
        {
            List<Aktie> list = new();
            
            paktien = SortByDate(paktien);
            
            // Wegen der Verweisung von Objekten (referenz) muss ich das Objekt klonen um so nicht das eigentliche Objekt zu verändern
            List<Aktie> temp = new();
            foreach (Aktie a in paktien)
            {
                Aktie tempa = new(a.Name, a.Datum, a.Aktion, a.Kosten, a.Kurs, a.NAktien);
                tempa.Aktiv = a.Aktiv;
                tempa.Ernte = a.Ernte;
                tempa.EingesetztesKap = a.EingesetztesKap;
                tempa.MetaID = a.MetaID;
                temp.Add(tempa);
            }

            // Alle Kauf Aktien miteinandner verrechnen            
            foreach (Aktie a in temp)
            {                
                if (list.Count == 0 && a.Aktion == "Kauf" && a.Name ==  paktie.Name)
                {
                    list.Add(a);
                    break;
                }                
            }
            
            foreach (Aktie a in temp)
            {
                bool Vorhanden = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Name == a.Name && a.Aktion == "Kauf")
                    {
                        if (list[i].Aktiv == false)
                        {
                            a.MetaID += 1;
                        }
                        list[i].Kurs = ((list[i].Kurs * list[i].NAktien) + (a.Kurs * a.NAktien)) / (list[i].NAktien + a.NAktien);
                        list[i].Kosten += a.Kosten;
                        list[i].NAktien += a.NAktien;
                        list[i].Datum = a.Datum;
                        list[i].EingesetztesKap += a.Kurs * a.NAktien;
                        Vorhanden = true;
                        continue;
                    }

                    if (list[i].NAktien - a.NAktien >= 0 && list[i].Name == a.Name && a.Aktion == "Verkauf")
                    {
                        list[i].NAktien -= a.NAktien;
                        list[i].Kosten += a.Kosten;
                        list[i].Ernte += a.NAktien * (a.Kurs - list[i].Kurs);
                        list[i].Datum = a.Datum;
                        if (list[i].NAktien == 0)
                        {
                            list[i].Aktiv = false;
                        }
                        break;
                    }                    
                }
                if (!Vorhanden && a.Aktion == "Kauf")
                {
                    list.Add(a);
                }
            }
            int ID = 1;
            foreach (Aktie a in list)
            {
                if (a.MetaID > ID) ID += 1;
            }            
            return ID;
        }

        public static List<Aktie> SortByDate(List<Aktie> aktien)
        {
            bool änderung = true;
            while (änderung == true)
            {                
                änderung = false;
                DateTime tempDt = DateTime.ParseExact(aktien[0].Datum.Replace('.', '/'), "dd/MM/yyyy", CultureInfo.InvariantCulture).Date;
                for (int i = 1; i < aktien.Count; i++)
                {
                    DateTime currentDt = DateTime.ParseExact(aktien[i].Datum.Replace('.', '/'), "dd/MM/yyyy", CultureInfo.InvariantCulture).Date;
                    if (DateTime.Compare(tempDt, currentDt) < 0)
                    {
                        Aktie temp = aktien[i - 1];
                        aktien[i - 1] = aktien[i];
                        aktien[i] = temp;
                        änderung = true;
                    }
                    else if (DateTime.Compare(tempDt, currentDt) == 0)
                    {
                        if (aktien[i].Aktion == "Kauf" && aktien[i - 1].Aktion == "Verkauf")
                        {
                            Aktie temp = aktien[i - 1];
                            aktien[i - 1] = aktien[i];
                            aktien[i] = temp;
                            änderung = true;
                        }
                    }
                }
            }
            return aktien;
        }
    }

    [Serializable]
    public class Aktie : Pool
    {        
        public string Name { get; set; }
        public string Datum { get; set; }        
        public string Aktion { get; set; }
        public double Kosten { get; set; }
        public double Kurs { get; set; }
        public int NAktien { get; set; }
        public bool Aktiv { get; set; } 
        public double Ernte { get; set; }
        public double EingesetztesKap { get; set; } 
        public int MetaID { get; set; } 

        public Aktie(string pname, string pdatum, string paktion, double pkosten, double pkurs, int pnaktien)
        {
            Name = pname;
            Datum = pdatum;
            Aktion = paktion;
            Kosten = pkosten;
            Kurs = pkurs;
            NAktien = pnaktien;
            Aktiv = true;
            Ernte = 0;
            EingesetztesKap = pkurs * pnaktien;
            MetaID = 1;
        }
    }

    public class ReturnForUebersicht
    {
        public List<Aktie> rAktien;
        public double Gewinn { get; set; }
        public double Kosten { get; set; }  
        public double Kapital { get; set; }

        public ReturnForUebersicht(List<Aktie> pAktien, double pGewinn, double pKosten, double pKapital)
        {
            rAktien = pAktien;
            Gewinn = pGewinn;
            Kosten = pKosten;
            Kapital = pKapital;
        }
    }
}
