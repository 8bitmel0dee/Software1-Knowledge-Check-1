using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            Console.WriteLine();

            var input = Console.ReadLine();

            var calculator = new Calculator();

            Console.WriteLine();    

            // Moved the code that asks for two numbers and parses them into a seperate method -> InputTwoNumbers()

            switch (input)
            {
                case "1":

                    Console.WriteLine("You have selected addition.");

                    Console.WriteLine();    

                    var (addNumOne, addNumTwo) = InputTwoNumbers();

                    

                    Console.Write($"{addNumOne} + {addNumTwo} = ");

                    Console.Write(calculator.Add(addNumOne, addNumTwo));

                    break;

                case "2":

                    Console.WriteLine("You have selected subtraction.");

                    Console.WriteLine();

                    var (subNumOne, subNumTwo) = InputTwoNumbers();

                    Console.Write($"{subNumOne} - {subNumTwo} = ");

                    Console.Write(calculator.Subtract(subNumOne, subNumTwo));

                    break;

                case "3":

                    Console.WriteLine("You have selected multiplication.");

                    Console.WriteLine();

                    var (multiplyNumOne, multiplyNumTwo) = InputTwoNumbers();

                    Console.Write($"{multiplyNumOne} * {multiplyNumTwo} = ");

                    Console.Write(calculator.Multiply(multiplyNumOne, multiplyNumTwo));

                    break;

                case "4":

                    Console.WriteLine("You have selected division.");

                    Console.WriteLine();

                    var (divideNumOne, divideNumTwo) = InputTwoNumbers();

                    Console.Write($"{divideNumOne} / {divideNumTwo} = ");

                    Console.Write(calculator.Divide(divideNumOne, divideNumTwo));

                    break;


                default:

                    Console.WriteLine("Unknown input");

                    break;
            }


            /* new method - InputTwoNumbers() */

            static (int, int) InputTwoNumbers()
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
}