using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Call displays on Uncle
        Word myWord = new Word("Uncle");
        myWord.DisplayWord();
        myWord.HideWord();
        myWord.DisplayWord();

        // Call displays on Kaladin
        Word wordNumberTwo = new Word("Kaladin");
        wordNumberTwo.DisplayWord();
        wordNumberTwo.HideWord();
        wordNumberTwo.DisplayWord();

        // Create and display John Reference
        Reference johnReference = new Reference("John", 3, 17);
        Console.WriteLine(johnReference.GetReferenceString());

        // Create 2 Nephi Reference
        Reference tentReference = new Reference("2 Nephi", 2, 12);

        // Create 2 Nephi Scripture
        string myScriptureText = "And my father dwelt in a tent.";
        Scripture myTestScripture = new Scripture(tentReference, myScriptureText);
        myTestScripture.DisplayScripture();
        myTestScripture.HideRandomWords();
        myTestScripture.DisplayScripture();
    }
}