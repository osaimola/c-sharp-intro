using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // assign "osa" to the myName variable
            string myName = "Osa";
            // use the + operator to concatenate Hello and the value of myName variable
            Console.WriteLine("Hello, " + myName);

            Console.WriteLine("Enter your name followed by the Enter key...");
            // assign string entered from the console to the username Variable
            string userName = Console.ReadLine();
            // print entered string to console using string interpolation.
            Console.WriteLine($"Thanks {userName}");
            // Substring takes two arguements. !. starting position 2. Number of characters to return
            Console.WriteLine("1234567890".Substring(2, 5));
        }
    }
}
