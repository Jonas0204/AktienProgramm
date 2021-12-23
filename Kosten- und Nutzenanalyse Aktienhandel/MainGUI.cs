using System;
using System.Drawing;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Diagnostics;

namespace Kosten__und_Nutzenanalyse_Aktienhandel.Forms
{
    public partial class MainGUI : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(44, 47, 51), ButtonBorderStyle.Solid);
        }

        public MainGUI()
        {
            InitializeComponent();
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 50)
            };
            panelMenu.Controls.Add(leftBorderBtn);
            //Oberen Rand der Form entfernen
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //this.FormBorderStyle = ;
        } 

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241); 
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        
        private void Btn_Press(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                Btn_Disable();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                //linke seite Btn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Überschrift und derzeitiges icon ändern
                CurrentFormIcon.IconChar = currentBtn.IconChar;
                CurrentFormIcon.IconColor = color;
            }
        }

        private void Btn_Disable()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(44, 47, 51);
                currentBtn.ForeColor = Color.DarkGray;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(114, 137, 218);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //Nur eins Öffnen
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.Show();
            lblHeader.Text = childForm.Text;
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome());
            Updater();
        }

        private static async void Updater()
        {
            try
            {
                bool con = NetworkInterface.GetIsNetworkAvailable();
                if (con == true)
                {
                    HttpClient client = new();

                    double t;
                    double version = Convert.ToDouble(Assembly.GetExecutingAssembly().GetName().Version.ToString());
                    string url = "http://jonas-prog.bplaced.net/updates/programms/versions/version_Aktien.txt";

                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        using HttpContent content = response.Content;
                        t = Convert.ToDouble(content.ReadAsStringAsync().Result);
                    }

                    if (t == version)
                    {
                        //MessageBox.Show("Kein Update verfügbar!");
                    }
                    else if (t > version)
                    {
                        if (MessageBox.Show("Es ist ein neues Update verfügbar!" + Environment.NewLine + "Möchten sie das Update installieren?", "Update Installieren", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string pid = Convert.ToString(Environment.ProcessId.ToString());
                            string filedownload = "http://jonas-prog.bplaced.net/updates/programms/";
                            string path = Environment.CurrentDirectory;
                            string filename = Process.GetProcessById(Convert.ToInt32(pid)).ProcessName + ".exe";
                            Process.Start(path + "\\Updater.exe", "\"" + path + "\"" + " " + "\"" + filename + "\"" + " " + "\"" + pid + "\"" + " " + "\"" + filedownload + "\"");
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Btn_Press(sender, RGBColors.color2);
            OpenChildForm(new FormDashboard());
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Btn_Press(sender, RGBColors.color3);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Btn_Press(sender, RGBColors.color4);
            Application.Exit();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {            
            Reset();
            OpenChildForm(new FormHome());
        }

        private void Reset()
        {
            Btn_Disable();
            leftBorderBtn.Visible = false;
            CurrentFormIcon.IconChar = IconChar.Home;
            CurrentFormIcon.IconColor = Color.FromArgb(114, 137, 218);
            lblHeader.Text = "Home";
        }

        //From ziehen
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnTopExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void BtnMaximise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
