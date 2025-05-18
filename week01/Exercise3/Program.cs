using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        int magicNumber = 0;
        magicNumber = int.Parse(Console.ReadLine());*/

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (magicNumber != guess)
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}