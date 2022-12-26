namespace GU1222E.ChessBoard;

public class Position<T>
{
    public T X;
    public T Y;


    public string ToString()
    {
        return $"({X}, {Y})";
    }
}
