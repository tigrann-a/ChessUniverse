using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class King(PieceColor color) : Piece(color)
{

    public override char GetSymbol() => Color == PieceColor.white ? 'K' : 'k';

    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        return true;
    }
}
