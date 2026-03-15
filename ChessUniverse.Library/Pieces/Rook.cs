using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Rook(PieceType type, PieceColor color, Coords position) : Piece(type, color, position)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'R' : 'r';

    public bool IsMovePossible(Coords start, Coords final)
    {
        return true;
    }
}
