// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task0.V14.Lib
// Description: Вычисление y(x) и запись результата в файл (Вариант 14)

using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AxyonovMA.Sprint5.Task0.V14.Lib
{
    public class Class1 : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            double x3 = Math.Pow(x, 3);
            double denom = x3 - 1.0;
            double y = (denom == 0) ? 0.0 : (4.0 * x3) / denom;

            // округление до 3 знаков
            double yRound = Math.Round(y, 3);

            // путь к временной директории
            string dir = Path.GetTempPath();
            string filePath = Path.Combine(dir, "OutPutFileTask0.txt");

            // запись числа формата "4.154"
            File.WriteAllText(filePath, yRound.ToString("F3", CultureInfo.InvariantCulture));

            return filePath;
        }
    }
}
