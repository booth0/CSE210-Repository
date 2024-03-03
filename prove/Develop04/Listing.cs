using System;
using Microsoft.VisualBasic;

class Listing:Activity {

    private List<string> listingPrompts;
     public Listing(string activityName, string startingMessage):base(activityName, startingMessage) {
        listingPrompts = new List<string>();
        List<string> prompts = [" --- Who are people that you appreciate? --- ", " --- What are personal strengths of yours? --- ", " --- Who are people that you have helped this week? --- ", " --- When have you felt the Holy Ghost this month? --- ", " --- Who are some of your personal heroes? --- "];
        foreach (var prompt in prompts) {
            listingPrompts.Add(prompt);
        }
    }

    public void ListingActivity(int duration, Listing listing){
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(listingPrompts[listing.RandomNum(5)]);
        Console.Write("You may begin in: ");
        listing.Countdown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
         while (startTime < futureTime){ 
            Console.ReadLine();
            Console.ReadKey();
            startTime = DateTime.Now;
        }
        Console.WriteLine("");

    }
}