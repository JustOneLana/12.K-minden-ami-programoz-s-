using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorIsmetles
{
    public class Player
    {
        public string Name { get; set; }
        public int Stage { get; set; }
        public int Score { get; set; }

        public Player(string name, int stage = 1, int score = 0)
        {
            Name = name;
            Stage = stage;
            Score = score;
        }
        public override string ToString()
        {
            return $"{Name}: {Stage}, {Score}";
        }
    }
}
