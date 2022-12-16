// See https://aka.ms/new-console-template for more information

namespace GU1222E
{
    public class Program
    {
        static void Example1()
        {
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

        static void Example2()
        {
            Character atreus = new Character("Atreus");
            Console.WriteLine(atreus.Name);
            Console.WriteLine(atreus.Name);
            atreus.PrintInfo();

            atreus.Hp = -100;
            atreus.PrintInfo();
            
            atreus.Hp = 500;
            atreus.PrintInfo();

            atreus.Hp = 50;
            atreus.PrintInfo();
        }

        public static void Main(string[] args)
        {
            // Example1();
            Example2();
        }
    }
}
