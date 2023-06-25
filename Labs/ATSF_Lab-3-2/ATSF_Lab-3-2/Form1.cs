using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Threading.Tasks;

namespace ATSF_Lab_3_2
{
    public partial class Form1 : Form
    {
        string Origin;
        string End;

        bool DistFlag = false;
        bool InstFoldFlag = false;

        void CopyPaste(string FromFirst, string ToLast)
        {
            DirectoryInfo DI = new DirectoryInfo(FromFirst);
            foreach (DirectoryInfo DirInf in DI.GetDirectories())
            {
                if (Directory.Exists(ToLast + "\\" + DirInf.Name) == false)
                    Directory.CreateDirectory(ToLast + "\\" + DirInf.Name);
                CopyPaste(DirInf.FullName, ToLast + "\\" + DirInf.Name);
            }

            foreach (string Ffile in Directory.GetFiles(FromFirst))
            {
                string Fille = Ffile.Substring(Ffile.LastIndexOf("\\"), Ffile.Length - Ffile.LastIndexOf("\\"));
                File.Copy(Ffile, ToLast + "\\" + Fille, true);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Install";
        }

        public void SaveFile()
        {
            while (true)
            {
                File.Delete("install.dat");
                if (DistFlag == true && InstFoldFlag == true)
                {
                    File.WriteAllLines("install.dat", new string[] { Origin, End });
                }
                else MessageBox.Show("Empty");
                break;
            }
        }

        private void Distribution_Click_1(object sender, EventArgs e)
        {
            using (var FBD = new FolderBrowserDialog())
            {
                DialogResult Result = FBD.ShowDialog();

                if (Result == DialogResult.OK && !string.IsNullOrWhiteSpace(FBD.SelectedPath))
                    Origin = FBD.SelectedPath;
            }
            DistFlag = true;
            if (InstFoldFlag == true) SaveFile();
        }

        private void InstallFolder_Click_1(object sender, EventArgs e)
        {
            using (var FBD = new FolderBrowserDialog())
            {
                DialogResult Result = FBD.ShowDialog();

                if (Result == DialogResult.OK && !string.IsNullOrWhiteSpace(FBD.SelectedPath))
                    End = FBD.SelectedPath;
            }
            InstFoldFlag = true;
            if (DistFlag == true) SaveFile();
        }

        private void Installing_Click_1(object sender, EventArgs e)
        {
            RegistryKey CurrentUK = Registry.CurrentUser;
            RegistryKey HelperKey = CurrentUK.OpenSubKey("AlphaKey");
            if (HelperKey == null)
            {
                CopyPaste(Origin, End);
                HelperKey = CurrentUK.CreateSubKey("AlphaKey");
                HelperKey.Close();
            }
            else
            {
                MessageBox.Show("Программа уже установлена", "Ошибка!", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void Deleting_Click_1(object sender, EventArgs e)
        {
            RegistryKey CurrentUK = Registry.CurrentUser;
            RegistryKey HelperKey = CurrentUK.CreateSubKey("AlphaKey");
            if (HelperKey == null)
            {
                MessageBox.Show("Программа уже удалена!", "Ошибка!", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                Directory.Delete(End, true);
                CurrentUK.DeleteSubKey("AlphaKey");
            }
        }

    }
}
