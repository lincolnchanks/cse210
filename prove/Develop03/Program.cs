using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // // Call displays on Uncle
        // Word myWord = new Word("Uncle");
        // myWord.DisplayWord();
        // myWord.HideWord();
        // myWord.DisplayWord();

        // // Call displays on Kaladin
        // Word wordNumberTwo = new Word("Kaladin");
        // wordNumberTwo.DisplayWord();
        // wordNumberTwo.HideWord();
        // wordNumberTwo.DisplayWord();

        // // Create and display John Reference
        // Reference johnReference = new Reference("John", 3, 17);
        // Console.WriteLine(johnReference.GetReferenceString());

        // // Create 2 Nephi Reference
        // Reference tentReference = new Reference("2 Nephi", 2, 12);

        // // Create 2 Nephi Scripture
        // string myScriptureText = "And my father dwelt in a tent.";
        // Scripture myTestScripture = new Scripture(tentReference, myScriptureText);
        // myTestScripture.DisplayScripture();
        // myTestScripture.HideRandomWords();
        // myTestScripture.DisplayScripture();

        // Build scripture
        Reference goDoReference = new Reference("1 Nephi", 3, 7);
        string goDoText = "And it came to pass that I, Nephi, said unto my father, I will go and do the things which the Lord has commanded, for I know that the Lord giveth no commandment unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Scripture goDoScripture = new Scripture(goDoReference, goDoText);

        string action = "";

        do
        {
            Console.WriteLine("Here is a scripture: ");
            goDoScripture.DisplayScripture();
            Console.Write("> ");
            action = Console.ReadLine();
            goDoScripture.HideRandomWords();
            Console.Clear();
            goDoScripture.DisplayScripture();
        }
        while (action != "quit");

    }
}