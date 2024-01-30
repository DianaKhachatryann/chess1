using ClassicGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicGame;

 class Validate
{
    public bool validCoord= true;
    public bool diffLocation = true;
    public bool check;

    //chisht e nermutsats coordy te che +
    //irar vra en figurnery te che +
    //tagavori vra shax ka te che +
    //pat a te che 

    public bool CheckIsTheCoordRight(Coordinates coordinate)
    {
       // Coordinates coord = new Coordinates();
        int numberCoord = coordinate.number;
        Letters letterCoord = coordinate.letter;
        if (Enum.IsDefined(typeof(Letters), letterCoord) && numberCoord >= 1 && numberCoord <= 8)
        {
            validCoord = true;
            Console.WriteLine("chisht coord");
        }
        else
        {
            validCoord = false;
          //  Console.WriteLine("sxal coord");
        }
      //  Console.WriteLine(validCoord);
        return validCoord;
    }
    public bool CheckIfTheCoordinatesAreEqual(Coordinates coordRook1, Coordinates coordRook2, Coordinates coordQueen, Coordinates coordBlackKing, 
        Coordinates coordWhiteKing)
    {
        Coordinates [] coord = {coordRook1, coordQueen, coordRook2, coordBlackKing, coordWhiteKing };
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
       
        if (!(coordWhiteKing.number == (int)coordQueen.letter && (int)coordWhiteKing.letter == coordQueen.number ||
            coordWhiteKing.number == coordQueen.number || coordWhiteKing.letter == coordQueen.letter))
        {
            check = false;
        }
        else if(!(coordWhiteKing.number == coordRook1.number || coordWhiteKing.letter == coordRook1.letter))
        {
            check = false;
        }
        else if (!(coordWhiteKing.number == coordRook2.number || coordWhiteKing.letter == coordRook2.letter))
        {
            check = false;
        }
        else if(!(Math.Abs(coordWhiteKing.number - coordBlackKing.number)==1 ||
            Math.Abs((int)coordWhiteKing.letter - (int)coordBlackKing.letter) ==1))
        {
            check = false;
        }
        if (check == false)
        {
            Console.WriteLine("shax chka");
        }
        else
        {
            Console.WriteLine("shax");
        }        
        return check;
    }
}
