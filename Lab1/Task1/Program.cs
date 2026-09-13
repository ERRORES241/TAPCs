namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.Write("A: "); double a = double.Parse(Console.ReadLine());
            Console.Write("B: "); double b = double.Parse(Console.ReadLine());
            Console.Write("C: "); double c = double.Parse(Console.ReadLine());
            if ((a < b && b < c) || (a > b && b > c))
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            Console.WriteLine($"A = {a}, B = {b}, C = {c}");
        }
    }
}
