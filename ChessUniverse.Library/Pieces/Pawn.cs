using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Pawn(PieceColor color) : Piece(color, PieceType.Pawn)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'P' : 'p';
}
