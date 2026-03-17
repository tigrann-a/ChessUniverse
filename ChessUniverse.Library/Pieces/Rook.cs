using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Rook(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'R' : 'r';

    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        return true;
    }
}
