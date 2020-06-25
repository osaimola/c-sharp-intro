using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a text to be stored in the userInput
            Console.WriteLine("Put in some text if you dare...");
            string userInput = Console.ReadLine();

            // the if statement will run if the  IF CONTDITION is TRUE or has a truthy value
            if (userInput.Length > 0)
            {
                Console.WriteLine("the user entered a string");
            }
            // the else statement will run
            else
            {
                Console.WriteLine("hmmm... looks like the user did not enter any values");
            }
        }
    }
}
