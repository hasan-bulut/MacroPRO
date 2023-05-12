using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroPRO
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void MainCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        bool formDrag;
        int clickX = 0, clickY = 0;
        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            formDrag = true;
            clickX = e.X;
            clickY = e.Y;

        }

        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            formDrag = false;
        }
        int mouseX = 0, mouseY = 0;

        private void Settings_CloseButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
            SettingsButton.Enabled = true;

            for (int i = 0; i < settings.Count; i++)
            {
                SettingsPanel.Controls.RemoveByKey(i.ToString());
                SettingsPanel.Controls.RemoveByKey("setting" + i.ToString());
            }
                SettingsPanel.Controls.RemoveByKey("settingsSave_btn");
        }

        List<List<String>> settings = new List<List<String>>()
        {
            new List<String> { "CPS Göstergesi", "Kapalı" } ,
            new List<String> { "asfsaf", "Açık" } ,
            new List<String> { "asgfasg", "Açık" }
        };

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            SettingsButton.Enabled = false;

            for (int i = 0; i < settings.Count; i++)
            {
                ToggleButton toggle = new ToggleButton();
                toggle.Location = new Point(10, 50 + (40 * i));
                toggle.Size = new Size(50, 25);
                toggle.Click += Toggle_Click;
                toggle.Name = i.ToString();
                toggle.Checked = settings[i][1] == "Açık" ? true : false;

                Label label = new Label();
                label.Text = settings[i][0] + " " + settings[i][1];
                label.Font = new Font("Play", 10);
                label.AutoSize = true;
                label.Location = new Point(60, 50 + (40 * i));
                label.Name = "setting" + i.ToString();

                SettingsPanel.Controls.Add(label);
                SettingsPanel.Controls.Add(toggle);
            }
            Button btn = new Button();
            btn.Name = "settingsSave_btn";
            btn.Text = "Değişiklikleri Kaydet";
            btn.Font = new Font("Play", 10);
            btn.ForeColor = Color.White;
            btn.BackColor = Color.IndianRed;
            btn.Size = new Size(100, 50);
            btn.Location = new Point(100, 250);
            btn.Enabled = false;
            btn.Click += Btn_Click;

            SettingsPanel.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            for (int i = 0; i < settings.Count; i++)
            {
                ToggleButton toggleButton = (ToggleButton)SettingsPanel.Controls[i.ToString()];
                settings[i][1] = toggleButton.Checked ? "Açık" : "Kapalı";

            }
            Settings_CloseButton_Click(sender, e);
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            ToggleButton senderToggle = (ToggleButton)sender;
            //settings[Convert.ToInt32(senderToggle.Name)][1] = senderToggle.Checked ? "Açık" : "Kapalı";
            SettingsPanel.Controls["setting" + senderToggle.Name].Text = settings[Convert.ToInt32(senderToggle.Name)][0] + " " + (senderToggle.Checked ? "Açık" : "Kapalı");

            int sayi = 0;
            for (int i = 0; i < settings.Count; i++)
            {
                ToggleButton toggleButton = (ToggleButton)SettingsPanel.Controls[i.ToString()];
                bool toggleButton2 = settings[i][1] == "Açık" ? true : false;

                if (toggleButton.Checked == toggleButton2)
                {
                    sayi++;
                }
            }
            if (sayi == settings.Count)
            {
                SettingsPanel.Controls["settingsSave_btn"].Enabled = false;
            }
            else
            {
                SettingsPanel.Controls["settingsSave_btn"].Enabled = true;
            }
        }
        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X - mouseX;
            mouseY = e.Y - mouseY;
            if (formDrag)
            {
                this.Location = new Point(this.Location.X + mouseX - clickX, this.Location.Y + mouseY - clickY);
            }
            mouseX = 0;
            mouseY = 0;
        }
    }
}
