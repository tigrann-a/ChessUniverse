using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library;

public class Piece(PieceColor color, PieceType type)
{
    public PieceColor Color { get; } = color;
    public PieceType Type { get; } = type;
    

    public virtual char GetSymbol()
    {
        return '?';
    }
}
