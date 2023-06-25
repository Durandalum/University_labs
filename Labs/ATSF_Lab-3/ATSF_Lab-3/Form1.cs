using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Data.OleDb;



namespace ATSF_Lab_3
{
    public partial class Form1 : Form
    {
        public string Imgread = "G:\\Visual Studio 2010\\Projects\\ATSF_Lab-3\\ATSF_Lab-3\\Program\\Image\\0.jpg";
        public string Txtread = "G:\\Visual Studio 2010\\Projects\\ATSF_Lab-3\\ATSF_Lab-3\\Program\\Text\\HW.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "App";
        }

        static string Tblread = "G:\\Visual Studio 2010\\Projects\\ATSF_Lab-3\\ATSF_Lab-3\\Program\\Table";
        string TBLFilename = Path.Combine(Tblread, "session.mdb");
        string connectionString;
        bool connected = false;

        private void LoadPicture_Click(object sender, EventArgs e)
        {
            pictureBox.Image = new Bitmap(Imgread);
            Refresh();
        }

        private void LoadText_Click_1(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader(Txtread);
            string Str = SR.ReadLine();
            while (Str != null)
            {
                richTextBox.Text += Str + "\n";
                Str = SR.ReadLine();
            }
            SR.Close();
        }

        private void LoadTable_Click(object sender, EventArgs e)
        {
            connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + TBLFilename;
            string command = "SELECT Фамилия, Группа, Дисциплина, Оценка FROM [Session]";
            connected = true;
            Text = "ATSF_Lab-3";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(command, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Session");
                dataGridView.DataSource = dataSet;
            }
            dataGridView.DataMember = "Session";
        }

    }
}
