using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indtast navn:");
            string navn = Console.ReadLine();
            Console.Write("Velkommen ");
            Console.WriteLine(navn.ToUpper());
            Console.WriteLine("Tryk på en tast for at fortsætte!");
            Console.ReadKey();
            
        }
    }
}
