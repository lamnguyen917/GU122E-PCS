namespace GU1222E;

public abstract class Character
{
    public static string PlayerName = "Thrud";

    private string _name;
    private int _hp = 100;
    private int _maxMaxHp = 100;
    protected int _exp;

    public abstract void Attack(Character target);
    public abstract string ClassName { get; }

    // private Actor _actor;

    static Character()
    {
        Console.WriteLine("Static Constructor");
        PlayerName = "Freya";
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Hp
    {
        get => _hp;
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

    protected virtual bool IsDead()
    {
        return _hp <= 0;
    }

    public Character()
    {
        _name = "Kratos";
    }

    public Character(string name)
    {
        _name = name;
    }

    public Character(string name, int maxHp, int exp)
    {
        _name = name;
        _maxMaxHp = maxHp;
        _exp = exp;
    }

    public void GainExp(int amount)
    {
        if (amount > 1000000)
        {
            throw new HackCheatException("Exp", amount);
        }

        if (amount == -10)
        {
            throw new Exception("Mình thích thì mình bắt lỗi thôi, không cho tăng điểm kinh nghiệm");
        }

        if (amount < 0)
        {
            throw new InvalidOperationException("Giá trị không hợp lệ");
        }

        _exp += amount;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine("=============================");
        Console.WriteLine($"Class: {ClassName}");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Current HP: {_hp}");
        Console.WriteLine($"Current Max HP: {_maxMaxHp}");
        Console.WriteLine($"Current Exp: {_exp}");
        Console.WriteLine("=============================");
    }

    public void ChangeName(string newName)
    {
        _name = newName;
    }

    public void SetPlayer()
    {
        PlayerName = Name;
    }

    public void PrintPlayerName()
    {
        Console.WriteLine(PlayerName);
    }

    public static void CallAllTest()
    {
        Console.WriteLine("Call all example for Character");
        Day3Test.Example1();
        Day3Test.Example2();
        Console.WriteLine(PlayerName);
    }


    public void CheckThis(string _name)
    {
        // this._name = _name;
        Console.WriteLine(_name);
        Console.WriteLine(this._name);

        int _exp = 10000000;
        Console.WriteLine(_exp);
        Console.WriteLine(this._exp);
    }

    public void Damage(int amount)
    {
        _hp -= amount;
    }

    public void PrintClassName()
    {
        Console.WriteLine($"Nhân vật của tôi là {ClassName}");
    }

    public void Attack(IDefensable target)
    {
        Console.WriteLine($"{Name} attack a target but he is defending so it no use");
    }

    public int GetHpPercent()
    {
        return (_hp * 100) / _maxMaxHp;
    }

    public void HackCheatPenalty()
    {
        _hp = 0;
        _maxMaxHp = 0;
        _exp = 0;
    }
}
