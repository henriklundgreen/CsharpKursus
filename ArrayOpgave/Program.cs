using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] salary = { 70000, 60000, 50000, 80000, 90001.25 };
            System.Array.Sort(salary);

            double total = 0;

            for (int i = 0; i < salary.Length; i++)
            {
                Console.WriteLine("Månedsløn: " + salary[i]);
                total += salary[i];
            }

            double gen = total / salary.Length;
            Console.WriteLine("Gennemsnit: " + gen.ToString("n2"));
            Console.WriteLine("Gennemsnit: " + gen.ToString("c2"));


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
