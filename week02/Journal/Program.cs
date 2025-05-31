using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        //Test code
        //Entry e = new Entry();

        //Testing prompt generator
        //PromptGenerator promptGenerator= new PromptGenerator();
        //e._promptText = promptGenerator.GetRandomPrompt();

        //Testing date    
        //e._date = "1/1/2025";

        // Today's date
        //DateTime theCurrentTime = DateTime.Now;
        //string dateText = theCurrentTime.ToShortDateString();
        //e._date = dateText;

        //Test entry text
        //Console.WriteLine("Prompt: ");
        //e._EntryText = Console.ReadLine();

        //e.Display();

        //
        Journal journal = new Journal();

        Console.WriteLine("Welcoem to the Journal Program!");

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            // WRITE
            if (choice == 1)
            {
                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();

                PromptGenerator promptGenerator = new PromptGenerator();
                newEntry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine("Prompt: " + newEntry._promptText);

                Console.Write(">");
                newEntry._EntryText = Console.ReadLine();

                journal.AddEntry(newEntry);

                newEntry.Display();

                
            }

            // DISPLAY
            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            // Load
            else if (choice == 3)
            {

            }

            // SAVE
            else if (choice == 4)
            {

            }

            // NOT A CHOICE
            else if (choice != 5)
            {
                Console.WriteLine("You've entered an invalid number, try again.");
            }

        }

        // QUIT
        if (choice == 5)
        {
            Console.WriteLine("Goodbye!");
        }
    }
}