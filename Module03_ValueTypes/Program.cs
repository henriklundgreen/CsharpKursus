using System;

namespace Module03_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            if (System.Diagnostics.Debugger.IsAttached)
            {
                //System.Int32 i;
                //System.Decimal komma;
                int i;
                decimal komma;

                long l;
                DateTime dato;
                bool b;
                dato = DateTime.Now;
                DateTime jul = new DateTime(2017, 12, 24);
                TimeSpan ts = jul.Subtract(dato);

                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
