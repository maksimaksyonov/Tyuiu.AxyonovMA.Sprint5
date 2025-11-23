// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task7.V3.Test
// Description: Тест удаления русских букв из файла (Вариант 3)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using Tyuiu.AxyonovMA.Sprint5.Task7.V3.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task7.V3.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Delete_All_Russian_Letters()
        {
            // 1. создаём временный входной файл
            string dir = Path.GetTempPath();
            string pathIn = Path.Combine(dir, "InPutDataFileTask7V3_Test.txt");

            // Строка: смешанные русские и не русские символы
            // Должно остаться только: "Hello, 123 !"
            string source = "Привет Hello, 123 мир!";

            File.WriteAllText(pathIn, source, Encoding.UTF8);

            // 2. вызываем метод библиотеки
            Class1 obj = new Class1();
            string pathOut = obj.LoadDataAndSave(pathIn);

            // 3. проверяем, что выходной файл существует
            Assert.IsTrue(File.Exists(pathOut), "Файл результата не создан.");

            // 4. читаем результат
            string result = File.ReadAllText(pathOut, Encoding.UTF8);

            string expected = " Hello, 123 !";

            Assert.AreEqual(expected, result, "Русские буквы удалены неверно или затронуты лишние символы.");
        }
    }
}
