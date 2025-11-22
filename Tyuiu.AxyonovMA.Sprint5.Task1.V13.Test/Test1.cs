// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task1.V13.Test

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task1.V13.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task1.V13.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckFileExistsAndCorrectCount()
        {
            Class1 obj = new Class1();

            string path = obj.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(path), "Файл не создан!");

            string[] lines = File.ReadAllLines(path);

            // должно быть 11 строк (от -5 до 5 включительно)
            Assert.AreEqual(11, lines.Length);

            // можно добавить проверку формата:
            foreach (var s in lines)
                Assert.IsTrue(s.Contains(","), "Формат должен быть с запятой (ru-RU).");
        }
    }
}
