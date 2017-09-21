using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start_dag_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] værdier = { 5, 7, 8, 34, 9, 0 };
            ArrayResultat res = beregn(værdier);

            Console.WriteLine(res.sum);
            Console.WriteLine(res.gennemsnit.ToString("N2"));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }


        static ArrayResultat beregn(int[] værdier)
        {
            ArrayResultat resultat;
            resultat.sum = 0;
            resultat.gennemsnit = 0;

            for (int i = 0; i < værdier.Length; i++)
            {
                resultat.sum += værdier[i];
            }

            resultat.gennemsnit = resultat.sum / værdier.Length;

            return resultat;
        }

    }
    
}
