using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        enum FilTyper
        {
            csv,
            pdf,
            txt
        }

        struct Person
        {
            public int id;
            public string navn;
        }


        static void Main(string[] args)
        {
            //int thisvariableisnogood;  // StyleCop test

            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            FilTyper ft;
            ft = FilTyper.csv;
            Console.WriteLine(ft);
            int v = Convert.ToInt32(ft);
            Console.WriteLine(v);

            DateTime dag = DateTime.Now;
            Console.WriteLine(dag.ToString("ddMMyy"));
            Console.WriteLine(dag.ToString("dMy"));
            Console.WriteLine(dag.ToString("ddddd MMMMM yyyy"));
            Console.WriteLine(dag.ToLongDateString());

            Person p;
            p.id = 1;
            p.navn = "Thomas";
            Console.WriteLine(p.navn);
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
