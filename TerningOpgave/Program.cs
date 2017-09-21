using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.skriv();
            t1.ryst();
            t1.skriv();

            Terning t2 = new Terning(true);
            t2.skriv();
            t2.ryst();
            t2.skriv();

            Console.WriteLine("");

            Terning t3 = new Terning();
            for (int i = 0; i < 25; i++)
            {
                t3.ryst();
                t3.skriv();
            }

            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();
        }
    }
}
