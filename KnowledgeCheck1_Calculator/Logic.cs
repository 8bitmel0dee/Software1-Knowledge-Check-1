using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Logic
    {
        public static (int, int) InputTwoNumbers()
        {
            Console.WriteLine("Enter the first number: ");

            Console.WriteLine();

            var number1 = Console.ReadLine();


            Console.WriteLine("Enter the second number: ");

            Console.WriteLine();

            var number2 = Console.ReadLine();

            if (int.TryParse(number1, out int numOne) && int.TryParse(number2, out int numTwo))
            {
                return (numOne, numTwo);
            }
            else
            {
                Console.WriteLine("Incorrect input, numbers only.");
                return (0, 0);
            }
        }
    }
}
