using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReader
{
    public class ConsoleReader
    {
        public static int SumOfNumbers(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {  
            int number1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter random number: ");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second random number: ");
            int number3 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third random number: ");
            int result = (number1 + number2 + number3);
            Console.WriteLine($"Sum of the tree numbers is {result}");
        }
    }
}
