using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadFinder
{
    public class Solution
    {
        public int IdRoad { get; set; }
        public int TotalDistance { get; set; }

        public Solution(int idRoad, int totalDistance)
        {
            this.IdRoad = idRoad;
            this.TotalDistance = totalDistance;
        }
    }
}
