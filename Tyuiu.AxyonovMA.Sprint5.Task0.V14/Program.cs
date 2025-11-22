// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task0.V14
// Description: Запись результата функции в файл (Вариант 14)

using System;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task0.V14.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";

            Class1 obj = new Class1();
            int x = 3;

            string path = obj.SaveToFileTextData(x);
            string value = File.ReadAllText(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5 | Класс File | Задание #0 | Вариант #14                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"Результат: {value}");
            Console.WriteLine($"Файл сохранён по пути: {path}");
            Console.ReadKey();
        }
    }
}
