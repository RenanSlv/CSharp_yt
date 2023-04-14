using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maratona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture),
                   B = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture),
                   C = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture);
            double X = ((A * 2) + (B * 3) + (C * 5)) / 10;
            Console.WriteLine($@"MEDIA = {String.Format(System.Globalization.CultureInfo.InvariantCulture,
                                "{0:0.0}", X)}");
            Console.Read();

        }
    }
}
