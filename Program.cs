using chess1.Figures;

namespace chess1;
internal class Program
{
    static void Main()
    {
        ChessBoard chess = new ChessBoard();
        chess.CreateBoard(chess.array);

        Knight knight = new Knight();
        knight.CanKnightMoveOrNot(FigureName.Knight);

        Bishop bishop = new Bishop();
        bishop.CanBishopMoveOrNot(FigureName.Bishop);

        Rook rook = new Rook();
        rook.CanRookMoveOrNot(FigureName.Rook);

        Queen queen = new Queen();
        queen.CanQueenMoveOrNot(FigureName.Queen);

        King king = new King();
        king.CanKingMoveOrNot(FigureName.King);
    }
}


