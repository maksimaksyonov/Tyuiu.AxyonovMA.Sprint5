// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint5.Task2.V23.Lib
// Description: Замена нечётных элементов матрицы на 0 и сохранение в CSV-файл

using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AxyonovMA.Sprint5.Task2.V23.Lib
{
    // Подключаем интерфейс соответствующего варианта
    public class Class1 : ISprint5Task2V23
    {
        // Метод принимает матрицу 3x3 и возвращает путь к созданному файлу
        public string SaveToFileTextData(int[,] matrix)
        {
            // временная директория ОС
            string dir = Path.GetTempPath();
            string filePath = Path.Combine(dir, "OutPutFileTask2.csv");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int value = matrix[i, j];

                        // замена нечётных на 0
                        if (value % 2 != 0)
                        {
                            value = 0;
                        }

                        writer.Write(value);

                        // между элементами ставим ;, в конце строки — перевод
                        if (j < cols - 1)
                        {
                            writer.Write(";");
                        }
                    }

                    if (i < rows - 1)
                    {
                        writer.WriteLine();
                    }
                }
            }

            return filePath;
        }
    }
}
