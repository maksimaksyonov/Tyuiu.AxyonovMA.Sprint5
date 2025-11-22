// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task3.V12
// Description: Чтение значения из бинарного файла и вывод на консоль

using System;
using System.Globalization;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task3.V12.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Потоковая запись в бинарный файл | Задание #3 | Вариант #12";

            int x = 3;
            Class1 obj = new Class1();
            string path = obj.SaveToFileTextData(x);

            double value;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                value = br.ReadDouble();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5 | Потоковый метод записи в бинарный файл | Задание #3 | Вариант #12 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = " + x);

            // форматируем вывод с запятой и 3 знаками
            string yStr = Math.Round(value, 3).ToString("F3", new CultureInfo("ru-RU"));
            Console.WriteLine("y = " + yStr);

            Console.WriteLine("Файл: " + path);
            Console.ReadKey();
        }
    }
}
