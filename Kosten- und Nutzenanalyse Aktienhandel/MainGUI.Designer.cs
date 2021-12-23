namespace Kosten__und_Nutzenanalyse_Aktienhandel.Forms
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.BtnSettings = new FontAwesome.Sharp.IconButton();
            this.BtnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.BtnMinimise = new FontAwesome.Sharp.IconButton();
            this.BtnMaximise = new FontAwesome.Sharp.IconButton();
            this.BtnTopExit = new FontAwesome.Sharp.IconButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.CurrentFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelHeaderShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentFormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.BtnExit);
            this.panelMenu.Controls.Add(this.BtnSettings);
            this.panelMenu.Controls.Add(this.BtnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 623);
            this.panelMenu.TabIndex = 2;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.BtnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(0, 200);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(200, 50);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnSettings.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.BtnSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.BtnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.Location = new System.Drawing.Point(0, 150);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(200, 50);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDashboard.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnDashboard.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.BtnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.BtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 100);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(200, 50);
            this.BtnDashboard.TabIndex = 5;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.BtnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 3;
            // 
            // BtnHome
            // 
            this.BtnHome.Image = global::Kosten__und_Nutzenanalyse_Aktienhandel.Properties.Resources.JHIcon_removebg_preview;
            this.BtnHome.Location = new System.Drawing.Point(50, 15);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(97, 64);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelHeader.Controls.Add(this.BtnMinimise);
            this.panelHeader.Controls.Add(this.BtnMaximise);
            this.panelHeader.Controls.Add(this.BtnTopExit);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.CurrentFormIcon);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1087, 75);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // BtnMinimise
            // 
            this.BtnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimise.FlatAppearance.BorderSize = 0;
            this.BtnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimise.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimise.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.BtnMinimise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimise.IconSize = 40;
            this.BtnMinimise.Location = new System.Drawing.Point(980, 3);
            this.BtnMinimise.Name = "BtnMinimise";
            this.BtnMinimise.Size = new System.Drawing.Size(36, 36);
            this.BtnMinimise.TabIndex = 4;
            this.BtnMinimise.UseVisualStyleBackColor = true;
            this.BtnMinimise.Click += new System.EventHandler(this.BtnMinimise_Click);
            // 
            // BtnMaximise
            // 
            this.BtnMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximise.FlatAppearance.BorderSize = 0;
            this.BtnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximise.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximise.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.BtnMaximise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximise.IconSize = 40;
            this.BtnMaximise.Location = new System.Drawing.Point(1015, 3);
            this.BtnMaximise.Name = "BtnMaximise";
            this.BtnMaximise.Size = new System.Drawing.Size(36, 36);
            this.BtnMaximise.TabIndex = 3;
            this.BtnMaximise.UseVisualStyleBackColor = true;
            this.BtnMaximise.Click += new System.EventHandler(this.BtnMaximise_Click);
            // 
            // BtnTopExit
            // 
            this.BtnTopExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTopExit.FlatAppearance.BorderSize = 0;
            this.BtnTopExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTopExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnTopExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.BtnTopExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTopExit.IconSize = 40;
            this.BtnTopExit.Location = new System.Drawing.Point(1051, 3);
            this.BtnTopExit.Name = "BtnTopExit";
            this.BtnTopExit.Size = new System.Drawing.Size(36, 36);
            this.BtnTopExit.TabIndex = 2;
            this.BtnTopExit.UseVisualStyleBackColor = true;
            this.BtnTopExit.Click += new System.EventHandler(this.BtnTopExit_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkGray;
            this.lblHeader.Location = new System.Drawing.Point(96, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(97, 36);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Home";
            // 
            // CurrentFormIcon
            // 
            this.CurrentFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CurrentFormIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.CurrentFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.CurrentFormIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.CurrentFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CurrentFormIcon.IconSize = 50;
            this.CurrentFormIcon.Location = new System.Drawing.Point(19, 15);
            this.CurrentFormIcon.Name = "CurrentFormIcon";
            this.CurrentFormIcon.Size = new System.Drawing.Size(50, 50);
            this.CurrentFormIcon.TabIndex = 0;
            this.CurrentFormIcon.TabStop = false;
            // 
            // panelHeaderShadow
            // 
            this.panelHeaderShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.panelHeaderShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderShadow.Location = new System.Drawing.Point(200, 75);
            this.panelHeaderShadow.Name = "panelHeaderShadow";
            this.panelHeaderShadow.Size = new System.Drawing.Size(1087, 10);
            this.panelHeaderShadow.TabIndex = 4;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 85);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1087, 538);
            this.panelDesktop.TabIndex = 5;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 623);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeaderShadow);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainGUI";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentFormIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnSettings;
        private FontAwesome.Sharp.IconButton BtnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox BtnHome;
        private FontAwesome.Sharp.IconButton BtnExit;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private FontAwesome.Sharp.IconPictureBox CurrentFormIcon;
        private System.Windows.Forms.Panel panelHeaderShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton BtnTopExit;
        private FontAwesome.Sharp.IconButton BtnMinimise;
        private FontAwesome.Sharp.IconButton BtnMaximise;
    }
}