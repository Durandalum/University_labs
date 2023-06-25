using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        char CipherChar;

        int ShiftCount;

        int ClickCount = 0;

        byte[] FirstHashValue = { };
        byte[] SecondHashValue = { };     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void ProgramNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CoderTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {
            Random Rnd = new Random();
            CipherChar = (char)Rnd.Next(0, 128);
            ShiftCount = (int)Rnd.Next(5, 18);

            if (DecoderTextBox.Text != "")
            {
                StringBuilder CipherText = new StringBuilder(DecoderTextBox.Text);

                for (int i = 0; i < CipherText.Length; i++)
                {
                    CipherText[i] ^= CipherChar;
                }

                if (isLatinRButton.Checked == true)
                {
                    for (int i = 0; i < CipherText.Length; i++)
                    {
                        CipherText[i] = (char)((CipherText[i] + ShiftCount) % 128);
                    }
                }
                String RevStr = CipherText.ToString();
                RevStr.Reverse();
                CoderTextBox.Text = RevStr;
            }
            else MessageBox.Show("Вы не ввели текст для шифровки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            if (DecoderTextBox.Text != "")
            {
                StringBuilder CipherText = new StringBuilder(DecoderTextBox.Text);
                String RevStr = CipherText.ToString();
                RevStr.Reverse();

                if (isLatinRButton.Checked == true)
                {
                    for (int i = 0; i < CipherText.Length; i++)
                    {
                        CipherText[i] = (char)((CipherText[i] + 128 - ShiftCount % 128) % 128);
                    }
                }

                for (int i = 0; i < CipherText.Length; i++)
                {
                    CipherText[i] ^= CipherChar;
                }

                CoderTextBox.Text = CipherText.ToString();
            }
            else MessageBox.Show("Вы не ввели текст для дешифровки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void SaveTextButton_Click(object sender, EventArgs e)
        {
            if (CoderTextBox.Text != "")
            {
                SaveFileDialog SDF = new SaveFileDialog();
                SDF.ShowDialog();
                StreamWriter SW = new StreamWriter(SDF.FileName + ".txt");
                SW.WriteLine(CipherChar);
                SW.WriteLine(ShiftCount);
                SW.Write(CoderTextBox.Text);
                SW.Close();
            }
            else MessageBox.Show("В поле вывода ничего нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
            StreamReader SR = new StreamReader(OFD.FileName);
            String ChrStr = SR.ReadLine();
            CipherChar = Convert.ToChar(ChrStr);
            ChrStr = SR.ReadLine();
            ShiftCount = Convert.ToInt32(ChrStr);
            String Str = SR.ReadLine();
            while (Str != null)
            {
                DecoderTextBox.Text = Str;
                Str = SR.ReadLine();
            }
            SR.Close();
        }

        private void CheckHashButton_Click(object sender, EventArgs e)
        {
            if (DecoderTextBox.Text != "")
            {
                ClickCount += 1;

                bool Identity = true;

                string FirstTextCheck = "";
                string SecondTextCheck = "";

                if (ClickCount < 2)
                {
                    FirstTextCheck = DecoderTextBox.Text;
                    UnicodeEncoding UE = new UnicodeEncoding();
                    byte[] FirstTextCheckBytes = UE.GetBytes(FirstTextCheck);
                    SHA1Managed Hash = new SHA1Managed();
                    FirstHashValue = Hash.ComputeHash(FirstTextCheckBytes);

                    MessageBox.Show("Данные сохранены. Нажмите на кнопку ещё раз, чтобы продолжить.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SecondTextCheck = DecoderTextBox.Text;
                    UnicodeEncoding UE = new UnicodeEncoding();
                    byte[] SecondTextCheckBytes = UE.GetBytes(SecondTextCheck);
                    SHA1Managed Hash = new SHA1Managed();
                    SecondHashValue = Hash.ComputeHash(SecondTextCheckBytes);
                    for (int x = 0; x < FirstHashValue.Length; x++)
                    {
                        if (FirstHashValue[x] != SecondHashValue[x])
                            Identity = false;
                    }
                    if (Identity)
                        MessageBox.Show("Проверка завершена! Данные целы.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Проверка завершена! К сожалению, данные были повреждены.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ClickCount = 0;
                }
            }
            else MessageBox.Show("Вы не ввели текст для проверки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
