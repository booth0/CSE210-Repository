using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {

        var breathing = new Breathing("Breathing", "Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
        var reflecting = new Reflecting("Reflecting", "Welcome to the Reflecting Activity.\n\nThis activity will help you recognize the power you have and how you can use it in other aspects of your life.");
        
        var listing = new Listing("Listing", "Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        
        bool stillGoing = true;
        while (stillGoing){
            stillGoing = Menu(breathing, reflecting, listing);
        }
        
        
    }


    static bool Menu(Breathing breathing, Reflecting reflecting, Listing listing) {
        int duration = 0;
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity\n2. Start relfecting activity\n3. Start listing activity\n4. Quit");
        Console.Write("Select a choice from the menu: ");

        string choice = Console.ReadLine();

        switch (choice){
            case "1":
            // Breathing
            Console.Clear();
            duration = breathing.StartingMessagePrint();
            breathing.BreathingActivity(duration, breathing);
            breathing.WellDone(duration);
                return true;
            case "2":
            // Reflecting
            Console.Clear();
            duration = reflecting.StartingMessagePrint();
            reflecting.ReflectingActivity(duration, reflecting);
            reflecting.WellDone(duration);
                return true;
            case "3":
            // Listing
            Console.Clear();
            duration = listing.StartingMessagePrint();
            listing.ListingActivity(duration, listing);
            listing.WellDone(duration);
                return true;
            case "4":
            // Quit
                return false;
            default:
                Console.WriteLine("This is an error");
                return true;
        }

    }
}