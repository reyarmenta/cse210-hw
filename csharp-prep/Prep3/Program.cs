using System;

class Program
{
    static void Main(string[] args)
    {
        

        //Console.Write("What is the magic number? ");
        //Console.Write("What is your guess? ");

        Random randomGenerator = new Random ();
        int number = randomGenerator.Next(1,101);


        int guess =0;


        while (guess!= number){

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess){
                Console.Write("Higher ");
            }

            else if (number < guess){
                Console.Write("Lower ");
            }
            else {
                Console.Write("You guessed it!");
            }
        }



    }
}