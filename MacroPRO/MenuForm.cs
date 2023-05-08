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
        }

        List<List<String>> settings = new List<List<String>>()
        {
            new List<String> { "CPS Göstergesi", "Kapalı" } ,
            new List<String> { "asfsaf", "Kapalı" } ,
            new List<String> { "asgfasg", "Açık" }
        };
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            SettingsButton.Enabled = false;

            for (int i = 0; i < settings.Count; i++)
            {
                ToggleButton toggle = new ToggleButton();
                toggle.Location = new Point(10, 50 + (25 * i));
                toggle.Size = new Size(50, 25);
                toggle.CheckedChanged += Toggle_CheckedChanged;
                toggle.Name = i.ToString();
                //toggle.Checked = settings[i][1] == "Açık" ? true : false;

                Label label = new Label();
                label.Text = settings[i][0] + " " + settings[i][1];
                label.Font = new Font("Play", 10);
                label.AutoSize = true;
                label.Location = new Point(60, 50 + (25 * i));
                label.Name = "setting" + i.ToString();

                SettingsPanel.Controls.Add(toggle);
                SettingsPanel.Controls.Add(label);
            }
        }

        private void Toggle_CheckedChanged(object sender, EventArgs e)
        {
            ToggleButton senderToggle = (ToggleButton)sender;

            settings[Convert.ToInt32(senderToggle.Name)][1] = senderToggle.Checked ? "Açık" : "Kapalı";
            SettingsPanel.Controls["setting" + senderToggle.Name].Text = settings[Convert.ToInt32(senderToggle.Name)][0] + " " + settings[Convert.ToInt32(senderToggle.Name)][1];
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
