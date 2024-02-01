using ClassicGame.Figures;
using ClassicGameLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassicGame;

class ChooseTheGame
{
    public void ChooseQGameOrCGame()
    {
        Console.WriteLine("Welcome to my game! Please, choose the game \n ClassicGame(1)  QueenGame(2)");
        string game = Console.ReadLine();
        if (game == "1")
        {
            ClassicGame classicGame = new ClassicGame();
            classicGame.Run();
        }
        else if (game == "2")
        {
            QueenGame queenGame = new QueenGame();
            queenGame.Run();
        }
        else
        {
            Console.WriteLine("The number you entered is invalid");
        }
    }
}
class ClassicGame
{
   public void Run()
    {
        ChessBoard chess = new ChessBoard();
        chess.CreateBoard(chess.array);

        Knight knight = new Knight();
       // knight.CanMoveOrNot();

        Bishop bishop = new Bishop();
        bishop.CanMoveOrNot();

        Rook rook = new Rook();
        //rook.CanMoveOrNot();

        Queen queen = new Queen();
        //queen.CanMoveOrNot();

        King king = new King();
        //king.CanMoveOrNot();
    }
}
class QueenGame
{
    public void Run()
    {
        Rook rook1 = new Rook();
        rook1.color = FigureColor.Black;
        rook1.ValidateCoordinates();

        Rook rook2 = new Rook();
        rook2.color = FigureColor.Black;
        rook2.ValidateCoordinates();

        Queen queen = new Queen();
        queen.color = FigureColor.Black;
        queen.ValidateCoordinates();

        King blackKing = new King();
        blackKing.color = FigureColor.Black;
        blackKing.ValidateCoordinates();

        King whiteKing = new King();
        whiteKing.color = FigureColor.White;
        whiteKing.ValidateCoordinates();

        ChessBoard chess = new ChessBoard();

        Validate validate = new Validate();
        bool differentLocation=validate.CheckIfTheCoordinatesAreEqual(rook1.input, rook2.input,queen.input,blackKing.input, whiteKing.input);
        bool noCheck =  validate.IsTheKingInCheck(rook1.input, rook2.input, queen.input, blackKing.input, whiteKing.input);
        bool validCoordinate = validate.CheckCoord(rook1.valid, rook2.valid, queen.valid, blackKing.valid, whiteKing.valid);
        
        PrintTeams printTeams = new PrintTeams();
        if ((validCoordinate == true) && (noCheck == true) && (differentLocation == true))
        {
            printTeams.PrintFiguresLetterOnTheBoard(chess.array, rook1.input, rook2.input, queen.input, blackKing.input, whiteKing.input);
        }
        else
        {
            Console.WriteLine("Smth is wrong, try again!");
        }
    }
}
