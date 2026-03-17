using ChessUniverse.Library.Enums;
using System.Drawing;

namespace ChessUniverse.Library.Pieces;

public class Bishop(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'B' : 'b';
    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        return true;
    }

}
