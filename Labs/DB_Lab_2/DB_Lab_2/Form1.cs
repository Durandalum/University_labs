using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DB_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String TBoxText;

        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TableComboBox.SelectedItem == "Студенты")
            {
                FieldComboBox.Enabled = true;
                FieldComboBox.Items.Add("Фамилия");
                FieldComboBox.Items.Add("Группа");
                FieldComboBox.Items.Add("Год_поступления");
                FieldComboBox.Items.Add("Рейтинг");
            }
            else if (TableComboBox.SelectedItem == "Кафедры")
            {
                FieldComboBox.Enabled = true;
                FieldComboBox.Items.Add("Название");
                FieldComboBox.Items.Add("Факультет");
                FieldComboBox.Items.Add("Заведующий");
            }
            else if (TableComboBox.SelectedItem == "Группы")
            {
                FieldComboBox.Enabled = true;
                FieldComboBox.Items.Add("Шифр_группы");
                FieldComboBox.Items.Add("Специальность");
                FieldComboBox.Items.Add("Год_поступления");
            }
            else if (TableComboBox.SelectedItem == "Специальности")
            {
                FieldComboBox.Enabled = true;
                FieldComboBox.Items.Add("Код");
                FieldComboBox.Items.Add("Название");
                FieldComboBox.Items.Add("Отрасль знаний");
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FieldComboBox.Enabled = false;
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestTextBox.Visible = true;
            if (RequestComboBox.SelectedItem == "SELECT")
            {
                TBoxText = RequestComboBox.SelectedItem.ToString() + " " + FieldComboBox.SelectedItem.ToString() + " FROM [" + TableComboBox.SelectedItem.ToString() + "] WHERE ";
                RequestTextBox.Text = TBoxText;
            }
            else if (RequestComboBox.SelectedItem == "INSERT INTO") 
            {
                TBoxText = RequestComboBox.SelectedItem.ToString() + " [" + TableComboBox.SelectedItem.ToString() + "] (" + ") VALUES (" + ")";
                RequestTextBox.Text = TBoxText;
            }
            else if (RequestComboBox.SelectedItem == "UPDATE")
            {
                TBoxText = RequestComboBox.SelectedItem.ToString() + " [" + TableComboBox.SelectedItem.ToString() + "] SET   " + " WHERE";
                RequestTextBox.Text = TBoxText;
            }
            else if (RequestComboBox.SelectedItem == "DELETE") 
            {
                TBoxText = RequestComboBox.SelectedItem.ToString() + " [" + TableComboBox.SelectedItem.ToString() + "] WHERE";
                RequestTextBox.Text = TBoxText;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RequestTextBox.Text != "")
            {
                SaveFileDialog SDF = new SaveFileDialog();
                SDF.ShowDialog();
                StreamWriter SW = new StreamWriter(SDF.FileName);
                SW.Write(RequestTextBox.Text);
                SW.Close();
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
            MessageBox.Show(OFD.FileName);
            StreamReader SR = new StreamReader(OFD.FileName);
            string Str = SR.ReadLine();
            while (Str != null)
            {
                RequestTextBox.Text = Str;
                Str = SR.ReadLine();
            }
            SR.Close();
        }
    }
}
