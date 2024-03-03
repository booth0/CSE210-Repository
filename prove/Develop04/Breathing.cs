using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Breathing:Activity {
        
        
    public Breathing(string activityName, string startingMessage):base(activityName, startingMessage) {

        }
    public void BreathingActivity(int duration, Breathing breathing) {
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
         while (startTime < futureTime){
            Console.Write("Breathe in...");
            breathing.Countdown(4);
         
            Console.Write("Breathe out...");
            breathing.Countdown(6);
            Console.WriteLine("");
            startTime = DateTime.Now;
        }
        
    }

    
}