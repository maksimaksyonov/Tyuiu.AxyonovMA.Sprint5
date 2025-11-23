// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task7.V3
// Description: Удаление русских букв из файла и вывод результата

using System;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task7.V3.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Задание 7 | Вариант 3 | Аксёнов М.А.";

            // В онлайне обычно файл заранее кладут в temp:
            string dir = Path.GetTempPath();
            string pathIn = Path.Combine(dir, "InPutDataFileTask7V3.txt");

            Class1 obj = new Class1();
            string pathOut = obj.LoadDataAndSave(pathIn);

            Console.WriteLine("Входной файл:  " + pathIn);
            Console.WriteLine("Выходной файл: " + pathOut);
            Console.WriteLine("\nСодержимое выходного файла:\n");
            Console.WriteLine(File.ReadAllText(pathOut));

            Console.ReadKey();
        }
    }
}
