namespace GU1222E;

public class HackCheatException : InvalidOperationException
{
    public int HackedValue;
    public string HackedData;

    public HackCheatException(string data, int val) : base("Nghi ngờ hack")
    {
        HackedData = data;
        HackedValue = val;
    }
}
