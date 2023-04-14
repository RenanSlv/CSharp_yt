using System;


namespace ConsoleTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture);
            double A = raio * raio * pi;
            A = Math.Round(A, 4);
            Console.WriteLine($@"A={String.Format(System.Globalization.CultureInfo.InvariantCulture,
                                "{0:0.0000}", A)}");
            Console.Read();
        }
    }
}
