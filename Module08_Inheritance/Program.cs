namespace Module08_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person o1 = new Person() {  navn = "Henrik"};
            o1.print();
            Student o2 = new Student() { navn = "student", StudentId = 1 };
            o2.print();
            o2.BookEksamen();
            Instruktør o3 = new Instruktør() { navn = "instruktør",  nøgle = 5 };
            o3.KørLøn();
            HjælpeInstruktør o4 = new HjælpeInstruktør() { navn = "Hjælpe", MidlertidigNøgle = 6 };

            // polymorphism
            Person o5 = new Instruktør();
            HjælpeInstruktør o6 = o5 as HjælpeInstruktør;
            o6.KørLøn();
            o6.FindKlasser();

            Person[] pa = new Person[4];
            pa[0] = o1;
            pa[1] = o2;
            pa[2] = o3;
            pa[3] = o4;
            foreach (var item in pa)
            {
                item.print();  // compiler finder selv ud af hvilken type objeter er
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string navn { get; set; }

        public virtual void print()
        {
            System.Console.WriteLine("Jeg er en Person og hedder " + this.navn);
        }

        public override string ToString()
        {
            return base.ToString() + " navn " + this.navn;
        }
    }

    class Student : Person
    {
        public int StudentId { get; set; }

        public void BookEksamen()
        {

        }

        public override void print()
        {
            System.Console.WriteLine("Jeg er en Student og hedder " + this.navn + " med id " + this.StudentId);
        }
    }

    class Instruktør : Person
    {
        public int nøgle { get; set; }

        public void KørLøn()
        {

        }

        public override void print()
        {
            System.Console.WriteLine("Jeg er en Instruktør og hedder " + this.navn + " med nøgle " + this.nøgle);
        }
    }

    sealed class HjælpeInstruktør : Instruktør  // sealed betyder at den ikke kan nedarves
    {
        public int MidlertidigNøgle { get; set; }

        public void FindKlasser()
        {

        }

        public override void print()
        {
            System.Console.WriteLine("Jeg er en HjælpeInstruktør og hedder " + this.navn + " med nøgle " + this.nøgle);
        }
    }

    class MinRandom : System.Random  // eksempel på nedarving fra system klasse
    {
        public int HluRandom()
        {
            return 1;
        }
    }



}
