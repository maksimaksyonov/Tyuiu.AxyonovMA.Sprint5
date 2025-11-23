// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task7.V3.Lib
// Description: Удаление всех русских букв из файла и сохранение результата (Вариант 3)

using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AxyonovMA.Sprint5.Task7.V3.Lib
{
    public class Class1 : ISprint5Task7V3   // имя интерфейса возьми из DLL
    {
        // Сигнатуру подгони под интерфейс из DLL.
        // Например: public string LoadDataAndSaveToFile(string path)
        public string LoadDataAndSave(string pathIn)
        {
            // читаем весь входной текст
            string inputText = File.ReadAllText(pathIn, Encoding.UTF8);

            StringBuilder sb = new StringBuilder();

            foreach (char c in inputText)
            {
                bool isRusUpper = (c >= 'А' && c <= 'Я') || c == 'Ё';
                bool isRusLower = (c >= 'а' && c <= 'я') || c == 'ё';

                if (!isRusUpper && !isRusLower)
                {
                    sb.Append(c);   // оставляем все, что НЕ русские буквы
                }
            }

            string resultText = sb.ToString();

            // формируем путь к выходному файлу во временной директории
            string dir = Path.GetTempPath();
            string pathOut = Path.Combine(dir, "OutPutDataFileTask7V3.txt");

            File.WriteAllText(pathOut, resultText, Encoding.UTF8);

            // возвращаем путь к выходному файлу — это будет проверять онлайн-тест
            return pathOut;
        }
    }
}
