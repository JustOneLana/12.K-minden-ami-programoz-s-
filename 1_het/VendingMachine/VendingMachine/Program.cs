namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member Józsi = new Member("Józsi", 18, true);
            Member Marika = new Member("Marika", 56, false);
            Member Béla = new Member("Béla", 19, false);

            Console.WriteLine(Józsi.Name, Józsi.Age);
            Console.WriteLine(Marika.Name, Marika.Age);
            Console.WriteLine(Béla.Name, Béla.Age);

            Marika.CheckIn();
            Marika.CheckIn();
            Marika.CheckIn();
            Marika.CheckIn();
            Józsi.CheckIn();
            Józsi.CheckIn();
            Józsi.CheckIn();
            Józsi.CheckIn();
            Józsi.CheckIn();
            Józsi.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();
            Béla.CheckIn();

            Console.WriteLine(Józsi.Describe());
            Console.WriteLine(Marika.Describe());
            Console.WriteLine(Béla.Describe());

        }
    }
}
