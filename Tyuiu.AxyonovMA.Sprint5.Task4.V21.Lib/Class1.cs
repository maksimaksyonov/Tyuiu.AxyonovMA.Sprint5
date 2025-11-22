using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AxyonovMA.Sprint5.Task4.V21.Lib
{
    public class Class1 : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            // 1. читаем строку из файла
            string text = File.ReadAllText(path).Trim();

            // 2. парсим вещественное (поддержим и запятую, и точку на всякий случай)
            double x;
            if (!double.TryParse(text, NumberStyles.Any, new CultureInfo("ru-RU"), out x))
            {
                x = double.Parse(text, CultureInfo.InvariantCulture);
            }

            // 3. считаем по формуле y = x^3 * cos(x) + 2x
            double y = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;

            // 4. округляем до 3 знаков
            y = Math.Round(y, 3);

            // 5. возвращаем результат (онлайн-тест будет сравнивать это число)
            return y;
        }
    }
}
