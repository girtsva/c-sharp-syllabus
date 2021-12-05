using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            PlayGame();
        }

        private static void PlayGame()
        {
            string[] players = InitGame();
            InitBoard();
            DisplayBoard();
            bool player1Turn = true;
            string playerTurnName;

            do
            {
                if (player1Turn)
                {
                    playerTurnName = players[0];
                }
                else
                {
                    playerTurnName = players[1];
                }

                MakeAMove(players, playerTurnName);
                Console.Clear();
                DisplayBoard();
                if (IsGameOver(players) == 1)
                {
                    GameOverChoice();
                    break;
                }
                player1Turn = !player1Turn;
            } while (IsGameOver(players) == 0);

            Console.ReadKey();
        }
        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }  
        }

        private static void DisplayBoard()
        {
            Console.WriteLine();
            Console.WriteLine("      0   1   2");
            Console.WriteLine("    +---+---+---+");
            Console.WriteLine("  0 | " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2] + " |");
            Console.WriteLine("    +---+---+---+");
            Console.WriteLine("  1 | " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2] + " |");
            Console.WriteLine("    +---+---+---+");
            Console.WriteLine("  2 | " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + " |");
            Console.WriteLine("    +---+---+---+");
            Console.WriteLine();
        }

        private static string[] InitGame()
        {
            Console.WriteLine("Welcome to TIC TAC TOE game!\n");
            Console.Write("Player one, enter your name: ");
            string player1 = Console.ReadLine();
            Console.Write("Player two, enter your name: ");
            string player2 = Console.ReadLine();
            Console.WriteLine($"\n{player1} goes first and starts with X. Then {player2} will continue with O...");
            return new string[] { player1, player2 };
        }
        
        private static void MakeAMove(string[] players, string player)
        {
            string str;
            int rowIndex;
            int columnIndex;
            bool inputCorrect;
            do
            {
                Console.Write($"{player}, it's your move. Choose your location (0-2 for row and 0-2 for column, e.g. 00): ");
                str = Console.ReadLine();

                if (str.Length != 2 || !int.TryParse(str[0].ToString(), out rowIndex) || !int.TryParse(str[1].ToString(), out columnIndex))
                {
                    Console.WriteLine($"Incorrect value! You entered {str}");
                    inputCorrect = false;
                    continue;
                }

                if (rowIndex < 0 || rowIndex > 2 || columnIndex < 0 || columnIndex > 2)
                {
                    Console.WriteLine("Value is out of game field bounds! Enter 0-2 for row and 0-2 for column (e.g. 00).");
                    inputCorrect = false;
                    continue;
                }

                if (board[rowIndex, columnIndex] == ' ')
                {
                    board[rowIndex, columnIndex] = DrawsXorO(players, player);
                    inputCorrect = true;
                }
                else
                {
                    Console.WriteLine("You can't move here, the location is already taken!");
                    inputCorrect = false;
                }

            } while (inputCorrect == false);
        }

        private static char DrawsXorO(string[] players, string player)
        {
            if (player == players[0])
            {
                return 'X';
            }
            else
            {
                return 'O';
            }
        }

        private static int IsGameOver(string[] players)
        {
            if (HasPlayerWon() == 'X')
            {
                Console.WriteLine($"Congratulations! {players[0]} has won!");
                return 1;
            }
            else if (HasPlayerWon() == 'O')
            {
                Console.WriteLine($"Congratulations! {players[1]} has won!");
                return 1;
            }
            else if (IsDraw())
            {
                Console.WriteLine("The game is a tie!");
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private static char HasPlayerWon()
        {
            if (board[0, 0] != ' ' && board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
            {
                return board[0, 0];
            } 
            else if (board[1, 0] != ' ' && board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                return board[1, 0];
            }
            else if (board[2, 0] != ' ' && board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                return board[2, 0];
            }
            else if (board[0, 0] != ' ' && board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                return board[0, 0];
            }
            else if (board[0, 1] != ' ' && board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                return board[0, 1];
            }
            else if (board[0, 2] != ' ' && board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                return board[0, 2];
            }
            else if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0];
            }
            else if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return board[0, 2];
            }
            else
            {
                return ' ';
            }
        }

        private static bool IsDraw()
        {
            if (board[0, 0] != ' ' && board[0, 1] != ' ' && board[0, 2] != ' ' &&
                board[1, 0] != ' ' && board[1, 1] != ' ' && board[1, 2] != ' ' &&
                board[2, 0] != ' ' && board[2, 1] != ' ' && board[2, 2] != ' ')
                {
                return true;
            }
            return false;
        }

        private static void GameOverChoice()
        {
            Console.WriteLine("GAME OVER!");
            int gameEndChoice;

            do
            {
                Console.Write("Do you want to RESTART (input 1) or QUIT (input 2)? ");

                if (int.TryParse(Console.ReadLine(), out gameEndChoice))
                {
                    if (gameEndChoice == 1)
                    {
                        Console.Clear();
                        PlayGame();
                    }
                    else if (gameEndChoice == 2)
                    {
                        Environment.Exit(0);
                    }
                }

            } while (gameEndChoice != 1 || gameEndChoice != 2);
        }
    }
}
