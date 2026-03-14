using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Pawn(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'P' : 'p';
}
