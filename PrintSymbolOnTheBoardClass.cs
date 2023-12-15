namespace chess1;
class Symbol
{
    public void CheckIsTheCoordRight(Coordinates coord, SymbolOfFigure symbol)
    {
        int numberCoord = coord.ReturnsNumberCoordinate();
        Letters letterCoord = coord.ReturnsLetterCoordinate();
        ChessBoard chess = new ChessBoard();

        if (numberCoord >= 1 && numberCoord <= 8 && (int)letterCoord < 8)//&& letterCoord >= 'A' && letterCoord <= 'H')
        {
            PrintSymbol(chess.array, coord, symbol);
        }
        else
        {
            Console.WriteLine("The Coordinate you entered is invalid!");
        }
    }
    public void PrintSymbol(string[,] array, Coordinates coord, SymbolOfFigure symbol)
    {
        ChessBoard chess = new ChessBoard();
        int numberCoord = coord.ReturnsNumberCoordinate();
        Letters letterCoord = coord.ReturnsLetterCoordinate();

        chess.PrintLettersNextToBoard();
        for (int i = 0; i < 8; i++)
        {
            chess.PrintNumbersNextToBoard();
            for (int j = 0; j < 8; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    if (i == numberCoord - 1 && j == (int)letterCoord)
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
                    if (i == numberCoord - 1 && j == (int)letterCoord)
                    {
                        array[i, j] = " ";
                    }
                    else
                    {
                        array[i, j] = "   ";
                    }
                }
                Console.Write(array[i, j]);
                if (i == numberCoord - 1 && j == (int)letterCoord)
                {
                    PrintSymbolOnTheBoard(SymbolOfFigure.N);
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        void PrintSymbolOnTheBoard(SymbolOfFigure symbol)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{symbol} ");
        }
    }
}
