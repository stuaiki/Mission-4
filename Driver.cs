// Welcome the user to the game
Console.WriteLine("Welcome to the Tic-Tac-Toe game!");

string rowNum = "";
string colNum = "";
string[,] boardArray = {
{ " ", " ", " " },
{ " ", " ", " " },
{ " ", " ", " " }
};

Console.WriteLine("Which row do you want to put? (1~3) ");
rowNum = Console.ReadLine();

Console.WriteLine("Which column do you want to put? (1~3) ");
colNum = Console.ReadLine();

if (rowNum == "1")
{
    if (colNum == "1")
    {
        boardArray[0].add('ss')
    }
}