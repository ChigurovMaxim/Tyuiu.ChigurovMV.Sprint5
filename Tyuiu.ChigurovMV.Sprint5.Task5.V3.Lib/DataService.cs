using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;

namespace Tyuiu.ChigurovMV.Sprint5.Task5.V3.Lib
{
    public class DataService : ISprint5Task5V3
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            NumberFormatInfo info = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ","
            };
            string text = File.ReadAllText(path);
            string[] strings = text.Split(' ');
            foreach (string s in strings)
            {
                if (int.TryParse(s.Trim(), out int number))
                {
                    res += number;
                }
            }
            return res;
        }
    }
}
