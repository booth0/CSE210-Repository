using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magNum = randomGenerator.Next(1, 101);

    bool isCorrect = false;
    while (!isCorrect){

        System.Console.WriteLine("What's your guess?");
        var guess = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{guess}");
        if(guess == magNum){
            Console.WriteLine("That's right!");
            isCorrect = true;
        }
        else if(guess > magNum){
            Console.WriteLine("Lower!");
        }
        else{
            Console.WriteLine("Higher!");
        }
    }
    }
}