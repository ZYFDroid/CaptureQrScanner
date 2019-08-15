using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 截屏扫码
{
    static class Program
    {
        public static Bitmap screenBitmap;
        public static int maxsize = 768;
        [STAThread]
        static void Main()
        {
            Size screenSize = Screen.PrimaryScreen.Bounds.Size;
            screenBitmap = new Bitmap(screenSize.Width,screenSize.Height);
            Graphics gpc = Graphics.FromImage(screenBitmap);
            gpc.CopyFromScreen(0, 0, 0, 0, screenSize);
            gpc.Dispose();

            maxsize = Math.Min(screenBitmap.Width,screenBitmap.Height);

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
