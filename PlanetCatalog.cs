using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymType
{
    internal class PlanetCatalog
    {
        private List<Planet> _planets;
        private int _queries;

        public PlanetCatalog()
        {
            _planets = new List<Planet>
        {
            new Planet("Venus", 2, "37,104 km"),
            new Planet("Earth", 3, "40,075 km"),
            new Planet("Mars", 4, "21,344 km")
        };
            _queries = 0;
        }

        public (int, string, string) GetPlanet(string name)
        {
            _queries++;

            if (_queries % 3 == 0)
            {
                return (0, "", "Вы спрашиваете слишком часто");
            }

            var planet = _planets.Find(p => p.Name.Equals(name));

            if (planet != null)
            {
                return (planet.OrderFromSun, planet.EquatorLength, "");
            }
            else
            {
                return (0, "", "Не удалось найти планету");
            }
        }
    }
}
