using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // "=" is the assignment operator
            // String datatype is used for text
            string myString = "this is a string";

            // Integer datatype is used for whole numbers (no decimal)
            int myInt = 42;

            // Double datatype is used for decimal numbers
            double myDouble = 69.99;

            // Boolean datatype is used for true/false values
            bool myBool = true;

            // Subtraction operator is "-"
            Console.WriteLine(myInt - 10); //32

            // Multiplication operator is "*"
            Console.WriteLine(myInt * 100); //4200

            // Division operator is "/"
            Console.WriteLine(myInt / 2); //21

            // Modulus operator is "%" (it returns the remainder after division)
            Console.WriteLine(myInt % 5); //2 (8, remainder 2)

            // Addition operator is "+"
            // But WAIT!!! This is also the concatenation operator
            Console.WriteLine(myInt + 8); //50

            Console.WriteLine("String " + 124); // Mixing string with int makes concatenation => String124
            Console.WriteLine("String" + 5 + 5); // If string comes first everything is concatenated => String55
            Console.WriteLine(5 + 5 + "String"); // calculations before strings are handled before concatenation => 10String



        }
    }
}
