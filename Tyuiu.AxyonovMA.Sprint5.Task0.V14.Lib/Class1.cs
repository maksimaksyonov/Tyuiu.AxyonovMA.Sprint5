// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task0.V14.Lib

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
            // формула y(x) (оставляем, как договорились)
            double x3 = Math.Pow(x, 3);
            double denom = x3 - 1.0;
            double y = (denom == 0) ? 0.0 : (4.0 * x3) / denom;

            // округление до 3 знаков
            double yRound = Math.Round(y, 3);

            // 👇 универсальный путь: временная папка ОС
            string dir = Path.GetTempPath();                    // напр. C:\Users\...\AppData\Local\Temp или /tmp
            string fileName = "OutPutFileTask0.txt";
            string filePath = Path.Combine(dir, fileName);

            // записываем с запятой (ru-RU), чтобы онлайн-тест читал "4,145"/"4,154" как строку
            File.WriteAllText(filePath, yRound.ToString("F3", new CultureInfo("ru-RU")));

            return filePath;
        }
    }
}
