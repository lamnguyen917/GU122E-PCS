using System.Text;

namespace GU1222E;

public class Day5
{
    public static void Example1()
    {
        Console.Write("Nhập 1 số từ bàn phím: ");
        var inputValue = Console.ReadLine();
        int x;
        if (!Int32.TryParse(inputValue, out x))
        {
            Console.WriteLine("Chuỗi bạn nhập vào không phải là số");
            return;
        }

        // int x = Int32.Parse(inputValue);
        Console.WriteLine($"Số nhập vào là {x}");
        if (x == 0)
        {
            Console.WriteLine("Số nhập vào không hợp lệ");
            return;
        }

        Console.WriteLine($"1000/{x} = {1000 / x}");
    }

    static void Example2()
    {
        try
        {
            Console.Write("Nhập 1 số từ bàn phím: ");
            var inputValue = Console.ReadLine();
            int x = Int32.Parse(inputValue);
            Console.WriteLine($"1000/{x} = {1000 / x}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Có lỗi gì đó đã xảy ra");
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Làm gì đó sau khi xử lý xong ngoại lệ");
        }

        Console.WriteLine("Gọi đến những đoạn code không liên quan đến ngoại lệ đã xử lý ở trên");
    }

    static void Example5()
    {
        Warrior warrior = new Warrior("Warrior");
        try
        {
            warrior.GainExp(160);
            warrior.PrintInfo();
            warrior.GainExp(1000000000);
            warrior.PrintInfo();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            warrior.HackCheatPenalty();
            Console.WriteLine(e.Message);
        }
        finally
        {
            warrior.PrintInfo();
        }
    }

    static void Example3()
    {
        Wizard merlin = new Wizard("Merlin", 100, 0);
        merlin.Hp = 80;
        Console.WriteLine($"Merlin HP is {merlin.GetHpPercent()}%");

        Wizard zantana = new Wizard("Zantana", 0, 0);
        zantana.Hp = 80;

        Console.WriteLine($"Zantana HP is {zantana.GetHpPercent()}%");
    }

    static void Example4()
    {
        int x = 10;
        try
        {
            Console.Write("Nhập 1 số từ bàn phím: ");
            var inputValue = Console.ReadLine();
            x = Int32.Parse(inputValue);
        }
        catch (Exception e)
        {
            x = 0;
            Console.WriteLine("Gặp lỗi khi nhập số");
        }
        finally
        {
            Console.WriteLine($"x = {x}");
        }

        try
        {
            Console.WriteLine($"1000/{x} = {1000 / x}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Gặp lỗi khi thực hiện phép chia");
        }

        Console.WriteLine("Gọi đến những đoạn code không liên quan đến ngoại lệ đã xử lý ở trên");
    }

    static void Example6()
    {
        Warrior warrior = new Warrior("Warrior");
        Console.WriteLine("Nhận -100 exp");
        try
        {
            warrior.GainExp(-100);
        }
        catch (InvalidDataException e)
        {
            Console.WriteLine("InvalidDataException: " + e.Message);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("InvalidOperationException: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Common Exception: " + e.Message);
        }
        
        Console.WriteLine("Nhận -10 exp");
        try
        {
            warrior.GainExp(-10);
        }
        catch (InvalidDataException e)
        {
            Console.WriteLine("InvalidDataException: " + e.Message);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("InvalidOperationException: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Common Exception: " + e.Message);
        }
        
        Console.WriteLine("Nhận 1000000000 exp");
        try
        {
            warrior.GainExp(1000000000);
        }
        catch (HackCheatException e)
        {
            Console.WriteLine("HackCheatException: " + e.Message);
            Console.WriteLine("Thông số bị hack: " + e.HackedData);
            Console.WriteLine("Giá trị hack: " + e.HackedValue);
        }
        catch (InvalidDataException e)
        {
            Console.WriteLine("InvalidDataException: " + e.Message);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("InvalidOperationException: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Common Exception: " + e.Message);
        }
    }

    public static void Run()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Example1();
        // Example2();
        // Example3();
        // Example4();
        // Example5();
        Example6();
    }
}
