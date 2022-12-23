namespace GU1222E;

public class Wizard : Character, ICanCastSpell
{
    private int _mana = 100;

    public int Mana => _mana;

    public Wizard()
    {
    }

    public Wizard(string name, int maxHp, int exp) : base(name, maxHp, exp)
    {
    }

    public void PrintInfoFromBase()
    {
        Console.WriteLine("*****************************************");
        base.PrintInfo();
        Console.WriteLine("*****************************************");
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} use a staff to attack {target.Name}");
    }

    public override string ClassName => "Pháp sư";

    public override void PrintInfo()
    {
        Console.WriteLine("=============================");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Current HP: {Hp}");
        Console.WriteLine($"Current Mana: {_mana}");
        Console.WriteLine($"Current Exp: {_exp}");
        Console.WriteLine("=============================");
    }

    public void CastSpell(Character target)
    {
        _mana -= 1;
        target.Damage(2);
        Console.WriteLine($"Cast a spell to {target.Name}");
    }

    public void Test()
    {
        Console.WriteLine(base.ToString() + "======"); // derived class
    }
}
