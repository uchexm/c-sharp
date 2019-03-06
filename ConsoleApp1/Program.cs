namespace Exercise {
    class Program{
        static void Main(string[] args)
        {
            Console.Write("Enter the number of the weekday: ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day you must enter a number between 1 and 7");
                    break;
            }


 

            // Console.Write("Enter the first number: ");

            // int firstNumber = Convert.ToInt32(Console.ReadLine());


            // Console.Write("Enter the second number: ");

            // int secondNumber = Convert.ToInt32(Console.ReadLine());

            // int answer = firstNumber * secondNumber;

            // Console.WriteLine("Value of " + firstNumber + " X " + secondNumber + " : " );
            // string answerString = Console.ReadLine();

            // int actualValue = Convert.ToInt32(answerString);

            // if (actualValue == answer)
            // {
            //     Console.WriteLine("Correct!");
            // }
            // else
            // {
            //     Console.WriteLine("Incorrect!");
            // }




            // int sum = firstNumber + secondNumber;
            // Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sum}");

            // int multiply = firstNumber * secondNumber;
            // Console.WriteLine($"The multiple of {firstNumber} and {secondNumber} is {multiply}");

            // int difference = firstNumber - secondNumber;
            // Console.WriteLine($"The difference of {firstNumber} and {secondNumber} is {difference}");

        }
    }
}