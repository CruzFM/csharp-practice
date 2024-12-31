using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            Exercise2();
        }

        static void Exercise1()
        {
            Console.Write("Enter your name: ");
            string lineaFerchu = Console.ReadLine();
            Console.WriteLine($"{lineaFerchu}! Welcome to .NET programming!");
            Console.ReadLine();
        }

        static void Exercise2()
        {
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operation (+, -, * , /): ");
            string operation = Console.ReadLine();
            void mathOperation(int number) {
                Console.WriteLine($"The result is: {number}");
            }
            switch(operation)
            {
                case "+":
                    mathOperation(firstNumber + secondNumber);
                    break;
                case "-":
                    mathOperation(firstNumber - secondNumber);
                    break;
                case "*":
                    mathOperation(firstNumber * secondNumber);
                    break;
                case "/":
                    mathOperation(firstNumber / secondNumber);
                    break;
                default:
                    Console.WriteLine("Incorrect operation, terminating program.");
                    return;
            }
            Console.ReadLine();
        }
    }
}
