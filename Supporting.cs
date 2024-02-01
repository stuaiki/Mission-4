using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    internal class Supporting
    {
        public void printBoard(string[,] boardArray) //Prints board
        {
            // print boardArray[x][y]
            // print | after the first and second position of the row
            // print a bunch of dashes in a new line

            Console.WriteLine("\n" + "  1   2   3");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + 1);
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($" {boardArray[row, col]} ");
                    if (col < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (row < 2) Console.WriteLine(" -----------");
            }
        }

        public string[] gameResults(string[,] boardArray) //Find if there is a winner and who it is
        {
            string[] results = new string[2];
            string foundWinner = "No";
            string winnerName = "Tie Game";
          
            // Check rows three in a row
            for (int row = 0; row < 3; row++)
            {
                if ((boardArray[row, 0] == boardArray[row, 1]) && (boardArray[row, 1] == boardArray[row, 2]))
                {
                    if (boardArray[row, 0] == "X" || boardArray[row, 0] == "O")
                    {
                        foundWinner = "Yes";
                        winnerName = boardArray[row, 0];
                        if (boardArray[row, 0] == "X")
                        {
                            winnerName = "Player 1";
                        }
                        else
                        {
                            winnerName = "Player 2";
                        }
                    }
                }
            }

            //Check column three in a row
            if (foundWinner.Equals("No"))
            {
                for (int col = 0; col < 3; col++)
                {
                    if ((boardArray[0, col] == boardArray[1, col]) && (boardArray[1, col] == boardArray[2, col]))
                    {
                        if (boardArray[0, col] == "X" || boardArray[0, col] == "O")
                        {
                            foundWinner = "Yes";
                            if (boardArray[0, col] == "X")
                            {
                                winnerName = "Player 1";
                            }
                            else
                            {
                                winnerName = "Player 2";
                            }
                        }
                    }
                }
            }

            //Check diagonal three in a row
            if (foundWinner.Equals("No"))
            {
                if ((boardArray[0, 2] == boardArray[1, 1]) && (boardArray[1, 1] == boardArray[2, 0]))
                {
                    if (boardArray[0, 2] == "X" || boardArray[0, 2] == "O")
                    {
                        foundWinner = "Yes";
                        if (boardArray[0, 2] == "X")
                        {
                            winnerName = "Player 1";
                        }
                        else
                        {
                            winnerName = "Player 2";
                        }
                    }
                }

                if ((boardArray[0, 0] == boardArray[1, 1]) && (boardArray[1, 1] == boardArray[2, 2]))
                {
                    if (boardArray[0, 0] == "X" || boardArray[0, 0] == "O")
                    {
                        foundWinner = "Yes";

                        if (boardArray[0, 0] == "X")
                        {
                            winnerName = "Player 1";
                        }
                        else
                        {
                            winnerName = "Player 2";
                        }
                    }
                }
            }

            results[0] = foundWinner;
            results[1] = winnerName;

            return results;
        }
    }
}
