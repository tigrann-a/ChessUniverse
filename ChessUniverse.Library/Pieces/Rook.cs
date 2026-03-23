using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Rook(PieceColor color) : Piece(color)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'R' : 'r';

    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        int dx = Math.Abs(final.Row - start.Row);
        int dy = Math.Abs(final.Col - start.Col);

        Console.WriteLine(start.Row);

        if (dy == 0)
        {
            int dir = final.Row - start.Row;
            Console.WriteLine(dir);
            if (dir < 0)
            {
                for (int i = final.Row; i < start.Row; i++)
                {
                    //Console.WriteLine($"{i}, {start.Col}");
                    if (board[i, start.Col] != null)
                    {
                        //Console.WriteLine($"{board[i, start.Col]}");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (dir > 0) 
            {
                for (int i = start.Row; i < final.Row; i--)
                {
                    //Console.WriteLine($"{i}, {start.Col}");
                    if (board[i, start.Col] != null)
                    {
                        //Console.WriteLine($"{board[i, start.Col]}");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            
        }

        if (dx == 0)
        {
            int dir = final.Col - start.Col;
            Console.WriteLine(dir);
            if (dir < 0)
            {
                for (int i = start.Col - 1; i < final.Col; i--)
                {
                    Console.WriteLine($"{i}, {start.Col}");
                    if (board[start.Row, i] != null)
                    {
                        Console.WriteLine($"{board[start.Row, i]}");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (dir > 0)
            {
                for (int i = start.Col + 1; i < final.Col; i++)
                {
                    Console.WriteLine($"{i}, {start.Col}");
                    if (board[start.Row, i] != null)
                    {
                        Console.WriteLine($"{board[start.Row, i]}");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

        }

        if (dx == 0 || dy == 0)
        {
            return true;
        }

        return false;
    }
}
