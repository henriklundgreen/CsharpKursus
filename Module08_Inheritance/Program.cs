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

        public void print()
        {
            System.Console.WriteLine("Jeg er en Person og hedder " + this.navn);
        }
    }

    class Student : Person
    {
        public int StudentId { get; set; }

        public void BookEksamen()
        {

        }
    }

    class Instruktør : Person
    {
        public int nøgle { get; set; }

        public void KørLøn()
        {

        }
    }

    sealed class HjælpeInstruktør : Instruktør  // sealed betyder at den ikke kan nedarves
    {
        public int MidlertidigNøgle { get; set; }

        public void FindKlasser()
        {

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
