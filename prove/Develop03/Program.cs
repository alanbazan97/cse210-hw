using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Scripture class with a reference and text
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            // While the scripture is not yet complete (all words are not yet hidden)
            while (!scripture.IsComplete())
            {
                // Clear the console window
                Console.Clear();
                // Display the reference and text of the scripture
                Console.WriteLine($"{scripture.GetReference()}:");
                Console.WriteLine(scripture.GetText());
                // Prompt the user to press enter to continue or type 'quit' to exit
                Console.WriteLine("Press enter to continue or type 'quit' to exit.");

                // Get the user's input
                string input = Console.ReadLine();
                
                // If the user types 'quit', exit the program
                if (input.ToLower() == "quit")
                {
                    return;
                }

                // Otherwise, hide a random word in the scripture and continue the loop
                scripture.HideRandomWord();
            }
    }
}
