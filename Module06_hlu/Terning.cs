using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_hlu
{
    public class Terning
    {
        private int værdi;

        public Terning() : this (1)
        {
            //this.værdi = 1;
        }

        public Terning(int startVærdi)
        {
            if (startVærdi < 1 || startVærdi > 6)
                startVærdi = 1;

            this.værdi = startVærdi;
        }

        /// <summary>
        /// Skriver terningens værdi til consol
        /// </summary>
        public void skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        /// <summary>
        /// Hent terningens værdi
        /// </summary>
        /// <returns></returns>
        public int hentVærdi()  // getter
        {
            // log
            // sikkerhed

            return this.værdi;
        }

        /// <summary>
        /// Gemmer ny værdi på terningen
        /// </summary>
        /// <param name="værdi"></param>
        public void gemVærdi(int værdi)  // setter
        {
            // log
            // sikkerhed

            // validering
            if (værdi < 1 || værdi > 6)
                værdi = 1;

            this.værdi = værdi;
        }
    }
}
