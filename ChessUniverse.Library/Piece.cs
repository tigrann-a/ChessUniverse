using ChessUniverse.Library.Enums;
using System.Drawing;

namespace ChessUniverse.Library;

public abstract class Piece(PieceColor color)
{
    public PieceColor Color { get; } = color;
    public Coords Position { get; set; }


    public abstract char GetSymbol();

    //public abstract void IsMovePossible(Coords start, Coords final);

    public abstract bool IsMovePossible(Coords start, Coords final, ChessBoard board);

}
