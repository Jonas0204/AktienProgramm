namespace Kosten__und_Nutzenanalyse_Aktienhandel.Forms
{
    partial class FormSettings
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
            this.panelSettings = new System.Windows.Forms.Panel();
            this.BtnFileBrowser = new FontAwesome.Sharp.IconButton();
            this.TbSpeicherordner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.BtnFileBrowser);
            this.panelSettings.Controls.Add(this.TbSpeicherordner);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(800, 450);
            this.panelSettings.TabIndex = 0;
            // 
            // BtnFileBrowser
            // 
            this.BtnFileBrowser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.BtnFileBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFileBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.BtnFileBrowser.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.BtnFileBrowser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.BtnFileBrowser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFileBrowser.IconSize = 28;
            this.BtnFileBrowser.Location = new System.Drawing.Point(679, 57);
            this.BtnFileBrowser.Name = "BtnFileBrowser";
            this.BtnFileBrowser.Size = new System.Drawing.Size(26, 26);
            this.BtnFileBrowser.TabIndex = 3;
            this.BtnFileBrowser.UseVisualStyleBackColor = true;
            this.BtnFileBrowser.Click += new System.EventHandler(this.BtnFileBrowser_Click);
            // 
            // TbSpeicherordner
            // 
            this.TbSpeicherordner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.TbSpeicherordner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSpeicherordner.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbSpeicherordner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TbSpeicherordner.Location = new System.Drawing.Point(24, 57);
            this.TbSpeicherordner.Name = "TbSpeicherordner";
            this.TbSpeicherordner.Size = new System.Drawing.Size(649, 26);
            this.TbSpeicherordner.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speicherordner:";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSettings);
            this.Name = "FormSettings";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.TextBox TbSpeicherordner;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnFileBrowser;
    }
}