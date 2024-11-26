using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
namespace Tyuiu.ChigurovMV.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string str = File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask6V6.txt");
            string result = "";

            foreach (char c in str)
            {
                if (char.IsLower(c) && (Regex.IsMatch(Convert.ToString(c), @"\p{IsCyrillic}")))
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
