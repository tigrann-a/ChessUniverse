using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Rook(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'R' : 'r';

    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        int rowStep = Math.Sign(final.Row - start.Row);
        int colStep = Math.Sign(final.Col - start.Col);

        int currentRow = start.Row + rowStep;
        int currentCol = start.Col + colStep;

        while(currentRow != final.Row || currentCol != final.Col)
        {
            Console.WriteLine($"{start.Row}, {final.Row}");
            Console.WriteLine($"{start.Col}, {final.Col}");
            if (board[currentRow, currentCol] != null)
            { 
                return false;
            }

            currentRow+=rowStep;
            currentCol+=colStep;
        }

        //if (dy == 0)
        //{
        //    int dir = final.Row - start.Row;
        //    Console.WriteLine(dir);
        //    if (dir < 0)
        //    {
        //        for (int i = final.Row; i < start.Row; i++)
        //        {
        //            //Console.WriteLine($"{i}, {start.Col}");
        //            if (board[i, start.Col] != null)
        //            {
        //                //Console.WriteLine($"{board[i, start.Col]}");
        //                return false;
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }
        //    }
        //    else if (dir > 0) 
        //    {
        //        for (int i = start.Row; i < final.Row; i--)
        //        {
        //            //Console.WriteLine($"{i}, {start.Col}");
        //            if (board[i, start.Col] != null)
        //            {
        //                //Console.WriteLine($"{board[i, start.Col]}");
        //                return false;
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }
        //    }

        //}

        //if (dx == 0)
        //{
        //    int dir = final.Col - start.Col;
        //    Console.WriteLine(dir);
        //    if (dir < 0)
        //    {
        //        for (int i = start.Col - 1; i >= final.Col; i--)
        //        {
        //            Console.WriteLine($"{i}, {start.Col}");
        //            if (board[start.Row, i] != null)
        //            {
        //                Console.WriteLine($"{board[start.Row, i]}");
        //                return false;
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }
        //    }
        //    else if (dir > 0)
        //    {
        //        for (int i = start.Col + 1; i < final.Col; i++)
        //        {
        //            Console.WriteLine($"{i}, {start.Col}");
        //            if (board[start.Row, i] != null)
        //            {
        //                Console.WriteLine($"{board[start.Row, i]}");
        //                return false;
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }
        //    }

        //}

        //if (dx == 0 || dy == 0)
        //{
        //    return true;
        //}

        return true;
    }
}
