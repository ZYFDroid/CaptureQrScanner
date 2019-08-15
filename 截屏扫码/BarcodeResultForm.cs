using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace 截屏扫码
{
    public partial class BarcodeResultForm : Form
    {
        Bitmap source;

        public BarcodeResultForm(Bitmap source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void BarcodeResultForm_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = source;
            try {
                BarcodeReader reader = new BarcodeReader();
                reader.AutoRotate = true;
                Result result= reader.Decode(source);

                textBox1.Text = result.Text;
            } catch { }
        }

        private void BarcodeResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
