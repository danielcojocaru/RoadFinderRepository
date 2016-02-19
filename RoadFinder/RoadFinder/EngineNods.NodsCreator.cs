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
        public List<City> CitiesList { get; set; }

        private string filePath;

        public EngineNods(string filePath)
        {
            this.filePath = filePath;
            CreateCitiesList();
        }

        #region Private Methods
        private void CreateCitiesList()
        {
            this.CitiesList = new List<City>();

            using (StreamReader sr = new StreamReader(this.filePath))
            {
                while (!sr.EndOfStream)
                {
                    string currentLine = sr.ReadLine();
                    CreateCitiesFrom(currentLine);
                }
            }
        }

        private void CreateCitiesFrom(string currentLine)
        {
            string[] threeThings = currentLine.Split(';');

            string firsCity = threeThings[0].ToLower();
            string secondCity = threeThings[1].ToLower();
            int distance = int.Parse(threeThings[2]);

            AddOrCompleteCity(firsCity, secondCity, distance);
            AddOrCompleteCity(secondCity, firsCity, distance);
        }

        private void AddOrCompleteCity(string cityName, string neighborName, int distance)
        {
            int index = -1;
            if (!CityAlreadyExists(cityName, out index))
            {
                City newCity = new City(cityName);
                Neighbor newNeighbor = new Neighbor(neighborName, distance);
                newCity.NeighborsList.Add(newNeighbor);
                this.CitiesList.Add(newCity);
            }
            else if (!NeighborAlreadyExists(index, neighborName))
            {
                City currentCity = this.CitiesList[index];
                Neighbor newNeighbor = new Neighbor(neighborName, distance);
                currentCity.NeighborsList.Add(newNeighbor);
            }
        }

        private bool NeighborAlreadyExists(int cityIndex, string neighborName)
        {
            foreach (Neighbor currentNeighbor in this.CitiesList[cityIndex].NeighborsList)
            {
                if (currentNeighbor.Name == neighborName)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CityAlreadyExists(string cityName, out int index)
        {
            index = -1;

            if (this.CitiesList.Count == 0)
            {
                return false;
            }
            else
            {
                foreach (City currentCity in this.CitiesList)
                {
                    index++;
                    if (currentCity.Name == cityName)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        #endregion Private Methods
    }
}
