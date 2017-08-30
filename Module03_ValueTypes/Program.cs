using System;

namespace Module03_ValueTypes
{
    class Program
    {
        enum Køn
        {
            Mand = 1,
            Kvinde =2
        }

        struct Person
        {
            public string navn;
            public Køn køn;
        }


        static void Main(string[] args)
        {
            {
                //System.Int32 i;
                //System.Decimal komma;
                int i = 0;
                decimal komma;

                long l;
                DateTime dato;
                bool b;
                dato = DateTime.Now;
                DateTime jul = new DateTime(2017, 12, 24);
                TimeSpan ts = jul.Subtract(dato);

                Console.WriteLine(i);
                Console.WriteLine("dd MMMMM yyyy");
            }

            {
                int i = 1;
                short s;
                s = Convert.ToInt16(i);

                //var v = 1000.34;
                double v = 1000.34;

                Køn køn1 = Køn.Mand;
                int kønInt = 1;
                Køn nytKøn = (Køn) Enum.Parse(typeof(Køn), kønInt.ToString());

                Person person1;
                person1.navn = "Mikkel";
                person1.køn = Køn.Mand;

                
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
