namespace ClassicGame.Figures;
using ClassicGameLibrary;
class Knight
{
    public FigureColor color;

    //int[,] CoordinateArray = { { 1, 2 }, { 1, -2 }, { -1, 2 }, { -1, -2 }, { 2, 1 }, { 2, -1 }, { -2, 1 }, { -2, -1 } };
    //bool move= false;
    ///// <summary>
    ///// Checks, if the Knight can move or not
    ///// </summary>
    ///// <param name="figure">The name of the figure</param>
    //public void CanMoveOrNot()
    //{
    //   // Symbol symbol = new Symbol();
    //    ChessBoard chess = new ChessBoard();
    //    Print print = new Print();
    //    Validate validate = new Validate();    

    //    print.PrintTextForInitalCoordinate(FigureName.Knight);
    //    Coordinates coord = new Coordinates(Console.ReadLine());
    //    validate.CheckIsTheCoordRight(coord);
    //    //int numberCoord = coord.numberCoordinate;
    //    //Letters letterCoord = coord.letterCoordinate;
    //    int numberCoord = coord.ReturnsNumberCoordinate();
    //    Letters letterCoord = coord.ReturnsLetterCoordinate();

    //    print.PrintTextForDestinationCoordinate(FigureName.Knight);
    //    Coordinates moveCoord = new Coordinates(Console.ReadLine());
    //    //int numberMoveCoord = moveCoord.numberCoordinate;
    //    //Letters letterMoveCoord = moveCoord.letterCoordinate;
    //    int numberMoveCoord = moveCoord.ReturnsNumberCoordinate();
    //    Letters letterMoveCoord = moveCoord.ReturnsLetterCoordinate();

    //    int x = Math.Abs(numberCoord - numberMoveCoord);
    //    int y = Math.Abs((int)letterCoord - (int)letterMoveCoord);

    //    for (int i = 0; i < 8; i++)
    //    {
    //        if (x == CoordinateArray[i, 0] && y == CoordinateArray[i, 1])
    //        {
    //            move = true;
    //            break;
    //        }            
    //    }
    //    if (move)
    //    {
    //       // symbol.PrintSymbol(chess.array, moveCoord, SymbolOfFigure.N);

    //    }
    //    print.PrintMove(move);
}
//public void PrintMove(bool move)
//{
//    Console.WriteLine("\n" + move);
//}
