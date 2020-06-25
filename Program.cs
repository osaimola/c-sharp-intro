using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 3;
            while (myNum > 0)
            {
                Console.WriteLine(myNum);
                myNum--;
            }

            for (int i = 0; i < 6; i += 2)
            {
                //do something
                Console.WriteLine("Current (for) loop number is: {0}", i);
            }

            // If we need to iterate through a list, use foreach!
            // @link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in
            string[] myList = { "cat", "turtle", "lizard", "frog", "dog" }; // This is a list of strings!
            foreach (string listItem in myList)
            {
                Console.WriteLine("The current item is: {0}", listItem);
            }
        }
    }
}
