namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputFile = "OutPutFiIeTask0.txt";
            double x10 = 5;
            double result10 = Math.Pow(x10, 4) - 4 * Math.Pow(x10,3) + 6 * Math.Pow(x10,2) - 8 * x10 + 10;
            File.AppendAllText(outputFile, result10.ToString());
        }
    }
}
