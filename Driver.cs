internal class Program
{
    static char[,] board = new char[3, 3];
    private static void Main(string[] args)
    {
        // Welcome the user to the game
        Console.WriteLine("Welcome to the Tic-Tac-Toe game!");

        Console.WriteLine(" 1 2 3");
        for (int row = 0; row < 3; row++)
        {
            Console.Write(row + 1);
            for (int col = 0; col < 3; col++)
            {
                Console.Write($" {board[row, col]}");
                if (col < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (row < 2) Console.WriteLine(" -----");
        }
    }


}