using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool shouldQuit = false;
        // var entries = new List<Entry>();

        while (shouldQuit == false) 
        {
            Console.Clear();
            string input = Menu();

            if (input == "1") {
                journal.AddEntry();           
            }
            else if (input == "2") {
                Console.Clear();
                journal.DisplayEntries();
            }
            else if (input == "3") {
                var lines = journal.Export();
                WriteFile(lines);
            }
            else if (input == "4") {
                var lines = ReadFile();
                journal = new Journal(lines);
            }
            else if (input == "5") {
        
                shouldQuit = true;
            }
            else {
                Console.WriteLine("Invalid Response, please try again.");
            }
        }

        static string Menu()
        {
            Console.WriteLine("\nEnter a Command: \n1. Add Entry \n2. Display Entries \n3. Save \n4. Open \n5. Exit\n");
            Console.Write("What would you like to do? ");
            return Console.ReadLine();
        }

        static string[] ReadFile()
        {
            Console.Write("Enter filename: ");
            var filename = Console.ReadLine();
            return System.IO.File.ReadAllLines(filename);
        }    

        static void WriteFile(string[] lines)
        {
            Console.Write("Enter filename: ");
            var filename = Console.ReadLine();
            System.IO.File.WriteAllLines(filename, lines);
        }
            
        


        }

        

    }