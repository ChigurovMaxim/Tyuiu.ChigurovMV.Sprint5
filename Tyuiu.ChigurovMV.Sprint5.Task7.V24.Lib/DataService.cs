﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.ChigurovMV.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V24.txt" });
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists)
            {
                File.Delete(pathSaveFile);
            }
            string str = File.ReadAllText(path);
            string pattern = @"\b([а-яА-ЯёЁ]+)\b";
            string result = Regex.Replace(str, pattern, "слово");
            File.WriteAllText(pathSaveFile, result);
            return pathSaveFile;
        }
    }
}
