// Welcome the user to the game
using System.Runtime.InteropServices;

Console.WriteLine("Welcome to the Tic-Tac-Toe game!");
// make variables
bool bPlayGame = true;
bool bPosition = true;
string rowNum = "";
string colNum = "";
string[,] boardArray = {
{ " ", " ", " " },
{ " ", " ", " " },
{ " ", " ", " " }
};

while (bPlayGame == true)
{
    int iNum = 0;
    string symbol = "";

    if (iNum % 2 == 0)
    {
        symbol = "O";
    }
    else
    {
        symbol = "X";
    }


    while (bPosition == true)
    {
        bPosition = false;

        Console.WriteLine("Which row do you want to put? (1~3) ");
        rowNum = Console.ReadLine();

        Console.WriteLine("Which column do you want to put? (1~3) ");
        colNum = Console.ReadLine();

        if (rowNum == "1")
        {
            if (colNum == "1")
            {
                if (boardArray[0, 0] == "")
                {
                    boardArray[0, 0] = symbol;
                }
                else
                {
                    Console.WriteLine("Position is taken. Choose another spot");
                    bPosition = true;
                }
            }
            else if (colNum == "2")
            {
                if (boardArray[0, 1] == "")
                {
                    boardArray[0, 1] = symbol;
                }
                else
                {
                    Console.WriteLine("Position is taken. Choose another spot");
                    bPosition = true;
                }
            }
            else if (colNum == "3")
            {
                if (boardArray[0, 2] == "")
                {
                    boardArray[0, 2] = symbol;
                }
                else
                {
                    Console.WriteLine("Position is taken. Choose another spot");
                    bPosition = true;
                }
            }
        }
        else if (rowNum == "2")
        {
            if (colNum == "1")
            {
                if (boardArray[1, 0] == "")
                {
                    boardArray[1, 0] = symbol;
                }
                else
                {
                    Console.WriteLine("Position is taken. Choose another spot");
                    bPosition = true;
                }
            }
            else if (colNum == "2")
            {
                if (boardArray[1, 1] == "")
                {
                    boardArray[1, 1] = symbol;
                }
                else
                {
                    Console.WriteLine("Position is taken. Choose another spot");
                    bPosition = true;
                }
            }
            else if (colNum == "3")
            {
                if (boardArray[1, 2] == "")
                {
                    boardArray[1, 2] = symbol;
                }
                else
                {
                    Console.WriteLine("Position is taken. Choose another spot");
                    bPosition = true;
                }
            }
        }
        else if (rowNum == "3")
        {
            if (colNum == "1")
            {
                if (boardArray[2, 0] == "")
                {
                    boardArray[2, 0] = symbol;
                }
                else
                {
                    Console.WriteLine("Position is taken. Choose another spot");
                    bPosition = true;
                }
            }
            else if (colNum == "2")
            {
                if (boardArray[2, 1] == "")
                {
                    boardArray[2, 1] = symbol;
                }
                else
                {
                    Console.WriteLine("Position is taken. Choose another spot");
                    bPosition = true;
                }
            }
            else if (colNum == "3")
            {
                if (boardArray[2, 2] == "")
                {
                    boardArray[2, 2] = symbol;
                }
                else
                {
                    Console.WriteLine("Position is taken. Choose another spot");
                    bPosition = true;
                }
            }
        }
    }

    iNum++;
}
