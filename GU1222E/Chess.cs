namespace GU1222E;

public class Chess
{
    public int X;
    public int Y;

    public void PrintInfo()
    {
        Console.WriteLine($"{X} - {Y}");
    }

    public void Move(int x, int y)
    {
        X = x;
        Y = y;
    }
}
