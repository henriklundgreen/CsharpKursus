using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "Mikkel";
            string s2 = "Fennefoss";
            string navn = s1 + " " + s2;
            Console.WriteLine(navn);

            string navnStort = navn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = navn.ToLower();
            Console.WriteLine(navnLille);

            string del = navn.Substring(7, 4);
            Console.WriteLine(del);

            string[] arr = navn.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            string test = s1 + "\t\t" + s2;
            Console.WriteLine(test);
            test = s1 + "\n" + s2;
            Console.WriteLine(test);

            System.IO.File.WriteAllText("c:\\temp\\mikkel.txt", navn);
            Console.WriteLine("Fil oprettet og skrevet!");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
