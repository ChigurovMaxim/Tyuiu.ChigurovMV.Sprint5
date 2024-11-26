using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;
namespace Tyuiu.ChigurovMV.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {      
            string strX = File.ReadAllText(path);
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
            };

            double x = double.Parse(strX, numberFormatInfo);
            double res = Math.Round(((Math.Pow(x, 4) + Math.Cos(x)) * Math.Sin(x)), 3);
            return res;
        }
    }
}
