using ClassicGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassicGame;
class Validate
{
    //chisht e nermutsats coordy te che +
    //irar vra en figurnery te che +
    //tagavori vra shax ka te che +
    //pat a te che 

    public bool CheckIsTheCoordRight(Coordinates coordinate)
    {
        bool validCoord;
        if (coordinate.number >= 1 && coordinate.number <= 8)
        {
            validCoord = true;
            Console.WriteLine("chisht coord");
        }
        else
        {
            validCoord = false;
            Console.WriteLine("sxal coord");
        }
        return validCoord;
    }
    public bool CheckIfTheCoordinatesAreEqual(Coordinates coordRook1, Coordinates coordRook2, Coordinates coordQueen, Coordinates coordBlackKing,
        Coordinates coordWhiteKing)
    {
        bool diffLocation;
        Coordinates[] coord = { coordRook1, coordQueen, coordRook2, coordBlackKing, coordWhiteKing };
        if (coord.Length == coord.Distinct().Count())
        {
            diffLocation = true;
            Console.WriteLine("irar vra chen");
        }
        else
        {
            diffLocation = false;
            Console.WriteLine("irar vra en");
        }
        return diffLocation;
    }
    public bool IsTheKingInCheck(Coordinates coordRook1, Coordinates coordQueen, Coordinates coordRook2, Coordinates coordBlackKing,
        Coordinates coordWhiteKing)
    {
    bool noKingCheck= false;

        if ((coordWhiteKing.number == (int)coordQueen.letter) && ((int)coordWhiteKing.letter == coordQueen.number) ||
            coordWhiteKing.number == coordQueen.number || coordWhiteKing.letter == coordQueen.letter)
        {
            Console.WriteLine("shax ka");
        }
        else if ((coordWhiteKing.number == coordRook1.number || coordWhiteKing.letter == coordRook1.letter))
        {
            Console.WriteLine("shax ka");
        }
        else if ((coordWhiteKing.number == coordRook2.number || coordWhiteKing.letter == coordRook2.letter))
        {
            Console.WriteLine("shax ka");
        }
        else if ((Math.Abs(coordWhiteKing.number - coordBlackKing.number) == 1 &&
            Math.Abs((int)coordWhiteKing.letter - (int)coordBlackKing.letter) == 1))
        {
            Console.WriteLine("shax ka");
        }      
        else
        {
            noKingCheck = true;
            Console.WriteLine("shax chka");
        }
        return noKingCheck;
    }
    public bool CheckCoord(bool a, bool b, bool c, bool d, bool e)
    {
        bool f;
        if (a && b && c && d && e)
        {
            f = true;
        }
        else
        {
            f = false;
        }
        return f;
    }
}
