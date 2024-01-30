namespace ClassicGame;
using ClassicGameLibrary;
class Rook
{
    public FigureColor color;

    //bool move = false;
    ///// <summary>
    ///// Checks, if the Rook can move or not
    ///// </summary>
    ///// <param name="figure">The name of figure</param>
    //public void CanMoveOrNot()
    //{
    //   // Symbol symbol = new Symbol();
    //    ChessBoard chess = new ChessBoard();
    //    Print print = new Print();
    //   // Input input = new Input();

    //    print.PrintTextForInitalCoordinate(FigureName.Rook);
    //    Coordinates coord = new Coordinates(Console.ReadLine());
    //   // symbol.CheckIsTheCoordRight(coord, SymbolOfFigure.R);
    //    //int numberCoord = coord.numberCoordinate;
    //    //Letters letterCoord = coord.letterCoordinate;
    //    int numberCoord = coord.ReturnsNumberCoordinate();
    //    Letters letterCoord = coord.ReturnsLetterCoordinate();

    //    print.PrintTextForDestinationCoordinate(FigureName.Rook);
    //    Coordinates moveCoord = new Coordinates(Console.ReadLine());
    //    //int numberMoveCoord = moveCoord.numberCoordinate;
    //    //Letters letterMoveCoord = moveCoord.letterCoordinate;
    //    int numberMoveCoord = moveCoord.ReturnsNumberCoordinate();
    //    Letters letterMoveCoord = moveCoord.ReturnsLetterCoordinate();

    //    int x = Math.Abs(numberCoord - numberMoveCoord);
    //    int y = Math.Abs(letterCoord - letterMoveCoord);

    //    if (x == 0 || y == 0)
    //    {
    //        move = true;
    //       // symbol.PrintSymbol(chess.array, moveCoord, SymbolOfFigure.R);
    //    }
    //    print.PrintMove(move);
    //}
    PrintText print = new PrintText();
    Validate validate = new Validate();
    bool validCoordinate;
    // public Coordinates coord;
    public Coordinates input;

    public void ValidateCoordinates()
    {
        print.PrintTextForFigureCoord(FigureName.Rook);
        //input = Console.ReadLine();
        Coordinates coordinate = new Coordinates(Console.ReadLine());
        input = coordinate;
        //coordinate.ParseCoordinate(input);
        validate.CheckIsTheCoordRight(coordinate);
        validCoordinate = validate.validCoord;
    }
}