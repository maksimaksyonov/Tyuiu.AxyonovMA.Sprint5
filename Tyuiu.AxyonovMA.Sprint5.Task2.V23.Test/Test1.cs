// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task2.V23.Test
// Description: Тест сохранения матрицы в OutPutFileTask2.csv

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task2.V23.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task2.V23.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckCsvContent()
        {
            int[,] src =
            {
                { 7, 2, 8 },
                { 6, 9, 1 },
                { 2, 3, 5 }
            };

            Class1 obj = new Class1();
            string path = obj.SaveToFileTextData(src);

            Assert.IsTrue(File.Exists(path), "Файл не создан.");

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(3, lines.Length);
            Assert.AreEqual("0;2;8", lines[0]);
            Assert.AreEqual("6;0;0", lines[1]);
            Assert.AreEqual("2;0;0", lines[2]);
        }
    }
}
