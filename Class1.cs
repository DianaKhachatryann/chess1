namespace ClassicGameLibrary;


public class PrintText
{
    public void PrintTextForB()
    {
        Console.WriteLine("\nWelcome to the Queen Game");
        Console.WriteLine("\nPLease, enter the coordinates for the enemy (B)");
    }
    public void PrintTextForFigureCoord(FigureName figure)
    {
        Console.WriteLine($"\nPlease, enter the cordinates for the {figure} (B)");
    }
    public void PrintTextForW()
    {
        Console.WriteLine("\nPLease, enter the coordinates for the King (W)");
    }
}

