using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class King(PieceColor color) : Piece(color) //primary constructor syntax
{
    // public King(PieceColor color) : base(color) կոնստրուկտոր է
    // King-ը ստանում է color-ը, այն փոխանցում է Piece-ին և Piece-ը պահում է այդ գույնը իր Color property-ում
    //                              ^
    //                              |
    // ------------------------------------------------------
    //  public class King : Piece
    //  {
    //      public King(PieceColor color) : base(color){}
    //  }
    // ------------------------------------------------------

    // override է անում Piece-ում գրված GetSymbol մեթոդը և վերադարձնում է խաղաքարի սիմվոլը
    public override char GetSymbol() => Color == PieceColor.white ? 'K' : 'k';

    // override է անում Piece-ում գրված IsMovePossible մեթոդը և ստուգում է կարող է խաղաքարը շարժվել․ թե ոչ
    public override bool IsMovePossible(Coords start, Coords final, ChessBoard board)
    {
        int dx = Math.Abs(final.Row - start.Row);
        int dy = Math.Abs(final.Col - start.Col);

        if (dx == 0 && dy == 0)
            return false;
        else if (dx <= 1 && dy <= 1)
            return true;

        return false;
        
        //return (dx <= 1 && dy <= 1) && !(dx == 0 && dy == 0);
    }
}
