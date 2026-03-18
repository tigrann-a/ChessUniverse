using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library;

public abstract class Piece(PieceColor color)
{
    // խաղաքարի գույնը սահմանվում է կոնստրուկտորով և չի փոխվում, այսինքն կարող ենք կարդալ այդ գույնը, բայց դրսից այն փոխել չենք կարող
    public PieceColor Color { get; } = color;

    public Coords Position { get; set; }

    // Այս մեթոդի միջոցով կարող ենք ստանալ խաղաքարի սիմվոլը, կաղված գույից այն կարող է լինել մեծատառ կամ փոքրատառ, օրինակ սպիտակ թագավորը կլինի 'K', իսկ սև թագավորը կլինի 'k'
    // Յուրաքանչյուր խաղաքար իր դասում override է անում այս մեթոդը և վերադարձնում իր սիմվոլը
    public abstract char GetSymbol();

    // ստուգում ենք արդյոք հնարավոր է կատարել շարժումը start դիրքից final դիրք, իսկ ChessBoard board-ի միջոցով հասանելիություն ենք ստանում board-ի ներկայիս վիճակին
    // այս դեպքում էլ ամեն խաղաքար յուրովի է ստուգում շարժումը, քանի, որ խաղաքարերը տարբեր ձևոերով են շարժվում
    // ամեն խաղաքար իր կլասում override է անւում այս մեթոդը և իր ձևով ստուգում է շարժումը
    public abstract bool IsMovePossible(Coords start, Coords final, ChessBoard board);
}
