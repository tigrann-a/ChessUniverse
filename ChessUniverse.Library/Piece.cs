using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library;

public abstract class Piece(PieceType type, PieceColor color, Coords position)
{
    public PieceColor Color { get; } = color;
    public PieceType Type { get; } = type;
    public Coords Position { get; } = position;


    public abstract char GetSymbol();

    //public abstract void IsMovePossible(Coords start, Coords final);
}
