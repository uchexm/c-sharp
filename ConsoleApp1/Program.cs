using System.Formats.Asn1;

namespace Exercise {
    class Program{
        static void Main(string[] args)
        {

            // Console.WriteLine("Enter a word you want to repeat: ");
            // string word = Console.ReadLine();

            // Console.WriteLine("Enter the number of times you want to repeat the word: ");
            // int times = Convert.ToInt32(Console.ReadLine());

            
            //     if (times == 0) {
            //         Console.WriteLine("Invalid number of times please enter a number more than 0");
            //     } else {
            //         for (int i = 0; i <times; ++i){
            //             Console.WriteLine(word);
            //         }
            //     }

            Console.WriteLine("Welcome to the multiplication game BOOM BOOM!!!");
            Console.WriteLine("Choose your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int answer = num1 * num2;

            Console.WriteLine("What is the value of " + num1 + " X " + num2 + " ? ");
            Console.WriteLine("Enter Your Answer: ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            while (userAnswer != answer)
            {   
                Console.WriteLine("Enter Your Answer: ");
               
                userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer!= answer)
                {
                    Console.WriteLine("Sorry, that's not correct. Try again.");
                    System.Console.WriteLine();
                }
            } Console.WriteLine("Yay! you got it the answer is: " + "(" + answer +")");


            












            // Console.Write("Enter the number of the weekday: ");
            // int day = Convert.ToInt32(Console.ReadLine());
            // switch (day)
            // {
            //     case 1:
            //         Console.WriteLine("Monday");
            //         break;
            //     case 2:
            //         Console.WriteLine("Tuesday");
            //         break;
            //     case 3:
            //         Console.WriteLine("Wednesday");
            //         break;
            //     case 4:
            //         Console.WriteLine("Thursday");
            //         break;
            //     case 5:
            //         Console.WriteLine("Friday");
            //         break;
            //     case 6:
            //         Console.WriteLine("Saturday");
            //         break;
            //     case 7:
            //         Console.WriteLine("Sunday");
            //         break;
            //     default:
            //         Console.WriteLine("Invalid day you must enter a number between 1 and 7");
            //         break;
            // }


 

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