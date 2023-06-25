using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSR_Lab_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point start_position;
        Point current_position;

        class fire_force
        {
            double[] fuzzy_arr = new double[] { 0, 0, 0, 0 };
            double dx = 0;
            double dy = 0;

            public void fuzzyfication(int current_range_x, int current_range_y, int start_range_x, int start_range_y)
            {
                dx = Convert.ToDouble(Math.Abs(current_range_x)) / Convert.ToDouble(Math.Abs(start_range_x));
                dy = Convert.ToDouble(Math.Abs(current_range_y)) / Convert.ToDouble(Math.Abs(start_range_y));
            }

            public int[] defuzzyfication(int speed)
            {
                int[] output = new int[] { 0, 0 };
                output[0] = Convert.ToInt32(fuzzy_arr[0] * speed);
                output[1] = Convert.ToInt32(fuzzy_arr[1] * speed);
                if (fuzzy_arr[2] == 1)
                {
                    output[0] = output[0] * -1;
                }
                if (fuzzy_arr[3] == 1)
                {
                    output[1] = output[1] * -1;
                }
                return output;
            }

            public void membership_function(int current_range_x, int current_range_y)
            {

                fuzzy_arr[0] = Math.Sqrt(dx);
                fuzzy_arr[1] = Math.Sqrt(dy);

                if (current_range_x < 0)
                {
                    fuzzy_arr[2] = 1;
                }
                if (current_range_y < 0)
                {
                    fuzzy_arr[3] = 1;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drone_picture_box.BringToFront();
            bottle_picture_box.BringToFront();
            start_position = new Point(fire_picture_box.Location.X - drone_picture_box.Location.X, fire_picture_box.Location.Y - drone_picture_box.Location.Y);
        }

        private void up_button_Click(object sender, EventArgs e)
        {
            drone_picture_box.Location = new Point(drone_picture_box.Location.X, drone_picture_box.Location.Y - 10);
            bottle_picture_box.Location = new Point(bottle_picture_box.Location.X, bottle_picture_box.Location.Y - 10);
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            drone_picture_box.Location = new Point(drone_picture_box.Location.X - 10, drone_picture_box.Location.Y);
            bottle_picture_box.Location = new Point(bottle_picture_box.Location.X - 10, bottle_picture_box.Location.Y);
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            drone_picture_box.Location = new Point(drone_picture_box.Location.X + 10, drone_picture_box.Location.Y);
            bottle_picture_box.Location = new Point(bottle_picture_box.Location.X + 10, bottle_picture_box.Location.Y);
        }

        private void down_button_Click(object sender, EventArgs e)
        {
            drone_picture_box.Location = new Point(drone_picture_box.Location.X, drone_picture_box.Location.Y + 10);
            bottle_picture_box.Location = new Point(bottle_picture_box.Location.X, bottle_picture_box.Location.Y + 10);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.A)
            {
                left_button_Click(left_button, null);
                check_position();
            }

            if (e.KeyValue == (char)Keys.W)
            {
                up_button_Click(up_button, null);
                check_position();
            }

            if (e.KeyValue == (char)Keys.S)
            {
                down_button_Click(down_button, null);
                check_position();
            }

            if (e.KeyValue == (char)Keys.D)
            {
                right_button_Click(right_button, null);
                check_position();
            }

            if (e.KeyValue == (char)Keys.R)
            {
                restart_button_Click(restart_button, null);
            }

            if (e.KeyValue == (char)Keys.Space)
            {
                extinguish_button_Click(extinguish_button, null);
            }

            if (e.KeyValue == (char)Keys.I)
            {
                info_button_Click(info_button, null);
            }
        }

        private void extinguish_button_Click(object sender, EventArgs e)
        {
            if (message_label.Text == "Цель рядом!")
            {
                bottle_picture_box.Visible = false;
                fire_picture_box.Visible = false;
                message_label.Text = "Пожар потушен!";
                extinguish_button.Enabled = false;
            }
            else
            {
                MessageBox.Show("Нужно подлететь ближе!");
            }
        }

        private void check_position()
        {
            if (drone_picture_box.Location.X < 0)
            {
                drone_picture_box.Location = new Point(0, drone_picture_box.Location.Y);
                bottle_picture_box.Location = new Point(9, bottle_picture_box.Location.Y);
            }

            if (drone_picture_box.Location.X > this.Width - drone_picture_box.Width)
            {
                drone_picture_box.Location = new Point(this.Width - drone_picture_box.Width, drone_picture_box.Location.Y);
                bottle_picture_box.Location = new Point(this.Width - bottle_picture_box.Width, bottle_picture_box.Location.Y);
            }

            if (drone_picture_box.Location.Y < 0)
            {
                drone_picture_box.Location = new Point(drone_picture_box.Location.X, 0);
            }

            if (bottle_picture_box.Location.Y < drone_picture_box.Height)
            {
                bottle_picture_box.Location = new Point(bottle_picture_box.Location.X, drone_picture_box.Height);
            }

            if (drone_picture_box.Location.Y > this.Height - drone_picture_box.Height - bottle_picture_box.Height)
            {
                drone_picture_box.Location = new Point(drone_picture_box.Location.X, this.Height - drone_picture_box.Height - bottle_picture_box.Height);
            }

            if (bottle_picture_box.Location.Y > this.Height - bottle_picture_box.Height)
            {
                bottle_picture_box.Location = new Point(bottle_picture_box.Location.X, this.Height - bottle_picture_box.Height);
            }

            if (drone_picture_box.Location.X < 400)
            {
                message_label.Text = "Цель далеко!";
            }

            if (drone_picture_box.Location.X > 400 && drone_picture_box.Location.X < 550)
            {
                message_label.Text = "Цель впереди!";
            }

            if (drone_picture_box.Location.Y > 300 && drone_picture_box.Location.X > 500)
            {
                message_label.Text = "Цель выше!";
            }

            if (drone_picture_box.Location.Y < 30 && drone_picture_box.Location.X > 500)
            {
                message_label.Text = "Цель ниже!";
            }

            if (drone_picture_box.Location.Y > 70 &&  drone_picture_box.Location.Y < 135 && drone_picture_box.Location.X > 560)
            {
                message_label.Text = "Цель рядом!";
            }
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Управление: \nW - лететь вверх \nA - лететь влево \nS - лететь вниз \nD - лететь вправо \nR - рестарт \nSpace - потушить пожар");
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            drone_picture_box.Location = new Point(12, 559);
            bottle_picture_box.Location = new Point(21, 578);
            bottle_picture_box.Visible = true;
            fire_picture_box.Visible = true;
            extinguish_button.Enabled = true;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            fire_force drone_firefighter = new fire_force();

            while (fire_picture_box.Visible == true)
            {
                current_position = new Point(fire_picture_box.Location.X - drone_picture_box.Location.X, fire_picture_box.Location.Y - drone_picture_box.Location.Y);
                drone_firefighter.fuzzyfication(current_position.X, current_position.Y, start_position.X, start_position.Y);
                drone_firefighter.membership_function(current_position.X, current_position.Y);
                int[] speed = drone_firefighter.defuzzyfication(7);
                drone_picture_box.Location = new Point(drone_picture_box.Location.X + speed[0], drone_picture_box.Location.Y + speed[1]);
                bottle_picture_box.Location = new Point(bottle_picture_box.Location.X + speed[0], bottle_picture_box.Location.Y + speed[1]);               

                if (fire_picture_box.Location.Y + 25 >= drone_picture_box.Location.Y && fire_picture_box.Location.Y - 25 <= drone_picture_box.Location.Y
    && fire_picture_box.Location.X + 25 >= drone_picture_box.Location.X && fire_picture_box.Location.X - 80 <= drone_picture_box.Location.X)
                {
                    bottle_picture_box.Visible = false;
                    fire_picture_box.Visible = false;
                    message_label.Text = "Пожар потушен!";
                    extinguish_button.Enabled = false;
                }
                System.Threading.Thread.Sleep(25);
            }
        }
    }
}
