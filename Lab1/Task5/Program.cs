namespace Task5
{
    class Program
    {
        static void Main()
        {
            Console.Write("A: "); double a = double.Parse(Console.ReadLine());
            Console.Write("B: "); double b = double.Parse(Console.ReadLine());
            Console.Write("C: "); double c = double.Parse(Console.ReadLine());
            int total = 0;
            // Проходимо вздовж сторони A рядками шириною C
            while (a >= c)
            {
                // У кожному рядку викладаємо квадрати вздовж сторони B
                double tempB = b;
                while (tempB >= c)
                {
                    total++;
                    tempB -= c;
                }
                a -= c;
            }
            Console.WriteLine($"Всього квадратів: {total}");
        }
    }
}
