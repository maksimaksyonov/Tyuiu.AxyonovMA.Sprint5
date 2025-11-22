// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task3.V12.Lib
// Description: Вычисление y(x) и запись результата в бинарный файл (Вариант 12)

using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AxyonovMA.Sprint5.Task3.V12.Lib
{
    public class Class1 : ISprint5Task3V12
    {
        // x задаётся извне (в онлайне передадут 3)
        public string SaveToFileTextData(int x)
        {
            // y = x^3 / (2 (x + 5)^2)
            double y = Math.Pow(x, 3) / (2 * Math.Pow(x + 5, 2));

            // округление до трёх знаков
            double yRound = Math.Round(y, 3); // для x=3 -> 0.211

            // временная директория и имя бинарного файла
            string dir = Path.GetTempPath();
            string filePath = Path.Combine(dir, "OutPutFileTask3.bin");

            // потоковая запись в бинарный файл
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(yRound); // пишем double в бинарном виде
            }

            // возвращаем путь — его будет использовать тест/онлайн-проверка
            return filePath;
        }
    }
}
