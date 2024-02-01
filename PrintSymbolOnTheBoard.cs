namespace ClassicGame;
using ClassicGameLibrary;
class PrintSymbol
{
    ChessBoard chess = new ChessBoard();
    Validate validate = new Validate();

    /// <summary>
    /// Checks if the coordinate is right or not 
    /// </summary>
    /// <param name="coord">The coordinates user entered</param>
    /// <param name="symbol">Figure's symbol</param>
    public void Check1(Coordinates coord, SymbolOfFigure symbol)
    {
        if (validate.CheckIsTheCoordRight(coord))
        {
            PrintSymbolOnTheBoard(chess.array, coord);
        }
        else
        {
            Console.WriteLine("The Coordinate you entered is invalid!");
        }
    }
    /// <summary>
    /// Prints the symbol on the board
    /// </summary>
    /// <param name="array">array for board</param>
    /// <param name="coord">The coordinates user entered</param>
    /// <param name="symbol">Figure's symbol</param>  
    public void PrintSymbolOnTheBoard(string[,] array, Coordinates coord)
    {
        int numberCoord = coord.number;
        Letters letterCoord = coord.letter;
        chess.PrintLettersNextToBoard();
        for (int i = 0; i < 8; i++)
        {
            chess.PrintNumbersNextToBoard();
            for (int j = 0; j < 8; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    if (i == coord.number - 1 && j == (int)coord.letter)
                    {
                        array[i, j] = " ";
                    }
                    else
                    {
                        array[i, j] = "   ";
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    if (i == coord.number - 1 && j == (int)coord.letter)
                    {
                        array[i, j] = " ";
                    }
                    else
                    {
                        array[i, j] = "   ";
                    }
                }
                Console.Write(array[i, j]);
                if (i == coord.number - 1 && j == (int)coord.letter)
                {
                    PrintSymbolOnTheBoard(SymbolOfFigure.N);
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
    public void PrintSymbolOnTheBoard(SymbolOfFigure symbol)
    {
        Console.Write($"{symbol} ");
    }
}