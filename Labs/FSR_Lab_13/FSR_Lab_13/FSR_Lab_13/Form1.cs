using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSR_Lab_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            restart_button.Enabled = false;
            while (drone_picture_box.Location.X <= 685 - drone_picture_box.Width)
            {
                drone_picture_box.Location = new Point(drone_picture_box.Location.X + 3, drone_picture_box.Location.Y);
                bottle_picture_box.Location = new Point(bottle_picture_box.Location.X + 3, bottle_picture_box.Location.Y);
                System.Threading.Thread.Sleep(25);
            }
            message_label.Visible = false;
            MessageBox.Show("Справа препятствие.");
            while (drone_picture_box.Location.Y >= 150 - drone_picture_box.Height)
            {
                drone_picture_box.Location = new Point(drone_picture_box.Location.X, drone_picture_box.Location.Y - 3);
                bottle_picture_box.Location = new Point(bottle_picture_box.Location.X, bottle_picture_box.Location.Y - 3);
                System.Threading.Thread.Sleep(25);
            }
            MessageBox.Show("Цель находится ниже.");
            while (drone_picture_box.Location.Y <= 280 - drone_picture_box.Height)
            {
                drone_picture_box.Location = new Point(drone_picture_box.Location.X, drone_picture_box.Location.Y + 3);
                bottle_picture_box.Location = new Point(bottle_picture_box.Location.X, bottle_picture_box.Location.Y + 3);
                System.Threading.Thread.Sleep(25);
            }
            MessageBox.Show("Цель обнаружена.");
            bottle_picture_box.Visible = false;
            fire_picture_box.Visible = false;
            MessageBox.Show("Пожар потушен.");
            restart_button.Enabled = true;
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            drone_picture_box.Location = new Point(12, 559);
            bottle_picture_box.Location = new Point(21, 578);
            bottle_picture_box.Visible = true;
            fire_picture_box.Visible = true;
        }
    }
}
