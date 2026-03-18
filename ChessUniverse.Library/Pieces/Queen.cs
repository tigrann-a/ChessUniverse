using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Queen(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'Q' : 'q';
    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        int dx = Math.Abs(final.Row - start.Row);
        int dy = Math.Abs(final.Col - start.Col);

        if (dx == 0 || dy == 0 || dx == dy)
            return true;
        else
            return false;
    }
}
