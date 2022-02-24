public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Roman Numbers.");

        RomanNumber n1 = new RomanNumber(23);
        RomanNumber n2 = new RomanNumber(46);
        Console.WriteLine($"{n1.ToString()} + {n2.ToString()} = {RomanNumber.Add(n1, n2).ToString()}");
        Console.WriteLine($"{n1.ToString()} * {n2.ToString()} = {RomanNumber.Mul(n1, n2).ToString()}");
        Console.WriteLine($"{n2.ToString()} - {n1.ToString()} = {RomanNumber.Sub(n2, n1).ToString()}");
        Console.WriteLine($"{n2.ToString()} / {n1.ToString()} = {RomanNumber.Div(n2, n1).ToString()}");
    }
}
