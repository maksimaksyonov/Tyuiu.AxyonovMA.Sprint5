// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task0.V14.Lib
// Description: Вычисление y(x) и запись результата в файл OutPutFileTask0.txt

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
            // вычисляем y(x) по формуле из задания
            double x3 = Math.Pow(x, 3);
            double denom = x3 - 1.0;
            double y = (denom == 0) ? 0.0 : (4.0 * x3) / denom;

            // округляем до 3 знаков
            double yRound = Math.Round(y, 3);

            // твоя папка bin (как ты просил раньше)
            string binDir = @"C:\Users\maxi\source\repos\Tyuiu.AxyonovMA.Sprint5\Tyuiu.AxyonovMA.Sprint5.Task0.V14\bin";

            if (!Directory.Exists(binDir))
            {
                Directory.CreateDirectory(binDir);
            }

            string filePath = Path.Combine(binDir, "OutPutFileTask0.txt");

            // ВАЖНО: используем ru-RU, чтобы была запятая: 4,145
            File.WriteAllText(filePath, yRound.ToString("F3", new CultureInfo("ru-RU")));

            return filePath;
        }
    }
}
