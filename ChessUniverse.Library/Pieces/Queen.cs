using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Queen(PieceColor color) : Piece(color, PieceType.Queen)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'Q' : 'q';
}
