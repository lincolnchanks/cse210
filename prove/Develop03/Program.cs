using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Build scripture
        Reference goDoReference = new Reference("1 Nephi", 3, 7);
        string goDoText = "And it came to pass that I, Nephi, said unto my father, I will go and do the things which the Lord has commanded, for I know that the Lord giveth no commandment unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Scripture goDoScripture = new Scripture(goDoReference, goDoText);

        string action = "";

        do
        {
            Console.Clear();
            Console.WriteLine("Here is a scripture: ");
            goDoScripture.DisplayScripture();
            Console.Write("> ");
            action = Console.ReadLine();
            goDoScripture.HideRandomWords();
        }
        while (action != "quit");

    }
}