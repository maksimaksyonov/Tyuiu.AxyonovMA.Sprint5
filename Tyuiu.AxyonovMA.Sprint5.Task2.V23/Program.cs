// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task2.V23
// Description: Ввод матрицы, вызов библиотеки, вывод результата и пути к файлу

using System;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task2.V23.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Задание 2 | Вариант 23 | Аксёнов М.А.";

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите элементы матрицы 3x3 (значения от 2 до 9):");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i + 1},{j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Class1 obj = new Class1();
            string path = obj.SaveToFileTextData(matrix);

            Console.WriteLine("\nРезультирующая матрица (нечётные заменены на 0) из файла:");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line.Replace(";", " "));
            }

            Console.WriteLine($"\nДанные сохранены в файл: {path}");
            Console.ReadKey();
        }
    }
}
