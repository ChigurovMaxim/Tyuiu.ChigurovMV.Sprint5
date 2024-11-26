using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask4V0.txt");
            string[] strings = text.Split(',');
            List<string> oddNumbers = new List<string>();
            foreach (string str in strings)
            {
                if (int.TryParse(str.Trim(), out int number) && number % 3 == 0)
                {
                    oddNumbers.Add(str);
                }

            }
            File.WriteAllLines(@"C:\DataSprint5\InPutDataFileTask4V0.txt", oddNumbers);
            Console.WriteLine(String.Join("\n", oddNumbers));
        }
    }
}
