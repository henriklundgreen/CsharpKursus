using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.fuldtnavn());

            Person p2 = new Person("henrik", "lundgreen", 1960);
            Console.WriteLine(p2.fuldtnavn());
            Console.WriteLine(p2.alder());


            System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();
        }
    }
}
