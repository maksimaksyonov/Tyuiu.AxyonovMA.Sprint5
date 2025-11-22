using System;
using System.Globalization;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task4.V21.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Чтение данных из текстового файла | Задание #4 | Вариант #21";

            // допустим, тест/препод заранее скопировали InPutDataFileTask4V0.txt в temp
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutDataFileTask4V0.txt");

            Class1 obj = new Class1();
            double y = obj.LoadFromDataFile(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5 | Чтение данных из текстового файла | Задание #4 | Вариант #21 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Результат y = " + y.ToString("F3", new CultureInfo("ru-RU")));
            Console.ReadKey();
        }
    }
}
