using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class King(PieceColor color) : Piece(color) //primary constructor syntax
{

    public override char GetSymbol() => Color == PieceColor.white ? 'K' : 'k';

    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        int dx = Math.Abs(final.Row - start.Row);
        int dy = Math.Abs(final.Col - start.Col);



        if (dx == 0 && dy == 0)
            return false;
        else if (dx <= 1 && dy <= 1)
            return true;

        return false;
        
        //return (dx <= 1 && dy <= 1) && !(dx == 0 && dy == 0);
    }
}
