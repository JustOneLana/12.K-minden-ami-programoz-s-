using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorIsmetles
{
    public class FIlm
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public bool IsRecommended { get; set; }

        public FIlm(string name, double rating)
        {
            Name = name;
            Rating = rating;
            IsRecommended = rating > 7 ? true : false;
        }
        public override string ToString()
        {
            return $"{Name} : {Rating}, {IsRecommended}";
        }
    }
}
