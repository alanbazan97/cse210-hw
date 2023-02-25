using System;

class Program
{
    static void Main(string[] args)
    {
        ///Prompt the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        ///Convernting the string in an integer
        int percentage = int.Parse(gradePercentage);
        string letterGrade = "";
        ///Determing which is the right value for letterGrade
        if ( percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        ///Printing out the appropriate letter grade
        Console.WriteLine($"Your grade is {letterGrade},");
        ///Determining if the user passed the course
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("I'm sorry, you didn't passed the class.");
        }
    }
}