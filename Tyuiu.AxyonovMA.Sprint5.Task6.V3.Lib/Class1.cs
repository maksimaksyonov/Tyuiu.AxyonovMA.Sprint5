// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task6.V3.Lib
// Description: Подсчёт количества латинских букв в текстовом файле (Вариант 3)

using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AxyonovMA.Sprint5.Task6.V3.Lib
{
    public class Class1 : ISprint5Task6V3
    {
        // path – полный путь к входному файлу
        // возвращает количество латинских букв в файле
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            int count = 0;

            foreach (char c in text)
            {
                bool isLatinUpper = (c >= 'A' && c <= 'Z');
                bool isLatinLower = (c >= 'a' && c <= 'z');

                if (isLatinUpper || isLatinLower)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
