using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Pawn(PieceType type, PieceColor color, Coords position) : Piece(type, color, position)
{
    private Coords _position;
    public Coords position
    {
        get => _position;
        set => _position = value;
    }

    public override char GetSymbol() => Color == PieceColor.white ? 'P' : 'p';

    public static void IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.x - start.x);
        int coefficentY = Math.Abs(final.y - start.y);

        if (coefficentX <= 1 && coefficentY <= 1 && (coefficentX + coefficentY != 0))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}
