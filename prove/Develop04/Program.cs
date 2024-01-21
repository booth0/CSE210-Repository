using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool isZero = false;
        while (isZero == false){
            Console.WriteLine("Enter number: ");
            var num = int.Parse(Console.ReadLine());
            if (num == 0){
                isZero = true;
            }
            else{
                numbers.Add(num);
            }
        }

        Console.WriteLine(numbers);
        
        
        
    }
}