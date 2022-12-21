namespace GU1222E;

public class Warrior : Character, IDefensable
{
    public Warrior() : base("A new warrior", 180, 10)
    {
    }

    public Warrior(string name) : base(name)
    {
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} use a sword to attack {target.Name}");
    }

    public override string ClassName => "Chiến binh";
    public void Defense()
    {
        Console.WriteLine($"I'm defending but no use");
    }
}
