namespace ClassicGame;
using ClassicGameLibrary;
using global::ClassicGame.Figures;
class PrintTeams
{
    ChessBoard chess = new ChessBoard();
    public Coordinates currentCoord = new Coordinates();
    public Coordinates[] coordArray;
    public Coordinates c = new Coordinates();
    public void PrintFiguresLetterOnTheBoard(string[,] array, Coordinates rook1Coord, Coordinates rook2Coord,
        Coordinates queenCoord, Coordinates blackKingCoord, Coordinates whiteKingCoord)
    {
        coordArray = new Coordinates[] { rook1Coord, rook2Coord, queenCoord, blackKingCoord, whiteKingCoord };
        Coordinates currentCoordRook1 = rook1Coord;
        Coordinates currentCoordRook2 = rook2Coord;
        Coordinates currentCoordQueen = queenCoord;
        Coordinates currentCoordBlackKing = blackKingCoord;
        Coordinates currentCoordWhiteKing = whiteKingCoord;
        chess.PrintLettersNextToBoard();
        for (int i = 0; i < 8; i++)
        {
            chess.PrintNumbersNextToBoard();
            for (int j = 0; j < 8; j++)
            {
                for (int index = 0; index < 5; index++)
                {
                    c = coordArray[index];
                    if ((i + j) % 2 == 0)
                    {
                        array[i, j] = "   ";
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                    {
                        array[i, j] = "   ";
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    }
                }
                if (i == currentCoordRook1.number - 1 && j == (int)currentCoordRook1.letter)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    array[i, j] = "";
                    Console.Write($" {SymbolOfFigure.R} ");
                }
                if (i == currentCoordRook2.number - 1 && j == (int)currentCoordRook2.letter)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    array[i, j] = "";
                    Console.Write($" {SymbolOfFigure.R} ");
                }
                if (i == currentCoordQueen.number - 1 && j == (int)currentCoordQueen.letter)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    array[i, j] = "";
                    Console.Write($" {SymbolOfFigure.Q} ");
                }
                if (i == currentCoordBlackKing.number - 1 && j == (int)currentCoordBlackKing.letter)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    array[i, j] = "";
                    Console.Write($" {SymbolOfFigure.K} ");
                }
                if (i == currentCoordWhiteKing.number - 1 && j == (int)currentCoordWhiteKing.letter)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    array[i, j] = "";
                    Console.Write($" {SymbolOfFigure.K} ");
                }
                Console.Write(array[i, j]);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}