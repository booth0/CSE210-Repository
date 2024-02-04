using System;
public class Journal
{
    
    public List<Entry> entries;

    public Journal() 
    {
        entries = new List<Entry>();
    }

    public Journal(string[] importLines)
    {
        entries = new List<Entry>();
        foreach (var line in importLines)
        {
            var entry = new Entry(line);
            entries.Add(entry);
        }
    }

        public void DisplayEntries()
    {
        Console.WriteLine("\nEntry List:");
        Console.WriteLine("---------");

        foreach (var entry in entries)
        {
            Console.WriteLine(entry.Display());
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var entry in entries)
        {
            exportLines.Add(entry.Export());
        }
        return exportLines.ToArray();
    }

    


    public void AddEntry()
    {
        string[] prompts = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
        Random r = new Random();
        int rInt = r.Next(0, 4);

        var prompt = prompts[rInt];
        Console.WriteLine(prompt);

        Console.Write("Enter text here: ");
        var response = Console.ReadLine();

        Console.Write("What is today's date? ");
        var date = Console.ReadLine();

        var entry = new Entry(prompt, response, date);

        entries.Add(entry);
    }

}