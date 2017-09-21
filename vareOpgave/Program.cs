using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vareOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.navn = "3 par sokker";
            v.pris = 100;
            double prisMedMoms = v.PrisMedMoms();
            Console.WriteLine(prisMedMoms);

            Vare v2 = new Vare("Vare 2", 200);
            Console.WriteLine(v2.PrisMedMoms());

            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();
        }
    }

    internal class Vare
    {
        public string navn;
        public double pris;

        public Vare()
        {

        }

        public Vare(string navn, double pris)
        {
            this.navn = navn;
            this.pris = pris;
        }

        public string Navn
        {
            get
            {
                Console.WriteLine("navn aflæses");
                return this.navn;
            }
            set
            {
                Console.WriteLine("navn sættes");
                this.navn = value;
            }
        }

        public double Pris
        {
            get
            {
                Console.WriteLine("pris aflæses");
                return this.pris;
            }
            set
            {
                Console.WriteLine("pris aflæses");
                this.pris = value;
            }
        }

        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }

    }
}
