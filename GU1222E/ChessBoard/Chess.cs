using GU1222E.ChessBoard;

namespace GU1222E;

[Serializable]
public class Chess
{
    public Position<int> Position = new Position<int>();

    public ChessType Type = ChessType.White;

    public void PrintInfo()
    {
        Console.WriteLine($"{Type} - {Position.X} - {Position.Y}");
    }

    public void Move(int x, int y)
    {
        Position.X = x;
        Position.Y = y;
    }
}
