using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadFinder
{
    public class Neighbor
    {
        public string Name { get; set; }
        public int Distance { get; set; }

        public Neighbor(string name, int distance)
        {
            this.Name = name;
            this.Distance = distance;
        }
    }
}
