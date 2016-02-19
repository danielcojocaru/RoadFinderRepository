using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadFinder
{
    public class City
    {
        public string Name { get; set; }
        public List<Neighbor> NeighborsList { get; set; }

        public City(string name)
        {
            this.Name = name;
            this.NeighborsList = new List<Neighbor>();
        }
    }
}
