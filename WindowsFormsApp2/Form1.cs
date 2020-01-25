using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ScreenSetUp();
        }

        public void PictureInserted()
        {
            pictureBox1.Load(@"C:\Users\joonwoo\Documents\1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void SetTextBox()
        {
            textBox1.Text = "안대웅";
        }

        private void ScreenSetUp()
        {
            GroupBox box = new GroupBoxMaker().NewGroupBox(@"대웅");
            box.Controls.Add(new GroupBoxMaker().NewPictureBox());
            box.Location = new System.Drawing.Point(300, 12);
            box.Size = new System.Drawing.Size(200, 174);
            this.Controls.Add(box);
        }

    }
}
