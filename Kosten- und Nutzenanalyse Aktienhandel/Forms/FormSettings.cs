using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosten__und_Nutzenanalyse_Aktienhandel.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            TbSpeicherordner.Text = Properties.Settings.Default.Speicherpfad;
        }

        private void BtnFileBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new();
            fbd.SelectedPath = Convert.ToString(Application.StartupPath); // Environment.SpecialFolder.MyDocuments;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.Speicherpfad = fbd.SelectedPath;
                Properties.Settings.Default.Save();
            }
            else
            {
                return;
            }
        }
    }
}
