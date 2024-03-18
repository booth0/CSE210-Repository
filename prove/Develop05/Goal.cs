using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using Microsoft.VisualBasic;
using System.IO; 

public class Goal {
    protected string goalName;
    protected string goalDescription;
    protected int pointValue;
    protected bool isComplete;
    
    public Goal(string goalName,  string goalDescription, int pointValue, bool isComplete) {
        this.goalName = goalName;
        this.goalDescription = goalDescription;
        this.pointValue = pointValue;
        this.isComplete = isComplete;
    }

    public virtual void Display() {
        string symbol = "";
        if (isComplete){
            symbol = "X";
        }
        else {
            symbol = " ";
        }

        Console.WriteLine($"[{symbol}] {goalName} ({goalDescription})");
    }

    public void Display2(){
        Console.WriteLine(goalName);
    }

    public bool IsComplete {
        get { return isComplete; }
        set { isComplete = value; }
    }

    public string GetGoalName() {
        return goalName;
    }
    public string GetGoalDescription() {
        return goalDescription;
    }
    public bool GetIsComplete() {
        return isComplete;
    }

    public int GetPoints() {
        return pointValue;
    }

    public virtual int EarnPoints(int pointTotal) {
        isComplete = true;
        pointTotal += pointValue;
                                
        Console.Write($"\nCongratulations! You have earned {pointValue} points!\nYou now have {pointTotal} points!\n\nPress enter to continue: ");
        Console.ReadKey();
        Console.WriteLine("");
        return pointTotal;
    }

    public virtual string Complile() {
        return "S:|" + goalName + "|" + goalDescription + "|" + pointValue + "|" + isComplete;
    }

    // public void Export(List<Goal> goals, string filename, int pointTotal){
    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //         {
    //             outputFile.WriteLine($"{pointTotal}");

    //             foreach (Goal g in goals) {
    //             outputFile.WriteLine($"{g.Complile()}");
    //             }

                
    //         }
    // }

    

    
}