using System;
using Microsoft.VisualBasic;

class Reference
{
    private string book;
    private int chapter;
    private int verses;
    

    public Reference(string book, int chapter, int verses){
        this.book = book;
        this.chapter = chapter;
        this.verses = verses;
    }


    public void DisplayRef(){
        System.Console.WriteLine($"{book} {chapter}:{verses}");
    }
}