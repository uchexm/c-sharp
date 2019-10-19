using System.Formats.Asn1;

namespace Exercise {
    class Program{
        static void Main(string[] args){
            int width = ReadInt("Enter the width: ");
            int height = ReadInt("Enter the height: ");

            int result = CalculateArea(width, height);
            Console.WriteLine($"The area is: {result}");

       }
        static int CalculateArea(int width, int height){
            return (width * height) / 2;
        }

        static int ReadInt(string message){
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    
    
    }

};


       