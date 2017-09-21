using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonOpgave
{
    class Person
    {
        public string fornavn;
        public string efternavn;
        public int fødselsår;

        public Person()
        {
            fornavn = "";
            efternavn = "";
        }

        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.fornavn = fornavn.ToUpper();
            this.efternavn = efternavn.ToUpper();
            this.fødselsår = fødselsår;
        }

        public string fuldtnavn()
        {
            return fornavn + " " + efternavn;
        }

        public int alder()
        {
            System.DateTime moment = System.DateTime.Now;
            int year = moment.Year;
            return year - fødselsår;
        }



    }
}
