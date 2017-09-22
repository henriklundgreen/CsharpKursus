using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingOpgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            Console.WriteLine(t.Værdi);
            t.ryst();
            Console.WriteLine(t.Værdi);

            LudoTerning l = new LudoTerning(5);
            Console.WriteLine(l.Værdi);
            Console.WriteLine(l.ErStjerne());
            l.ryst();
            Console.WriteLine(l.Værdi);
            Console.WriteLine("Er Stjerne: " + l.ErStjerne());
            Console.WriteLine("Er Globus: " + l.ErGlobus());


            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();
        }
    }

    class Terning
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
            Console.Write("[" + this.værdi + "] ");
        }

    }


    class LudoTerning : Terning
    {
        public LudoTerning() : base()
        {
        }

        public LudoTerning(int værdi) : base(værdi)
        {
        }


        public bool ErGlobus()
        {
            if (this.Værdi == 3)
                return true;
            else
                return false;
        }

        public bool ErStjerne()
        {
            if (this.Værdi == 5)
                return true;
            else
                return false;
        }

    }


}
