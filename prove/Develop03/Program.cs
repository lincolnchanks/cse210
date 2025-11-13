using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Uncle");
        myWord.DisplayWord();

        myWord.HideWord();
        if (myWord.GetIsHidden())
        {
            Console.WriteLine("Word is hidden.");
        }

        // Console.WriteLine(myWord.GetWordString());
        myWord.DisplayWord();

        Word wordNumberTwo = new Word("Kaladin");
        // Console.WriteLine(wordNumberTwo.GetWordString());
        wordNumberTwo.DisplayWord();
        wordNumberTwo.HideWord();
        // Console.WriteLine(wordNumberTwo.GetWordString());
        wordNumberTwo.DisplayWord();
    }
}