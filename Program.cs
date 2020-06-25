using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please tell us if you want to add, subtract or multiply. (add/ subtract/  multiply)");
            string userOperator = Console.ReadLine();

            if (userOperator == "add")
            {
                // converting string to int https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                Console.WriteLine("Please enter the first number");
                int firstNum = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number");
                int secondNum = Int32.Parse(Console.ReadLine());

                // Calculate the result
                int result = firstNum + secondNum;
                Console.WriteLine("{0} + {1} = " + result, firstNum, secondNum);
            }

            else if (userOperator == "subtract")
            {
                // converting string to int https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                Console.WriteLine("Please enter the first number");
                int firstNum = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number");
                int secondNum = Int32.Parse(Console.ReadLine());

                // Calculate the result
                int result = firstNum - secondNum;
                Console.WriteLine("{0} - {1} = " + result, firstNum, secondNum);
            }

            else if (userOperator == "multiply")
            {
                // converting string to int https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                Console.WriteLine("Please enter the first number");
                int firstNum = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number");
                int secondNum = Int32.Parse(Console.ReadLine());

                // Calculate the result
                int result = firstNum * secondNum;
                Console.WriteLine("{0} * {1} = " + result, firstNum, secondNum);
            }

            else
            {
                Console.WriteLine("Invalid operation. Please use only add / subtract / multiply");
            }
        }
    }
}
