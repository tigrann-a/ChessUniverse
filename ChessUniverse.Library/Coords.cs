namespace ChessUniverse.Library;

public struct Coords
{
    public int Row { get; set; }
    public int Col { get; set; }

    public Coords(int row, int col)
    {
        Row = row;
        Col = col;
    }

}
