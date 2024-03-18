using System;
using System.Diagnostics.Metrics;
using Microsoft.VisualBasic;
using System.IO; 

class Eternal:Goal {

    public Eternal(string goalName, string goalDescription, int pointValue, bool isComplete):base(goalName,  goalDescription, pointValue, isComplete) {
        
    }

  public override void Display()
    {
        Console.WriteLine($"[ ] {GetGoalName()} ({GetGoalDescription()})");
    }

  public override string Complile() {
        return "E:|" + goalName + "|" + goalDescription + "|" + pointValue + "|" + isComplete;
    }
}