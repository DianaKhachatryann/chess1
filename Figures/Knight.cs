namespace chess1.Figures;
class Knight
{
    int[,] CoordinateArray = { { 1, 2 }, { 1, -2 }, { -1, 2 }, { -1, -2 }, { 2, 1 }, { 2, -1 }, { -2, 1 }, { -2, -1 } };
    bool move= false;
   public void CanKnightMoveOrNot(FigureName figure)
    {
        Symbol symbol = new Symbol();
        
        Console.WriteLine($"Enter the coordinate for {figure}");
        Coordinates coord = new Coordinates(Console.ReadLine());
        symbol.CheckIsTheCoordRight(coord, SymbolOfFigure.N);
        int numberCoord = coord.ReturnsNumberCoordinate();
        Letters letterCoord = coord.ReturnsLetterCoordinate();

        Console.WriteLine($"Enter the move coordinate for {figure}");
        Coordinates moveCoord = new Coordinates(Console.ReadLine());
        int numberMoveCoord = moveCoord.ReturnsNumberCoordinate();
        Letters letterMoveCoord = moveCoord.ReturnsLetterCoordinate();

        int x = Math.Abs(numberCoord - numberMoveCoord);
        int y = Math.Abs((int)letterCoord - (int)letterMoveCoord);

        for (int i = 0; i < 8; i++)
        {
            if (x == CoordinateArray[i, 0] && y == CoordinateArray[i, 1])
            {
                move = true;
                break;
            }            
        }
        if (move)
        {
            symbol.CheckIsTheCoordRight(moveCoord, SymbolOfFigure.N);
        }
        PrintMove(move);
    }
    public void PrintMove(bool move)
    {
        Console.WriteLine(move);
    }
}