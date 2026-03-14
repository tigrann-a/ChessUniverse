using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library;

public abstract class Piece(PieceColor color)
{
    public PieceColor Color { get; } = color;
    //public PieceType Type { get; } = type;


    public abstract char GetSymbol();
}
