using System;
using System.Drawing;
using System.Windows.Forms;
using InterP;
using System.Threading;

// 0 - лес, 1 - тропинка, 2 - озеро, 3 - вертолёт, 4 - огонь;

namespace APOS
{
    public partial class Form1 : Form
    {
        //Переменные отрисовки
        const int X = 40;
        const int Y = 40;
        int footpath_Length = 15;
        int spritSize = 12;

        //Процессы
        Process[] Proc = new Process[200];
        int ProcN = -1;
        PictureBox[] ProcI = new PictureBox[200];
        int SSet = 1;

        //"Системные"
        Random rand = new Random();
        PictureBox[,] Map = new PictureBox[X, Y];
        int[,] Map_Meta = new int[X, Y];
        int[,] Map_Data = new int[X, Y];
        int[,] Map_Meta_ID = new int[X, Y];
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        string filename;
        Thread myThread;
        bool yes = true;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        bool add = false;
        bool flag = false;
        int I = 0;

        //Отрисовка карты
        void BlockDraw(int i, int j, String img)
        {
            Bitmap Img = new Bitmap(img);
            Map[i, j] = new PictureBox();
            Map[i, j].Width = spritSize;
            Map[i, j].Height = spritSize;
            Map[i, j].Image = Img;
            Map[i, j].Location = new Point(i * spritSize, j * spritSize + 24);
            Map[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Map[i, j]);
        }
        void Map_init()
        {
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (i == 0 || i == X - 1 || j == 0 || j == Y - 1)
                    {
                        Map_Data[i, j] = 1;
                    }
                    else
                    {
                        Map_Data[i, j] = 0;
                    }
                }
            }

            int n = rand.Next(15, 25);

            for (int i = 0; i < n; i++)
            {
                int lake_X = rand.Next(1, X - 2);
                int lake_Y = rand.Next(1, Y - 2);
                FootPath_Generation(lake_X, lake_Y);
            }

            n = rand.Next(15, 25);

            for (int i = 0; i < n; i++)
            {
                int path_X = rand.Next(1, X - 2);
                int path_Y = rand.Next(1, Y - 2);
                Lake_Generation(path_X, path_Y);
            }
        }

        void Forest_Generation(int x, int y, int iter = 0)
        {
            if (iter < footpath_Length)
            {
                Map_Meta[x, y] = 0;
            }                  
        }

        void Lake_Generation(int x, int y)
        {
            int n = rand.Next(1, 3);
            switch (n)
            {
                case 1:
                    Map_Data[x, y] = 2;
                    if (y - 1 > 1)
                        Map_Data[x, y - 1] = 2;
                    if (y - 2 > 1)
                        Map_Data[x, y - 2] = 2;
                    if (y + 1 < Y - 1)
                        Map_Data[x, y + 1] = 2;
                    if (x - 1 > 1)
                        Map_Data[x - 1, y] = 2;
                    if (x + 1 < X)
                        Map_Data[x + 1, y] = 2;
                    if (x + 1 < X && y - 1 > 1)
                        Map_Data[x + 1, y - 1] = 2;
                    if (x - 1 > 1 && y + 1 < Y - 1)
                        Map_Data[x - 1, y + 1] = 2;
                    break;
                case 2:
                    Map_Data[x, y] = 2;
                    if (y - 1 > 1)
                        Map_Data[x, y - 1] = 2;
                    if (y + 1 < Y - 1)
                        Map_Data[x, y + 1] = 2;
                    if (x + 1 < X)
                        Map_Data[x + 1, y] = 2;
                    if (x + 1 < X && y - 1 > 1)
                        Map_Data[x + 1, y - 1] = 2;
                    if (x - 1 > 1 && y + 1 < Y - 1)
                        Map_Data[x - 1, y + 1] = 2;
                    if (x - 1 > 1 && y + 2 < Y - 1)
                        Map_Data[x - 1, y + 2] = 2;
                    if (x - 1 > 1 && y + 3 < Y - 1)
                        Map_Data[x - 1, y + 3] = 2;

                    break;
                case 3:
                    Map_Data[x, y] = 2;
                    if (y - 1 > 1)
                        Map_Data[x, y - 1] = 2;
                    if (y + 1 < Y - 1)
                        Map_Data[x, y + 1] = 2;
                    if (y + 2 < Y - 1)
                        Map_Data[x, y + 2] = 2;
                    if (x - 1 > 1)
                        Map_Data[x - 1, y] = 2;
                    if (x + 1 < X)
                        Map_Data[x + 1, y] = 2;

                    break;
            }
        }
        void FootPath_Generation(int x, int y, int iter = 0)
        {
            if (iter < footpath_Length)
            {
                int n = rand.Next(1, 4);
                switch (n)
                {
                    case 1:
                        Map_Data[x, y] = 1;
                        if(x + 1 < X)
                            FootPath_Generation(x + 1, y, iter + 1);
                        else
                            FootPath_Generation(x, y, iter + 1);
                        break;
                    case 2:
                        Map_Data[x, y] = 1;
                        if (x - 1 > 1)
                            FootPath_Generation(x - 1, y, iter + 1);
                        else
                            FootPath_Generation(x, y, iter + 1);
                        break;
                    case 3:
                        Map_Data[x, y] = 1;
                        if (y - 1 > 1)
                            FootPath_Generation(x, y - 1, iter + 1);
                        else
                            FootPath_Generation(x, y, iter + 1);
                        break;
                    case 4:
                        Map_Data[x, y] = 1;
                        if (y + 1 < Y - 1)
                            FootPath_Generation(x, y + 1, iter + 1);
                        else
                            FootPath_Generation(x, y, iter + 1);
                        break;
                }
            }
        }
        void Map_Draw()
        {
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (Map_Data[i, j] == 0)
                    {
                        BlockDraw(i, j, "forest.png");
                    }

                    if (Map_Data[i, j] == 1)
                    {
                        BlockDraw(i, j, "footpath.png");
                    }

                    if (Map_Data[i, j] == 2)
                    {
                        BlockDraw(i, j, "lake.png");
                    }

                }
            }
        }
        //Конец отрисовки карты

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X * spritSize + 150, Y * spritSize + 64);
            Map_init();
            Map_Draw();
            SSetText.Location = new Point(X * spritSize + 20 , 40);
            SSetTextM.Location = new Point(X * spritSize, 40);
            SSetTextP.Location = new Point(X * spritSize + 110, 40);
            StartI.Location = new Point(X * spritSize + 20, 65);
            Stats.Location = new Point(X * spritSize + 20, 90);
            KillProc.Location = new Point(X * spritSize + 20, 250);
            PiD.Location = new Point(X * spritSize + 75, 250);
            SSetText.Text = Convert.ToString(SSet);
            clearStat();

            for (int i = 0; i < Proc.Length; i++)
            {
                Proc[i] = null;
            }
        }//---//
        public Form1()
        {
            InitializeComponent();
        }//---//
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            myThread.Abort();
            yes = false;
        }

        //Добавить
        void HelicopterDraw(int i, int j, String img, int ProcN)
        {
            Bitmap Img = new Bitmap(img);
            ProcI[ProcN] = new PictureBox();
            ProcI[ProcN].Width = spritSize * 2;
            ProcI[ProcN].Height = spritSize * 2;
            ProcI[ProcN].Image = Img;
            ProcI[ProcN].Location = new Point(i * spritSize - spritSize/2, j * spritSize + 24 - spritSize / 2);
            ProcI[ProcN].SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(ProcI[ProcN]);
            ProcI[ProcN].BringToFront();
        }

        void WildfireDraw(int i, int j, String img, int ProcN)
        {
            Bitmap Img = new Bitmap(img);
            ProcI[ProcN] = new PictureBox();
            ProcI[ProcN].Width = spritSize;
            ProcI[ProcN].Height = spritSize;
            ProcI[ProcN].Image = Img;
            ProcI[ProcN].Location = new Point(i * spritSize, j * spritSize + 24);
            ProcI[ProcN].SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(ProcI[ProcN]);
            ProcI[ProcN].BringToFront();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = false;
            int pos = 0;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                for (int i = 0; i < SSet; i++)
                {
                    if (ProcN >= 99)
                    {
                        break;
                    }
                    while (true)
                    {
                        int pX = rand.Next(1, X - 2);
                        int pY = rand.Next(1, Y - 2);
                        if (Map_Meta[pX, pY] == 0)
                        {
                            spawnHeli(pos, pX, pY, filename);
                            break;
                        }
                    }
                }
            }
            add = true;
        }

        private void addFireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = false;
            int pos = 0;
                filename = "More_Fire.txt";
                for (int i = 0; i < SSet; i++)
                {
                    if (ProcN >= 99)
                    {
                        break;
                    }
                    while (true)
                    {
                        int pX = rand.Next(1, X - 2);
                        int pY = rand.Next(1, Y - 2);
                        if (Map_Meta[pX, pY] == 0 && Map_Data[pX, pY] == 0)
                        {
                            spawnFire(pos, pX, pY, filename);
                            break;
                        }
                    }
                }
            add = true;
        }

        private void SSetTextM_Click(object sender, EventArgs e)
        {
            SSet--;
            if (SSet == 0)
            {
                SSet = 1;
            }
            SSetText.Text = Convert.ToString(SSet);
        }
        private void SSetTextP_Click(object sender, EventArgs e)
        {
            SSet++;
            SSetText.Text = Convert.ToString(SSet);
        }
        void spawnHeli(int pos, int pX, int pY, string fname, string img = "helicopter.png", bool prior = false, int n = 0, int HP = 90)
        {
            Map_Meta[pX, pY] = 3;
            for (int k = 0; k < ProcN; k++)
            {
                pos = 0;
                if (Proc[k] == null)
                {
                    pos = k;
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                HelicopterDraw(pX, pY, img, pos);
                Proc[pos] = new Process(pX, pY, fname, pos, prior, n, HP);
                flag = false;
            }
            else
            {
                ProcN++;
                HelicopterDraw(pX, pY, img, ProcN);
                Proc[ProcN] = new Process(pX, pY, fname, ProcN, prior, n, HP);
                pos = ProcN;
            }
            Map_Meta_ID[pX, pY] = pos;
            if (prior) { I = pos; }
        }

        void spawnFire(int pos, int pX, int pY, string fname, string img = "fire.png", bool prior = false, int n = 0, int HP = 1)
        {
            Map_Meta[pX, pY] = 4;
            for (int k = 0; k < ProcN; k++)
            {
                pos = 0;
                if (Proc[k] == null)
                {
                    pos = k;
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                WildfireDraw(pX, pY, img, pos);
                Proc[pos] = new Process(pX, pY, fname, pos, prior, n, HP);
                flag = false;
            }
            else
            {
                ProcN++;
                WildfireDraw(pX, pY, img, ProcN);
                Proc[ProcN] = new Process(pX, pY, fname, pos, prior, n, HP);
                pos = ProcN;
            }
            Map_Meta_ID[pX, pY] = pos;
            if (prior) { I = pos; }
        }
        //---//

        //Удалить
        private void KillProc_Click(object sender, EventArgs e)
        {
            if (Proc[Convert.ToInt32(PiD.Text)] != null)
            {
                Proc[Convert.ToInt32(PiD.Text)]._HP = 0;
            }
        }
        //---//

        int t = 0;

        bool test = true;

        //Интерпретация
        void interp()
        {
            undStat();
            while (yes)
            {
                if (add)
                {
                    undStat();
                    Thread.Sleep(50);
                    add = false;
                }
                I = 0;
                for (I = 0; I < ProcN + 1;)
                {
                    if (Proc[I] != null)
                    {
                        //Thread.Sleep(1);
                        if (Proc[I]._HP <= 0)
                        {
                            test = false;
                            I++;
                            BeginInvoke(new Action(() => { Dead(I - 1); }));
                            Thread.Sleep(50);

                            undStat();
                            Thread.Sleep(50);

                            break;
                        }
                        String j = Proc[I].KOD[Proc[I].CC];
                        Proc[I].CC++;
                        if (Proc[I].CC >= 100)
                        {
                            Proc[I].CC = 0;
                        }
                        if (j != null && Proc[I] != null)
                        {
                            //MessageBox.Show(j);
                            switch (j.Split()[0])
                            {
                                case "step":
                                    Thread.Sleep(100);
                                    step(I);
                                    if (Proc[I] != null)
                                    {
                                        if (!Proc[I].Prior) { I++; }
                                    }
                                    else
                                    {
                                        I++;
                                    }
                                    break;
                                case "rleft":
                                    rleft(I);
                                    break;
                                case "rright":
                                    rright(I);
                                    break;
                                case "flip":
                                    flip(I);
                                    if (Proc[I] != null)
                                    {
                                        if (!Proc[I].Prior) { I++; }
                                    }
                                    else
                                    {
                                        I++;
                                    }
                                    break;
                                case "jump":
                                    jump(I, j);
                                    break;
                                case "com":
                                    com(I, j);
                                    break;
                                case "jumpb":
                                    jumpb(I, j);
                                    break;
                                case "jumpm":
                                    jumpm(I, j);
                                    break;
                                case "jumpr":
                                    jumpr(I, j);
                                    break;
                                case "look":
                                    Proc[I]._Dist = 0;
                                    look(I, Proc[I].X, Proc[I].Y);
                                    break;
                                case "eat":
                                    eat(I);
                                    Thread.Sleep(10);
                                    if (Proc[I] != null)
                                    {
                                        if (!Proc[I].Prior) { I++; }
                                    }
                                    else
                                    {
                                        I++;
                                    }
                                    break;
                                case "splash":
                                    splash(I);
                                    if (Proc[I] != null)
                                    {
                                        if (!Proc[I].Prior) { I++; }
                                    }
                                    else
                                    {
                                        I++;
                                    }
                                    break;
                                case "more_fire":
                                    more_Fire(I);
                                    if (Proc[I] != null)
                                    {
                                        if (!Proc[I].Prior) { I++; }
                                    }
                                    else
                                    {
                                        I++;
                                    }
                                    break;
                                case "app":
                                    App(I);
                                    if (Proc[I] != null)
                                    {
                                        if (!Proc[I].Prior) { I++; }
                                    }
                                    else
                                    {
                                        I++;
                                    }
                                    break;
                                case "non":
                                    non(I);
                                    if (Proc[I] != null)
                                    {
                                        if (!Proc[I].Prior) { I++; }
                                    }
                                    else
                                    {
                                        I++;
                                    }
                                    break;
                                case "":
                                    Proc[I].CC = 0;
                                    if (Proc[I] != null)
                                    {
                                        if (!Proc[I].Prior) { I++; }
                                    }
                                    else
                                    {
                                        I++;
                                    }
                                    break;
                            }
                        }
                    }
                    if (Proc[I] != null)
                    {
                        if (!Proc[I].Prior) { I++; }
                    }
                    else
                    {
                        I++;
                    }
                }

            }

        }

        private void StartI_Click(object sender, EventArgs e)
        {
            StartI.Enabled = false;
            myThread = new Thread(new ThreadStart(interp));
            myThread.Start();
        }

        //Доп Функции
        void Move(int i)
        {
            ProcI[i].Location = new Point(Proc[i].X * spritSize - spritSize / 2, Proc[i].Y * spritSize + 24 - spritSize / 2);
        }
        void Dead(int j)
        {
            Map_Meta[Proc[j].X, Proc[j].Y] = 0;
            Map_Meta_ID[Proc[j].X, Proc[j].Y] = 0;
            Proc[j] = null;
            ProcI[j].Visible = false;
            test = true;
            I++;
        }
        void srav(int a, int b, int i)
        {
            if (a == b)
            {
                Proc[i].A = 0;
            }
            if (a > b)
            {
                Proc[i].A = 1;
            }
            if (a < b)
            {
                Proc[i].A = -1;
            }
        }
        int sirch(int x, int y)
        {
            for (int i = 0; i < Proc.Length; i++)
            {
                if (Proc[i].X == x && Proc[i].Y == y)
                {
                    return i;
                }
            }
            return 0;
        }
        void outStat(int id)
        {
            Stats.Text = Stats.Text + "ID: " + id + "\n";
        }
        void clearStat()
        {
            Stats.Text = "Процессы:\n";
        }
        void undStat()
        {
            BeginInvoke(new Action(() => { clearStat(); }));
            Thread.Sleep(5);
            for (int c = 0; c < ProcN + 1; c++)
            {
                if (Proc[c] != null)
                {
                    BeginInvoke(new Action(() => { outStat(c); }));
                    Thread.Sleep(5);
                    //MessageBox.Show(Convert.ToString(Proc[c].ID));
                }
            }
        }
        void kill(int id)
        {
            Proc[id]._HP = 0;
        }
        bool fC(int x, int y)
        {
            if (Map_Meta[x, y] == 0 && Map_Data[x, y] == 0)
            {
                return true;
            }
            return false;
        }


        //Команды
        void step(int i)
        {
            int x = 0;
            int y = 0;
            switch (Proc[i].N)
            {
                case 0:
                    x = Proc[i].X;
                    y = Proc[i].Y - 1;
                    break;
                case 2:
                    x = Proc[i].X;
                    y = Proc[i].Y + 1;
                    break;
                case 3:
                    x = Proc[i].X - 1;
                    y = Proc[i].Y;
                    break;
                case 1:
                    x = Proc[i].X + 1;
                    y = Proc[i].Y;
                    break;
            }
            if (x < X && x >= 0 && y < Y && y >= 0)
            {
                if (Map_Meta[x, y] == 0)
                {
                    Map_Meta[x, y] = 3;
                    Map_Meta[Proc[i].X, Proc[i].Y] = 0;
                    Map_Meta_ID[x, y] = Map_Meta_ID[Proc[i].X, Proc[i].Y];
                    Map_Meta_ID[Proc[i].X, Proc[i].Y] = 0;
                    Proc[i].X = x;
                    Proc[i].Y = y;
                    BeginInvoke(new Action(() => { Move(i); }));
                    Thread.Sleep(1);
                }
                else
                {
                    Proc[i]._HP--;
                }
            }
            else
            {
                Proc[i]._HP--;
            }
        }

        void rleft(int i)
        {
            Proc[i].N--;
            if (Proc[i].N < 0)
            {
                Proc[i].N = 3;
            }
        }

        void rright(int i)
        {
            Proc[i].N++;
            if (Proc[i].N > 3)
            {
                Proc[i].N = 0;
            }
        }

        void flip(int i)
        {
            rright(i);
            rright(i);
        }

        void jump(int i, String j)
        {
            Proc[i].CC = Convert.ToInt32(j.Split()[1]) - 1;
        }

        void com(int i, String j)
        {
            switch (j.Split()[1])
            {
                case "hp":
                    srav(Proc[i]._HP, Convert.ToInt32(j.Split()[2]), i);
                    break;
                case "obj":
                    srav(Proc[i]._Obj, Convert.ToInt32(j.Split()[2]), i);
                    break;
                case "dist":
                    srav(Proc[i]._Dist, Convert.ToInt32(j.Split()[2]), i);
                    break;
                case "app":
                    srav(Proc[i].B, Convert.ToInt32(j.Split()[2]), i);
                    break;
                default:
                    srav(Convert.ToInt32(j.Split()[1]), Convert.ToInt32(j.Split()[2]), i);
                    break;
            }
        }

        void jumpb(int i, String j)
        {
            if (Proc[i].A == 1)
            {
                Proc[i].CC = Convert.ToInt32(j.Split()[1]) - 1;
            }
        }

        void jumpm(int i, String j)
        {
            if (Proc[i].A == -1)
            {
                Proc[i].CC = Convert.ToInt32(j.Split()[1]) - 1;
            }
        }

        void jumpr(int i, String j)
        {
            if (Proc[i].A == 0 && Proc[i] != null)
            {
                Proc[i].CC = Convert.ToInt32(j.Split()[1]) - 1;
            }
        }
        
        void look(int i, int x, int y)
        {
            //MessageBox.Show(Convert.ToString(Proc[i].N));
            int nx = 0;
            int ny = 0;
            switch (Proc[i].N)
            {
                case 0:
                    nx = x;
                    ny = y - 1;
                    break;
                case 1:
                    nx = x + 1;
                    ny = y;
                    break;
                case 2:
                    nx = x;
                    ny = y + 1;
                    break;
                case 3:
                    nx = x - 1;
                    ny = y;
                    break;
            }
            if (nx < X && nx >= 0 && ny < Y && ny >= 0)
            {
                if (Map_Meta[nx, ny] == 0)
                {
                    Proc[i]._Dist = Proc[i]._Dist + 1;
                    look(i, nx, ny);
                }
                else
                {
                    Proc[i]._Obj = Map_Meta[nx, ny];
                }
            }
            else
            {
                Proc[i]._Obj = 1;
            }
            

        }
        
        void eat(int i)
        {
            int x = Proc[i].X;
            int y = Proc[i].Y;

            if (y + 1 < Y) { if (Map_Meta[x, y + 1] == 4) { kill(Map_Meta_ID[x, y + 1]); } }
            if (y + 1 < Y && x + 1 < X) { if (Map_Meta[x + 1, y + 1] == 4) { kill(Map_Meta_ID[x + 1, y + 1]); } }
            if (x + 1 < X) { if (Map_Meta[x + 1, y] == 4) { kill(Map_Meta_ID[x + 1, y]); } }
            if (y - 1 > 0 && x + 1 < X) { if (Map_Meta[x + 1, y - 1] == 4) { kill(Map_Meta_ID[x + 1, y - 1]); } }
            if (y - 1 > 0) { if (Map_Meta[x, y - 1] == 4) { kill(Map_Meta_ID[x, y - 1]); } }
            if (y - 1 > 0 && x - 1 > 0) { if (Map_Meta[x - 1, y - 1] == 4) { kill(Map_Meta_ID[x - 1, y - 1]); } }
            if (x - 1 > 0) { if (Map_Meta[x - 1, y] == 4) { kill(Map_Meta_ID[x - 1, y]); } }
            if (y + 1 < Y && x - 1 > 0) { if (Map_Meta[x - 1, y + 1] == 4) { kill(Map_Meta_ID[x - 1, y + 1]); } }
        }

        void splash(int i)
        {
            switch (Proc[i].N)
            {
                case 0:
                    if (Map_Meta[Proc[i].X, Proc[i].Y - 1] == 0)
                    {
                        BeginInvoke(new Action(() => { spawnHeli(0, Proc[i].X, Proc[i].Y - 1, "splash.txt", "splash.png", true, 0, 2); }));
                        Thread.Sleep(5);
                    }
                    break;
                case 1:
                    if (Map_Meta[Proc[i].X + 1, Proc[i].Y] == 0)
                    {
                        BeginInvoke(new Action(() => { spawnHeli(0, Proc[i].X + 1, Proc[i].Y, "splash.txt", "splash.png", true, 1, 2); }));
                        Thread.Sleep(5);
                    }
                    break;
                case 2:
                    if (Map_Meta[Proc[i].X, Proc[i].Y + 1] == 0)
                    {
                        BeginInvoke(new Action(() => { spawnHeli(0, Proc[i].X, Proc[i].Y + 1, "splash.txt", "splash.png", true, 2, 2); }));
                        Thread.Sleep(5);
                    }
                    break;
                case 3:
                    if (Map_Meta[Proc[i].X - 1, Proc[i].Y] == 0)
                    {
                        BeginInvoke(new Action(() => { spawnHeli(0, Proc[i].X - 1, Proc[i].Y, "splash.txt", "splash.png", true, 3, 2); }));
                        Thread.Sleep(5);
                    }
                    break;
            }

        }

        void more_Fire(int i)
        {
            int x = Proc[i].X;
            int y = Proc[i].Y;
            if (y < Y && y > 0)
            {
                if (fC(x, y + 1))
                {
                    BeginInvoke(new Action(() => { spawnFire(0, x, y + 1, "More_Fire.txt"); }));
                    Thread.Sleep(5);
                }
                else
                {
                    if (fC(x, y - 1))
                    {
                        BeginInvoke(new Action(() => { spawnFire(0, x, y - 1, "More_Fire.txt"); }));
                        Thread.Sleep(5);
                    }
                    else
                    {
                        if (x < X && x > 0)
                        {
                            if (fC(x + 1, y))
                            {
                                BeginInvoke(new Action(() => { spawnFire(0, x + 1, y, "More_Fire.txt"); }));
                                Thread.Sleep(5);
                            }
                            else
                            {
                                if (fC(x - 1, y))
                                {
                                    BeginInvoke(new Action(() => { spawnFire(0, x - 1, y, "More_Fire.txt"); }));
                                    Thread.Sleep(5);
                                }
                                else
                                {
                                    Proc[i]._HP = 0;
                                    Map_Data[x, y] = 1;
                                    Bitmap Img = new Bitmap("coil.png");
                                    BeginInvoke(new Action(() => { Map[x, y].Image = Img; }));
                                    Thread.Sleep(5);
                                }
                            }
                        }
                        else
                        {
                            Proc[i]._HP = 0;
                            Map_Data[x, y] = 1;
                            Bitmap Img = new Bitmap("coil.png");
                            BeginInvoke(new Action(() => { Map[x, y].Image = Img; }));
                            Thread.Sleep(5);
                        }
                    }
                }
            }
            else
            {
                Proc[i]._HP = 0;
                Map_Data[x, y] = 1;
                Bitmap Img = new Bitmap("coil.png");
                BeginInvoke(new Action(() => { Map[x, y].Image = Img; }));
                Thread.Sleep(5);
            }
        }
        
        void App(int i)
        {
            Proc[i].B++;
        }
        
        void non(int i)
        {
            Proc[i].B = 0;
        }
        //Конец команд

        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

    }
}