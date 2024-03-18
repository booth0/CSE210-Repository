using System;
using System.Net;
using System.IO;
using System.IO.Enumeration;
using System.Xml;
using System.Reflection.Metadata;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        int pointTotal = 0;
        var goals = new List<Goal>();
        string goalName = "";
        string goalDescription = "";
        int pointValue = 0;
        int secondPointValue = 0;
        int goalTotal = 0;

        bool stillGoing = true;
        while (stillGoing){
        Console.WriteLine($"You have {pointTotal} points.\n");
        Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        switch (choice) {
            
            case "1":
            // New Goal
            Console.Clear();
            Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string choice2 = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            pointValue = int.Parse(Console.ReadLine());

            switch (choice2) {
                case "1":
                    Simple test1 = new Simple(goalName, goalDescription, pointValue, false);
                    goals.Add(test1);
                    break;
                case "2":
                    Eternal test2 = new Eternal(goalName, goalDescription, pointValue, false);
                    goals.Add(test2);
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    goalTotal = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    secondPointValue = int.Parse(Console.ReadLine());
                    Checklist test3 = new Checklist(goalName, goalDescription, pointValue, false, secondPointValue, 0, goalTotal);
                    goals.Add(test3);
                    break;
                default:
                    break;
                    
            }
            Console.Clear();
            
            break;

            case "2":
            // List Goals
            Console.Clear();
            int counter1 = 1;
            Console.WriteLine("The goals are:");
            foreach (Goal g in goals) {
                Console.Write($"{counter1}. ");
                g.Display();
                counter1 += 1;
            }
            Console.WriteLine("");
            break;

            case "3":
            // Save Goals
            Console.Write("\nWhat is the filename for the goal file? ");
            string filename = Console.ReadLine();
            Export(goals, filename, pointTotal);
            Console.Clear();
            break;

            case "4":
            // Load Goals
            Console.Write("What is the filename? ");
            string importFilename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(importFilename);

            
            int counter = 1;
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                
                if (counter == 1){
                    pointTotal = int.Parse(parts[0]);
                    counter += 1;
                }

                else {switch (parts[0]) {
                case "S:":
                    Simple test1 = new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    goals.Add(test1);
                    break;
                case "E:":
                    Eternal test2 = new Eternal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    goals.Add(test2);
                    break;
                case "C:":
                    Checklist test3 = new Checklist(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                    goals.Add(test3);
                    break;
                default:
                    break;}
                       
                }
                
            }
            Console.Clear();
            break;

            case "5":
            // Record event
            Console.Clear();
            int counter2 = 1;
            Console.WriteLine("The goals are:");
            foreach (Goal g in goals) {
                Console.Write($"{counter2}. ");
                g.Display2();
                counter2 += 1;
            }
            pointTotal = AwardPoints(pointTotal, goals);
            Console.Clear();
            break;

            case "6":
            // Quit
            stillGoing = false;
            break;

            default:
                Console.WriteLine("This is an error");
                break;
        }
        }

    }

    static void Export(List<Goal> goals, string filename, int pointTotal){
        using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine($"{pointTotal}");

                foreach (Goal g in goals) {
                outputFile.WriteLine($"{g.Complile()}");
                }  
            }
    }

    static int AwardPoints(int pointTotal, List<Goal> goals) {
        Console.Write("Which goal did you accomplish? ");
            int choice = int.Parse(Console.ReadLine());
           
            int counter = 1;
            foreach (Goal g in goals) {                    
                if (counter == choice) {
                    switch (g.GetIsComplete()){
                        case true:
                        counter += 1;
                        Console.WriteLine("\nThis goal has already been completed.\nPress enter to continue: ");
                        Console.ReadKey();
                        break;

                        case false:
                        counter += 1;
                        pointTotal = g.EarnPoints(pointTotal);
                        break;
                    }
                }
                else if (counter != choice) {
                    counter += 1;
                }
                else {
                    Console.WriteLine("This is an error");
                }
            }
    return pointTotal;
    }
}