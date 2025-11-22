// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task4.V21.Test
// Description: Тест чтения числа из файла и вычисления по формуле (Вариант 21)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task4.V21.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task4.V21.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void LoadFromDataFile_CorrectValue()
        {
            // 1. создаём временный файл с тестовым значением x
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutDataFileTask4V0_Test.txt");

            // запишем x = 1,5 (русская запись с запятой)
            File.WriteAllText(path, "1,5");

            // 2. вызываем метод библиотеки
            Class1 obj = new Class1();
            double actual = obj.LoadFromDataFile(path);

            // 3. сами считаем ожидаемое значение по формуле:
            //    y = x^3 * cos(x) + 2x, округлённое до 3 знаков
            double x = 1.5;
            double expected = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;
            expected = Math.Round(expected, 3);   // → 3.239

            // 4. сравниваем (лучше с маленькой дельтой на всякий случай)
            Assert.AreEqual(expected, actual, 1e-6,
                "Значение, вычисленное методом LoadFromDataFile, неверно.");
        }
    }
}
