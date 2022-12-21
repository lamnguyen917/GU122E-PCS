namespace GU1222E;

public class Paladin : Character, IDefensable, ICanCastSpell
{
    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} use a divined sword to attack {target.Name}");
    }

    public override string ClassName => "Paladin";

    public void Defense()
    {
        Console.WriteLine($"I'm defending but no use");
    }

    public void CastSpell(Character target)
    {
        Console.WriteLine($"I'm casting spell but no use");
    }
}
