// See https://aka.ms/new-console-template for more information
using System;
class MainClass
{
    static void Main(string[] args)
    {
        string myName;
        myName = "Alex";
        byte age = 24;
        Boolean pet = true;
        double size = 45.1;


        Console.WriteLine("\t дратути");
        Console.WriteLine(" What is your name? \t" + myName);
        Console.WriteLine(" how old are you? \t" + age);
        Console.WriteLine(" do you have a pet? \t" + pet);
        Console.WriteLine(" what is your shoose size? \t" + size);
        Console.WriteLine("\u0040");
        Console.WriteLine("\x23");
        Console.ReadKey();
    }
}

