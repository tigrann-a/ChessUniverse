using ChessUniverse.Library.Enums;
using System.Drawing;

namespace ChessUniverse.Library.Pieces;

public class Bishop(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'B' : 'b';
    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        int rowStep = Math.Sign(final.Row - start.Row);
        int colStep = Math.Sign(final.Col - start.Col);

        int currentRow = start.Row + rowStep;
        int currentCol = start.Col + colStep;

        while (currentRow != final.Row || currentCol != final.Col)
        {
            Console.WriteLine($"{start.Row}, {final.Row}");
            Console.WriteLine($"{start.Col}, {final.Col}");
            if (board[currentRow, currentCol] != null)
            {
                return false;
            }

            currentRow += rowStep;
            currentCol += colStep;
        }

        return true;

        //int dx = Math.Abs(final.Row - start.Row);
        //int dy = Math.Abs(final.Col - start.Col);
        //if (dx == dy)
        //    return true;
        //else
        //    return false;
    }

}
