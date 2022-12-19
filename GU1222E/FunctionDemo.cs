namespace GU1222E;

public class FunctionDemo
{
    static void MoveChess(ref Chess chess, int x, int y)
    {
        chess.X = x;
        chess.Y = y;
    }

    static void PrintChessInfo(Chess chess)
    {
        Console.WriteLine($"{chess.X} - {chess.Y}");
    }

    public static void RunTest()
    {
        Chess rook = new Chess();
        // move chess to x,y
        PrintChessInfo(rook);
        MoveChess(ref rook, 10, 10);
        PrintChessInfo(rook);

        rook.PrintInfo();
        rook.Move(10, 10);
        rook.PrintInfo();
    }
}
