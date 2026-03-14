using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Bishop(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'B' : 'b';
    
}
