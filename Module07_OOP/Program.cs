namespace Module07_OOP
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Værdi = 10;
            System.Console.WriteLine(t.Værdi);

            Person p = new Person() { Navn = "Henrik", Alder = 57 };

            double res = FinansielleBeregninger.Beregn();  // da Beregn() er static kaldes den på klassen


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

    }

    internal class Person
    {
        public string Navn { get; set; } = "";
        public int Alder { get; set; } = 0;
        public string Land { get; set; } = "DK";
    }

    internal class Terning
    {
        private int værdi;
        private bool snyd;
        private string test { get; set; }

        public int Værdi
        {
            get
            {
                return this.værdi;
            }
            set
            {
                this.værdi = value;
            }
        }

        public bool Snyd
        {
            get { return snyd; }
            set { snyd = value; }
        }

    }
}
