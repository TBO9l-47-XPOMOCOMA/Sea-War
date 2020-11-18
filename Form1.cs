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
        Random random = new Random();
        int[,] myMap = new int[mapSize, mapSize];
        int[,] enemyMap = new int[mapSize, mapSize];
        GroupBox MyGroupBox = new GroupBox();
        GroupBox EnemyGroupBox = new GroupBox();
        int[] myDecks = new int[4];
        int[] eDecks = new int[4];
        int myKill;
        int enemyKill;
        public void Init()
        {
            CreateMap();
        }

        public void CreateMap()
        {
            for (int i = 0; i < 4; i++)
            {
                myDecks[i] = 4 - i;
                eDecks[i] = 4 - i;
            }
            myKill = 0;
            enemyKill = 0;
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

        public void ClearField()
        {
            clearButton.Enabled = true;
            random_Button.Enabled = true;
            playLabel.Enabled = true;
            for (int i = 0; i < 4; i++)
            {
                myDecks[i] = 4 - i;
                eDecks[i] = 4 - i;
            }
            myKill = 0;
            enemyKill = 0;
            for (int i = 1; i < mapSize; i++)
            {
                for (int j = 1; j < mapSize; j++)
                {
                    myMap[i, j] = 0;
                    (Controls["myButton" + i + j] as Button).Enabled = true;
                    (Controls["myButton" + i + j] as Button).BackColor = Color.FromArgb(213, 223, 242);
                }
            }

            for (int i = 1; i < mapSize; i++)
            {
                for (int j = 1; j < mapSize; j++)
                {
                    enemyMap[i, j] = 0;
                    (Controls["eButton" + i + j] as Button).Enabled = false;
                    (Controls["eButton" + i + j] as Button).BackColor = Color.FromArgb(213, 223, 242);
                   
                }
            }
        }
    

        public int SetShip(int i, int j, int deck, int selectedDeck, string location, int[,] map, string forControls)
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
                                    if (map[iCords, jCords] == 1) { flag = false; }
                                }
                            }
                        }
                        if (flag)
                        {
                            for (int iter = 0; iter < deck; iter++)
                            {
                                int line = iter + i;
                                map[line, j] = 1;
                                if (forControls == "myButton")
                                {
                                    (Controls[forControls + line + j] as Button).BackColor = Color.FromArgb(149, 104, 222);
                                }
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
                                    if (map[iCords, jCords] == 1) { flag = false; }
                                }
                            }
                        }
                        if (flag)
                        {
                            for (int iter = 0; iter < deck; iter++)
                            {
                                int line = iter + j;
                                map[i, line] = 1;
                                if (forControls == "myButton")
                                {
                                    (Controls[forControls + i + line] as Button).BackColor = Color.FromArgb(149, 104, 222);
                                }
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
            if (singleDeck.Checked) { myDecks[0] = SetShip(i, j, 1, myDecks[0], location,myMap,"myButton"); }
            else if (doubleDeck.Checked) { myDecks[1] = SetShip(i, j, 2, myDecks[1], location, myMap, "myButton"); }
            else if (threeDeck.Checked) { myDecks[2] = SetShip(i, j, 3, myDecks[2], location, myMap, "myButton"); }
            else if (fourDeck.Checked) { myDecks[3] = SetShip(i, j, 4, myDecks[3], location, myMap, "myButton"); }
        }
        
        public void EnemyShoot()
        {
            int i = RandCoords(random);
            int j = RandCoords(random);
            if (myMap[i, j] == 1)
            {
                myMap[i, j] = 3;
                enemyKill++;
                (Controls["myButton" + i + j] as Button).BackColor = Color.Red;
                if(enemyKill==20)
                {
                    EnemyWin alert = new EnemyWin();
                    alert.Show();
                    playAgainButton.Visible = true;
                    playAgainButton.Enabled = true;
                }
                EnemyShoot();
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
                enemyMap[i, j] = 3;
                myKill++;
                (Controls["eButton" + i + j] as Button).BackColor = Color.Red;
                if(myKill==20)
                {
                    PlayerWin alert = new PlayerWin();
                    alert.Show();
                    playAgainButton.Visible = true;
                    playAgainButton.Enabled = true;
                }
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
            if (myDecks[0] == 0 && myDecks[1] == 0 && myDecks[2] == 0 && myDecks[3] == 0)
            {
                for (int iCords = 1; iCords < 11; iCords++)
                    for (int jCords = 1; jCords < 11; jCords++)
                    {
                        (Controls["eButton" + iCords + jCords] as Button).Enabled = true;
                        (Controls["myButton" + iCords + jCords] as Button).Enabled = false;
                    }
                clearButton.Enabled = false;
                random_Button.Enabled = false;
                playLabel.Enabled = false;
                fieldGeneration(eDecks, enemyMap, "eButton");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        
        }
        static int RandCoords(Random random)
        {
            return random.Next(1, 11); 
        }

        public void fieldGeneration(int [] arrayOfDecks, int [,] map, string buttonForControls)
        {
            int index = 3;
            while(arrayOfDecks[0]>0 || arrayOfDecks[1]>0 || arrayOfDecks[2]>0 || arrayOfDecks[3] > 0)
            {
                if (arrayOfDecks[index] == 0)
                    index--;
                int i = RandCoords(random);
                int j = RandCoords(random);
                int rand = random.Next(0, 2);
                string location;
                if (rand == 0) { location = "vertical"; }
                else location = "horizontal";
                arrayOfDecks[index] = SetShip(i, j, index + 1, arrayOfDecks[index],location, map,buttonForControls);
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

            for(int i =0;i<4;i++)
            {
                myDecks[i] = 4 - i;
            }
        }

        private void random_Button_Click(object sender, EventArgs e)
        {
            fieldGeneration(myDecks, myMap,"myButton");
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            playAgainButton.Enabled = false;
            playAgainButton.Visible = false;
            ClearField();
        }
    }
}
