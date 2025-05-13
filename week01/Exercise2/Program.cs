using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        
        int percentage = int.Parse(userInput);
        string letter;

        //Determine Letter
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        //Grade prints out in every if statement.
        /*if (percentage >= 90)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Your grade is: B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("Your grade is: C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Your grade is: D");
        }
        else 
        {
            Console.WriteLine("Your grade is: F");
        }*/

        //Determine if the person passed or not    
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else
        {
            Console.WriteLine("Keep working hard :)");
        }

    }
}