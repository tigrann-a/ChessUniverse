using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Queen(PieceColor color, Coords position) : Piece(color, position)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'Q' : 'q';
    public bool IsMovePossible(Coords start, Coords final)
    {
        return true;
    }
}
