namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Рік: ");
            int year = int.Parse(Console.ReadLine());
            int offset = (year - 1984) % 60;
            // Визначаємо назву кольору (5 підциклів по 12 років)
            string color = (offset / 12) switch
            {
                0 => "зеленого",
                1 => "червоного",
                2 => "жовтого",
                3 => "білого",
                _ => "чорного"
            };
            // Визначаємо назву тварини (12 тварин)
            string animal = (offset % 12) switch
            {
                0 => "щура", 1 => "корови", 2 => "тигра", 3 => "зайця",
                4 => "дракона", 5 => "змії", 6 => "коня", 7 => "вівці",
                8 => "мавпи", 9 => "курки", 10 => "собаки", _ => "свині"
            };
            Console.WriteLine($"Рік {color} {animal}");
        }
    }
}
