using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningOpgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning(3);
            t.skriv();
            t.ryst();
            t.skriv();

            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();
        }
    }


    internal class Terning
    {
        private int værdi;
        private System.Random rnd = new System.Random();

        public Terning()
        {

        }

        public Terning(int værdi)
        {
            this.værdi = værdi;
        }

        public int Værdi
        {
            get
            {
                Console.WriteLine("værdi aflæses");
                return this.værdi;
            }
            set
            {
                Console.WriteLine("værdi sættes");

                if (value < 1 || value > 6)
                    value = 1;

                this.værdi = value;
            }
        }

        public void ryst()
        {
            this.værdi = this.rnd.Next(1, 7);
        }

        public void skriv()
        {
            Console.WriteLine(this.værdi);
        }

    }

}
