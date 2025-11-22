// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task1.V13.Lib
// Description: Табулирование функции F(x) и запись набора данных в файл (Вариант 13)

using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AxyonovMA.Sprint5.Task1.V13.Lib
{
    public class Class1 : ISprint5Task1V13
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempDir = Path.GetTempPath();
            string filePath = Path.Combine(tempDir, "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denom = Math.Cos(x) + x;

                    double y = denom == 0
                        ? 0
                        : ((2 * x - 3) / denom) + 5;

                    double yRound = Math.Round(y, 2);

                    // округление до 2 знаков, русская культура (запятая)
                    string yStr = yRound.ToString(new CultureInfo("ru-RU"));

                    writer.WriteLine(yStr);
                }
            }

            return filePath;
        }
    }
}
