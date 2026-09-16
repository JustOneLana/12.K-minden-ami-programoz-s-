using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorIsmetles
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public Phone(string brand, string type, int price = 100000)
        {
            Brand = brand;
            Type = type;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Brand} : {Type}, {Price}";
        }
    }
}
