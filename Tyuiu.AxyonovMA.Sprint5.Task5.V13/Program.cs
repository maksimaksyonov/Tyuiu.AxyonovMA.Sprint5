// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task5.V13
// Description: Чтение набора чисел из файла и вывод среднего значения

using System;
using System.Globalization;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task5.V13.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Чтение набора данных | Задание #5 | Вариант #13";

            // путь к файлу (в онлайне тест положит его туда же)
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutDataFileTask5V13.txt");

            Class1 obj = new Class1();
            double avg = obj.LoadFromDataFile(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5 | Чтение набора данных из текстового файла | Задание #5 | Вариант #13 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Среднее значение чисел в диапазоне [-1.5; 1.5]: " +
                              avg.ToString("F3", new CultureInfo("ru-RU")));
            Console.ReadKey();
        }
    }
}
