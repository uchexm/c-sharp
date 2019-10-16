using System.Formats.Asn1;

namespace Exercise {
    class Program{
        static void Main(string[] args){
            
        int[] numbers = new int[]{ 4, 2, 6, 1, 3, 5 };
        if (numbers.Length > 0) {
            Console.WriteLine("Sum of the numbers: " + SumOfNumbers(numbers));

        }else{
             Console.Write("The array of numbers is empty");
        }
        
        }
       
     

      static int SumOfNumbers(int[] numbers) {
        if (numbers.Length > 0) {
            int sum = 0;
        foreach (int num in numbers) {
          sum += num;
        }
        return sum;

        }
        return -1;
      }
    
    }

};


       