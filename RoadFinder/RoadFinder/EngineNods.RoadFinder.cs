using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RoadFinder
{
    public partial class EngineNods
    {
        public List<List<Neighbor>> Roads { get; set; }

        #region Fields
        private string initialCityName;
        private string finalCityName;
        private int initialCityIndex;
        private int finalCityIndex;
        #endregion Fields

        
        public void FindTheBestRoad(string fromCity, string toCity)
        {
            InitialisePropertiesAndFields(fromCity, toCity);

            bool initialCityHasNeighbors = this.CitiesList[initialCityIndex].NeighborsList.Count != 0;
            if (initialCityHasNeighbors)
            {
                FindSolutions();
            }

            SetTotalDistanceForAllRoads();

            this.Roads = this.Roads.OrderBy(x => x[0].Distance).ToList();
        }

        #region Private Methods
        private void SetTotalDistanceForAllRoads()
        {
            int index = -1;
            for (int i = 0; i < this.Roads.Count; i++)
            {
                index++;
                int totalDistance = CalculateTotalDistanceOfRoad(this.Roads[index]);
                this.Roads[i][0] = new Neighbor(this.initialCityName, totalDistance);
            }
        }

        private void FindSolutions()
        {
            this.Roads.Add(new List<Neighbor>());
            NewNod(0, this.initialCityIndex, 0);
        }

        private void InitialisePropertiesAndFields(string fromCity, string toCity)
        {
            this.initialCityName = fromCity;
            this.finalCityName = toCity;

            SetInitialAndFinalCityIndexes();

            this.Roads = new List<List<Neighbor>>();
        }

        private void NewNod(int roadIndex, int cityIndex, int distance)
        {
            AddCityToCurrentRoad(roadIndex, cityIndex, distance);

            if (!ArrivedAtDestination(cityIndex))
            {
                List<Neighbor> theNeighbors = NeighborsOfTheCityThatAreNotOnAlreadyTheRoad(roadIndex, cityIndex);
                if (theNeighbors.Count > 0)
                {
                    List<Neighbor> currentRoad = GetCurrentRoad(roadIndex);
                    DeleteCurrentRoad(roadIndex);
                    CreateACopieOfTheRoadAndAddNewNods(currentRoad, theNeighbors);
                }
                else
                {
                    DeleteCurrentRoad(roadIndex);
                }
            }
        }

        private List<Neighbor> GetCurrentRoad(int roadIndex)
        {
            List<Neighbor> copyOfRoad = new List<Neighbor>();
            foreach (Neighbor item in this.Roads[roadIndex])
            {
                copyOfRoad.Add(item);
            }
            return copyOfRoad;
        }

        private void DeleteCurrentRoad(int roadIndex)
        {
            this.Roads.RemoveAt(roadIndex);
        }

        private void CreateACopieOfTheRoadAndAddNewNods(List<Neighbor> parrentRoad, List<Neighbor> theNeighbors)
        {
            int newRoadIndex = 99999;
            foreach (Neighbor currentNeighbor in theNeighbors)
            {
                CreateACopieOfTheExistingRoad(parrentRoad, out newRoadIndex);

                int nextDistance = currentNeighbor.Distance;
                int nextCityIndex = GetTheCityIndex(currentNeighbor.Name);
                NewNod(newRoadIndex, nextCityIndex, nextDistance);
            }
        }

        private void CreateACopieOfTheExistingRoad(List<Neighbor> parrentRoad, out int newRoadIndex)
        {
            List<Neighbor> duplicatedRoad = new List<Neighbor>();
            foreach (Neighbor currentNeighbor in parrentRoad)
            {
                duplicatedRoad.Add(currentNeighbor);
            }
            this.Roads.Add(duplicatedRoad);
            newRoadIndex = this.Roads.Count - 1;
        }

        private void ContinueOnTheSameRoad(int roadIndex, List<Neighbor> theNeighbors)
        {
            int nextRoadIndex = roadIndex;
            int nextDistance = theNeighbors[theNeighbors.Count - 1].Distance;
            int nextCityIndex = GetTheCityIndex(theNeighbors[theNeighbors.Count - 1].Name);

            NewNod(nextRoadIndex, nextCityIndex, nextDistance);
        }

        private int GetTheCityIndex(string name)
        {
            int index = -1;
            foreach (City currentCity in this.CitiesList)
            {
                index++;
                if (currentCity.Name == name)
                {
                    return index;
                }
            }
            return -1;
        }

        private void AddCityToCurrentRoad(int roadIndex, int cityIndex, int distance)
        {
            Neighbor neighborToBeAdded = new Neighbor(this.CitiesList[cityIndex].Name, distance);
            this.Roads[roadIndex].Add(neighborToBeAdded);
        }

        private List<Neighbor> NeighborsOfTheCityThatAreNotOnAlreadyTheRoad(int roadIndex, int cityIndex)
        {
            List<Neighbor> theNeighbors = new List<Neighbor>();

            foreach (Neighbor currentNeighbor in this.CitiesList[cityIndex].NeighborsList)
            {
                if (!NeighborIsAlreadyOnRoad(currentNeighbor, roadIndex))
                {
                    theNeighbors.Add(currentNeighbor);
                }
            }
            return theNeighbors;
        }

        private int CalculateTotalDistanceOfRoad(List<Neighbor> currentRoad)
        {
            int totalDistance = 0;
            foreach (Neighbor currentNeighbor in currentRoad)
            {
                totalDistance += currentNeighbor.Distance;
            }
            return totalDistance;
        }

        private bool ArrivedAtDestination(int cityIndex)
        {
            if (cityIndex == this.finalCityIndex)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool NeighborIsAlreadyOnRoad(Neighbor neighbor, int roadIndex)
        {
            foreach (Neighbor currentNeighbor in this.Roads[roadIndex])
            {
                if (currentNeighbor.Name == neighbor.Name)
                {
                    return true;
                }
            }
            return false;
        }

        private void SetInitialAndFinalCityIndexes()
        {
            int index = -1;
            foreach (City currentCity in this.CitiesList)
            {
                index++;
                if (currentCity.Name == this.initialCityName)
                {
                    this.initialCityIndex = index;
                }
                if (currentCity.Name == this.finalCityName)
                {
                    this.finalCityIndex = index;
                }
            }
        }
        #endregion Private Methods
    }
}