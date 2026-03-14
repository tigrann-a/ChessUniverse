using ChessUniverse.Library.Enums;
using ChessUniverse.Library.Pieces;

namespace ChessUniverse.Library;

public class ChessBoard
{
    private Piece?[,] _squares = new Piece?[8, 8]; // null-eri hamar

    public Piece? this[int row, int col]
    {
        get => _squares[row, col];
        set => _squares[row, col] = value;
    }

    public Piece? this[string coordinate]
    {
        get
        {
            if (coordinate.Length != 2) return null;

            char file = coordinate[0]; // A-H
            char rank = coordinate[1]; // 1-8

            int col = file - 'a';
            int row = 7 - (rank - 1);

            if (row < 0 || row > 7 || col < 0 || col > 7)
                return null;

            return _squares[row, col];
        }
    }
    public void SetStartPosition()
    {
        Array.Clear(_squares, 0, _squares.Length);

        Coords position = new Coords(0, 0); // A8
        _squares[position.x, position.y] = new Rook(PieceColor.black, position);
        position = new Coords(0, 1);
        _squares[position.x, position.y] = new Knight(PieceColor.black, position);
        position = new Coords(0, 2);
        _squares[0, 2] = new Bishop(PieceColor.black, position);
        position = new Coords(0, 3);
        _squares[0, 3] = new Queen(PieceColor.black, position);
        position = new Coords(0, 4);
        _squares[0, 4] = new King(PieceColor.black, position);
        position = new Coords(0, 5);
        _squares[0, 5] = new Bishop(PieceColor.black, position);
        position = new Coords(0, 6);
        _squares[0, 6] = new Knight(PieceColor.black, position);
        position = new Coords(0, 7);
        _squares[0, 7] = new Rook(PieceColor.black, position);

        for (int col = 0; col < 8; col++)
        {
            position = new Coords(1, col);
            _squares[1, col] = new Pawn(PieceColor.black, position);
            Pawn.IsMovePossible(position.x, position.y);
            position = new Coords(6, col);
            _squares[6, col] = new Pawn(PieceColor.white, position);
        }

        position = new Coords(7, 0); // A1
        _squares[7, 0] = new Rook(PieceColor.white, position); // A1
        position = new Coords(7, 1);
        _squares[7, 1] = new Knight(PieceColor.white, position);
        position = new Coords(7, 2);
        _squares[7, 2] = new Bishop(PieceColor.white, position);
        position = new Coords(7, 3);
        _squares[7, 3] = new Queen(PieceColor.white, position);
        position = new Coords(7, 4);
        _squares[7, 4] = new King(PieceColor.white, position);
        position = new Coords(7, 5);
        _squares[7, 5] = new Bishop(PieceColor.white, position);
        position = new Coords(7, 6);
        _squares[7, 6] = new Knight(PieceColor.white, position);
        position = new Coords(7, 7);
        _squares[7, 7] = new Rook(PieceColor.white, position);
    }
}
