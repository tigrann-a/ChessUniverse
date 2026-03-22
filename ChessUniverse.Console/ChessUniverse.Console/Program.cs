using ChessUniverse.Library;

ChessBoard chessBoard = new ChessBoard();
chessBoard.SetStartPosition();
PrintBoard(chessBoard);

while (true)
{
    Console.WriteLine("Please enter the start square: ");
    string startSquare = (Console.ReadLine() ?? string.Empty).ToLower();

    Console.WriteLine("Please enter the final square: ");
    string finalSquare = (Console.ReadLine() ?? string.Empty).ToLower();

    Coords? startCoords = Coords.ParseCoordinate(startSquare);
    Coords? finalCoords = Coords.ParseCoordinate(finalSquare);

    if (startCoords == null || finalCoords == null)
    {
        Console.WriteLine("Invalid coordinates.");
        return;
    }

    bool moved = chessBoard.MovePiece(startCoords.Value, finalCoords.Value);

    Console.WriteLine(moved ? "Move successful." : "Invalid move.");
    PrintBoard(chessBoard);
}
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


