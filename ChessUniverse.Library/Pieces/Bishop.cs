using ChessUniverse.Library.Enums;
using System.Drawing;

namespace ChessUniverse.Library.Pieces;

public class Bishop(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'B' : 'b';
    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        int dx = Math.Abs(final.Row - start.Row);
        int dy = Math.Abs(final.Col - start.Col);
        if (dx == dy)
            return true;

        return false;
    }
}
