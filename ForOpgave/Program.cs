using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] data = new string[100];
            
            for (int i = 0; i < 100; i++)
            {
                int no = i + 1;
                data[i] = no.ToString().PadRight(5);
            }

            for (int i = 0; i < 100; i++)
            {
                if (i >= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.Write(data[i]);
                int ten = (i+1) % 10;
                //Console.WriteLine("Ten: " + ten);
                if (ten == 0)
                {
                    Console.WriteLine("\n");
                }
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
