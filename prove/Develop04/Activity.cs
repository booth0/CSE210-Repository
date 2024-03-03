using System;
using System.Diagnostics.Metrics;
using Microsoft.VisualBasic;

class Activity {
    private string activityName;
    private string startingMessage;
    // private int duration;
    

    public Activity(string activityName, string startingMessage) {
        this.activityName = activityName;
        this.startingMessage = startingMessage;
        // this.duration = duration;
    }

    public int StartingMessagePrint() {
        Console.WriteLine(startingMessage);
        Console.Write("\nHow long in seconds would you like your session? ");
        int duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        GetReady(5);
        return duration;
    }

    public void WellDone(int duration) {
        Console.WriteLine("Well done!!!");
        GetReady(5);
        Console.WriteLine($"You have completed {duration} seconds of the {activityName} Activity.");
        GetReady(5);
    }

    public void GetReady(int howMany) {
        // Does the little animation for the specified number of seconds.
        int counter = 0;
        while (counter != howMany){
            Console.Write(" H");

            Thread.Sleep(500);

            Console.Write("\b \b\b"); 
            Console.Write("|-|"); 

            Thread.Sleep(500);

            Console.Write("\b\b\b   \b\b\b");

            counter += 1;
        }
        Console.WriteLine("");
    }

    public void Countdown(int num) {
        // Counts down from the specified number
        int counter = 0;
        Console.Write(num);
        while (counter != num) {
            counter += 1;
            Thread.Sleep(1000);
            Console.Write($"\b{num-counter}"); 
        }
        Console.WriteLine("\b ");
    }

    public int RandomNum(int howMany){
        // Randomly picks a number between 0 and the specified number.
        Random rnd = new Random();
        return rnd.Next(0, howMany);
    }

}