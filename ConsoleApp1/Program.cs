﻿using System.Formats.Asn1;

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

            // Console.WriteLine("Welcome to the multiplication game BOOM BOOM!!!");
            // Console.WriteLine("Choose your first number: ");
            // int num1 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Choose your second number: ");
            // int num2 = Convert.ToInt32(Console.ReadLine());

            // int answer = num1 * num2;

            // Console.WriteLine("What is the value of " + num1 + " X " + num2 + " ? ");
            // Console.WriteLine("Enter Your Answer: ");
            // int userAnswer = Convert.ToInt32(Console.ReadLine());

            // while (userAnswer != answer)
            // {   
            //     Console.WriteLine("Enter Your Answer: ");
               
            //     userAnswer = Convert.ToInt32(Console.ReadLine());

            //     if (userAnswer!= answer)
            //     {
            //         Console.WriteLine("Sorry, that's not correct. Try again.");
            //         System.Console.WriteLine();
            //     }
            // } Console.WriteLine("Yay! you got it the answer is: " + "(" + answer +")");

            // bool success = true;

            // while (success)
            // {
            //     Console.WriteLine("Enter a number: ");
            //     string numberInput = Console.ReadLine();

            //     if (int.TryParse(numberInput, out int number))
            //     {
            //         Console.WriteLine("You entered a number: " + number);
            //         success = false;
            //     }
            //     else
            //     {
            //         Console.WriteLine("You entered an invalid number Please try again.");
            //     }

                
            // }
            // Console.ReadLine();
            //Console.WriteLine("Welcome to the number table BOOM BOOM!!!");

            // Console.WriteLine("Enter a number for our table: ");
            // int userNumber = Convert.ToInt32(Console.ReadLine());

            // for (int i = 1; i <= 9; i++)
            // {
            //     Console.WriteLine("{0} x {1} = {2}", i, userNumber, i * userNumber);
            // }

            //Console.WriteLine("Welcome to FizzBuzz!");

            // for (int i = 1; i <= 15; ++i) {
            //    if (3 % i == 0 && 5 % i == 0){
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else if (3 % i == 0){
            //      Console.WriteLine("Fizz");
            //     }
            //     else if (5 % i == 0){
            //       Console.WriteLine("Buzz");
            //     }
            //     else{
            //        Console.WriteLine(i);

            //     }
            // }
            //bool divideByThree = false;
            //bool divideByFive = false;
         
            //  for (int i = 1; i <= 25; ++i){

            //    bool divideByThree = i % 3 == 0;
            //    bool  divideByFive = i % 5 == 0;

            //     if (divideByThree && divideByFive)
            //     {
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else if (divideByThree)
            //     {
            //         Console.WriteLine("Fizz");
            //     }
            //     else if (divideByFive)
            //     {
            //         Console.WriteLine("Buzz");
            //     }
            //     else
            //     {
            //         Console.WriteLine(i);
            //     }
            //  }

            // Console.Write("Enter a message: ");
            // string message = Console.ReadLine();

            // if (message != null){
            //     for (int i = 0; i < message.Length; i++){
            //       Console.WriteLine(message[i]);
            //       }
            //     for (int i = message.Length - 1; i >= 0; i--){
            //       Console.WriteLine(message[i]);
            //     }
            

            // }
            // Dictionary<string, string> user = new Dictionary<string, string>
            // {
            //     {"username", "admin"},
            //     {"password", "password"}
            // };
            // List<int> evenNumbers = new List<int>();

            // List<int> oddNumbers = new List<int>();

            // for (int i = 1; i <= 40; i++){
            //     if (i % 2 == 0){
            //         evenNumbers.Add(i);
            //        // Console.WriteLine("Even numbers" + i);
            //     }
            //     else{
            //         oddNumbers.Add(i);
            //         //Console.WriteLine("Odd numbers" + i);
            //     }
            // }
            // Console.Write("This is Even numbers: ");
            // foreach (int evenNumber in evenNumbers){
            //     Console.Write(evenNumber + " ");
            // }

            // Console.Write("\nThis is Odd numbers: ");
            // foreach (int oddNumber in oddNumbers){
            //     Console.Write(oddNumber + " ");
            // }
            // Console.Write($"This is Even numbers: {evenNumbers} \n This is Odd numbers: {oddNumbers}");






            // Console.WriteLine("Enter your password: ");
            // string password = Console.ReadLine();

            // Console.WriteLine("Enter your password again: ");
            // string password2 = Console.ReadLine();

            // if (!password.Equals(string.Empty) && !password2.Equals(string.Empty) ){
            //     if (password == password2){
            //         Console.WriteLine("Password Matched!");
            //     }
            //     else{
            //         Console.WriteLine("Password did not match!");
            //     }
            // }
            // else{
            //     Console.WriteLine("Please enter password");
            // }


        Console.WriteLine("Enter the Width of the rectangle: ");
        int width  = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Height of the rectangle: ");    
        int height = Convert.ToInt32(Console.ReadLine());

        CalculateArea(width, height);
    }

    static void CalculateArea(int width, int height){
        int area = width * height;
        Console.WriteLine("The area of the rectangle is: " + area);
    }














    //         Console.WriteLine("Enter your password again: ");
    //         string password = Console.ReadLine();

    //         Console.WriteLine("Enter your password again: ");
    //         string password2 = Console.ReadLine();

    //         if (!password.Equals(string.Empty)){
    //             if (!password2.Equals(string.Empty)){
    //                 if (password.Length >= 8 && password2.Length >= 8){
    //                     if (password == password2){
    //                     Console.WriteLine("Password Matched!");
    //                 }
    //                 else{
    //                     Console.WriteLine("Password did not match!");
    //                 }
                    
    //             }
    //             else{
    //                 Console.WriteLine("Password must be at least 8 characters long");
    //             }
    //         }
    //         else{
    //             Console.WriteLine("Please enter password");
            

    // // }

    // List<string> names = new List<string>();
    // Console.WriteLine("Enter a name: ");
    // names.Add(Console.ReadLine());
    // for (int i = 0; i < names.Count; i++){
    //    Console.WriteLine(names[i]);
    // }




    //          int[] numbers = new int[4];

    //          for (int i = 0; i < numbers.Length; i++){
    //              Console.WriteLine("Enter a number: ");
    //              numbers[i] = Convert.ToInt32(Console.ReadLine());
    //          }
             

    //          for (int i = 0; i < numbers.Length; i++){
                
    //             Console.WriteLine(numbers[i]);
    //          }

            //  Console.WriteLine("Enter a number: ");
            //  numbers[0] = Convert.ToInt32(Console.ReadLine());

            //  Console.WriteLine("Enter a number: ");
            //  numbers[1] = Convert.ToInt32(Console.ReadLine());

            //  Console.WriteLine("Enter a number: ");
            //  numbers[2] = Convert.ToInt32(Console.ReadLine());

            //  Console.WriteLine("Enter a number: ");
            //  numbers[3] = Convert.ToInt32(Console.ReadLine());


            //  Console.WriteLine("The numbers you entered are: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2] + ", " + numbers[3]);

                // numbers[0] = 10;
                // numbers[1] = 20;
                // numbers[2] = 30;
                // numbers[3] = 40;
                // numbers[4] = 50;

                // for (int i = 0; i < numbers.Length; ++i){
                //     Console.WriteLine(numbers[i]);  
                // }
            




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

            

        //MultiplicationTable();
        //WelcomeMessage();
        // Calculator();

        

        //}



        //  static void WelcomeMessage(){
        //     Console.WriteLine("Welcome to my Application!!!");
            
        // }
      
        }
    };

        // static void Calculator(){
        //     Console.WriteLine("This is a Calculator!!!");
        //     Console.WriteLine("Please choose an operation to perform:");
        //     Console.WriteLine("Press (1) for Addition");
        //     Console.WriteLine("Press (2) for Subtraction");
        //     Console.WriteLine("Press (3) for Multiplication");
        //     Console.WriteLine("Press (4) for Division");
        //     Console.WriteLine("Press (5) for Exit");

        //     int choice = Convert.ToInt32(Console.ReadLine());
        //     switch (choice)
        //     {
        //     case 1:
        //         PerformOperation("add", Add);
        //         break;
        //     case 2:
        //         PerformOperation("subtract", Subtract);
        //         break;
        //     case 3:
        //         PerformOperation("multiply", Multiply);
        //         break;
        //     case 4:
        //         PerformOperation("divide", Divide);
        //         break;
        //     case 5:
        //         Console.WriteLine("Goodbye!!!");
        //         break;
        //     default:
        //         Console.WriteLine("Invalid choice");
        //         break;
        //     }
        // }

        // static void PerformOperation(string operation, Func<int, int, int> func)
        // {
        //     Console.Write($"Enter the first number to {operation}: ");
        //     int arg1 = Convert.ToInt32(Console.ReadLine());

        //     Console.Write($"Enter the second number to {operation}: ");
        //     int arg2 = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine($"The result of {operation}ing {arg1} and {arg2} is: " + func(arg1, arg2));
        // }

        // static int Add(int a, int b){
        //     return a + b;
        // }

        // static int Subtract(int a, int b){
        //     return a - b;
        // }
        // static int Multiply(int a, int b){
        //     return a * b;
        // }
        // static int Divide(int a, int b){
        //     return a / b;
        // }








        // static public void MultiplicationTable(){
        //     int num = 7;
        //     int length = 5;

        //     int[] result = new int[length];
        //     int counter = 0;

        //     for (int i = 1; i <= result.Length; i++)
        //     {
        //         result[counter] = i * num;
        //         counter++;
        //        // Console.WriteLine(numbers[i]);
        //     }
        //     foreach (int number in result)
        //     {
        //         Console.WriteLine(number);
        //     }
        // }

       