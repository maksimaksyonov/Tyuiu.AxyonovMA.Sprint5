// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task1.V13
// Description: Вывод таблицы F(x) и запись в файл

using System;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task1.V13.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task1.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sprint #5 | Task1 | Variant 13 | Axyonov M.A.";

            Class1 obj = new Class1();
            string filePath = obj.SaveToFileTextData(-5, 5);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* Спринт 5 | Task 1 | Вариант 13                   *");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"Файл записан: {filePath}\n");

            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("  x     F(x)");
            Console.WriteLine("---------------");

            int x = -5;
            foreach (var line in lines)
            {
                Console.WriteLine($"{x,3} → {line}");
                x++;
            }

            Console.ReadKey();
        }
    }
}
