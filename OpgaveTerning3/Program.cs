using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTerning3
{
    class Program
    {
        static void Main(string[] args)
        {
            YatzyBæger b = new YatzyBæger();
            b.skrivBæger();
            b.rystBæger();
            b.skrivBæger();
            
            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();
        }
    }

    internal class Terning
    {
        private int værdi;
        private static System.Random rnd = new System.Random();

        public Terning()
        {
            this.værdi = rnd.Next(1, 7);
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
            this.værdi = rnd.Next(1, 7);
        }

        public void skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

    }

    internal class YatzyBæger
    {
        private Terning[] t5;
        
        public YatzyBæger()
        {
            t5 = new Terning[5];
            for (int i = 0; i < 5; i++)
            {
                t5[i] = new Terning();
            }
        }

        public void rystBæger()
        {
            for (int i = 0; i < 5; i++)
            {
                t5[i].ryst();
            }
        }

        public void skrivBæger()
        {
            for (int i = 0; i < 5; i++)
            {
                t5[i].skriv();
            }
            Console.WriteLine();
        }

    }

}