// See https://aka.ms/new-console-template for more information

using System.Text;
using GU1222E;

Console.OutputEncoding = Encoding.UTF8;

int Input()
{
    Console.Write("Nhập 1 số: ");
    string inp = Console.ReadLine();
    int value = Int32.Parse(inp);
    return value;
}

void Print(int a, int b)
{
    Console.WriteLine($"a={a}, b={b}");
    if (a == 10)
    {
        return;
    }

    Console.WriteLine("A không phải bằng 10");
}

int Plus(int a, int b)
{
    if (a == 10)
    {
        return b;
    }

    return a + b;
}

int n = 10;
int[] arr = new int[n];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i * 2;
}

// int a = Input();
// int b = Input();
// int c = Plus(a, b);
// Console.WriteLine($"Tổng của {a} và {b} là: {c}");
// Print(a, b);

Console.WriteLine(CustomArray.Str);
CustomArray.Fn();
Console.WriteLine(arr.Length);
Console.WriteLine(arr[5]);
