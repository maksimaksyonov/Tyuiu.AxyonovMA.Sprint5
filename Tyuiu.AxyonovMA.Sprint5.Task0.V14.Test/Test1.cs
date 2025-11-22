// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task0.V14.Test
// Description: Проверка пути и содержимого OutPutFileTask0.txt

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task0.V14.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckPathAndValue()
        {
            Class1 obj = new Class1();

            string path = obj.SaveToFileTextData(3);

            // ожидаемый путь (если ты пользуешься жёстким путём)
            string expectedPath = @"C:\Users\maxi\source\repos\Tyuiu.AxyonovMA.Sprint5\Tyuiu.AxyonovMA.Sprint5.Task0.V14\bin\OutPutFileTask0.txt";
            Assert.AreEqual(expectedPath, path, "Путь к файлу не совпадает с ожидаемым.");

            Assert.IsTrue(File.Exists(path), "Файл OutPutFileTask0.txt не найден по указанному пути.");

            string text = File.ReadAllText(path).Trim();

            // здесь ставь то значение, которое пишет онлайн-тест (у тебя это 4,145)
            Assert.AreEqual("4,145", text, "Неверное значение, записанное в файл.");
        }
    }
}
