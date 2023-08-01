using System;
class MainClass
{
    public static void Main(string[] args)
    {
        string MyName = "Computer";
        Console.WriteLine("Hello human");
        Console.WriteLine("I am a {0}", MyName);
        Console.Write("What is your name?");
        Console.WriteLine();
        string YourName = Console.ReadLine();
        Console.Write("I am happy to met you {0}", YourName);

        Console.ReadKey();

    }
}
