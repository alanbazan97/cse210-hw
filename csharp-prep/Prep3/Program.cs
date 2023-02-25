using System;

class Program
{
    static void Main(string[] args)
    {
        ///Prompt the user for a magic number
        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int number = int.Parse(magicNumber); 
        ///Genearating a random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = -1;
        ///While Loop
        while (guess != number)
        {
            ///Prompt the user for a guess
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            int guess = int.Parse(guessNumber);
            ///Determining if the user needs to guess higher or lower next time, or telling them if they guessed
            if ( guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}