//Group 3-7 Aiki Takaku, Parker Watts, Donna Kim, Mac Hartsell 
//Tic Tac Toe Project with driver part and supporting class part
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Driver;


//Start game message
Console.WriteLine("Welcome to the Tic-Tac-Toe game!");
Console.WriteLine("Select the row and column to play the game.");

// Declare variables PlayGame, Number of turns, result string, and board string
Supporting supTools = new Supporting();
bool bPlayGame = true;
int iNum = 0;
string[] result = new string[2];
string[,] boardArray = {
{ " ", " ", " " },
{ " ", " ", " " },
{ " ", " ", " " }
};

//Print out the blank board 
supTools.printBoard(boardArray);

//Start the game
while (bPlayGame)
{
    //Reset variables every turn
    int player = 0;
    string symbol = "";
    bool bPosition = true;

    //Decide which player and turn
    if (iNum % 2 == 0)
    {
        symbol = "X";
        player = 1;
    }
    else
    {
        symbol = "O";
        player = 2;
    }

    //Get the input for rows and colomns
    while (bPosition)
    {
        int rowNum = 0;
        int colNum = 0;
        bool validNum = true;

        do
        {
            Console.Write("Which row do you want to pick (1-3)? ");
            string rowInput = Console.ReadLine();

            Console.Write("Which column do you want to pick (1-3)? ");
            string colInput = Console.ReadLine();

            if (int.TryParse(rowInput, out rowNum) && int.TryParse(colInput, out colNum))
            {
                // Both inputs were successfully parsed into integers.
                if (rowNum >= 1 && rowNum <= 3 && colNum >= 1 && colNum <= 3)
                {
                    // Both values are within the valid range.
                    validNum = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 3 (1, 2, or 3) for both row and column.");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid integer values for both row and column.");
            }

        } while (!validNum);

        if (boardArray[rowNum - 1, colNum - 1] == "X" || boardArray[rowNum - 1, colNum - 1] == "O") // Don't let user pick occupied spot
        {
            Console.WriteLine("Position is taken. Please choose another spot.");
        }
        else // Add symbol to spot
        {
            boardArray[rowNum - 1, colNum - 1] = symbol;
            bPosition = false;
        }
    }

    // Increase turn number
    iNum++;

    //Call methods to print board and see if there is a winner
    supTools.printBoard(boardArray);
    result = supTools.gameResults(boardArray);

    //End game when someone gets tic tac toe
    if (result[0].Equals("Yes"))
    {
        Console.WriteLine($"\nTic-Tac-Toe, Three in a Row! The winner is {result[1]}!!");
        bPlayGame = false;
    }

    //End game at Nine turns with tie if there is no winner
    if (iNum == 9 && result[0].Equals("No"))
    {
        Console.WriteLine("\nTie game. Thanks for playing!");
        bPlayGame = false;
    }
}
