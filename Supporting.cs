using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    internal class Supporting
    {
        public void printBoard(string[] boardArray)
        {
            // print boardArray[x][y]
            // print | after the first and second position of the row
            // print a bunch of dashes in a new line
            Console.WriteLine(" 1 2 3");
            for (int row = 0; row < boardArray.Length; row++)
            {
                Console.Write(row + 1);
                for (int col = 0; col < boardArray[i].Length; col++)
                {
                    Console.Write($" {boardArray[row, col]}");
                    if (col < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (row < 2) Console.WriteLine(" -----");
            }
        }

        public string[] gameResults(string[] boardArray)
        {
            string[] results = new string[2];
        }
    }
}
