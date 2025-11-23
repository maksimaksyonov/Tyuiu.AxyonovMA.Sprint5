// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task5.V13.Test
// Description: Тест метода LoadFromDataFile (Вариант 13)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task5.V13.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task5.V13.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckAverageInRange()
        {
            // создаём временный файл
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutDataFileTask5V13_Test.txt");

            // числа: в диапазоне [-1.5;1.5] и вне его
            // возьмём: -2  -1  0.5  1.5  3
            // в диапазоне: -1, 0.5, 1.5 -> среднее = ( -1 + 0.5 + 1.5 ) / 3 = 0.333333...
            File.WriteAllText(path, "-2 -1 0,5 1,5 3");

            Class1 obj = new Class1();
            double actual = obj.LoadFromDataFile(path);

            double expected = (-1 + 0.5 + 1.5) / 3.0;
            expected = Math.Round(expected, 3); // 0.333

            Assert.AreEqual(expected, actual, 1e-6, "Среднее значение посчитано неверно.");
        }
    }
}
