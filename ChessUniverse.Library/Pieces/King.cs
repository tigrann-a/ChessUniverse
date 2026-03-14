using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class King(PieceColor color, Coords position) : Piece(color, position)
{
    
    public override char GetSymbol() => Color == PieceColor.white ? 'K' : 'k';
    public bool IsMovePossible(Coords start, Coords final)
    {
        return true;
    }
}
