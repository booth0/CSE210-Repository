using System;
using System.Diagnostics.Metrics;
using Microsoft.VisualBasic;
using System.IO; 

class Checklist:Goal {
    private int secondPointValue;
    private int goalCounter;
    private int goalTotal;
    public Checklist(string goalName, string goalDescription, int pointValue, bool isComplete, int secondPointValue, int goalCounter, int goalTotal):base(goalName,  goalDescription, pointValue, isComplete) {
        this.secondPointValue = secondPointValue;
        this.goalCounter = goalCounter;
        this.goalTotal = goalTotal;
        
    }

    public override void Display()
    {
        bool isComplete = GetIsComplete();
        string symbol = "";
        if (isComplete){
            symbol = "X";
        }
        else {
            symbol = " ";
        }

        Console.WriteLine($"[{symbol}] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {goalCounter}/{goalTotal}");
    }


    public override string Complile() {
        return "C:|" + goalName + "|" + goalDescription + "|" + pointValue + "|" + isComplete + "|" + secondPointValue + "|" + goalCounter + "|" + goalTotal;
    }

    public int GetSecondPointValue(){
        return secondPointValue;
    }

    public int GetGoalCounter(){
        return goalCounter;
    }

    public int GetGoalTotal(){
        return goalTotal;
    }

    public override int EarnPoints(int pointTotal) {
        if (goalCounter == goalTotal - 1) {
            isComplete = true;
            pointTotal += secondPointValue;
                                
            Console.Write($"\nCongratulations! You have earned {secondPointValue} points!\nYou now have {pointTotal} points!\n\nPress enter to continue: ");
            Console.ReadKey();
            Console.WriteLine("");
            return pointTotal;
        }
        else if (goalCounter != goalTotal) {
            pointTotal += pointValue;
            goalCounter += 1;
                                
            Console.Write($"\nCongratulations! You have earned {pointValue} points!\nYou now have {pointTotal} points!\n\nPress enter to continue: ");
            Console.ReadKey();
            Console.WriteLine("");
            return pointTotal;
        }
        else {
            return pointTotal;
        }
        
    }
}