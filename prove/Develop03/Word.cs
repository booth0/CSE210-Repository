using System;
using System.Security.Cryptography;

class Word
{
    private bool isHidden;
    private string word;

    public Word(string word, bool isHidden){
        this.word = word;
        this.isHidden = isHidden;
    }

    // public string DisplayWord(){
    //     if (isHidden == false){
    //         return word;
    //     }
    //     else if (isHidden == true){
    //         string thing = "";
    //         for (int i = 0; i <= word.Length-1;){
    //             thing += "_";
    //         }
    //         Console.WriteLine(thing);
    //         return thing;
    //     }
    //     else {
    //         return "error";        }
    // }
    public string DisplayWord(){
        if (!isHidden){
            return word;
        }
        else {
            // If the word is hidden, this code will replace that word with underscores
            string thing = "";
            for (int i = 0; i < word.Length; i++){
                thing += "_";
            }
            return thing;
        }
    }

    public void Hide() {
        isHidden = true;
    }

    public bool AlreadyHidden() {
        if (isHidden == true){
            return true;
        }
        else {
            return false;
        }
    }
}

