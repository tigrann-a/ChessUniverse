namespace ChessUniverse.Library;

public struct Coords
{
    // կարդում ենք տողը և կարող ենք այն դրսից փոխել
    public int Row { get; set; }

    // կարդում ենք սյունը և կարող ենք այն դրսից փոխել
    public int Col { get; set; }

    // Կոնստրուկտոր, որը ընդունում է տողը և սյունը և վերագրում է դրանք համապատասխան հատկություններին
    public Coords(int row, int col)
    {
        Row = row;
        Col = col;
    }

    // static է, քանի որ մեթոդը պատկանում է հենց կլասին, որ թե նրա instance-ին
    public static Coords? ParseCoordinate(string coordinate)
    {
        if (coordinate == null || coordinate.Length != 2)
            return null;

        char file = char.ToLower(coordinate[0]);
        char rank = coordinate[1];

        int col = file - 'a';
        int row = 7 - (rank - '1');

        if (row < 0 || row > 7 || col < 0 || col > 7)
            return null;

        return new Coords(row, col);
    }

}
