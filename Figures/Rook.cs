namespace chess1.Figures;
class Rook
{
    bool move = false;
    public void CanRookMoveOrNot(FigureName figure)
    {
        Symbol symbol = new Symbol();

        Console.WriteLine($"Enter the coordinate for {figure}");
        Coordinates coord = new Coordinates(Console.ReadLine());
        symbol.CheckIsTheCoordRight(coord, SymbolOfFigure.R);
        int numberCoord = coord.ReturnsNumberCoordinate();
        Letters letterCoord = coord.ReturnsLetterCoordinate();

        Console.WriteLine($"Enter the move coordinate for {figure}");
        Coordinates moveCoord = new Coordinates(Console.ReadLine());
        int numberMoveCoord = moveCoord.ReturnsNumberCoordinate();
        Letters letterMoveCoord = moveCoord.ReturnsLetterCoordinate();

        int x = Math.Abs(numberCoord - numberMoveCoord);
        int y = Math.Abs(letterCoord - letterMoveCoord);

        if (x == 0 || y == 0)
        {
            move = true;
            symbol.CheckIsTheCoordRight(moveCoord, SymbolOfFigure.R);
        }
        Knight knight = new Knight();
        knight.PrintMove(move);
    }
}