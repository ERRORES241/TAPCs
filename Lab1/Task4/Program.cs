namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть M: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Числа Армстронга:");
            int i = 1;
            do
            {
                // Рахуємо кількість цифр у числі
                int count = 0;
                int temp = i;
                do
                {
                    count++;
                    temp /= 10;
                } while (temp > 0);
                // Рахуємо суму цифр у степені count
                int sum = 0;
                temp = i;
                do
                {
                    int digit = temp % 10;
                    sum += (int)Math.Pow(digit, count);
                    temp /= 10;
                } while (temp > 0);
                // Якщо сума дорівнює числу - це число Армстронга
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= m);
        }
    }
}
