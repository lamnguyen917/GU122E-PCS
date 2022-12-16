namespace GU1222E;

public static class Day3Test
{
    public static void Example1()
    {
        Console.WriteLine("Start example 1");
        Actor character = new Actor();
        Actor henry = new Actor("Tris", "Tris");
        character.PrintInfo();
        henry.PrintInfo();

        Character kratos = new Character();
        kratos.PrintInfo();
        Character sif = new Character("Sif");
        sif.PrintInfo();
        Character atreus = new Character("Atreus", 50, 100);
        atreus.PrintInfo();
        atreus.ChangeName("Loki");
        atreus.GainExp(100);
        atreus.PrintInfo();
    }


    public static void Example2()
    {
        Console.WriteLine("Start example 2");
        Character atreus = new Character("Atreus");
        Console.WriteLine(atreus.Name);
        atreus.PrintInfo();
        atreus.Name = "Loki";
        Console.WriteLine(atreus.Name);
        atreus.Hp = -100;
        atreus.PrintInfo();

        atreus.Hp = 500;
        atreus.PrintInfo();

        atreus.Hp = 50;
        atreus.PrintInfo();
    }


    private static void Example3()
    {
        Console.WriteLine("Start example 3");
        Character baldur = new Character("Baldur");
        Character.PlayerName = "Syndri";
        baldur.PrintPlayerName();
        baldur.SetPlayer();
        Console.WriteLine(Character.PlayerName);
        Character odin = new Character("Odin");
        odin.PrintPlayerName();
    }

    public static void All()
    {
        Example1();
        Example2();
        Example3();
    }
}
