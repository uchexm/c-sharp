public class Program
{
    public static int FindMax(int[] numbers)
    {
         if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The array must contain at least one element.");
        }
        
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    public static void Main()
    {
        int[] myNumbers = { -5, -10, -3, -8, -2 };
        int maxNumber = FindMax(myNumbers);
        Console.WriteLine("The maximum number is: " + maxNumber);
    }
}