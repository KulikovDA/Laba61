//базовый 3
class Program
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите значение b: ");
        int b = int.Parse(Console.ReadLine());
        int z = Max(a, 2 * b) + Max(2 * a - b, b);
        Console.WriteLine("Значение z = " + z);
    }

    static int Max(int x, int y)
    {
               return x > y ? x : y;
    }
}
