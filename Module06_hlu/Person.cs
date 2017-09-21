using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_hlu
{
    internal partial class Person  //internal klasse (default)
    {
        public string navn;  // private er default
        public int alder;
        public bool erILive;

        // ctor (default constructor)
        public Person() : this("", 0, true)  // kald constructor med parametre (custom constructor)
        {
            // log
            // sikkerhed

            //initialiser variable
            //navn = "";
            //erILive = true;
        }

        public Person(string navn, int alder, bool erILive)
        {
            if (alder < 0 || alder > 120)
                this.alder = 0;

            this.navn = navn;
            this.alder = alder;
            this.erILive = erILive;

            this.land = "DK";
        }

    }
}
