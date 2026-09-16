using System;

namespace KonstruktorIsmetles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Bodri = new Dog("Bodri", "Labrador", 5);
            Dog Morzsi = new Dog("Morzsi","Beagle", 3);
            Console.WriteLine(Bodri.ToString());
            Console.WriteLine(Morzsi.ToString());

            Phone samsung = new Phone("Samsung", "Galaxy S24");
            Phone apple = new Phone("Apple", "iPhone 16", 350000);
            Console.WriteLine(samsung.ToString());
            Console.WriteLine(apple.ToString());

            Player Steve = new Player("Steve");
            Player Alex = new Player("Alex", 5, 1200);
            Console.WriteLine(Steve.ToString());
            Console.WriteLine(Alex.ToString());

            Car Toyota = new Car("Toyota", "Corolla", 2018);
            Car BMW = new Car("BMW", "320i", 2021);
            Console.WriteLine(BMW.ToString());
            Console.WriteLine(Toyota.ToString());

            FIlm Insterstellar = new FIlm("Interstellar", 8.7);
            FIlm Minecraft = new FIlm("Minecraft Movie", 5.6);
        }
    }
}
