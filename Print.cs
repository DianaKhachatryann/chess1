using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicGameLibrary;

public class Print 
{
    public void PrintTextForInitalCoordinate(FigureName figure)
    {
        Console.WriteLine($"\nEnter the coordinate for {figure}");
    }
   public void PrintTextForDestinationCoordinate(FigureName figure)
    {
        Console.WriteLine($"\nEnter the move coordinate for {figure}");

    }
    public void PrintMove(bool move)
    {
        Console.WriteLine("\n" + move);
    }
    public void PrintTextForChoosingTheGame()
    {
        Console.WriteLine("Choose the game you want to play.\n Classic Game(1) \n QueenGame(2)");
    }
}
