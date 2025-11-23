// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task6.V3.Test
// Description: Тест метода LoadFromDataFile (Вариант 3)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task6.V3.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task6.V3.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Count_Latin_Letters_Correctly()
        {
            // 1. создаём временный входной файл
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutDataFileTask6V3_Test.txt");

            // Строка: латиница + кириллица + цифры
            // Латинские буквы: "Hello" (5) + "abc" (3) + "XYZ" (3) = 11
            string data = "Hello, Привет! abcXYZ123";
            File.WriteAllText(path, data);

            // 2. вызываем метод библиотеки
            Class1 obj = new Class1();
            int actual = obj.LoadFromDataFile(path);

            // 3. проверяем результат
            int expected = 11;
            Assert.AreEqual(expected, actual, "Количество латинских букв посчитано неверно.");
        }
    }
}
