using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace MonguGamerPro
{
    public partial class Form1 : Form
    {
        public const byte VK_NUMLOCK = 0x90;
        public const byte VK_CAPSLOCK = 0x14;
        public const byte VK_SCROLL = 0x91;

        public const byte VK_F13 = 0x7C;
        public const byte VK_F14 = 0x7D;
        public const byte VK_F15 = 0x7E;
        public const byte VK_F16 = 0x7F;
        public const byte VK_F17 = 0x80;
        public const byte VK_F18 = 0x81;
        public const byte VK_F19 = 0x82;
        public const byte VK_F20 = 0x83;
        public const byte VK_F21 = 0x84;
        public const byte VK_F22 = 0x85;
        public const byte VK_F23 = 0x86;
        public const byte VK_F24 = 0x87;

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        const int KEYEVENTF_EXTENDEDKEY = 0x1;
        const int KEYEVENTF_KEYUP = 0x2;
        const int KEYEVENTF_KEYDOWN = 0x0;

        public int delay = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numLockLabelUpdate(Control.IsKeyLocked(Keys.NumLock));
            capsLockLabelUpdate(Control.IsKeyLocked(Keys.CapsLock));
            scrollLockLabelUpdate(Control.IsKeyLocked(Keys.Scroll));
        }

        private void numLockButton_Click(object sender, EventArgs e)
        {
            bool isKeyLocked = Control.IsKeyLocked(Keys.NumLock);

            if (isKeyLocked)
            {
                keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
            else
            {
                keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYDOWN, (UIntPtr)0);
            }

            numLockLabelUpdate(!isKeyLocked);
        }

        private void capsLockButton_Click(object sender, EventArgs e)
        {
            bool isKeyLocked = Control.IsKeyLocked(Keys.CapsLock);

            if (isKeyLocked)
            {
                keybd_event(VK_CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(VK_CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
            else
            {
                keybd_event(VK_CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(VK_CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYDOWN, (UIntPtr)0);
            }

            capsLockLabelUpdate(!isKeyLocked);
        }

        private void scrolLockButton_Click(object sender, EventArgs e)
        {
            bool isKeyLocked = Control.IsKeyLocked(Keys.Scroll);

            if (isKeyLocked)
            {
                keybd_event(VK_SCROLL, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(VK_SCROLL, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
            else
            {
                keybd_event(VK_SCROLL, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(VK_SCROLL, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYDOWN, (UIntPtr)0);
            }

            scrollLockLabelUpdate(!isKeyLocked);
        }

        private void numLockLabelUpdate(bool isKeyLocked)
        {
            if (isKeyLocked)
            {
                numLockLabel.Text = "ON";
                numLockLabel.BackColor = Color.Green;
            }
            else
            {
                numLockLabel.Text = "OFF";
                numLockLabel.BackColor = Color.Red;
            }
        }

        private void capsLockLabelUpdate(bool isKeyLocked)
        {
            if (isKeyLocked)
            {
                capsLockLabel.Text = "ON";
                capsLockLabel.BackColor = Color.Green;
            }
            else
            {
                capsLockLabel.Text = "OFF";
                capsLockLabel.BackColor = Color.Red;
            }
        }

        private void scrollLockLabelUpdate(bool isKeyLocked)
        {
            if (isKeyLocked)
            {
                scrollLockLabel.Text = "ON";
                scrollLockLabel.BackColor = Color.Green;
            }
            else
            {
                scrollLockLabel.Text = "OFF";
                scrollLockLabel.BackColor = Color.Red;
            }
        }

        private void showClockButton_Click(object sender, EventArgs e)
        {

        }

        private void showCrosshairButton_Click(object sender, EventArgs e)
        {

        }

        private void fKeyButton_Click(object sender, EventArgs e)
        {
            Text = ((Button)sender).Text;

            if ((Button)sender == f14Button)
                Text = "Yes";

            delayTextBox.Enabled = false;
            f13Button.Enabled = false;
            f14Button.Enabled = false;
            f15Button.Enabled = false;
            f16Button.Enabled = false;
            f17Button.Enabled = false;
            f18Button.Enabled = false;
            f19Button.Enabled = false;
            f20Button.Enabled = false;
            f21Button.Enabled = false;
            f22Button.Enabled = false;
            f23Button.Enabled = false;
            f24Button.Enabled = false;

            delay = Convert.ToInt32(delayTextBox.Text);
            fKeyTimer.Start();
        }

        private void fKeyTimer_Tick(object sender, EventArgs e)
        {
            int countdown = Convert.ToInt32(delayTextBox.Text);

            if(countdown <= 1)
            {
                delayTextBox.Enabled = true;
                f13Button.Enabled = true;
                f14Button.Enabled = true;
                f15Button.Enabled = true;
                f16Button.Enabled = true;
                f17Button.Enabled = true;
                f18Button.Enabled = true;
                f19Button.Enabled = true;
                f20Button.Enabled = true;
                f21Button.Enabled = true;
                f22Button.Enabled = true;
                f23Button.Enabled = true;
                f24Button.Enabled = true;

                delayTextBox.Text = delay.ToString();
                fKeyTimer.Stop();
            }
            else
            {
                delayTextBox.Text = Convert.ToString(countdown - 1);
            }            
        }

        private void stopDelayButton_Click(object sender, EventArgs e)
        {
            delayTextBox.Text = "0";

            fKeyTimer_Tick(sender, e);
        }

        private string makeNumber(string text)
        {
            string outputText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if("0123456789".Contains(text[i]))
                    outputText += text[i];
            }

            outputText = outputText.TrimStart('0');

            if (outputText == "")
                outputText = "0";

            return outputText;
        }

        private void delayTextBox_Validating(object sender, CancelEventArgs e)
        {
            delayTextBox.Text = makeNumber(delayTextBox.Text);
        }
    }
}
