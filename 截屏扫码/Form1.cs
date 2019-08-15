using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 截屏扫码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Program.screenBitmap;
            blurMask.BackColor = Color.FromArgb(128, 0, 0, 0);
            txtHint.BackColor = Color.FromArgb(128, 0, 0, 0);
            frontMask.MouseWheel += FrontMask_MouseWheel;
            this.MouseWheel += FrontMask_MouseWheel;
        }

        private void FrontMask_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                size -= 14;
                if (size < 16) { size = 16; }
            }
            else {
                size += 14;
                if (size > Program.maxsize) { size = Program.maxsize; }
            }
            frontMask.Width = size;
            frontMask.Height = size;
        }

        int size = 192;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {
                Application.Exit();
            }
        }

        private void blurMask_MouseMove(object sender, MouseEventArgs e)
        {
            int x = Control.MousePosition.X, y = Control.MousePosition.Y;
            int top = y - size / 2;
            int left = x - size / 2;
            if (top < 0) { top = 0; }
            if (left < 0) { left = 0; }
            if (top + size > Height) { top = Height - size; }
            if (left + size > Width) { left = Width - size; }
            frontMask.Top = top;
            frontMask.Left = left;
            txtHint.Top = top + size + 2;
            txtHint.Left = left;
        }

        private void frontMask_Click(object sender, EventArgs e)
        {
            Bitmap selection = new Bitmap(size, size);
            Graphics gpc = Graphics.FromImage(selection);
            gpc.DrawImage(Program.screenBitmap,new Point(-frontMask.Left,-frontMask.Top));
            gpc.Dispose();
            new BarcodeResultForm(selection).Show();
            Hide(); 
        }
    }
}
