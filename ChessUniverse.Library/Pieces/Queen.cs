using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Queen(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.white ? 'Q' : 'q';
    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        return true;
    }
}
