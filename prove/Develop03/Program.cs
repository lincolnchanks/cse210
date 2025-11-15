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

        Reference myReference = new Reference("John", 3, 17);
        Console.WriteLine(myReference.GetReferenceString());

        Reference tentReference = new Reference("2 Nephi", 2, 12);

        // List<Word> myScriptureWordsList = new List<Word>();
        string myScriptureText = "And my father dwelt in a tent.";
        // string[] wordsArray = myScriptureText.Split(" ");
        // foreach (string word in wordsArray)
        // {
        //     Word word1 = new Word(word);
        //     myScriptureWordsList.Add(word1);
        // }
        
        Scripture myTestScripture = new Scripture(tentReference, myScriptureText);

        myTestScripture.DisplayScripture();
        // Scripture myScripture = new Scripture()
    }
}