using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        int deck1 = 4; int deck2 = 3; int deck3 = 2; int deck4 = 1;

        public void Init()
        {
            CreateMap();
        }
        
        public void CreateMap()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    myMap[i, j] = 0;
                    enemyMap[i, j] = 0;
                    Button button = new Button();
                    button.Location = new Point(78 + j * cellSize, 50 + i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.BackColor = Color.FromArgb(213, 223, 242);
                    button.Tag = new List<int> { i, j };
                    button.Name = "myButton" + i + j;
                    if(i==11||j==11)
                    {
                        button.Visible = false;
                    }
                    MyGroupBox.Controls.Add(button);
                    button.Click += new EventHandler(PlayerClick); 
                    if (i == 0||j==0)
                    {
                        button.BackColor = Color.White;
                        if (i == 0&&j>0&&j<11)
                        {
                            button.Text = alphabet[j-1].ToString();
                        }
                        if(j==0&&i>0&&i<11)
                        {
                            button.Text = i.ToString();
                        }
                    }
                    this.Controls.Add(button);
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(778+j * cellSize,50+i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.BackColor = Color.FromArgb(213, 223, 242);
                    button.Name = "eButton" + i + j;
                    if (i == 11 || j == 11)
                    {
                        button.Visible = false;
                    }
                    EnemyGroupBox.Controls.Add(button);
                    if (i == 0 || j == 0)
                    {
                        button.BackColor = Color.White;
                        if (i == 0 && j>0&&j<11)
                        {
                            button.Text = alphabet[j-1].ToString();
                        }
                        if (j == 0 && i > 0&&i<11)
                        {
                            button.Text = i.ToString();
                        }
                    }
                    this.Controls.Add(button);
                }
            }
        }

        public void PlayerClick(object sender, EventArgs e)
        {
            Button pressedBut = sender as Button;
            List<int> xy = pressedBut.Tag as List<int>;
            int i = xy[0];
            int j = xy[1];
            int deck = 0;
            string location = "";
            if (singleDeck.Checked) { deck = 1; }
            else if (doubleDeck.Checked) { deck = 2; }
            else if (threeDeck.Checked) { deck = 3; }
            else if (fourDeck.Checked) { deck = 4; }
            if (vertical.Checked) { location = "vertical"; }
            else if (horizontal.Checked) { location = "horizontal"; }
            switch (deck)
            {
                case 1:
                    {
                        if (deck1 > 0)
                        {
                            bool flag = true;
                            for(int iCords = i-1;iCords<=i+1;iCords++)
                            {
                                for (int jCords = j-1; jCords <= j+1; jCords++)
                                {
                                    if (myMap[iCords, jCords] == 1) { flag = false; }
                                }
                            }
                            if (flag == true)
                            {
                                myMap[i, j] = 1;
                                (Controls["myButton" + i + j] as Button).BackColor = Color.FromArgb(149, 104, 222);
                                deck1--;
                            }                          
                        }
                        break;
                    }

                case 2:
                    {
                        if (deck2 > 0)
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
                                        deck2--;
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
                                        deck2--;
                                    }
                                }
                            }
                            
                        }
                        break;
                    }

                case 3:
                    {
                        if (deck3 > 0)
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
                                        deck3--;
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
                                        deck3--;
                                    }
                                }
                            }
                            
                        }
                        break;
                    }

                case 4:
                    {
                        if (deck4 > 0)
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
                                        deck4--;
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
                                        deck4--;
                                    }
                                }
                            }
                            
                        }
                        break;
                    }
            }
        }

            private void ExitLabel_ExitGame(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
