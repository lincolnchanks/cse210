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
    }
}