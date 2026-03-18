using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Rook(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'R' : 'r';

    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        int dx = Math.Abs(final.Row - start.Row);
        int dy = Math.Abs(final.Col - start.Col);
        //int coefficentOtherX = Math.Abs(other.x - final.x);
        //int coefficentOtherY = Math.Abs(other.y - final.y);

        if (dx == 0 || dy == 0)
        {
            return true;
        }

        return false;
    }
}
