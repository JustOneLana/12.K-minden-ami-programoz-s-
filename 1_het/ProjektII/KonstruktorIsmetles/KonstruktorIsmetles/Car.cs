using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorIsmetles
{
    public class Car
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public int YearItWasMade { get; set; }
        public int Age { get; set; }

        public Car(string brand, string type, int yearItwasMade)
        {
            Brand = brand;
            Type = type;
            YearItWasMade = yearItwasMade;
            Age = 2026 - YearItWasMade;
        }
        public override string ToString()
        {
            return $"{Brand} : {Type}, {YearItWasMade}, {Age}";
        }
    }
}
