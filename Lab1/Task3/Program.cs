namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть N: ");
            int n = int.Parse(Console.ReadLine());

            int a1 = 1, a2 = 2, a3 = 3;
            Console.WriteLine($"A1 = {a1}\nA2 = {a2}\nA3 = {a3}");

            // Обчислюємо кожен наступний елемент без масивів
            for (int k = 4; k <= n; k++)
            {
                int ak = a3 + a2 - 2 * a1;
                Console.WriteLine($"A{k} = {ak}");

                // Зсуваємо значення для наступного кроку
                a1 = a2;
                a2 = a3;
                a3 = ak;
            }
        }
    }
}
