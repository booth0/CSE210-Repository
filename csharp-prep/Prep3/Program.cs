using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        //while loop
        int count = 5;
        while (count < 10){
            System.Console.WriteLine($"Count = {count++}");
        }
        while (count < 15){
            System.Console.WriteLine($"Count = {count}");
            count += 1;
        }
    
        //do-while loop
        int anotherCount = 0;
        do{
            System.Console.WriteLine($"AnotherCount = {++anotherCount}");
        } while (anotherCount <10);

        // for loop
        for(int i = 0; i<5; i++){
            System.Console.WriteLine($"i = {i}");
        }


        // Ask for a random number
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);
    bool isCorrect = false;
    while (!isCorrect)
    {
            // Ask user for guess
            System.Console.WriteLine("Guess a random number;");
            int guess = int.Parse(Console.ReadLine());

            //Check if guess is higher
            if (guess > randomNumber)
            {
                System.Console.WriteLine("Too high");
            }
            else if (guess < randomNumber)
            {
                System.Console.WriteLine("Too low.");
            }
            else{
                System.Console.WriteLine("Correct.");
                isCorrect = true;
            }
    }

        
    }
}