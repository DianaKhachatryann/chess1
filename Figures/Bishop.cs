namespace ClassicGame.Figures;
using ClassicGameLibrary;
class Bishop
{
    bool move = false;
    public FigureColor color;
    /// <summary>
    /// Checks, if the Bishop can move or not
    /// </summary>
    /// <param name="figure">The name of the figure</param>
    public void CanMoveOrNot()
    {
        
        ChessBoard chess = new ChessBoard();
        Print print = new Print();

        print.PrintTextForInitalCoordinate(FigureName.Bishop);
        Coordinates coord = new Coordinates(Console.ReadLine());
        
        int numberCoord = coord.number;
        Letters letterCoord = coord.letter;

        print.PrintTextForDestinationCoordinate(FigureName.Bishop);
        Coordinates moveCoord = new Coordinates(Console.ReadLine());
        
        int numberMoveCoord = moveCoord.number;
        Letters letterMoveCoord = moveCoord.letter;

        int x = Math.Abs(numberCoord - numberMoveCoord);
        int y = Math.Abs(letterCoord - letterMoveCoord);

        if (x == y)
        {
            move = true;
            
        }
        print.PrintMove(move);
    }
}