using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArealBeregnOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            ArealBeregninger.BeregnArealFirkant(3, 4);
            ArealBeregninger.BeregnArealCirkel(3);


            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();
        }
    }

    public static class ArealBeregninger
    {
        public static void BeregnArealFirkant(int længde, int højde)
        {
            int areal = længde * højde;
            Console.WriteLine(areal);
        }

        public static void BeregnArealCirkel(int radius)
        {
            //double areal = 3.14 * radius * radius;
            double areal = Math.Pow(radius, 2) * System.Math.PI;
            Console.WriteLine(areal);
        }

    }
}
