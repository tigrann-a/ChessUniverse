using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Queen(PieceType type, PieceColor color, Coords position) : Piece(type, color, position)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'Q' : 'q';
    public bool IsMovePossible(Coords start, Coords final)
    {
        return true;
    }
}
