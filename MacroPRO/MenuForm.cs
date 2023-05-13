using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MacroPRO.Properties;
using Newtonsoft.Json;

namespace MacroPRO
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        string filePath = @"E:\settings.json";
        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                var settings = new Dictionary<string, Dictionary<string, string>>();
                settings["cps"] = new Dictionary<string, string>() { { "name", "CPS Göstergesi" }, { "status", "Kapalı" } };
                settings["ayar2"] = new Dictionary<string, string>() { { "name", "ASFASFGSA" }, { "status", "Açık" } };
                settings["ayar3"] = new Dictionary<string, string>() { { "name", "AAAAA" }, { "status", "Kapalı" } };
                settings["settings"] = new Dictionary<string, string>() { { "0", "cps" }, { "1", "ayar2" }, { "2", "ayar3" } };
                string JsonData = JsonConvert.SerializeObject(settings);
                File.WriteAllText(@"E:\settings.json", JsonData);
            }
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

            var settings = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText(@"E:\settings.json"));
            for (int i = 0; i < settings.Count-1; i++)
            {
                SettingsPanel.Controls.RemoveByKey(i.ToString());
                SettingsPanel.Controls.RemoveByKey("setting" + i.ToString());
            }
            SettingsPanel.Controls.RemoveByKey("settingsSave_btn");
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            SettingsButton.Enabled = false;
            var settings = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText(@"E:\settings.json"));
            for (int i = 0; i < settings.Count-1; i++)
            {
                string settingName = settings[settings["settings"][i.ToString()]]["name"];
                string settingStatus = settings[settings["settings"][i.ToString()]]["status"];

                ToggleButton toggle = new ToggleButton();
                toggle.Location = new Point(10, 50 + (40 * i));
                toggle.Size = new Size(50, 25);
                toggle.Click += Toggle_Click;
                toggle.Name = i.ToString();
                toggle.Checked = settingStatus == "Açık" ? true : false;

                Label label = new Label();
                label.Text = settingName + " " + settingStatus;
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

            var settings = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText(@"E:\settings.json"));

            for (int i = 0; i < settings.Count - 1; i++)
            {
                ToggleButton toggleButton = (ToggleButton)SettingsPanel.Controls[i.ToString()];
                settings[settings["settings"][i.ToString()]]["status"] = toggleButton.Checked ? "Açık" : "Kapalı";
            }

            string JsonData = JsonConvert.SerializeObject(settings);
            File.WriteAllText(@"E:\settings.json", JsonData);

            Settings_CloseButton_Click(sender, e);
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            ToggleButton senderToggle = (ToggleButton)sender;
            var settings = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText(@"E:\settings.json"));

            SettingsPanel.Controls["setting" + senderToggle.Name].Text = settings[settings["settings"][senderToggle.Name]]["name"] + " " + (senderToggle.Checked ? "Açık" : "Kapalı");

            int sayi = 0;
            for (int i = 0; i < settings.Count - 1; i++)
            {
                ToggleButton toggleButton = (ToggleButton)SettingsPanel.Controls[i.ToString()];
                bool toggleButton2 = settings[settings["settings"][i.ToString()]]["status"] == "Açık" ? true : false;

                if (toggleButton.Checked == toggleButton2)
                {
                    sayi++;
                }
            }
            if (sayi == settings.Count-1)
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
