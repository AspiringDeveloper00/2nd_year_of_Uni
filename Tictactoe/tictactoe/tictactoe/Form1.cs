using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private string player1 = "x";
        private string player2 = "o";
        int scoreplayer1 = 0;
        int scoreplayer2 = 0;
        int n;
        Random rnd = new Random();
        int randombutton;
        string gameplay;
        Button[] buttons;
        bool turn = true;
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            

            Int32.TryParse(textBox1.Text, out n);
            if(!(n <= 3 || n % 2 == 0) & !(comboBox1.SelectedItem == null))
            {
                if (comboBox1.SelectedItem.ToString() == "PC")
                {
                    gameplay = "p";
                }
                else if (comboBox1.SelectedItem.ToString() == "Human")
                {
                    gameplay = "h";
                }
                textBox1.Visible = false;
                button1.Visible = false;
                comboBox1.Visible = false;
                n = n * n;
                SetButtons();
                SetGrid();
            }
            else
            {
                MessageBox.Show("Try Again! Pick an odd number equal to 5 or higher! Pick your opponent! ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
            
        }


 //Reset table when there is a winner
        public void winnersreset()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = true;
                buttons[i].BackColor = Color.White;
                buttons[i].Text = "";
                a = 0;
            }
        }
        int a = 0;

        public void gamereset()
        {
            winnersreset();
            Application.Restart();
        }
        //Check winner
        public bool winners()
        {
            bool winner = false;
            int count=0;
            int y = Convert.ToInt32(Math.Sqrt(n));
            //Columns x
            for (int j=0;j<= y-1;j++)
            {
                for (int i = j; i <n; i = i + y)
                {
                    if (i == j) { count = 0; }

                    if (buttons[i].Text == player1)
                    {
                        count = count + 1;
                    }
                }
                if (count == y)
                {
                    for (int i = j; i < n; i = i + y)
                    {
                        buttons[i].BackColor = Color.Blue;
                    }
                    MessageBox.Show("X is Winner");
                    scoreplayer1 += 1;
                    l1.Text = "Score of player X: " + scoreplayer1.ToString();
                    winnersreset();
                    winner = true;
                }
            }

            //Rows x
            for (int j = 0; j <n; j = j + y)
            {
                for (int i = j; i <=j+(y-1); i++)
                {
                    if (i == j) { count = 0; }

                    if (buttons[i].Text == player1)
                    {
                        count = count + 1;
                    }
                }
                if (count == y)
                {
                    for (int i = j; i <= j + (y - 1); i++)
                    {
                        buttons[i].BackColor = Color.Blue;
                    }
                    MessageBox.Show("X is Winner");
                    scoreplayer1 += 1;
                    l1.Text = "Score of player X: " + scoreplayer1.ToString();
                    winnersreset();
                    winner = true;
                }
            }

            //Main diagonal x
            for (int i = 0; i < n; i = i + (y + 1))
            {
                if(i == 0) { count = 0; }

                if (buttons[i].Text == player1)
                {
                    count = count + 1;
                }
            }

            if (count == y)
            {
                for (int i = 0; i < n; i = i + (y + 1))
                {
                    buttons[i].BackColor = Color.Blue;
                }
                MessageBox.Show("X is Winner");
                scoreplayer1 += 1;
                l1.Text = "Score of player X: " + scoreplayer1.ToString();
                winnersreset();
                winner = true;
            }

            //Secondary diagonal x
            for(int i = y - 1; i <= n - y; i = i + (y - 1))
            {
                if (i == y-1) { count = 0; }

                if (buttons[i].Text == player1)
                {
                    count = count + 1;
                }
            }

            if (count == y)
            {
                for (int i = y - 1; i <= n - y; i = i + (y - 1))
                {
                    buttons[i].BackColor = Color.Blue;
                }
                MessageBox.Show("X is Winner");
                scoreplayer1 += 1;
                l1.Text = "Score of player X: " + scoreplayer1.ToString();
                winnersreset();
                winner = true;
            }


            //Columns O
            for (int j = 0; j <= y - 1; j++)
            {
                for (int i = j; i < n; i = i + y)
                {
                    if (i == j) { count = 0; }

                    if (buttons[i].Text == player2)
                    {
                        count = count + 1;
                    }
                }
                if (count == y)
                {
                    for (int i = j; i < n; i = i + y)
                    {
                        buttons[i].BackColor = Color.Red;
                    }
                    MessageBox.Show("O is Winner");
                    scoreplayer2 += 1;
                    l2.Text = "Score of player O: " + scoreplayer2.ToString();
                    winnersreset();
                    winner = true;
                }
            }

            //Rows O
            for (int j = 0; j < n; j = j + y)
            {
                for (int i = j; i <= j + (y - 1); i++)
                {
                    if (i == j) { count = 0; }

                    if (buttons[i].Text == player2)
                    {
                        count = count + 1;
                    }
                }
                if (count == y)
                {
                    for (int i = j; i <= j + (y - 1); i++)
                    {
                        buttons[i].BackColor = Color.Red;
                    }
                    MessageBox.Show("O is Winner");
                    scoreplayer2 += 1;
                    l2.Text = "Score of player O: " + scoreplayer2.ToString();
                    winnersreset();
                    winner = true;
                }
            }

            //Main diagonal O
            for (int i = 0; i < n; i = i + (y + 1))
            {
                if (i == 0) { count = 0; }

                if (buttons[i].Text == player2)
                {
                    count = count + 1;
                }
            }

            if (count == y)
            {
                for (int i = 0; i < n; i = i + (y + 1))
                {
                    buttons[i].BackColor = Color.Red;
                }
                MessageBox.Show("O is Winner");
                scoreplayer1 += 1;
                l2.Text = "Score of player O: " + scoreplayer2.ToString();
                winnersreset();
                winner = true;
            }

            //Secondary diagonal O
            for (int i = y - 1; i <= n - y; i = i + (y - 1))
            {
                if (i == y - 1) { count = 0; }

                if (buttons[i].Text == player2)
                {
                    count = count + 1;
                }
            }

            if (count == y)
            {
                for (int i = y - 1; i <= n - y; i = i + (y - 1))
                {
                    buttons[i].BackColor = Color.Red;
                }
                MessageBox.Show("O is Winner");
                scoreplayer1 += 1;
                l2.Text = "Score of player O: " + scoreplayer2.ToString();
                winnersreset();
                winner = true;
            }

            a += 1;

            if (gameplay == "h")
            {
                if (a == n & winner == false)
                {
                    MessageBox.Show("It's a tie");
                    winnersreset();
                }
            }
            else
            {
                if (a == n+1 & winner == false)
                {
                    MessageBox.Show("It's a tie");
                    winnersreset();
                }
            }

            if (scoreplayer1 == 5)
            {
                MessageBox.Show("PLAYER X IS THE FINAL WINNER", "Winner announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gamereset();
            }else if (scoreplayer2 == 5)
            {
                MessageBox.Show("PLAYER O IS THE FINAL WINNER", "Winner announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gamereset();
            }
            return winner;
        }
        

       
        public void Game(object sender, EventArgs e)
        {
            if (gameplay == "h")
            {
                Button clicked = (Button)sender;
                if (turn)
                {
                    clicked.Text = player1;
                }
                else
                {
                    clicked.Text = player2;
                }

                turn = !turn;
                clicked.Enabled = false;

                winners();
            }
            else
            {

                Button clicked = (Button)sender;
                clicked.Text = player1;
                clicked.Enabled = false;
                winners();
                while (true)
                {
                    randombutton = rnd.Next(n);
                    if (buttons[randombutton].Enabled == true)
                    {
                        buttons[randombutton].Text = player2;
                        buttons[randombutton].Enabled = false;
                        winners();
                        break;
                    }
                }
                             

            }
        }






        Label l1;
        Label l2;
        //Paint buttons in a 2d array
        public void SetGrid()
        {
            int y = Convert.ToInt32(Math.Sqrt(n));
            this.Size = new System.Drawing.Size(y * 100, y * 100);
            l1 = new Label();
            l2 = new Label();
            l1.Font = new Font("Arial", 15, FontStyle.Bold);
            l2.Font = new Font("Arial", 15, FontStyle.Bold);
            l1.Size = new Size (400, 30);
            l2.Size = new Size(400, 30);
            l1.Location = new Point(30, (y * 100 - 100) / 2 + 100);
            l2.Location= new Point(30, (y * 100 - 100) / 2 + 130);
            l1.Text = "Score of player X: " + scoreplayer1.ToString();
            l2.Text = "Score of player O: " + scoreplayer2.ToString();
            l1.Parent = this;
            l2.Parent = this;
            Controls.Add(l1);
            Controls.Add(l2);
            int k = 0;
            for (int j=30; j <= (y*100-100)/2 +30 ; j=j+50)
            {
                for (int i=0;i<= (y * 100 - 100); i = i + 100)
                {
                    buttons[k].Parent = this;
                    buttons[k].Location = new Point(i, j);
                    k = k + 1;
                }
                
            }
           

            for (int i = 0; i < buttons.Length; i++)
            {

                buttons[i].Click += new EventHandler(Game);
                buttons[i].BackColor = Color.White;


                
            }
        }

        //Initiate button array
        public void SetButtons()
        {
            buttons = new Button[n];
            for (int i = 0; i <= n - 1; i++)
            {
                buttons[i] = new Button();
            }

           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Classic tic tac toe game that you can play vs the pc or a friend! First player to reach 5 wins, simply wins!");
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Visible == false)
            {
                gamereset();
            }
            else { Application.Restart(); }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
