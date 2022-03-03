public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Roman Numbers.");

        RomanNumber n1 = new RomanNumber(23);
        RomanNumber n2 = new RomanNumber(46);
        Console.WriteLine($"{n1.ToString()} + {n2.ToString()} = {(n1+n2).ToString()}");
        Console.WriteLine($"{n1.ToString()} * {n2.ToString()} = {(n1*n2).ToString()}");
        Console.WriteLine($"{n2.ToString()} - {n1.ToString()} = {(n2-n1).ToString()}");
        Console.WriteLine($"{n2.ToString()} / {n1.ToString()} = {(n2/n1).ToString()}");

        RomanNumber n3 = new RomanNumber(89);
        RomanNumber n4 = new RomanNumber(9);
        RomanNumber n5 = new RomanNumber(11);
        RomanNumber n6 = new RomanNumber(3);
        RomanNumber[] numbers = { n1, n2, n3, n4, n5, n6 };
        foreach (var el in numbers)
        {
            Console.Write($"{el.ToString()} ");
        }
        Console.WriteLine();
        Array.Sort(numbers);
        foreach (var el in numbers)
        {
            Console.Write($"{el.ToString()} ");
        }
        Console.WriteLine();
    }
}
