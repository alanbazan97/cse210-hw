using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            while (!scripture.IsComplete())
            {
                Console.Clear();
                Console.WriteLine($"{scripture.GetReference()}:");
                Console.WriteLine(scripture.GetText());
                Console.WriteLine("Press enter to continue or type 'quit' to exit.");

                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    return;
                }

                scripture.HideRandomWord();
            }
    }
}
