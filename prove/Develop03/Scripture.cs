using System;
using System.Security.Cryptography;
// 12 Yea, I know that I am anothing; as to my strength I am weak; therefore I will bnot boast of myself, but I will cboast of my God, for in his dstrength I can do all ethings; yea, behold, many mighty miracles we have wrought in this land, for which we will praise his name forever.

class Scripture
{
    private List<Word> words;
    private Reference reference;

    public Scripture(Reference reference, string content) 
    {
        this.reference = reference;
        words = new List<Word>();
        //Breaking down the verse string into individual words and saving them to a list
        string[] wordsStrings = content.Split(" ");
        foreach (var word in wordsStrings){
            //Turns each word in the list into an instance of the Word class
            words.Add(new Word(word, false));
        }
    }


    public void Display(){
        // Combines the display functions from the Reference and Word classes respectively.
        reference.DisplayRef();
        foreach (var word in words){
            Console.Write($"{word.DisplayWord()} ");
        }
    }
    public void HideWords(){
        // This for loop iterates 3 times
        for (int i = 0; i <= 2; i = i + 1) {
            Random rnd = new Random();
            int randNum = -1;
            // the purpose of this counter is to ensure that the while loop doesn't get stuck once it runs out of words that aren't hidden.
            int counter = 0;
            bool alreadyHidden = true;
            // The purpose of this while loop is to make sure only words that aren't hidden are selected.
            while (alreadyHidden){
                if (counter < 100){
                randNum = rnd.Next(0, words.Count);
                alreadyHidden = words[randNum].AlreadyHidden();
                counter += 1;
                }
                else {
                    alreadyHidden = false;
                }
            }
            // Hides an unhidden word
            words[randNum].Hide();
            
        }
    }
}

