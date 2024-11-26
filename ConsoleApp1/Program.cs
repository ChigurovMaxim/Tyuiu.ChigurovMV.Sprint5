using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 25;
            double res = 10 * Math.Pow(x,0.5) - x;
            Console.WriteLine(res);
        }
    }
}
