using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {

        Button[,] button;
        string step;
        int total_Value;
        int countStep = 0;
        int value_X;
        int value_Y;
        string Xor0Sender;
        public Form1(int X, int Y, string Xor0Start) // check n * n or X or O
        {
            value_X = X;
            value_Y = Y;
            Xor0Sender = Xor0Start;
            total_Value = value_X * value_Y;
            //X or O sender value
            step = Xor0Sender;
            InitializeComponent();
            button = new Button[X, Y];
            int code = 0; // uniqueCode
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    button[i, j] = new Button(); 
                    button[i, j].Parent = panel1; 
                    button[i, j].Width = panel1.Width / X; 
                    button[i, j].Height = panel1.Height / X;

                    button[i, j].Top = j * panel1.Height / X; 
                    button[i, j].Left = i * panel1.Width / X; 
                    button[i, j].Click += new EventHandler(onclick);
                    button[i, j].Tag = code; // assigning each unique code 

                    int fontSize = 20;
                    button[i, j].Font = new Font(button[i, j].Font.FontFamily, fontSize, FontStyle.Bold);
                    code++;
                }
            }
        }

        //buttons lock (winner)
        private void win(string Xor0)
        {
            for (int i = 0; i < value_X; i++)
            {
                for (int j = 0; j < value_Y; j++)
                {
                    if (button[i, j].Text == Xor0)
                    {
                        button[i, j].BackColor = Color.FromArgb(0, 255, 0); // initialized a button
                    }
                    if (button[i, j].Text != Xor0)
                    {
                        button[i, j].BackColor = Color.FromArgb(128, 0, 0); 
                    }
                    if (button[i, j].Text == "")
                    {
                        button[i, j].BackColor = Color.FromArgb(0, 0, 0); 
                    }

                }
            }
            DialogResult result = MessageBox.Show(Xor0 + " Won this game", "Play Again?", MessageBoxButtons.YesNo);

            if (Convert.ToString(result) == "Yes")
            {
                Start frmStart = new Start();
                this.Hide();
                frmStart.Closed += (s, args) => this.Close();
                frmStart.Show();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        public void check1(int i, int j, string x)
        {
            try
            {
                if (button[i, j].Text == x && button[i - 1, j].Text == x && button[i + 1, j].Text == x) //Horizontal
                {
                    win(x);
                }
                if (button[i, j].Text == x && button[i, j - 1].Text == x && button[i, j + 1].Text == x)//Eilute
                {
                    win(x);
                }
                if (button[i, j].Text == x && button[i - 1, j - 1].Text == x && button[i + 1, j + 1].Text == x) //one Diagonales
                {
                    win(x);
                }
                if (button[i, j].Text == x && button[i - 1, j + 1].Text == x && button[i + 1, j - 1].Text == x) //Diagonales
                {
                    win(x);
                }
            }
            catch
            {
                if (i == 0 && j == 0)
                {
                    i++;
                    j++;
                    if (button[i, j].Text == x && button[i - 1, j].Text == x && button[i + 1, j].Text == x) //Horizontal
                    {
                        win(x);
                    }
                    if (button[i, j].Text == x && button[i, j - 1].Text == x && button[i, j + 1].Text == x)//Eilute
                    {
                        win(x);
                    }
                    if (button[i, j].Text == x && button[i - 1, j - 1].Text == x && button[i + 1, j + 1].Text == x) //Diagonales
                    {
                        win(x);
                    }
                    if (button[i, j].Text == x && button[i - 1, j + 1].Text == x && button[i + 1, j - 1].Text == x) //Diagonales
                    {
                        win(x);
                    }
                }
            }
        }
        private void checknxn()
        {
            for (int i = 0; i < value_X; i++)
            {
                for (int j = 0; j < value_Y; j++)
                {
                    check1(i, j, "X");
                    check1(i, j, "0");
                }
            }
        }

      //For Row
        private void checkRow(int j, string Xor0)
        {
            //int x = value_X;
            int counting = 0;
            bool flag = true; 
            //Line Counting !
            for (int i = 0; i < value_X; i++) //- 1
            {
                if (button[i, j].Text == Xor0 && flag == true)
                {
                    counting++;
                    if (counting == value_X)
                    {
                        win(Xor0);

                    }
                }
                else
                {
                    counting = 0;
                    break;
                }
            }
        }

        //Column
        private void checkColumn(int j, string Xor0)
        {
            //int IsViso = musuX;
            int counting = 0;
            bool flag = true; 
            //Column Counting
            for (int i = 0; i < value_X; i++) //- 1
            {
                if (button[j, i].Text == Xor0 && flag == true)
                {
                    counting++;
                    if (counting == value_X)
                    {
                        win(Xor0);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        //TIK Connection
        public void checkDiagonalLeftToRight(string Xor0)
        {
            int counting = 0;
            for (int i = 0; i < value_X; i++)
            {
                for (int j = 0; j < value_X; j++)
                {
                    if (i == j) // finding primary diagonal
                    {
                        if (button[i, j].Text == Xor0)
                        {
                            counting++;
                        }
                        else
                        {
                            break;
                        }
                        if (value_X == counting)
                        {
                            win(Xor0);
                            return;
                        }

                    }
                } // j
            } // i
        }

        private void checkDiagonalRightToLeft(string Xor0)
        {
            int counting = 0;

            for (int i = 0; i < value_X; i++)
            {
                for (int j = 0; j < value_X; j++)
                {
                    if (i == value_X - j - 1)// finding sum of secondary diagonal
                    {
                        if (button[i, j].Text == Xor0)
                        {
                            counting++;
                        }
                        else
                        {
                            break;
                        }
                        if (value_X == counting)
                        {
                            win(Xor0);
                        }
                    }
                } // j
            } // i

        }

        private void check()
        {
            for (int i = 0; i < value_X; i++)
            {
                checkRow(i, "X");
                checkRow(i, "0");

                checkColumn(i, "X");
                checkColumn(i, "0");

            }
            checkDiagonalLeftToRight("X");
            checkDiagonalLeftToRight("0");

            checkDiagonalRightToLeft("X");
            checkDiagonalRightToLeft("0");
            // checkn*n();
            if (countStep == total_Value)
            {
                CheckAll();
            }
        }

        private void onclick(object sender, EventArgs e)
        {

            // Print X to 0 , on table 
            Button b = (Button)sender;
            if (b.Text == "")
            {
                b.Text = step;
                countStep++;
            }

            // Switch from X to O
            if (step == "X")
            {
                step = "0";
            }
            else
            {
                step = "X";
            }
            check();
        }

        Boolean isCycle = false;
        //Draw
        public void CheckAll()
        {
            while (isCycle == false)
            {
                int request = 0;
                if (request != 4)
                {

                    if (checkRowForX().Contains("false") && checkColumnForX().Contains("false") &&
                        checkDiagonalLeftToRightX().Contains("false") && checkDiagonalRightToLeftX().Contains("false"))
                    {
                        request = 4;
                    }
                    else
                    {
                        isCycle = true;
                        request = 0;
                        MessageBox.Show("Try Again");
                    }

                    if (request == 4)
                    {
                        isCycle = true;
                        MessageBox.Show("Game Over");
                    }
                }
                else
                {
                    isCycle = true;
                    MessageBox.Show("Try Again");
                } 
            }
            MessageBox.Show("Try Again");
        }

        public string checkRowForX()
        {
            string Xor0 = "X";
            //  fillTableToWinRow();
            for (int i = 0; i < value_X; i++)
            {
                for (int j = 0; j < value_Y; j++)
                {
                    int counting = 0;
                    bool flag = true;
                    //Line Counting
                    for (int k = 0; k < value_X; k++) //- 1
                    {
                        if (button[j, k].Text == Xor0 && flag == true)
                        {
                            counting++;
                            if (counting == value_X)
                            {
                                return "true";
                            }
                        }
                        else
                        {
                            counting = 0;
                            break;
                        }
                    }

                }
            }
            return "false";
        }
        //ForColumn
        public string checkColumnForX()
        {
            string Xor0 = "X";
            // fillTableToWinColumn();
            for (int i = 0; i < value_X; i++)
            { 
                for (int j = 0; j < value_Y; j++)
                {
                    //int IsViso = musuX;
                    int counting = 0;
                    bool flag = true; 
                    //Column Counting
                    for (int k = 0; k < value_X; k++) //- 1
                    {
                        if (button[i, k].Text == Xor0 && flag == true)
                        {
                            counting++;
                            if (counting == value_X)
                            {
                                return "true";
                            }
                        }
                        else
                        {
                            counting = 0;
                            break;
                        }
                    }
                }
            }
            return "false";
        }

        //Right Diagonale 
        public string checkDiagonalLeftToRightX()
        {
            int count = 0;
            //  fillTableToWinDiagonalLeftToRightX();
            for (int i = 0; i < value_X; i++)
            {
                for (int j = 0; j < value_X; j++)
                {
                    if (i == value_X - j - 1)
                    {
                        if (Convert.ToString(button[i, j]) == "X")
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                        if (value_X == count)
                        {
                            return "true";
                        }
                    }
                } // j
            } // i
            return "false";
        }

        //Left Diagonale
        public string checkDiagonalRightToLeftX()
        {
            string Xor0 = "X";
            // fillTableToWinDiagonalRightToLeftX();
            int count = 0;
            for (int i = 0; i < value_X; i++)
            {
                for (int j = 0; j < value_X; j++)
                {
                    if (i == j)// finding primary diagonal 
                    {
                        if (Convert.ToString(button[i, j]) == Xor0)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                        if (value_X == count)
                        {
                            return "true";
                        }
                    }
                } // j
            } // i
            return "false";
        }

        // Tas Atsakingas Custom Draggable Windows Form Application
        private void Start_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;

        private void Start_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

