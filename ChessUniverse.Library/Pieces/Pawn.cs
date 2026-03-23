using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Pawn(PieceColor color) : Piece(color)
{
    private Coords _position;
    public Coords position
    {
        get => _position;
        set => _position = value;
    }

    public override char GetSymbol() => Color == PieceColor.White ? 'P' : 'p';

    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        int dRow = final.Row - start.Row;
        int dCol = final.Col - start.Col;

        // Ըստ գույնի որոշում ենք քարի շարժման ուղղությունը
        int direction = Color == PieceColor.White ? -1 : 1;

        // Ստանում ենք target դիրքում ինչ կա դրված կամ չկա
        Piece? target = board[final.Row, final.Col];

        // Եթե մեկ քայլ արաջ է գնում, ապա կարող ենք շարժել
        if (dCol == 0 && dRow == direction && target == null)
            return true;

        // Ստուգում ենք արդյոք առաջին քայլ ենք կատարում, այդ դեպքում կարող ենք երկու քայլ անել
        bool isFirstMove =
            (Color == PieceColor.White && start.Row == 6) ||
            (Color == PieceColor.Black && start.Row == 1);

        // Ստուգում ենք արդյոք դիմացը քար կա, թե ոչ
        if (dCol == 0 && dRow == 2 * direction && isFirstMove)
        {
            int middleRow = start.Row + direction;
            if (board[middleRow, start.Col] == null && target == null)
                return true;
        }

        // Ստուգում ենք, եթե target դիրքում կա խաղաքար և այլ գույնի է, ապա կաորղ ենք անկյուագծով ուտել
        if (Math.Abs(dCol) == 1 && dRow == direction && target != null && target.Color != Color)
            return true;

        return false;
    }
}
