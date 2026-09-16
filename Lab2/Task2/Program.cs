using System;

namespace Task2
{
    // Допоміжний статичний клас для операцій з двовимірним масивом
    public static class ArrayHelper
    {
        // Метод заповнення двовимірного масиву випадковими цілими числами
        public static void FillRandom(Array matrix, int rows, int cols, int minVal = -20, int maxVal = 50)
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = random.Next(minVal, maxVal + 1);
                    matrix.SetValue(value, i, j);
                }
            }
        }

        // Метод форматованого виведення матриці на екран
        public static void PrintMatrix(Array matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix.GetValue(i, j),5} ");
                }
                Console.WriteLine();
            }
        }

        // Метод перестановки рядків, симетричних відносно середини масиву (горизонтальної лінії)
        public static void SwapSymmetricRows(Array matrix, int rows, int cols)
        {
            // Прохід до середини масиву (rows / 2) для уникнення повторної перестановки
            for (int i = 0; i < rows / 2; i++)
            {
                int symmetricRow = rows - 1 - i;
                for (int j = 0; j < cols; j++)
                {
                    // Зчитування елемента поточного рядка за допомогою GetValue
                    object temp = matrix.GetValue(i, j);
                    // Запис елемента симетричного рядка на поточну позицію за допомогою SetValue
                    matrix.SetValue(matrix.GetValue(symmetricRow, j), i, j);
                    // Запис збереженого значення у симетричний рядок за допомогою SetValue
                    matrix.SetValue(temp, symmetricRow, j);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введіть кількість рядків (M): ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість стовпців (N): ");
            int cols = int.Parse(Console.ReadLine());

            // Створення екземпляра масиву за допомогою статичного методу Array.CreateInstance
            Array matrix = Array.CreateInstance(typeof(int), rows, cols);

            // Заповнення масиву випадковими числами з використанням класу Random
            ArrayHelper.FillRandom(matrix, rows, cols);

            Console.WriteLine("\nПочаткова матриця:");
            ArrayHelper.PrintMatrix(matrix, rows, cols);

            // Виконання перестановки симетричних рядків
            ArrayHelper.SwapSymmetricRows(matrix, rows, cols);

            Console.WriteLine("\nМатриця після перестановки рядків, симетричних відносно середини:");
            ArrayHelper.PrintMatrix(matrix, rows, cols);
        }
    }
}
