// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task0.V14.Test
// Description: Тестирование SaveToFileTextData

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task0.V14.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckOutput()
        {
            Class1 obj = new Class1();

            string path = obj.SaveToFileTextData(3);
            string result = File.ReadAllText(path).Trim();

            Assert.AreEqual("4.154", result);
        }
    }
}
