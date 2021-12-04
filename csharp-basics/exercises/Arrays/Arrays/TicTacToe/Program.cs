using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            string[] players = InitGame();
            //string player1 = players[0];
            //string player2 = players[1];
            InitBoard();
            DisplayBoard();
            //board[1, 2] = 'X';
            //DisplayBoard();
            //InitBoard();
            //DisplayBoard();
            //string playerTurn = player1;
            //char xOrO = ' ';
            //if (playerTurn == player1)
            //{
            //    xOrO = 'X';
            //    playerTurn = player2;
            //}
            //else if (playerTurn == player2)
            //{
            //    xOrO = 'O';
            //    playerTurn = player1;
            //}

            //int countX = board.Count();
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
                DisplayBoard();
                if (IsGameOver(players) == 1)
                {
                    Console.WriteLine("The game is over! Exiting...");  // seit izdomat, ko darit, lai 2x netiktu pasaukts IsGameOver un 2x nerakstitu uzvaretaju, ka ari kas jadara kad game over -> restart or exit
                    //Environment.Exit; 
                }
                player1Turn = !player1Turn;
            } while (IsGameOver(players) == 0);
            

            Console.ReadKey();
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
            
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);           // uzzimet smukaku board - plataku + padomat par Console.Clear pielietosanu, lai neskrolletos visu laiku uz leju
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static string[] InitGame()
        {
            Console.WriteLine("Welcome to Tic Tac Toe game!");
            Console.Write("Player one, enter your name: ");
            string player1 = Console.ReadLine();
            Console.Write("Player two, enter your name: ");
            string player2 = Console.ReadLine();
            Console.WriteLine($"{player1} goes first and starts with X. Then {player2} will continue with O\n");
            return new string[] { player1, player2 };
        }

        //private static void Turn(string[] players, out string player, out char mark)
        //{
        //    int playerIndex = 0;
        //    int nextPlayerIndex = 1 - playerIndex;
        //    player = players[playerIndex];
        //    if (player == players[0])
        //    {
        //        player = players[1];
        //        mark = 'X';
        //    }
        //    else
        //    {
        //        player = players[0];
        //        mark = 'O';
        //    }
        //}

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
        
        private static void MakeAMove(string[] players, string player)
        {
            string str;
            int rowIndex;
            int columnIndex;
            bool inputCorrect;
            do
            {
                Console.Write($"{player}, it's your move. Choose your location (0-2 for row and 0-2 for column): ");
                str = Console.ReadLine();                       // seit vai zemak pameginat ielikt parbaudi - ja ievada ko citu ka 0-2 (un citu string garumu) - lai ir pazinojums un loop ievadit atkal; var sasaistit ar inputCorrect??
                rowIndex = (int)Char.GetNumericValue(str[0]);
                columnIndex = (int)Char.GetNumericValue(str[1]);

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
            //if (Array.IndexOf(board, ' ') == -1)              // ta ka so nenem preti 2d array, tad izdomat citu veidu, ka noteikt, ka ir draw
            //{
            //    return true;
            //}
            return false;
        }
    }
}
