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
            //Exercise2();
            //Exercise3();
            //Exercise4();
            Exercise5();
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
            switch (operation)
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
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return;
                    }
                    mathOperation(firstNumber / secondNumber);
                    break;
                default:
                    Console.WriteLine("Incorrect operation, terminating program.");
                    return;
            }
            Console.ReadLine();
        }

        static void Exercise3()
        {
            for(int i=1; i<=50; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if( i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        static void Exercise4()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine().ToLower();
            string newWord = "";
            for (int i=word.Length - 1; i >= 0; i--)
            {
                newWord += word[i];
            }
            bool isEqualString = String.Compare( word, newWord ) == 0;
            Console.WriteLine($"Is palindrome? {isEqualString}");
            Console.ReadLine();
        }

        static void Exercise5()
        {
            Console.Write("Enter a number: ");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            int numberSqroot = (int)Math.Sqrt(enteredNumber);
            int divisors = 0;
            for (int i = enteredNumber; i >= numberSqroot; i--)
            {
                int result = enteredNumber % i;
                if (result == 0) divisors += 1;
            }
            Console.WriteLine($"Is it prime? {divisors < 2}");
            Console.ReadLine();
        }
    }
}
