namespace GU1222E;

public class Character
{
    private string _name;

    private int _hp = 100;
    private int _exp;

    private Actor _actor;

    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public int Hp
    {
        get { return _hp; }
        set
        {
            if (value < 0)
                _hp = 0;
            else if (value > 100)
                _hp = 100;
            else
                _hp = value;
        }
    }

    public Character()
    {
        _name = "Kratos";
    }

    public Character(string name)
    {
        _name = name;
    }

    public Character(string name, int hp, int exp)
    {
        _name = name;
        _hp = hp;
        _exp = exp;
    }

    public void GainExp(int amount)
    {
        _exp += amount;
        // Exp += amount;
    }

    public void PrintInfo()
    {
        Console.WriteLine("=============================");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Current HP: {_hp}");
        Console.WriteLine($"Current Exp: {_exp}");
        Console.WriteLine("=============================");
    }

    public void ChangeName(string newName)
    {
        _name = newName;
    }
}
