using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Rook(PieceColor color) : Piece(color, PieceType.Rook)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'R' : 'r';
}
