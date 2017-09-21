using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2(98);
            int sum = Test3(5,7);

            double r = 0;
            int res = Test4(5, 2, ref r);
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        static void Test1()
        {
            //int i = 1;
        }

        static void Test2(int y)
        {
            int i = y;
        }

        static int Test3(int a, int b)
        {
            return a + b;
        }

        static int Test4(int a, int b, ref double gns)  // "ref" er næsten det samme som "out"
        {
            gns = (a + b) / 2;
            return a + b;
        }

    }
}
