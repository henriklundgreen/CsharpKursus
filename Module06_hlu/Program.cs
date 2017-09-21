using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_hlu
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.navn = "Mikkel";
            p.alder = 27;
            p.erILive = true;

            Person q = new Person("Thomas", 29, true);

            Console.WriteLine();

            Terning t1 = new Terning();
            Terning t2 = new Terning(2);
            Terning t3 = new Terning(60);

            t1.skriv();
            t2.skriv();
            t3.skriv();

            t1.gemVærdi(3);
            t2.gemVærdi(600);

            t1.skriv();
            t2.skriv();


            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();
        }
    }
}
