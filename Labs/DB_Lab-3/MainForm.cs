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
            this.WindowState = FormWindowState.Maximized;
            FieldComboBox.Enabled = false;
        }

        bool connected = false;
        public String TBoxText;
        
        string filename = Path.Combine(Environment.CurrentDirectory, "DB_Lab-3.mdb");
        string connectionString;

        private void bdConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = filename;
            connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + filename;

            if (TableComboBox.SelectedItem == "Films")
            {
                string command = "SELECT Название, Страна, Режиссёр, Год_выхода, Кинотеатр FROM [Films]";
                connected = true;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Films");
                    dataGridView.DataSource = dataSet;
                }
                dataGridView.DataMember = "Films";
                MainForm_Resize(sender, e);
            }

            else if (TableComboBox.SelectedItem == "Cinema")
            {
                string command = "SELECT Название, Фильм, Сеанс, Места, Билеты, Рейтинг FROM [Cinema]";
                connected = true;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Cinema");
                    dataGridView.DataSource = dataSet;
                }
                dataGridView.DataMember = "Cinema";
                MainForm_Resize(sender, e);
            }

            else if (TableComboBox.SelectedItem == "Reviews")
            {
                string command = "SELECT Кинотеатр, Фильм, Отзыв, Балл FROM [Reviews]";
                connected = true;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Reviews");
                    dataGridView.DataSource = dataSet;
                }
                dataGridView.DataMember = "Reviews";
                MainForm_Resize(sender, e);
            }

            else if (TableComboBox.SelectedItem == "Specifications")
            {
                string command = "SELECT Фильм, Описание, Жанр, Ограничения, Главный_герой, Продолжительность, 3D, Мировой_рейтинг FROM [Specifications]";
                connected = true;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Specifications");
                    dataGridView.DataSource = dataSet;
                }
                dataGridView.DataMember = "Specifications";
                MainForm_Resize(sender, e);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int margin = 5;
            RequestTextBox.Top = LabelQuery.Top = ClientSize.Height - margin - RequestTextBox.Height;
            dataGridView.Height = RequestTextBox.Top - 7 * margin - menuStrip.Height;
            dataGridView.Width = ClientSize.Width;
            RequestTextBox.Width = 4 * ClientSize.Width / 5;

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

                string command = RequestTextBox.Text;
                OleDbDataAdapter adapter = new OleDbDataAdapter(command, connection);
                DataSet dataSet = new DataSet();
                if (TableComboBox.SelectedItem == "Films")
                {
                    adapter.Fill(dataSet, "Films");
                    dataGridView.DataSource = dataSet;
                    dataGridView.DataMember = "Films";
                    MainForm_Resize(sender, e);
                }
                else if (TableComboBox.SelectedItem == "Cinema")
                {
                    adapter.Fill(dataSet, "Cinema");
                    dataGridView.DataSource = dataSet;
                    dataGridView.DataMember = "Cinema";
                    MainForm_Resize(sender, e);
                }

                else if (TableComboBox.SelectedItem == "Reviews")
                {
                    adapter.Fill(dataSet, "Reviews");
                    dataGridView.DataSource = dataSet;
                    dataGridView.DataMember = "Reviews";
                    MainForm_Resize(sender, e);
                }

                else if (TableComboBox.SelectedItem == "Specifictions")
                {
                    adapter.Fill(dataSet, "Specifictions");
                    dataGridView.DataSource = dataSet;
                    dataGridView.DataMember = "Specifictions";
                    MainForm_Resize(sender, e);
                }
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
                using (OleDbCommand cmd = new OleDbCommand(RequestTextBox.Text, connection))
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

        private void GenerateQueryToolStripMenuItem_Click(object sender, EventArgs e)
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
            else if (RequestComboBox.SelectedItem == "DELETE FROM")
            {
                TBoxText = RequestComboBox.SelectedItem.ToString() + " [" + TableComboBox.SelectedItem.ToString() + "] WHERE";
                RequestTextBox.Text = TBoxText;
            }
        }

        private void SaveToTheFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream S;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((S = saveFileDialog.OpenFile()) != null)
                {
                    TextWriter TW = new StreamWriter(S);
                     for (int i = 0; i < dataGridView.RowCount ; i++)
                     {
                         for (int j = 0; j < dataGridView.ColumnCount; j++)
                         {
                             TW.Write("\t" + dataGridView.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                         }
                         TW.WriteLine("");
                         TW.WriteLine("______________________________________________________________________");
                     }
                     TW.Close();
                }
            }
        }

        private void DeleteSelectedDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                dataGridView.CurrentCell.Value = "";
        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TableComboBox.SelectedItem == "Films")
            {
                FieldComboBox.Enabled = true;
                FieldComboBox.Items.Clear();
                FieldComboBox.Items.Add("Название");
                FieldComboBox.Items.Add("Страна");
                FieldComboBox.Items.Add("Режиссёр");
                FieldComboBox.Items.Add("Год_выхода");
                FieldComboBox.Items.Add("Кинотеатр");
            }
            else if (TableComboBox.SelectedItem == "Cinema")
            {
                FieldComboBox.Enabled = true;
                FieldComboBox.Items.Clear();
                FieldComboBox.Items.Add("Название");
                FieldComboBox.Items.Add("Фильм");
                FieldComboBox.Items.Add("Сеанс");
                FieldComboBox.Items.Add("Места");
                FieldComboBox.Items.Add("Билеты");
                FieldComboBox.Items.Add("Рейтинг");
            }
            else if (TableComboBox.SelectedItem == "Reviews")
            {
                FieldComboBox.Enabled = true;
                FieldComboBox.Items.Clear();
                FieldComboBox.Items.Add("Кинотеатр");
                FieldComboBox.Items.Add("Фильм");
                FieldComboBox.Items.Add("Отзыв");
                FieldComboBox.Items.Add("Балл");
            }
            else if (TableComboBox.SelectedItem == "Specifications")
            {
                FieldComboBox.Enabled = true;
                FieldComboBox.Items.Clear();
                FieldComboBox.Items.Add("Фильм");
                FieldComboBox.Items.Add("Описание");
                FieldComboBox.Items.Add("Жанр");
                FieldComboBox.Items.Add("Ограничения");
                FieldComboBox.Items.Add("Главный_герой");
                FieldComboBox.Items.Add("Продолжительность");
                FieldComboBox.Items.Add("3D");
                FieldComboBox.Items.Add("Мировой_рейтинг");
            }
        }
    }
}
