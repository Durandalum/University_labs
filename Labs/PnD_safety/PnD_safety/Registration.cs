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
    public partial class Registration : Form
    {

        const string ConStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Дима\Documents\LogInData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        public Registration()
        {
            InitializeComponent();
            PasswordTBox.PasswordChar = '*';
            PasswordRepeatTBox.PasswordChar = '*';
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Разное\Visual Studio 2010\Projects\PnD_safety\LogInData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter Sda = new SqlDataAdapter("SELECT Count (*) FROM LoginPassword WHERE Login = '" + LoginTBox.Text + "'", Connection);
            DataTable Dt = new DataTable();
            Sda.Fill(Dt);
            if (Dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Этот логин уже занят. Пожалуйста, выберите другой.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordTBox.Text == PasswordRepeatTBox.Text)
            {
                if (LoginTBox.Text != "" && PasswordTBox.Text != "")
                {
                    string Query = "INSERT INTO LoginPassword (Login, Password) VALUES ('" + LoginTBox.Text + "' , '" + PasswordTBox.Text + "');";
                    try
                    {
                        using (SqlConnection Con = new SqlConnection(ConStr))
                        {
                            Con.Open();
                            SqlCommand Com = new SqlCommand(Query, Con);
                            Com.ExecuteNonQuery();
                        }
                        MessageBox.Show("Регистрация прошла успешно!");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Что-то пошло не так...", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Необходимо заполнить поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Пароли не совпадают!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
