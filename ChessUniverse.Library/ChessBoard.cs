using ChessUniverse.Library.Enums;
using ChessUniverse.Library.Pieces;

namespace ChessUniverse.Library;

public class ChessBoard
{
    //public bool isWhiteTurn = true;
    //public bool IsWhiteTurn
    //{
    //    get => _isWhiteTurn; 
    //    set => _isWhiteTurn = value;
    //}

    // Ստեղծում ենք երկչափ զանգված 8 x 8
    // Piece-ի հետ դնում ենք ? (nullable օպերատոր), քանի որ զանգվածը ստեղծում ենք Piece տիպի և compiler-ը սպասում է, որ
    // այդ զանգվածի բոլոր էլեմենտները կլինեն այդ տիպի, սակայն ստեղծման պահին նրանք null-են, այդ պատճառով դնում ենք nullable օպերատորը
    // ինչի շնորհիվ ասում ենք, որ զանգվածի էլեմենտները կարող են լինել նաև null
    private Piece?[,] _squares = new Piece?[8, 8]; // null-eri hamar

    // սա ինդեքսեր է, որը թույլ է տալիս ChessBoard օբյեկտին թույլ է տալիս երկչափ զանգվածի հետ աշխատել այնպես, կարծես ինքը երկչափ զանգված է
    // սակայն ChessBoard օբյեկտը array չէ
    // this-ը ասում է, որ այս class-ի օբյեկտը կարող է ինդեքսով հասանելի լինել
    // մեթոդի կամ օբյեկտի ներսում this-ը նշանակում է այս օբյեկտը
    public Piece? this[int row, int col]
    {
        get => _squares[row, col]; // կարդալ _squares-ի որևէ էլեմենտ
        // կանչվում է set, value-ի արժեքի մեջ դրվում է որևէ խաղաքարի և _squares[row, col] ում դրվում է այդ խաղաքարը
        // set-ի իմաստը այս վանդակում այս խաղաքարը դիր
        set => _squares[row, col] = value; // նոր արժեք դնել վանդակի մեջ, օրինակ board[6, 0] = new Pawn(PieceColor.white);
    }

    // ChessBoard-ի խաղատախտակին կարողանում ենք հասանելիություն ստանալ նաև string-ի միջոցով, այսինքն երբ մուտքագրենք դիրք, ապա այդ դիրքը
    // վերածենք կոորդինատների և indexer-ի միջոցով հասանլիություն ստանանք խաղատախտակին
    public Piece? this[string coordinate]
    {
        get
        {
            Coords? currentCoords = Coords.ParseCoordinate(coordinate);

            if (currentCoords == null)
                return null;

            Coords coordinates = currentCoords.Value;

            return _squares[coordinates.Row, coordinates.Col];
        }
    }

    //if (coordinate.Length != 2) return null;

    //char file = coordinate[0]; // A-H
    //char rank = coordinate[1]; // 1-8

    //int col = file - 'a';
    //int row = 7 - (rank - '1');

    //if (row < 0 || row > 7 || col < 0 || col > 7)
    //    return null;

    // դասավորում ենք խաղաքարերը խաղատախտակին
    public void SetStartPosition()
    {
        Array.Clear(_squares, 0, _squares.Length);

        _squares[0, 0] = new Rook(PieceColor.Black); // A8
        _squares[0, 1] = new Knight(PieceColor.Black);
        _squares[0, 2] = new Bishop(PieceColor.Black);
        _squares[0, 3] = new Queen(PieceColor.Black);
        _squares[0, 4] = new King(PieceColor.Black);
        _squares[0, 5] = new Bishop(PieceColor.Black);
        _squares[0, 6] = new Knight(PieceColor.Black);
        _squares[0, 7] = new Rook(PieceColor.Black);

        for (int col = 0; col < 8; col++)
        {
            _squares[1, col] = new Pawn(PieceColor.Black);
            _squares[6, col] = new Pawn(PieceColor.White);
        }

        _squares[7, 0] = new Rook(PieceColor.White); // A1
        _squares[7, 1] = new Knight(PieceColor.White);
        _squares[7, 2] = new Bishop(PieceColor.White);
        _squares[7, 3] = new Queen(PieceColor.White);
        _squares[7, 4] = new King(PieceColor.White);
        _squares[7, 5] = new Bishop(PieceColor.White);
        _squares[7, 6] = new Knight(PieceColor.White);
        _squares[7, 7] = new Rook(PieceColor.White);
    }

    // տեղափոխում ենք խաղաքարը խատախտակի վրա
    public bool MovePiece(Coords start, Coords final)
    {
        // start դիրքում գտնվող խաղաքարի համար ստեղծում ենք օբյեկտ
        Piece? piece = _squares[start.Row, start.Col];

        // եթե խաղաքար չկա
        if (piece == null)
            return false;

        //if (!isWhiteTurn && piece.Color == PieceColor.White)
        //    return false;

        //if (isWhiteTurn && piece.Color == PieceColor.Black)
        //    return false;

        // եթե քայլ անել հնարավոր չէ
        if (!piece.IsMovePossible(start, final, this))
            return false;

        // ստեղծում ենք օբյեկտ վերջնակետի դիրքի համար
        Piece? targetPiece = _squares[final.Row, final.Col];

        // ստուգում ենք, եթե այն null չէ և նույն գունի խաղաքար է, ապա այդտեղ խաղաքար չենք կարող դնել
        if (targetPiece != null && targetPiece.Color == piece.Color)
            return false;

        // այդ դիրքում դնում ենք մեր խաղաքարը
        _squares[final.Row, final.Col] = piece;
        // նախորդ դիրքը դարձնում ենք null
        _squares[start.Row, start.Col] = null;
        
        // Piece-ի position-ը տալիս ենք խաղաքարի նոր դիրքը
        piece.Position = final;

        //isWhiteTurn = !isWhiteTurn;

        return true;
    }
}