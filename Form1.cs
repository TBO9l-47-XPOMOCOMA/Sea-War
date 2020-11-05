using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Sea_War
{
    public partial class Form1 : Form
    {
        public const int mapSize = 12;
        public int cellSize = 45;
        public string alphabet = "АБВГДЕЖЗИК";
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        int[,] myMap = new int[mapSize, mapSize];
        int[,] enemyMap = new int[mapSize, mapSize];
        GroupBox MyGroupBox = new GroupBox();
        GroupBox EnemyGroupBox = new GroupBox();
        int deck1;
        int deck2;
        int deck3;
        int deck4;

        public void Init()
        {
            CreateMap();
        }

        public void CreateMap()
        {
             deck1 = 4;
             deck2 = 3;
             deck3 = 2; 
             deck4 = 1;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    myMap[i, j] = 0;
                    Button button = new Button();
                    button.Location = new Point(78 + j * cellSize, 50 + i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.BackColor = Color.FromArgb(213, 223, 242);
                    button.Tag = new List<int> { i, j };
                    button.Name = "myButton" + i + j;
                    if (i == 11 || j == 11)
                    {
                        button.Visible = false;
                    }
                    MyGroupBox.Controls.Add(button);
                    button.Click += new EventHandler(MyMapClick);
                    if (i == 0 || j == 0)
                    {
                        button.BackColor = Color.White;
                        if (i == 0 && j > 0 && j < 11)
                        {
                            button.Text = alphabet[j - 1].ToString();
                            button.Enabled = false;
                        }
                        if (j == 0 && i > 0 && i < 11)
                        {
                            button.Text = i.ToString();
                            button.Enabled = false;
                        }
                    }
                    this.Controls.Add(button);
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    enemyMap[i, j] = 0;
                    Button button = new Button();
                    button.Location = new Point(778 + j * cellSize, 50 + i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.BackColor = Color.FromArgb(213, 223, 242);
                    button.Tag = new List<int> { i, j };
                    button.Name = "eButton" + i + j;
                    button.Enabled = false;
                    if (i == 11 || j == 11)
                    {
                        button.Visible = false;
                    }
                    EnemyGroupBox.Controls.Add(button);
                    button.Click += new EventHandler(EnemyMapClick);
                    if (i == 0 || j == 0)
                    {
                        button.BackColor = Color.White;
                        if (i == 0 && j > 0 && j < 11)
                        {
                            button.Text = alphabet[j - 1].ToString();
                        }
                        if (j == 0 && i > 0 && i < 11)
                        {
                            button.Text = i.ToString();
                        }
                    }
                    this.Controls.Add(button);
                }
            }
        }

        public int SetShip(int i, int j, int deck, int selectedDeck, string location)
        {
            if (selectedDeck > 0)
            {
                if (location == "vertical")
                {
                    if (i + deck <= 11)
                    {
                        bool flag = true;
                        for (int iCell = i; iCell < i + deck; iCell++)
                        {
                            for (int iCords = iCell - 1; iCords <= iCell + 1; iCords++)
                            {
                                for (int jCords = j - 1; jCords <= j + 1; jCords++)
                                {
                                    if (myMap[iCords, jCords] == 1) { flag = false; }
                                }
                            }
                        }
                        if (flag)
                        {
                            for (int iter = 0; iter < deck; iter++)
                            {
                                int line = iter + i;
                                myMap[line, j] = 1;
                                (Controls["myButton" + line + j] as Button).BackColor = Color.FromArgb(149, 104, 222);

                            }
                            --selectedDeck;
                        }
                    }
                }


                else if (location == "horizontal")
                {
                    if (j + deck <= 11)
                    {
                        bool flag = true;
                        for (int jCell = j; jCell < j + deck; jCell++)
                        {
                            for (int iCords = i - 1; iCords <= i + 1; iCords++)
                            {
                                for (int jCords = jCell - 1; jCords <= jCell + 1; jCords++)
                                {
                                    if (myMap[iCords, jCords] == 1) { flag = false; }
                                }
                            }
                        }
                        if (flag)
                        {
                            for (int iter = 0; iter < deck; iter++)
                            {
                                int line = iter + j;
                                myMap[i, line] = 1;
                                (Controls["myButton" + i + line] as Button).BackColor = Color.FromArgb(149, 104, 222);

                            }
                            --selectedDeck;
                        }
                    }
                }
            }
            return selectedDeck;
        }

        public void MyMapClick(object sender, EventArgs e)
        {
            Button pressedBut = sender as Button;
            List<int> xy = pressedBut.Tag as List<int>;
            int i = xy[0];
            int j = xy[1];
            string location = "";
            if (vertical.Checked) { location = "vertical"; }
            else if (horizontal.Checked) { location = "horizontal"; }
            if (singleDeck.Checked) { deck1 = SetShip(i, j, 1, deck1, location); }
            else if (doubleDeck.Checked) { deck2 = SetShip(i, j, 2, deck2, location); }
            else if (threeDeck.Checked) { deck3 = SetShip(i, j, 3, deck3, location); }
            else if (fourDeck.Checked) { deck4 = SetShip(i, j, 4, deck4, location); }
        }
        
        public void EnemyShoot()
        {
            int i = RandCoords(random);
            int j = RandCoords(random);
            if (myMap[i, j] == 1)
            {
                myMap[i, j] = 2;
                (Controls["myButton" + i + j] as Button).BackColor = Color.Red;
            }
            else if (myMap[i, j] == 0)
            {
                myMap[i, j] = 2;
                (Controls["myButton" + i + j] as Button).BackColor = Color.Gray;

            }
            else if (myMap[i, j] == 2)
            {
                EnemyShoot();
            }
        }
        public void EnemyMapClick(object sender, EventArgs e)
        {
            Button pressedBut = sender as Button;
            List<int> xy = pressedBut.Tag as List<int>;
            int i = xy[0];
            int j = xy[1];
            if(enemyMap[i,j]==1)
            {
                enemyMap[i, j] = 2;
                (Controls["eButton" + i + j] as Button).BackColor = Color.Red;
            }
            else if(enemyMap[i,j]==0)
            {
                enemyMap[i, j] = 2;
                (Controls["eButton" + i + j] as Button).BackColor = Color.Gray;
                EnemyShoot();
            }
        }


        private void playLabel_Click(object sender, EventArgs e)
        {
            if (deck1 == 0 && deck2 == 0 && deck3 == 0 && deck4 == 0)
            {
                for (int iCords = 1; iCords < 11; iCords++)
                    for (int jCords = 1; jCords < 11; jCords++)
                    {
                        (Controls["eButton" + iCords + jCords] as Button).Enabled = true;
                        (Controls["myButton" + iCords + jCords] as Button).Enabled = false;
                    }
                enemyGeneration();
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        Random random = new Random();
        static int RandCoords(Random random)
        {
            return random.Next(1, 11); 
        }

        public void enemyGeneration()
        {
            while (true)
                {
                    int iForDeck4 = RandCoords(random);
                    int jForDeck4 = RandCoords(random);
                    if (iForDeck4 == 1 || iForDeck4 == 10)
                    {
                        if (jForDeck4 + 3 < 11)
                        {
                            for (int iter = 0; iter < 4; iter++)
                            {
                                int jCord = iter + jForDeck4;
                                enemyMap[iForDeck4, jCord] = 1;
                                (Controls["eButton" + iForDeck4 + jCord] as Button).BackColor = Color.FromArgb(149, 104, 222);
                            }
                            break;
                        }
                    }
                    else if (jForDeck4 == 1 || jForDeck4 == 10)
                    {
                        if (iForDeck4 + 3 < 11)
                        {
                            for (int iter = 0; iter < 4; iter++)
                            {
                                int iCord = iter + iForDeck4;
                                enemyMap[iCord, jForDeck4] = 1;
                                (Controls["eButton" + iCord + jForDeck4] as Button).BackColor = Color.FromArgb(149, 104, 222);
                            }
                            break;
                        }
                    }

                }
            
        }
            private void ExitLabel_ExitGame(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            for(int i = 1; i<12;i++)
                for(int j = 1; j<12; j++)
                {
                    (Controls["myButton" + i + j] as Button).BackColor = Color.FromArgb(213, 223, 242);
                    myMap[i, j] = 0;
                }
            deck1 = 4; deck2 = 3; deck3 = 2; deck4 = 1;
        }
    }
}
