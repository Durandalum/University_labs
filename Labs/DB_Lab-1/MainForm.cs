using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.IO;

namespace DBProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
                
        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm_Resize(sender, e);            
        }

        bool connected = false;
        
        string filename = Path.Combine(Environment.CurrentDirectory, "Phonebook.mdb");
        string connectionString;

        private void bdConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = filename;
            connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + filename;
            string command = "SELECT Фамилия, Имя, Отчество, НомСтацТелеф, НомМобТелеф, ДатаРождения, КатегорияАбонента, ДомашнийАдрес, Примечание FROM [Numbers]";
            connected = true;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(command, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Numbers");
                dataGridView.DataSource = dataSet;
            }
            dataGridView.DataMember = "Numbers";
            MainForm_Resize(sender, e);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int margin = 5;
            tbQuery.Top = lbQuery.Top = ClientSize.Height - margin - tbQuery.Height;
            dataGridView.Height = tbQuery.Top - 2*margin - menuStrip.Height;
            dataGridView.Width = ClientSize.Width;
            tbQuery.Width = 4 * ClientSize.Width / 5;

            int colCount = dataGridView.ColumnCount;
            if (colCount == 0) 
                return;
            int w = dataGridView.Width - dataGridView.RowHeadersWidth;
            w /= colCount;
            foreach (DataGridViewColumn col in dataGridView.Columns)
                col.Width = w;
            dataGridView.Columns[colCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void selectQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                MessageBox.Show("База данных не подключена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {

                string command = tbQuery.Text;
                OleDbDataAdapter adapter = new OleDbDataAdapter(command, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Numbers");
                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = "Numbers";
                MainForm_Resize(sender, e);
            }
        }

        private void bdDisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connected = false;
            dataGridView.DataSource = null;
            Text = "Database";
        }

        private void updateQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                MessageBox.Show("База данных не подключена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(tbQuery.Text, connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            bdConnectToolStripMenuItem_Click(sender, e);
        }

        private void deleteQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateQueryToolStripMenuItem_Click(sender, e);
        }

        private void insertQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateQueryToolStripMenuItem_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setDatabasePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                filename = openFileDialog.FileName;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная работа №1\nАвтор: Маглёванный Дмитрий\n",
                            "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
