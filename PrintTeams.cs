using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicGame;
using ClassicGameLibrary;
using global::ClassicGame.Figures;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class PrintTeams
{
    Rook rook1 = new Rook();
    Rook rook2 = new Rook();
    King whiteKing = new King();
    King blackKing = new King();
    Queen queen = new Queen();
    Validate validate = new Validate();
    ChessBoard chess = new ChessBoard();
    PrintSymbol symbol = new PrintSymbol();
    public Coordinates currentCoord;
    public Coordinates[] coordArray;
    public PrintTeams()
    {
        InitializeTeamCoordinates();
    }

    public void PrintTeamsOnTheBoard()
    {

        if ((validate.validCoord == true) && (validate.check == false) && (validate.diffLocation == true))
        {
            PrintFiguresLetterOnTheBoard(chess.array);
        }
        else
        {
            Console.WriteLine("Smth is wrong, try again!");
        }
    }
    public void InitializeTeamCoordinates()
    {

        coordArray = new Coordinates[] { rook1.input, rook2.input, queen.input, blackKing.input, whiteKing.input };

    }
    public void PrintFiguresLetterOnTheBoard(string[,] array)
    {

        chess.PrintLettersNextToBoard();
        for (int i = 0; i < 8; i++)
        {
            chess.PrintNumbersNextToBoard();
            for (int j = 0; j < 8; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    if (i == currentCoord.number - 1 && j == (int)currentCoord.letter)
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
                    if (i == currentCoord.number - 1 && j == (int)currentCoord.letter)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;

                        array[i, j] = " ";
                    }
                    else
                    {
                        array[i, j] = "   ";
                    }
                }
                Console.Write(array[i, j]);
                currentCoord = rook1.input;
                if (i == currentCoord.number && j == (int)currentCoord.letter)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(SymbolOfFigure.R);
                    //SymbolForCoordinates(currentCoord);
                }
                currentCoord = rook2.input;
                if (i == currentCoord.number && j == (int)currentCoord.letter)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(SymbolOfFigure.R);

                    //SymbolForCoordinates(currentCoord);
                }
                currentCoord = queen.input;
                if (i == currentCoord.number && j == (int)currentCoord.letter)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(SymbolOfFigure.Q);

                    // SymbolForCoordinates(currentCoord);
                }
                currentCoord = blackKing.input;
                if (i == currentCoord.number && j == (int)currentCoord.letter)
                {
                    //    //Console.ForegroundColor = ConsoleColor.Black;
                    //    //Console.Write(SymbolOfFigure.K);

                    //SymbolForCoordinates(currentCoord);
                }
                currentCoord = whiteKing.input;
                if (i == currentCoord.number && j == (int)currentCoord.letter)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(SymbolOfFigure.K);

                    //SymbolForCoordinates(currentCoord);
                }
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
    public void SymbolForCoordinates(Coordinates currentCoord)
    {

        if (currentCoord.Equals(rook1.input))
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(SymbolOfFigure.R);
        }
        else if (currentCoord.Equals(rook2.input))
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(SymbolOfFigure.R);
        }
        else if (currentCoord.Equals(queen.input))
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(SymbolOfFigure.Q);
        }
        else if (currentCoord.Equals(blackKing.input))
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(SymbolOfFigure.K);
        }
        else if (currentCoord.Equals(whiteKing.input))
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(SymbolOfFigure.K);
        }
    }
}

