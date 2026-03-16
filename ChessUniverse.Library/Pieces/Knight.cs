using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Knight(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'N' : 'n';
    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        return true;
    }
}
