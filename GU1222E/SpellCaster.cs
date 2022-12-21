namespace GU1222E;

public class SpellCaster : ICanCastSpell
{
    public void CastSpell(Character target)
    {
        target.Hp -= 10;
        Console.WriteLine($"I'm not a character but I can cast spell to {target.Name}");
    }
}
