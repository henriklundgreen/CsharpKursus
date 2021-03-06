﻿using System;

namespace Module09_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Dyr d = new Dyr();
                Dyr d = null;
                System.Console.WriteLine(d.ToString());
            }
            catch (NullReferenceException e)
            {
                System.Console.WriteLine("NULL REF EXCEPTION: " + e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("EXCEPTION: " + e.Message);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    class Dyr
    {

    }
}
