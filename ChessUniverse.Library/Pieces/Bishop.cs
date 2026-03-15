using ChessUniverse.Library.Enums;
using System.Drawing;

namespace ChessUniverse.Library.Pieces;

public class Bishop(PieceType type, PieceColor color, Coords position) : Piece(type, color, position)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'B' : 'b';
    public bool IsMovePossible(Coords start, Coords final)
    {
        return true;
    }

}
