using System.Text;

namespace Module04_ReferenceTypes
{
    class Program
    {

        struct PersonStruct   // værdi baseret (stack)
        {
            public int id;
            public bool erILine;
        }

        class PersonClass   // reference baseret (heap)
        {
            public int id;
            public bool erILive;
        }


        static void Main(string[] args)
        {

            PersonStruct p1;
            p1.id = 1;
            p1.erILine = true;

            PersonStruct p2 = new PersonStruct();  // brug denne initiaslisering
            p2.id = 2;
            p2.erILine = true;

            PersonClass p3 = new PersonClass();
            System.Console.WriteLine(p3.id);
            p3.id = 3;
            p3.erILive = false;
            System.Console.WriteLine(p3.id);
            System.Console.WriteLine(p3.erILive);

            PersonClass p4 = new PersonClass();
            p4 = p3;  // begge peger nu på samme område i memory (på heap'en)
            System.Console.WriteLine(p3.id);
            System.Console.WriteLine(p4.id);


            int[] i = new int[5];
            i[0] = 2;
            i[1] = 5;
            i[3] = 76;
            System.Console.WriteLine(i[0]);
            for (int j = 0; j < 5; j++)
            {
                System.Console.WriteLine(i[j]);
            }
            int[] x = { 0, 1, 2, 3, 4 };
            int[] y = { 1, 2, 5, 3, 0 };
            x = y;  // begge peger nu på y's værdier (array er refence baseret)
            System.Console.WriteLine(x[0]);
            System.Console.WriteLine(x == y);  // true da de peger samme sted hen

            System.Array.Sort(y);
            for (int j = 0; j < 5; j++)
            {
                System.Console.WriteLine(y[j]);
            }

            // STRINGS
            string u = "Mikkel";
            string w = u + " \n\t\t*** " + u;
            System.Console.WriteLine(w);

            //string stiTilFil = "c:\\temp\\text.txt";
            string stiTilFil = @"c:\temp\text.txt";

            u = u.ToUpper();
            System.Console.WriteLine(u.Substring(2, 3));

            string a = "";
            for (int q = 0; q < 1_000_000; q++)
            {
               a = a + "*";
            }

            StringBuilder sb = new StringBuilder();  // brug denne hvis meget string manipulation
            sb.Append("text");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
