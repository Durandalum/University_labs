using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            PasswordTBox.PasswordChar = '*';
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            /*if (LoginTBox.Text == "HappyBomber" && PasswordTBox.Text == "Boom")
            {
                MessageBox.Show("Авторизация прошла успешно", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else MessageBox.Show("Неверный логин или пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();*/
            SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Разное\Visual Studio 2010\Projects\PnD_safety\LogInData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter Sda = new SqlDataAdapter("SELECT Count (*) FROM LoginPassword WHERE Login = '" + LoginTBox.Text + "' and Password = '" + PasswordTBox.Text + "'", Con);
            DataTable Dt = new DataTable();
            Sda.Fill(Dt);
            if (Dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Авторизация прошла успешно", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 F1 = new Form1();
                F1.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Неверный логин или пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void RegistrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration Reg = new Registration();
            Reg.Show();
        }
    }
}
