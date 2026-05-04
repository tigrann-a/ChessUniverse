using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Knight(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'N' : 'n';
    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        int dx = Math.Abs(final.Row - start.Row);
        int dy = Math.Abs(final.Col - start.Col);

        if ((dx == 2 && dy == 1) || (dx == 1 && dy == 2))
            return true;
        else
            return false;
    }
}
