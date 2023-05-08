namespace MacroPRO
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.Title = new System.Windows.Forms.Label();
            this.MainCloseButton = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingTitle = new System.Windows.Forms.Label();
            this.Settings_CloseButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.IndianRed;
            this.Title.Font = new System.Drawing.Font("Play", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(800, 50);
            this.Title.TabIndex = 0;
            this.Title.Text = "MacroPRO";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // MainCloseButton
            // 
            this.MainCloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.MainCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("MainCloseButton.Image")));
            this.MainCloseButton.Location = new System.Drawing.Point(750, 5);
            this.MainCloseButton.Name = "MainCloseButton";
            this.MainCloseButton.Size = new System.Drawing.Size(40, 40);
            this.MainCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainCloseButton.TabIndex = 1;
            this.MainCloseButton.TabStop = false;
            this.MainCloseButton.Click += new System.EventHandler(this.MainCloseButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.IndianRed;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(10, 5);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(40, 40);
            this.SettingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.LightCoral;
            this.SettingsPanel.Controls.Add(this.Settings_CloseButton);
            this.SettingsPanel.Controls.Add(this.SettingTitle);
            this.SettingsPanel.Location = new System.Drawing.Point(200, 75);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(400, 400);
            this.SettingsPanel.TabIndex = 3;
            this.SettingsPanel.Visible = false;
            // 
            // SettingTitle
            // 
            this.SettingTitle.BackColor = System.Drawing.Color.IndianRed;
            this.SettingTitle.Font = new System.Drawing.Font("Play", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SettingTitle.ForeColor = System.Drawing.Color.Gold;
            this.SettingTitle.Location = new System.Drawing.Point(0, 0);
            this.SettingTitle.Name = "SettingTitle";
            this.SettingTitle.Size = new System.Drawing.Size(400, 40);
            this.SettingTitle.TabIndex = 0;
            this.SettingTitle.Text = "Ayarlar";
            this.SettingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings_CloseButton
            // 
            this.Settings_CloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.Settings_CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("Settings_CloseButton.Image")));
            this.Settings_CloseButton.Location = new System.Drawing.Point(350, 0);
            this.Settings_CloseButton.Name = "Settings_CloseButton";
            this.Settings_CloseButton.Size = new System.Drawing.Size(40, 40);
            this.Settings_CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings_CloseButton.TabIndex = 2;
            this.Settings_CloseButton.TabStop = false;
            this.Settings_CloseButton.Click += new System.EventHandler(this.Settings_CloseButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.MainCloseButton);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.MainCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Settings_CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox MainCloseButton;
        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label SettingTitle;
        private System.Windows.Forms.PictureBox Settings_CloseButton;
    }
}