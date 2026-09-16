using System;
using System.Globalization;
using System.Linq;

namespace Task1
{
    // Допоміжний статичний клас для операцій з одновимірним масивом
    public static class ArrayHelper
    {
        // Метод пошуку мінімального елемента масиву за допомогою методу розширення LINQ
        public static double GetMinimum(double[] array)
        {
            return array.Min();
        }

        // Метод обчислення суми елементів між першим і останнім додатними елементами
        public static double GetSumBetweenPositives(double[] array)
        {
            // Пошук індексу першого додатного елемента засобами класу System.Array
            int firstIndex = Array.FindIndex(array, x => x > 0);
            // Пошук індексу останнього додатного елемента засобами класу System.Array
            int lastIndex = Array.FindLastIndex(array, x => x > 0);

            // Якщо додатних елементів менше двох або між ними немає елементів, повертається 0
            if (firstIndex == -1 || lastIndex == -1 || lastIndex <= firstIndex + 1)
            {
                return 0;
            }

            // Обчислення суми проміжних елементів у звичайному циклі
            double sum = 0;
            for (int i = firstIndex + 1; i < lastIndex; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        // Метод перетворення масиву: переміщення нулів у початок масиву зі збереженням порядку інших елементів
        public static double[] MoveZerosToFront(double[] array)
        {
            // Використання методу розширення OrderBy простору імен System.Linq
            return array.OrderBy(x => x == 0 ? 0 : 1).ToArray();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введіть розмір масиву n: ");
            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"array[{i}] = ");
                array[i] = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("\nПочатковий масив: " + string.Join(", ", array));

            double min = ArrayHelper.GetMinimum(array);
            Console.WriteLine($"Мінімальний елемент: {min}");

            double sum = ArrayHelper.GetSumBetweenPositives(array);
            Console.WriteLine($"Сума елементів між першим і останнім додатними: {sum}");

            double[] transformed = ArrayHelper.MoveZerosToFront(array);
            Console.WriteLine("Перетворений масив: " + string.Join(", ", transformed));
        }
    }
}
