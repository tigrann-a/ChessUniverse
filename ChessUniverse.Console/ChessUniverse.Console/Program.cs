using ChessUniverse.Library;
using System.Numerics;

ChessBoard chessBoard = new ChessBoard();
chessBoard.SetStartPosition();
PrintBoard(chessBoard);

void PrintBoard(ChessBoard chessBoard)
{
    Console.WriteLine("   a  b  c  d  e  f  g  h");
    Console.WriteLine("");
    
    for(int row = 0 ; row < 8; row++)
    {
        Console.Write($"{8 - row} ");
        for (int col = 0; col < 8; col++)
        {
            bool isLightSquare = (row + col) % 2 == 0;
            Console.BackgroundColor = isLightSquare ? ConsoleColor.Gray : ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            var piece = chessBoard[row, col];
            char symbol = piece?.GetSymbol() ?? '.';

            Console.Write($" {symbol} ");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}


