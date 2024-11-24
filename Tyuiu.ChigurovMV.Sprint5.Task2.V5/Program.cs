using Tyuiu.ChigurovMV.Sprint5.Task2.V5.Lib;
namespace Tyuiu.ChigurovMV.Sprint5.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 3; int cols = 3;
            int[,] matrix = { { 9,6,6 },
                              { 8,7,2 },
                              { 1,7,8 } };
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Чигуров М. В. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Чигуров Максим Владиславович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая производит табулирование функции на         *");
            Console.WriteLine("* заданном диапазоне [-5;5] с шагом 1 и сохраняет результат в текстовый   *");
            Console.WriteLine("* файл.                                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
        }
    }
}
