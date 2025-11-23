// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task5.V13.Lib
// Description: Чтение набора данных из файла и вычисление среднего в диапазоне [-1.5; 1.5] (Вариант 13)

using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AxyonovMA.Sprint5.Task5.V13.Lib
{
    public class Class1 : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            // читаем весь текст файла
            string text = File.ReadAllText(path);

            // разбиваем по пробелам, переводам строки, табам
            char[] separators = { ' ', '\n', '\r', '\t', ';', ',' };
            string[] parts = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0.0;
            int count = 0;

            foreach (string p in parts)
            {
                // пробуем парсить с русской культурой (запятая),
                // если не вышло — с invariant (точка)
                double value;
                if (!double.TryParse(p, NumberStyles.Any, new CultureInfo("ru-RU"), out value))
                {
                    if (!double.TryParse(p, NumberStyles.Any, CultureInfo.InvariantCulture, out value))
                    {
                        // если вообще не число — пропускаем
                        continue;
                    }
                }

                // берём только числа в диапазоне [-1.5; 1.5]
                if (value >= -1.5 && value <= 1.5)
                {
                    sum += value;
                    count++;
                }
            }

            if (count == 0)
            {
                // если в диапазоне нет ни одного числа — договоримся вернуть 0
                // (обычно так делают в методичке)
                return 0.0;
            }

            double avg = sum / count;
            avg = Math.Round(avg, 3); // округление до трёх знаков

            return avg;
        }
    }
}
