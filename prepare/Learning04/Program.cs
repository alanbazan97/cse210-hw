using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a MathAssignment object and display its summary and homework list
        MathAssignment mathAssignment = new MathAssignment("John Doe", "Chapter 3", "Section 3.1", "1, 2, 3, 4");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Create a WritingAssignment object and display its summary and writing information
        WritingAssignment writingAssignment = new WritingAssignment("Jane Smith", "The Great Gatsby", "Write an essay about the symbolism in Chapter 5");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

        Console.ReadLine();
    }
}
