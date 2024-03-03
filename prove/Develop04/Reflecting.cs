using System;
using Microsoft.VisualBasic;

class Reflecting:Activity {

    private List<string> reflectingPrompts;
    private List<string> reflectingQuestions;
     public Reflecting(string activityName, string startingMessage):base(activityName, startingMessage) {
        reflectingPrompts = new List<string>();
        reflectingQuestions = new List<string>();
        List<string> prompts = [" --- Think of a time when you stood up for someone else. --- ", " --- Think of a time when you did something really difficult. --- ", " --- Think of a time when you helped someone in need. --- ", " --- Think of a time when you did something truly selfless. --- "];
        List<string> questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
        foreach (var prompt in prompts) {
            reflectingPrompts.Add(prompt);
        }
        foreach (var question in questions) {
            reflectingQuestions.Add(question);
        }
        }

    public void ReflectingActivity(int duration, Reflecting reflecting) {
        int randomNumber = reflecting.RandomNum(4);
        Console.WriteLine("Consider the following prompt:\n");        
        Console.WriteLine(reflectingPrompts[randomNumber]);
        Console.WriteLine("\nWhen you have something in mind, press enter to continue:");
        Console.ReadKey(); 
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        
        reflecting.Countdown(5);

        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
         while (startTime < futureTime){ 
            randomNumber = reflecting.RandomNum(9);
            Console.Write(reflectingQuestions[randomNumber]);
            reflecting.GetReady(8);

            startTime = DateTime.Now;
        }
        Console.WriteLine("");
        
    }
}