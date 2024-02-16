using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Set the scripture reference
        var reference = new Reference("Alma", 26, 12);
        // Add the reference and a scripture as a string into the constructor.
        var scripture = new Scripture(reference, "12 Yea, I know that I am nothing; as to my strength I am weak; therefore I will not boast of myself, but I will boast of my God, for in his strength I can do all things; yea, behold, many mighty miracles we have wrought in this land, for which we will praise his name forever.");
        // Displays the reference and iterates through the words list, printing the whole verse.
        scripture.Display();

        bool isQuit = false;
        while (!isQuit) {
            string response = "";
            Console.WriteLine("\n\nPlease press 'Enter' to hide words or type 'Quit' to quit:");
            response = Console.ReadLine();
            if (response == "Quit"){
                isQuit = true;
            }
            else {
                Console.Clear();
                // Randomly selects 3 words and hides them
                scripture.HideWords();
                // Displays the reference and iterates through the words list, now representing hidden words with underscores.
                scripture.Display();
            }
        }
        
    }
}