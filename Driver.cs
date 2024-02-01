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
            validNum = true;

            Console.WriteLine("\nPlayer " + player + "'s turn...\n" + "Which row do you want to pick (1-3)? ");
            rowNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Which column do you want to pick (1-3)? ");
            colNum = int.Parse(Console.ReadLine());

            if ((colNum > 3 || colNum < 1) || (rowNum > 3 || rowNum < 1)) //Make sure that the input is between 1 and 3
            {
                Console.WriteLine("Please enter a number between 1 and 3 (1,2,or 3).");
                validNum = false;
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
