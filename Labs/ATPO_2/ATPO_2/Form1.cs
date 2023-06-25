using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATPO_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "ru")
            {
                pictureBox1.Image = Res.Img.Ru;
            }
            else
            {
                pictureBox1.Image = Res.Img.Eu;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            if (Properties.Settings.Default.Stile == "1")
            {
                black();
            }
            else
            {
                white();
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("ru");
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("ru");
            Properties.Settings.Default.Language = "ru";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void engToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-Us");
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-Us");
            Properties.Settings.Default.Language = "en-Us";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        void black()
        {
            this.BackColor = Color.Black;
            Properties.Settings.Default.Stile = Res.Collors.Black;
            Properties.Settings.Default.Save();
        }
        void white()
        {
            this.BackColor = Color.White;
            Properties.Settings.Default.Stile = Res.Collors.White;
            Properties.Settings.Default.Save();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            black();
        }

        private void wToolStripMenuItem_Click(object sender, EventArgs e)
        {
            white();
        }
    }
}
