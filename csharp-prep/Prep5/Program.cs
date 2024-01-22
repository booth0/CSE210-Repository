using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        // Functions
        // returnType FunctionName(ParameterTypeEncoder prarmName1, ParameterTypeEncoder paranName2)
        // {
        //     FunctionName body
        // }

        int Add2(int number) {
            return number + 2;
        }
        int more = Add2(10);

        // void
        void PrintName(string name) {
            if (name.Length == 0){
                return;
            }
            System.Console.WriteLine($"Name is {name}");
            return;
        }
        PrintName("Bob");
        
        // use static for functions (for now)

        // variable scope

        var y = 0;
        {
            var w = 10;
            w = y + 4;
            y = w + 5;
        }
        // y = w + 4;
    }

}
