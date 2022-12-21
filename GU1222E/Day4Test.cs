namespace GU1222E;

public class Day4Test
{
    static void Test1()
    {
        Wizard merlin = new Wizard();
        merlin.PrintInfo();
        merlin.Name = "Merlin";
        Console.WriteLine(merlin.Name);
    }

    static void Test2()
    {
        Wizard merlin = new Wizard();
        merlin.Name = "Merlin";
        merlin.PrintInfo();
        Console.WriteLine(merlin.Mana);
        Wizard morgan = new Wizard("Morgan Le Fay", 120, 0);
        morgan.PrintInfo();
        merlin.CastSpell(morgan);
        Console.WriteLine(merlin.Mana);

        // Để có thể dùng đoạn code này, bỏ abstract ở Character
        // Character arthur = new Character("Arthur");
        // merlin.CastSpell(arthur);
        // Console.WriteLine(merlin.Mana);
    }

    static void Test3()
    {
        Wizard merlin = new Wizard();
        merlin.Name = "Merlin";
        merlin.PrintInfoFromBase();
        merlin.PrintInfo();
        Console.WriteLine(merlin.Mana);

        Wizard morgan = new Wizard("Morgan Le Fay", 120, 0);
        morgan.PrintInfo();
        merlin.CastSpell(morgan);
        merlin.PrintInfo();
        morgan.PrintInfo();

        // Để có thể dùng đoạn code này, bỏ abstract ở Character
        // Character arthur = new Character("Arthur");
        // merlin.CastSpell(arthur);
        // arthur.PrintInfo();
        // merlin.PrintInfo();
        //
        // merlin.CheckThis("Athur");
    }

    static void Test4()
    {
        Wizard merlin = new Wizard();
        Character player = merlin;
        player.PrintInfo();

        Wizard morgan = new Wizard("Morgan Le Fay", 120, 0);
        // morgan.PrintInfo();
        // merlin.CastSpell(morgan);
        // merlin.PrintInfo();
        // morgan.PrintInfo();

        Wizard wizard = (Wizard)player;
        wizard.CastSpell(morgan);

        Character character = new Wizard();
        character.PrintInfo();
        ;
    }

    static void Test5()
    {
        // Để có thể dùng đoạn code này, bỏ abstract ở Character
        // Character player = new Character(); // 264 byte
        // Wizard wizard = (Wizard)player; // 268 byte
        // Console.WriteLine(wizard);

        // Bị lỗi luôn sau khi cast
        // Wizard morgan = new Wizard("Morgan Le Fay", 120, 0);
        // wizard.CastSpell(morgan);
    }

    static void Test6()
    {
        // Để có thể dùng đoạn code này, bỏ abstract ở Character
        // Character player = new Character(); // 264 byte
        // Wizard wizard = player as Wizard; // 268 byte
        // Console.WriteLine($">>>>{wizard}<<<<");
        // Wizard morgan = new Wizard("Morgan Le Fay", 120, 0);
        // wizard.PrintInfo();
        // wizard.CastSpell(morgan);
    }

    static void Test7()
    {
        // Để có thể dùng đoạn code này, bỏ abstract ở Character
        // Character arthur = new Character();
        // Wizard merlin = new Wizard();
        //
        // Console.WriteLine(arthur is Character);
        // Console.WriteLine(arthur is Wizard);
        // Console.WriteLine("=====================");
        // Console.WriteLine(merlin is Character);
        // Console.WriteLine(merlin is Wizard);
    }

    static void Test8()
    {
        Warrior lancelot = new Warrior("Lancelot");
        lancelot.PrintInfo();

        Wizard merlin = new Wizard("Merlin", 100, 0);
        lancelot.Attack(merlin);
        merlin.Attack(lancelot as Character);

        lancelot.PrintClassName();
        merlin.PrintClassName();
    }

    static void Test9()
    {
        Warrior lancelot = new Warrior("Lancelot");
        SpellCaster caster = new SpellCaster();
        caster.CastSpell(lancelot);
        Wizard merlin = new Wizard("Merlin", 100, 0);
        merlin.CastSpell(lancelot);
        merlin.PrintInfo();
        lancelot.PrintInfo();
        
        lancelot.Defense();

        Console.WriteLine("=================================");
        Paladin paladin = new Paladin();
        paladin.Name = "No name paladin";
        paladin.CastSpell(lancelot);
        paladin.Defense();
        
        lancelot.Attack(paladin as Character);
        lancelot.Attack(paladin as IDefensable);
        lancelot.Attack(merlin);
    }

    public static void Run()
    {
        // Test1();
        // Test2();
        // Test3();
        // Test4();
        // Test5();
        // Test6();
        // Test7();
        // Test8();
        Test9();
    }
}
