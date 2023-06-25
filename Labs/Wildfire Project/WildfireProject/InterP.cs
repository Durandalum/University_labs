using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterP
{
    public class Process
    {
        public Process(int x, int y, String file, int id, bool prior = false, int n = 0, int hp = 90, int water = 3)
        {
            ID = id;
            X = x;
            Y = y;
            N = n;
            _HP = hp;
            Water = water;
            Prior = prior;
            StreamReader sr1 = new StreamReader(file);
            int j = 0;
            while (!sr1.EndOfStream)
            {
                KOD[j] = sr1.ReadLine();
                j++;
            }
            sr1.Close();

            StreamReader sr = new StreamReader(file);
            int i = 0;
            while (!sr.EndOfStream)
            {
                KOD[i] = sr.ReadLine();
                KOD[i] = KOD[i].ToLower();
                i++;
            }
            sr.Close();
        }

        //Служебное
        public int ID;
        public int CC = 0;
        public int X;
        public int Y;
        public int N = 0;
        public bool Prior;

        public int _HP = 90;
        public int Water = 3;
        public int _Obj = 0;
        public int _Dist = 0;
        public int _Er;

        public int A = 0;
        public int B = 0;
        public int C = 0;
        public int D = 0;
        //Код
        public String[] KOD = new String[100];

        
    }
}