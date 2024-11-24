using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ChigurovMV.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            double y; string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x)+1 != 0)
                {
                    y = Math.Round(2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1)), 2);
                    strY = Convert.ToString(y);
                }
                else
                {
                    y = 0; strY = "0";
                }
                if (x !=  stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
