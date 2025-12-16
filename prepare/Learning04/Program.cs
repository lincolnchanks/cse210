using System;

class Program
{
    static void Main(string[] args)
    {
        // Linguistics program!!! (Conlangs!!)
        Assignment assignment1 = new Assignment("Bob Jones", "Phonology");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHashCode()); // Is this the memory location?
        Console.WriteLine(assignment1.GetType()); // Gets the data type (Assignment)
    }
}