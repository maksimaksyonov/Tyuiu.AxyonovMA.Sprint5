// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task6.V3
// Description: Чтение файла и подсчёт количества латинских букв (Вариант 3)

using System;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task6.V3.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Обработка текстовых файлов | Задание #6 | Вариант #3";

            // В онлайне файл обычно кладут во временную папку
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutDataFileTask6V3.txt");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5 | Обработка текстовых файлов | Задание #6 | Вариант #3        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Ожидаемый входной файл: " + path);

            if (!File.Exists(path))
            {
                Console.WriteLine("\nФайл не найден. Скопируйте InPutDataFileTask6V3.txt в каталог:");
                Console.WriteLine(dir);
                Console.ReadKey();
                return;
            }

            Class1 obj = new Class1();
            int countLatin = obj.LoadFromDataFile(path);

            Console.WriteLine("\nКоличество латинских букв в файле: " + countLatin);
            Console.ReadKey();
        }
    }
}
