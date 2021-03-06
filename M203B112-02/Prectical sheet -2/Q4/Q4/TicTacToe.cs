using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class TicTacToe
    {
        private char win;
        public char winPerson
        {
            get
            {
                return win;
            }
            set
            {
                win = value;
            }
        }
        private bool hasWon;
        public bool isWin
        {
            get
            {
                return hasWon;
            }
            set
            {
                hasWon = value;
            }
        }
        private bool isX;
        public bool isY
        {
            get
            {
                return isX;
            }
            set
            {
                isX = value;
            }
        }
        private char boxone, boxtwo, boxthree, boxfour, boxfive, boxsix, boxseven, boxeight, boxnine;
        public char box1
        {
            get
            {
                return boxone;
            }
            set
            {
                boxone = value;
            }
        }
        public char box2
        {
            get
            {
                return boxtwo;
            }
            set
            {
                boxtwo = value;
            }
        }
        public char box3
        {
            get
            {
                return boxthree;
            }
            set
            {
                boxthree = value;
            }
        }
        public char box4
        {
            get
            {
                return boxfour;
            }
            set
            {
                boxfour = value;
            }
        }
        public char box5
        {
            get
            {
                return boxfive;
            }
            set
            {
                boxfive = value;
            }
        }
        public char box6
        {
            get
            {
                return boxsix;
            }
            set
            {
                boxsix = value;
            }
        }
        public char box7
        {
            get
            {
                return boxseven;
            }
            set
            {
                boxseven = value;
            }
        }
        public char box8
        {
            get
            {
                return boxeight;
            }
            set
            {
                boxeight = value;
            }
        }
        public char box9
        {
            get
            {
                return boxnine;
            }
            set
            {
                boxnine = value;
            }
        }
        public void gameBoard()
        {
            Console.WriteLine(" {0} | {1} | {2} ", boxone, boxtwo, boxthree);
            Console.WriteLine(" --------- ");
            Console.WriteLine(" {0} | {1} | {2} ", boxfour, boxfive, boxsix);
            Console.WriteLine(" --------- ");
            Console.WriteLine(" {0} | {1} | {2} ", boxseven, boxeight, boxnine);
        }
        public void CheckWin()
        { // 123, 456, 789, 147, 258, 369, 159, 357
            if ((box1 == 'X') && (box2 == 'X') && (box3 == 'X'))
            {
                isWin = true;
                winPerson = 'X';
                return;
            }
            if ((box4 == 'X') && (box5 == 'X') && (box6 == 'X'))
            {
                isWin = true;
                winPerson = 'X';
                return;
            }
            if ((box7 == 'X') && (box8 == 'X') && (box9 == 'X'))
            {
                isWin = true;
                winPerson = 'X';
                return;
            }
            if ((box1 == 'X') && (box4 == 'X') && (box7 == 'X'))
            {
                isWin = true;
                winPerson = 'X';
                return;
            }
            if ((box2 == 'X') && (box5 == 'X') && (box8 == 'X'))
            {
                isWin = true;
                winPerson = 'X';
                return;
            }
            if ((box3 == 'X') && (box6 == 'X') && (box9 == 'X'))
            {
                isWin = true;
                winPerson = 'X';
                return;
            } 
            if ((box1 == 'X') && (box5 == 'X') && (box9 == 'X'))
            {
                isWin = true;
                winPerson = 'X';
                return;
            }
            if ((box3 == 'X') && (box5 == 'X') && (box7 == 'X'))
            {
                isWin = true;
                winPerson = '0';
                return;
            }
            if ((box1 == '0') && (box2 == '0') && (box3 == '0'))
            {
                isWin = true;
                winPerson = '0';
                return;
            }
            if ((box4 == '0') && (box5 == '0') && (box6 == '0'))
            {
                isWin = true;
                winPerson = '0';
                return;
            }
            if ((box7 == '0') && (box8 == '0') && (box9 == '0'))
            {
                isWin = true;
                winPerson = '0';
                return;
            }
            if ((box1 == '0') && (box4 == '0') && (box7 == '0'))
            {
                isWin = true;
                winPerson = '0';
                return;
            }
            if ((box2 == '0') && (box5 == '0') && (box8 == '0'))
            {
                isWin = true;
                winPerson = '0';
                return;
            }
            if ((box3 == '0') && (box6 == '0') && (box9 == '0'))
            {
                isWin = true;
                winPerson = '0';
                return;
            } 
            if ((box1 == '0') && (box5 == '0') && (box9 == '0'))
            {
                isWin = true;
                winPerson = '0';
                return;
            }
            if ((box3 == '0') && (box5 == '0') && (box7 == '0'))
            {
                isWin = true;
                winPerson = '0';
                return;
            }
        }
        public void NotVacantError()
        {
            error = true;
            Console.WriteLine();
            Console.WriteLine("Error: box not vacant!");
            Console.WriteLine("Press any key to try again..");
            Console.ReadLine(); //or Console.ReadKey();
            return;
        }
        public void DisplayLoss()
        {
            Console.WriteLine();
            Console.WriteLine("No one won.");
            Console.ReadLine();
            Environment.Exit(1);
        }
        private bool hasError;
        public bool error
        {
            get
            {
                return hasError;
            }
            set
            {
                hasError = value;
            }
        }
        static void Main(string[] args)
        {
            int moveCount = 0; // check movement
            char askMove; // display X or 0 in question
            int selTemp;
            TicTacToe game = new TicTacToe();
            game.error = false;
            game.box1 = ' '; game.box2 = ' '; game.box3 = ' ';
            game.box4 = ' '; game.box5 = ' '; game.box6 = ' ';
            game.box7 = ' '; game.box8 = ' '; game.box9 = ' ';
            game.isY = true;
            Console.WriteLine(" -- Tic Tac Toe -- ");
            Console.Clear();
            while (!game.isWin)
            {
                if (moveCount == 9)
                {
                    game.DisplayLoss();
                }
                if ((game.isY) == true) // if is X
                {
                    askMove = 'X';
                }
                else
                {
                    askMove = '0';
                }
                Console.Clear();
                game.gameBoard();
                Console.WriteLine();
                Console.WriteLine("What box do you want to place {0} in? (1-9)", askMove);
                Console.Write("> ");
                selTemp = int.Parse(Console.ReadLine());
                switch (selTemp)
                {
                    case 1:
                        if (game.box1 == ' ')
                        {
                            game.box1 = askMove;
                            moveCount++;
                        }
                        else
                        {
                            game.NotVacantError();
                        }
                        break;
                    case 2:
                        if (game.box2 == ' ')
                        {
                            game.box2 = askMove;
                            moveCount++;
                        }
                        else
                        {
                            game.NotVacantError();
                        }
                        break;
                    case 3:
                        if (game.box3 == ' ')
                        {
                            game.box3 = askMove;
                            moveCount++;
                        }
                        else
                        {
                            game.NotVacantError();
                        }
                        break;
                    case 4:
                        if (game.box4 == ' ')
                        {
                            game.box4 = askMove;
                            moveCount++;
                        }
                        else
                        {
                            game.NotVacantError();
                        }
                        break;
                    case 5:
                        if (game.box5 == ' ')
                        {
                            game.box5 = askMove;
                            moveCount++;
                        }
                        else
                        {
                            game.NotVacantError();
                        }
                        break;
                    case 6:
                        if (game.box6 == ' ')
                        {
                            game.box6 = askMove;
                            moveCount++;
                        }
                        else
                        {
                            game.NotVacantError();
                        }
                        break;
                    case 7:
                        if (game.box7 == ' ')
                        {
                            game.box7 = askMove;
                            moveCount++;
                        }
                        else
                        {
                            game.NotVacantError();
                        }
                        break;
                    case 8:
                        if (game.box8 == ' ')
                        {
                            game.box8 = askMove;
                            moveCount++;
                        }
                        else
                        {
                            game.NotVacantError();
                        }
                        break;
                    case 9:
                        if (game.box9 == ' ')
                        {
                            game.box9 = askMove;
                            moveCount++;
                        }
                        else
                        {
                            game.NotVacantError();
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong selection entered!");
                        Console.WriteLine("Press any key to try again..");
                        Console.ReadKey();
                        game.error = true;
                        break;
                }
                if (game.error)
                {
                    game.CheckWin(); // if error, just check win
                    game.error = !game.error;
                }
                else
                {
                    game.isY = !game.isY; 
                    game.CheckWin();
                }
            }
            Console.Clear();
            game.gameBoard();
            Console.WriteLine();
            Console.WriteLine("The winner is {0}!", game.winPerson);
            Console.ReadLine();
        }
    }
}
