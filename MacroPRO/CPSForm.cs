using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroPRO
{
    public partial class CPSForm : Form
    {
        public CPSForm()
        {
            InitializeComponent();
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;
            Process[] ps = Process.GetProcessesByName("Discord");
            label1.Text = ps.Length.ToString();
            Process minecraftProcess = ps.FirstOrDefault();
        }
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public static void Move(int xDelta, int yDelta)
        {
            mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
        }
        public static void MoveTo(int x, int y)
        {
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
        }
        public void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        public static void LeftDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        public static void LeftUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        public static void RightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        public static void RightDown()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        public static void RightUp()
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
            LeftClick();
        }
        bool a;
        int cpsSayar = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a != (Control.MouseButtons == MouseButtons.Left) && Control.MouseButtons == MouseButtons.Left)
            {
                //macro();
                a = (Control.MouseButtons == MouseButtons.Left);
                cpsSayar++;
                silici();
            }
            else
            {
                a = (Control.MouseButtons == MouseButtons.Left);

            }
            label1.Text = cpsSayar.ToString();

        }
        async Task silici()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                cpsSayar--;
            });
        }

        async Task macro()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    LeftClick();
                }
            });
        }
    }
}