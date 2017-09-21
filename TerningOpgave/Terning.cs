using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningOpgave
{
    class Terning
    {
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();

        public Terning()
        {
            værdi = 1;
            snyd = false;
        }

        public Terning(bool snyd)
        {
            værdi = 1;
            this.snyd = snyd;

        }

        /// <summary>
        /// Skriver terningens værdi til consol
        /// </summary>
        public void skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        /// <summary>
        /// Ryster terningen
        /// </summary>
        public void ryst()
        {
            if (snyd)
            {
                værdi = 6;
            }
            else
            {
                værdi = rnd.Next(1, 7);
            }
        }




    }
}
