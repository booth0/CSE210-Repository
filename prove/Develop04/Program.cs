using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        List<float> numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool isZero = false;
        while (isZero == false){
            Console.WriteLine("Enter number: ");
            var num = float.Parse(Console.ReadLine());
            if (num == 0){
                isZero = true;
            }
            else{
                numbers.Add(num);
            }
        }
        float sum = 0;
        float largestNum = -99999;
        foreach (float number in numbers)
        {
            sum += number;
            Console.WriteLine(number);
            if(number > largestNum){
                largestNum = number;
            }
            else{}

        }

        float avg = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNum}");
        
        
    }
}