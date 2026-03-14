using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Knight(PieceColor color, Coords position) : Piece(color, position)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'N' : 'n';
    public bool IsMovePossible(Coords start, Coords final)
    {
        return true;
    }
}
