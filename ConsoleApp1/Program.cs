using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x7 = -2;
            double result7 = 3 * Math.Pow(x7,3) + 4 * Math.Pow(x7,2) - 2 * x7 + 7;
            Console.WriteLine(result7);
        }
    }
}
