// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task3.V12.Test
// Description: Тест бинарной записи (Вариант 12)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task3.V12.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task3.V12.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckBinaryFile()
        {
            Class1 obj = new Class1();
            string path = obj.SaveToFileTextData(3);

            Assert.IsTrue(File.Exists(path), "Бинарный файл не создан.");

            double value;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                value = br.ReadDouble();
            }

            // ожидаемое значение 0.211 (допускаем маленькую погрешность double)
            double expected = 0.211;
            Assert.IsTrue(Math.Abs(value - expected) < 1e-6, "Неверное значение в бинарном файле.");
        }
    }
}
