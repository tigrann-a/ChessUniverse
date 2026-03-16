using ChessUniverse.Library;
using ChessUniverse.Library.Enums;
using ChessUniverse.Library.Pieces;

ChessBoard chessBoard = new ChessBoard();
chessBoard.SetStartPosition();
PrintBoard(chessBoard);

Console.WriteLine("Please enter the square: ");
string currentSquare = Console.ReadLine() ?? string.Empty;
Console.WriteLine(currentSquare);

Piece? piece = chessBoard[currentSquare];
Console.WriteLine(piece);

//Coords position = chessBoard[square];
if (piece == null)
{
    Console.WriteLine("No piece found.");
}
else if(piece.GetSymbol() == 'P')
{
    Piece pawn = new Pawn(PieceType.Pawn, PieceColor.white, new Coords(piece.Position.x, piece.Position.y));
    Console.WriteLine($"X: {pawn.Position.x}, Y: {pawn.Position.y}");
    Console.WriteLine("Please enter the final square: ");
    string destSquare = Console.ReadLine() ?? string.Empty;
    Piece? piece1 = chessBoard[destSquare];
    if (piece1 != null)
    {
        Coords destCoords = new Coords(piece1.Position.x, piece1.Position.y);
        Console.WriteLine($"X: {destCoords.x}, Y: {destCoords.y}");
    }
    else
    {
        
    }
        
    
    
}

void CheckPieceMovingPossibility()
{}

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


