using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingOpgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Fornavn = "Henrik", Efternavn = "Lundgreen" };
            Console.WriteLine(p.FuldtNavn());

            Elev e = new Elev() { Fornavn = "Peter", Efternavn = "Petersen", KlasseLokale = "5a" };
            Console.WriteLine(e.FuldtNavn());

            Intruktør i = new Intruktør() { Fornavn = "Søren", Efternavn = "Sørensen", NøgleId = 5 };
            Console.WriteLine(i.FuldtNavn());


            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }

    class Elev : Person
    {
        public string KlasseLokale { get; set; }
    }

    class Intruktør : Person
    {
        public int NøgleId { get; set; }
    }

}
