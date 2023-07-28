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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void numLockButton_Click(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.NumLock))
            {
                keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);

                numLockLabel.Text = "OFF";
                numLockLabel.BackColor = Color.Red;
            }
            else
            {
                numLockLabel.Text = "ON";
                numLockLabel.BackColor = Color.Green;
            }
        }

        private void capsLockButton_Click(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                keybd_event(VK_CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(VK_CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);

                capsLockLabel.Text = "OFF";
                capsLockLabel.BackColor = Color.Red;
            }
            else
            {
                keybd_event(VK_CAPSLOCK, 0x45, 0, (UIntPtr)0);

                capsLockLabel.Text = "ON";
                capsLockLabel.BackColor = Color.Green;
            }
        }

        private void scrolLockButton_Click(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.Scroll))
            {
                keybd_event(VK_SCROLL, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(VK_SCROLL, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);

                scrollLockLabel.Text = "OFF";
                scrollLockLabel.BackColor = Color.Red;
            }
            else
            {
                scrollLockLabel.Text = "ON";
                scrollLockLabel.BackColor = Color.Green;
            }
        }
    }
}
