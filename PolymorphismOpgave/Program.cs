using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] d = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                d[i] = Dyr.TilfældigtDyr(); 
            }

            foreach (var item in d)
            {
                item.SigNoget();
            }


            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();
        }
    }

    class Dyr
    {
        private static System.Random rnd = new System.Random();
        public string navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et Dyr som hedder: " + this.navn);
        }

        public static Dyr TilfældigtDyr()
        {
            int tal = rnd.Next(1,20);
            string sti = @"X:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);

            if (tal / 2 == 0)
            {
                Hund h = new Hund();
                h.navn = navne[tal];
                return h;
            }
            else
            {
                Kat k = new Kat();
                k.navn = navne[tal];
                return k;
            }
        }

    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en Hund som hedder: " + this.navn);
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en Kat som hedder: " + this.navn);
        }
    }

}
