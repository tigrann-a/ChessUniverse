using ChessUniverse.Library.Enums;
using System.Drawing;

namespace ChessUniverse.Library.Pieces;

public class Pawn(PieceColor color, Coords position) : Piece(color, position)
{
    private Coords _position;
    public Coords Poaition
    {
        get => _position;
        set => _position = value;
    }

    internal static void IsMovePossible(int x, int y)
    {
        throw new NotImplementedException();
    }

    public override char GetSymbol() => Color == PieceColor.white ? 'P' : 'p';

    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.x - start.x);
        int coefficentY = Math.Abs(final.y - start.y);

        if (coefficentX <= 1 && coefficentY <= 1 && (coefficentX + coefficentY != 0))
            return true;
        else
            return false;
    }
}
