using ChessUniverse.Library.Enums;
using System.Drawing;

namespace ChessUniverse.Library.Pieces;

public class Bishop(PieceColor color, Coords position) : Piece(color, position)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'B' : 'b';
    public bool IsMovePossible(Coords start, Coords final)
    {
        return true;
    }

}
