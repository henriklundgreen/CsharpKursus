using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            MinRandom mr = new MinRandom();
            Console.WriteLine(mr.NextBool().ToString() );


            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();

        }
    }

    class MinRandom : System.Random  // eksempel på nedarving fra system klasse
    {
        public bool NextBool()
        {
            Random rnd = new Random();
            int tal = rnd.Next(2,1001);
            if (tal < 500)
                return true;
            else
                return false;
        }
    }

}
