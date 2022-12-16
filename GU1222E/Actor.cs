namespace GU1222E;

public class Actor
{
    public string _firstName = "Henry";
    public string _lastName = "Cavill";

    private int _hp = 100;
    private int _exp;

    public Actor()
    {
        _hp = 200;
        _exp = 100;
    }

    public Actor(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public void GainExp(int amount)
    {
        _exp += amount;
        // Exp += amount;
    }

    public void PrintInfo()
    {
        Console.WriteLine("=============================");
        Console.WriteLine($"Name: {GetFullName()}");
        Console.WriteLine($"Current HP: {_hp}");
        Console.WriteLine($"Current Exp: {_exp}");
        Console.WriteLine("=============================");
    }

    public string GetInfo()
    {
        return $"Name: {_firstName} {_lastName} - Exp: {_exp}";
    }

    public string GetInfo(string firstName)
    {
        _firstName = firstName;
        return GetInfo();
    }

    public string GetInfo(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
        return GetInfo();
    }

    private string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }
}
