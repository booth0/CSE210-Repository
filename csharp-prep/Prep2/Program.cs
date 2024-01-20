using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        //SOmtheing
        double d;
        char c;

        //Variables
        int myCount = 34;
        int anotherInt = 3;
        string myName = "Adam";

        //var
        var myLastName = "Booth";
        var myOtherCount = 3;

        //Printing Variables
        Console.WriteLine("A Name: " + myName);
        Console.WriteLine($"A Name: {myName}");

        //ReadLine
        System.Console.WriteLine("What's your age?");
        var ageString = Console.ReadLine();

        //Converting Variables
        var age = int.Parse(ageString);

        //Conditionals
        if (age < 18)
        {
            System.Console.WriteLine("You're a minor.");
        }
        else
        {
            System.Console.WriteLine("You're old.");
        }
    }
}