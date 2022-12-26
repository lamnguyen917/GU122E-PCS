using System.Net;
using System.Numerics;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using GU1222E.ChessBoard;

namespace GU1222E;

public class Day6
{
    static void CallWebContent(string url)
    {
        Console.WriteLine($"READING WEB CONTENT {url}");
        WebRequest webRequest = WebRequest.Create(url);
        var objStream = webRequest.GetResponse().GetResponseStream();
        StreamReader objReader = new StreamReader(objStream);
        // Console.WriteLine(objReader.ReadToEnd());
        Console.WriteLine($"END READING WEB CONTENT {url}");
        Thread.Sleep(2000);
        Console.WriteLine($"END READING FUNCTION");
    }

    static string GetContent(string url)
    {
        Console.WriteLine($"READING WEB CONTENT {url}");
        WebRequest webRequest = WebRequest.Create(url);
        var objStream = webRequest.GetResponse().GetResponseStream();
        StreamReader objReader = new StreamReader(objStream);
        return objReader.ReadToEnd();
    }

    static void Exam1()
    {
        CallWebContent("https://www.w3schools.com/cs/index.php");
    }

    static void Exam2()
    {
        Thread thread = new Thread(() => { CallWebContent("https://www.w3schools.com/cs/index.php"); });
        thread.Name = "Call web thread";
        thread.Start();
        Thread thread2 = new Thread(() =>
        {
            Console.WriteLine("END OF EXAM 2   1");
            Console.WriteLine("END OF EXAM 2    2");
            Thread.Sleep(2000);
            Console.WriteLine("END OF EXAM 2    3");
            Console.WriteLine("END OF EXAM 2   4");
            Console.WriteLine("END OF EXAM 2 555");
            thread.Join();
        });
        thread2.Name = "Example thread";
        thread2.Start();
        thread.Join();

        Console.WriteLine(thread.Name);
        Console.WriteLine(thread2.Name);
    }

    static Thread thread1;
    static Thread thread2;

    static void ThreadProc()
    {
        Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
        if (Thread.CurrentThread.Name == "Thread1" &&
            thread2.ThreadState != ThreadState.Unstarted)
            thread2.Join();

        Thread.Sleep(4000);
        Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
        Console.WriteLine("Thread1: {0}", thread1.ThreadState);
        Console.WriteLine("Thread2: {0}\n", thread2.ThreadState);
    }

    static void Exam3()
    {
        thread1 = new Thread(ThreadProc);
        thread1.Name = "Thread1";
        thread1.Start();

        thread2 = new Thread(ThreadProc);
        thread2.Name = "Thread2";
        thread2.Start();
    }

    static float Divide(float a, float b)
    {
        return a / b;
    }

    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Exam4()
    {
        int a1 = 6;
        int b1 = 5;

        float a2 = 7.4f;
        float b2 = 5.5f;
        Console.WriteLine($"{a1} / {b1} = {Divide(a1, b1)}");
        Console.WriteLine($"{a2} / {b2} = {Divide(a2, b2)}");

        Swap(ref a2, ref b2);
        Swap(ref a1, ref b1);
        Console.WriteLine($"{a1} / {b1} = {Divide(a1, b1)}");
        Console.WriteLine($"{a2} / {b2} = {Divide(a2, b2)}");
    }

    static void Exam5()
    {
        Board board = new Board();
        board.PrintAllChess();
    }

    static void Exam6()
    {
        Dictionary<ChessType, string> dictionary = new Dictionary<ChessType, string>();
        dictionary[ChessType.Black] = "BackType$$$$$";
        dictionary[ChessType.White] = "White^^^^^^^^^^^^^^";

        Console.WriteLine(dictionary[ChessType.Black]);
        Console.WriteLine(dictionary[ChessType.White]);

        dictionary[ChessType.Black] = "new black value";
        foreach (var kv in dictionary)
        {
            Console.WriteLine($"Key = {kv.Key}; Value = {kv.Value}");
        }

        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict["chess"] = "cờ vua";
        dict["rook"] = "quân xe";
        dict["bishop"] = "quân tượng";
        dict["knight"] = "quân mã";


        Console.WriteLine("=======================================");
        foreach (var kv in dict)
        {
            Console.WriteLine($"Key = {kv.Key}; Value = {kv.Value}");
        }

        Console.WriteLine(dict.ContainsKey("king"));
        Console.WriteLine(dict.ContainsKey("knight"));
        Console.WriteLine(dict.GetValueOrDefault("king", "k"));
        Console.WriteLine($"Custom default dict: {GetDictValue(dict, "king", "quân vua")}");
        Console.WriteLine(dict["king"]);
    }

    static string GetDictValue(Dictionary<string, string> dict, string key, string defaultValue)
    {
        if (dict.ContainsKey(key))
        {
            return dict[key];
        }

        return defaultValue;
    }

    static void Exam7()
    {
        string content = GetContent("https://www.w3schools.com/cs/index.php");
        File.WriteAllText("test.txt", content);

        string fileContent = File.ReadAllText("test.txt");
        Console.WriteLine(fileContent);

        Console.WriteLine(File.Exists("test.txt"));
        File.Move("test.txt", "/test.txt");
        Console.WriteLine(File.Exists("test.txt"));
    }

    static void Exam8()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict["chess"] = "cờ vua";
        dict["rook"] = "quân xe";
        dict["bishop"] = "quân tượng";
        dict["knight"] = "quân mã";
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("board.bin", FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, dict);
    }

    static void Exam9()
    {
        Stream stream = new FileStream("stream.txt", FileMode.Create, FileAccess.Write, FileShare.None);
        StreamWriter writer = new StreamWriter(stream);
        writer.WriteLine("Xe");
        writer.WriteLine("Pháo");
        writer.WriteLine("Mã");
        writer.WriteLine("Tướng");
        writer.WriteLine("Sĩ");
        writer.WriteLine("Tượng");
        writer.Close();
        Console.ReadLine();
        stream.Close();
    }

    static void Exam10()
    {
        Stream stream = new FileStream("stream.txt", FileMode.Open, FileAccess.Read, FileShare.None);
        StreamReader reader = new StreamReader(stream);
        Console.WriteLine(reader.ReadToEnd());
        Console.ReadLine();
    }

    static void Exam11()
    {
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("board.bin", FileMode.Open, FileAccess.Read, FileShare.None);
        Dictionary<string, string> dictionary = formatter.Deserialize(stream) as Dictionary<string, string>;
        foreach (var kv in dictionary)
        {
            Console.WriteLine($"Key = {kv.Key}; Value = {kv.Value}");
        }
    }

    public static void Run()
    {
        // Exam1();
        // Exam2();
        // Exam3();
        // Exam4();
        // Exam5();
        // Exam6();
        // Exam7();
        // Exam8();
        // Exam9();
        // Exam10();
        Exam11();
    }
}
