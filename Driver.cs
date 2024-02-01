﻿// Welcome the user to the game
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Driver;

Supporting sup = new Supporting();

Console.WriteLine("Welcome to the Tic-Tac-Toe game!");
// make variables
bool bPlayGame = true;
bool bPosition = true;
string[] result = new string[2];
string[,] boardArray = {
{ " ", " ", " " },
{ " ", " ", " " },
{ " ", " ", " " }
};

while (bPlayGame)
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


    while (bPosition)
    {
        int rowNum = 0;
        int colNum = 0;

        Console.WriteLine("Which row do you want to put? (1~3) ");
        rowNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Which column do you want to put? (1~3) ");
        colNum = int.Parse(Console.ReadLine());

        if (boardArray[rowNum - 1, colNum - 1] == "X" || boardArray[rowNum - 1, colNum - 1] == "O")
        {
            Console.WriteLine("Position is taken. Choose another spot");
        }
        else
        {
            boardArray[rowNum - 1, colNum - 1] = symbol;
            bPosition = false;
        }
    }

    iNum++;

    sup.printBoard(boardArray);

    result = sup.gameResults(boardArray);

    if (result[0].Equals("Yes"))
    {
        Console.WriteLine($"Winner is {result[1]}.");
        bPlayGame = false;
    }

    if (iNum == 8)
    {
        Console.WriteLine("Tie game.");
        bPlayGame = false;
    }
}
