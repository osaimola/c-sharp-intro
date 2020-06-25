using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logical operators
            // The OR "||" will evaluate to TRUE if EITHER side is TRUE
            Console.WriteLine(true || true); // true
            Console.WriteLine(false || true); // true
            Console.WriteLine(false || false); // false

            // The AND "&&" will evaluate to TRUE only if BOTH sides are TRUE
            Console.WriteLine(true && true); // true
            Console.WriteLine(false && true); // false
            Console.WriteLine(false && false); // false

            // How does this behave with other data types?
            // Console.WriteLine(true && 1); // IT DOESN"T WORK

            // Comparative operators
            // "Equal" to check
            Console.WriteLine(false == false); // true
            Console.WriteLine(true == false); // false
            Console.WriteLine(2.5 == 2.5); // true
            Console.WriteLine(2.25 == 3.15); // false
            // Console.WriteLine("2.25" == 2.25); // cannot compare two different types

            // Greater than checks
            Console.WriteLine(6 > 7); // false
            Console.WriteLine(10 > 5); // True

            // Less than checks
            Console.WriteLine(6 < 7); // false
            Console.WriteLine(10 < 5); // false

            // Greater than or Equal to checks
            Console.WriteLine(5 >= 5); // True
            Console.WriteLine(10 >= 5); // True
            Console.WriteLine(4 >= 5); // False

            // Less than or Equal to checks
            Console.WriteLine(5 <= 5); // True
            Console.WriteLine(10 <= 5); // False
            Console.WriteLine(4 <= 5); // True

            // Not Equal to check
            Console.WriteLine(false != false); // False
            Console.WriteLine(false != true); // Trues
            Console.WriteLine(5 != 5); // false
            Console.WriteLine(5 != 10); // true

        }
    }
}
