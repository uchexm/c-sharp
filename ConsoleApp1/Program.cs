﻿namespace Exercise {
    class Program{
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");

            int firstNumber = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the second number: ");

            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sum}");

            int multiply = firstNumber * secondNumber;
            Console.WriteLine($"The multiple of {firstNumber} and {secondNumber} is {multiply}");

            int difference = firstNumber - secondNumber;
            Console.WriteLine($"The difference of {firstNumber} and {secondNumber} is {difference}");

        }
    }
}