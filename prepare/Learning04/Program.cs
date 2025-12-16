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

        MathAssignment mathAssignment = new MathAssignment("Kaladin Stormblessed", 
            "Multiplication", "3.4", "3-9");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Shallan Davar", 
            "Lightweaving", "Words of Radiance");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}