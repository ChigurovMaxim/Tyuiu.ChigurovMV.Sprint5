using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = "SDNsSA2KgDNJ5ShAJN3DNA6SJ";
            string newContent = "";
            foreach (char c in content)
            {
                if (!char.IsUpper(c))
                {
                    newContent += c;
                }
            }
            Console.WriteLine(newContent);
        }
    }
}
