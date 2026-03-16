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

    public static Coords? ParseCoordinate(string coordinate)
    {
        if (string.IsNullOrWhiteSpace(coordinate) || coordinate.Length != 2)
            return null;

        char file = char.ToLower(coordinate[0]);
        char rank = coordinate[1];

        int col = file - 'a';
        int row = 7 - (rank - '1');

        if (row < 0 || row > 7 || col < 0 || col > 7)
            return null;

        return new Coords(row, col);
    }

    public Piece? this[string coordinate]
    {
        get
        {
            if (coordinate.Length != 2) return null;

            char file = coordinate[0]; // A-H
            char rank = coordinate[1]; // 1-8

            int col = file - 'a';
            int row = 7 - (rank - '1');

            if (row < 0 || row > 7 || col < 0 || col > 7)
                return null;

            return _squares[row, col];
        }
    }
    public void SetStartPosition()
    {
        Array.Clear(_squares, 0, _squares.Length);

        Array.Clear(_squares, 0, _squares.Length);

        _squares[0, 0] = new Rook(PieceColor.black); // A8
        _squares[0, 1] = new Knight(PieceColor.black);
        _squares[0, 2] = new Bishop(PieceColor.black);
        _squares[0, 3] = new Queen(PieceColor.black);
        _squares[0, 4] = new King(PieceColor.black);
        _squares[0, 5] = new Bishop(PieceColor.black);
        _squares[0, 6] = new Knight(PieceColor.black);
        _squares[0, 7] = new Rook(PieceColor.black);

        for (int col = 0; col < 8; col++)
        {
            _squares[1, col] = new Pawn(PieceColor.black);
            _squares[6, col] = new Pawn(PieceColor.white);
        }

        _squares[7, 0] = new Rook(PieceColor.white); // A1
        _squares[7, 1] = new Knight(PieceColor.white);
        _squares[7, 2] = new Bishop(PieceColor.white);
        _squares[7, 3] = new Queen(PieceColor.white);
        _squares[7, 4] = new King(PieceColor.white);
        _squares[7, 5] = new Bishop(PieceColor.white);
        _squares[7, 6] = new Knight(PieceColor.white);
        _squares[7, 7] = new Rook(PieceColor.white);
    }

    public bool MovePiece(Coords start, Coords final)
    {
        Piece? piece = _squares[start.Row, start.Col];

        if (piece == null)
            return false;

        if (!piece.IsMovePossible(start, final, this))
            return false;

        Piece? targetPiece = _squares[final.Row, final.Col];

        // Չի կարելի սեփական ֆիգուրը ուտել
        if (targetPiece != null && targetPiece.Color == piece.Color)
            return false;

        _squares[final.Row, final.Col] = piece;
        _squares[start.Row, start.Col] = null;
        piece.Position = final;

        return true;
    }
}
