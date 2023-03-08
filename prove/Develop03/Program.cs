using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Reference object with book "John", chapter 3, verse 16
        Reference reference = new Reference("John", 3, 16);
         // Define the text to be used in the Scripture
        string text = "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.";
        // Create a Scripture object with the reference and text defined above
        Scripture scripture = new Scripture(reference, text);
        // Clear the console
        Console.Clear();
        // Write the reference and rendered text of the initial state of the scripture
        Console.WriteLine(scripture.GetReference());
        Console.WriteLine(scripture.GetRenderedText());
        // Write a message asking for input to continue or quit
        Console.WriteLine("Press enter to continue, or type 'quit' to exit.");
        // Read the user input
        string input = Console.ReadLine();
        // Enter a loop until the user inputs 'quit' or all words in the scripture are hidden
        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            // Hide the next available word in the scripture
            scripture.HideWords();
            // Clear the console
            Console.Clear();
            // Write the reference and rendered text of the updated state of the scripture
            Console.WriteLine(scripture.GetReference());
            Console.WriteLine(scripture.GetRenderedText());
            // Write a message asking for input to continue or quit
            Console.WriteLine("Press enter to continue, or type 'quit' to exit.");
            // Read the user input
            input = Console.ReadLine();
        }
    }
}
