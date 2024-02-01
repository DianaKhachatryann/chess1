namespace ClassicGame;
class ChessBoard
{/// <summary>
/// Creates the chess board
/// </summary>
    public string[,] array = new string[8, 8];
    int a = 0;
    public void CreateBoard(string[,] array)
    {
        PrintLettersNextToBoard();
        for (int i = 0; i < 8; i++)
        {
            PrintNumbersNextToBoard();
            for (int j = 0; j < 8; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    array[i, j] = "   ";
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    array[i, j] = "   ";
                }
                PrintBoard(array);
            }
            Console.WriteLine();
        }
    }
    /// <summary>
    /// Prints the chess board
    /// </summary>
    /// <param name="array"></param>
    public void PrintBoard(string[,] array)
    {
        for (int i = 0; i < 1; i++)
        {

            for (int j = 0; j < 1; j++)
            {
                Console.Write(array[i, j]);
                Console.ResetColor();
            }
        }
    }
    /// <summary>
    /// Prints numbers next to the board(1-8)
    /// </summary>
    public void PrintNumbersNextToBoard()
    {
        Console.Write(++a + " ");
    }
    /// <summary>
    /// Prints letters next to the board (A-H)
    /// </summary>
    public void PrintLettersNextToBoard()
    {
        for (char k = 'A'; k <= 'H'; k++)
        {
            if (k == 'A')
            {
                Console.Write("  ");
            }
            Console.Write(" " + k + " ");
        }
        Console.WriteLine();
    }
}
