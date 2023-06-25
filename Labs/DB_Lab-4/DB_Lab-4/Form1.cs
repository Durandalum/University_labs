using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DB_Lab_4
{
    public partial class Form1 : Form
    {

        OleDbConnection connection;
        string path;
        List<string> tables = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Покупатели.ФИО, Max(Продажи.сумма) AS [Max-сумма]\n" +
                    "FROM Покупатели INNER JOIN Продажи ON Покупатели.код_покупателя = Продажи.код_покупателя\n";
                if (textBox1.Text != "") query += "WHERE " + textBox1.Text + "\n";
                query += "GROUP BY Покупатели.ФИО";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                richTextBox1.Text = query;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Продажи.код_покупателя, Покупатели.ФИО, Sum(Продажи.сумма) AS [суммы]\n" +
                    "FROM Покупатели INNER JOIN Продажи ON Покупатели.код_покупателя = Продажи.код_покупателя\n";
                if (textBox1.Text != "") query += "WHERE " + textBox1.Text + "\n";
                query += "GROUP BY Продажи.код_покупателя, Покупатели.ФИО";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                richTextBox1.Text = query;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Поставщики.ФИО, Sum(Закупки.сумма) AS суммы\n" +
                    "FROM Поставщики INNER JOIN Закупки ON Поставщики.код_поставщика = Закупки.код_поставщика\n";
                if (textBox1.Text != "") query += "WHERE " + textBox1.Text + "\n";
                query += "GROUP BY Поставщики.ФИО";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                richTextBox1.Text = query;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Поставщики.ФИО, Закупки.дата, Sum(Закупки.сумма) AS суммы\n" +
                    "FROM Поставщики INNER JOIN Закупки ON Поставщики.код_поставщика = Закупки.код_поставщика\n";
                if (textBox1.Text != "") query += "WHERE " + textBox1.Text + "\n";
                query += "GROUP BY Поставщики.ФИО, Закупки.дата";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                richTextBox1.Text = query;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Товары.группа, Группы.[группа товара], Count(Товары.наименование) AS количество\n" +
                    "FROM Группы INNER JOIN Товары ON Группы.код_группы = Товары.группа\n";
                if (textBox1.Text != "") query += "WHERE " + textBox1.Text + "\n";
                query += "GROUP BY Товары.группа, Группы.[группа товара]";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                richTextBox1.Text = query;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + ofd.FileName + ";Persist Security Info = False;";
                }

                connection = new OleDbConnection();
                connection.ConnectionString = path;
                connection.Open();
                connection.Close();

                tables = GetTables(path);
                tables.RemoveRange(0, 12);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<string> GetTables(string path)
        {
            using (OleDbConnection con = new OleDbConnection(path))
            {
                con.Open();
                DataTable schema = con.GetSchema("Tables");
                List<string> tables = new List<string>();
                foreach (DataRow row in schema.Rows)
                {
                    tables.Add(row.Field<string>("TABLE_NAME"));
                }
                con.Close();

                return tables;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                string newPath = "";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    newPath = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + ofd.FileName + ";Persist Security Info = False;";
                }

                OleDbConnection newConnection;
                newConnection = new OleDbConnection();
                newConnection.ConnectionString = newPath;
                Save(newConnection, newPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save(OleDbConnection con, string path)
        {
            tables = GetTables(path);

            con.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = con;

            string query = "";
            string tableName = "";
            string colNames = "";

            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                if (!Regex.IsMatch(tables[tables.Count - 1], "[0-9]"))
                {
                    query = "CREATE TABLE Table_1 (\n";
                    tableName = "Table_1";
                }
                else
                {
                    int index = Convert.ToInt32(Regex.Replace(tables[tables.Count - 1], @"[^\d]+", ""));
                    index++;
                    query = "CREATE TABLE Table" + index + " (\n";
                    tableName = "Table" + index;
                }

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    query += "[" + col.HeaderText + "]" + " varchar(255),";
                    colNames += col.HeaderText + ", ";
                }
                colNames = colNames.Remove(colNames.Length - 2, 2);
                query = query.Remove(query.Length - 1, 1);
                query += ")";
            }
            else
            {
                MessageBox.Show("Нечего записывать! Заполните таблицу.", "Заполните таблицу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            command.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

                        FillAccessTable(con, tableName, colNames);   
        }

        private void FillAccessTable(OleDbConnection con, string tableName, string colNames)
        {
            con.Open();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string request = "";

                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (String.Compare(dataGridView1.Rows[i].Cells[j].Value.ToString(), "") != 0)
                            request += "'" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "', ";
                        else
                            request += "0, ";
                }

                if (request != "")
                {
                    request = request.Remove(request.Length - 2, 2);

                    OleDbCommand command = con.CreateCommand();
                    string query = "insert into `" + tableName + "` (" + colNames + ") values(" + request + ")";
                    Console.WriteLine(query);
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }

            con.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
