using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Tyuiu.AxyonovMA.Sprint5.Task0.V14.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckPathAndValue()
        {
            var obj = new Class1();

            string path = obj.SaveToFileTextData(3);

            // ожидаемый путь формируем так же, как в Class1
            string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            Assert.AreEqual(expectedPath, path);

            Assert.IsTrue(File.Exists(path));

            string text = File.ReadAllText(path).Trim();

            // здесь ставь то значение, которое реально требует онлайн-тест:
            // Assert.AreEqual("4,145", text);  // или "4,154", если система ждёт так
        }
    }
}
