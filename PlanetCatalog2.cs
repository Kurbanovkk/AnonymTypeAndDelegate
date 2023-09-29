using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnonymType
{
    class PlanetCatalog2
    {
        private List<Planet> _planets;
        private Func<string, string> _planetValidator;

        public PlanetCatalog2(Func<string, string> validator)
        {
            _planets = new List<Planet>
        {
            new Planet("Venus", 2, "37,104 km"),
            new Planet("Earth", 3, "40,075 km"),
            new Planet("Mars", 4, "21,344 km")
        };
            _planetValidator = validator;
        }



        public Tuple<int, string, string> GetPlanet2(string planetName, Func<string, string> _planetValidator)
        {
            var order = 0;
            var length = "0";
            var error = "";

            error = _planetValidator(planetName);

            if (string.IsNullOrEmpty(error))
            {
                var planet = _planets.Find(p => p.Name == planetName);
                if (planet != null)
                {
                    order = planet.OrderFromSun;
                    length = planet.EquatorLength;
                }
                else
                {
                    error = "Не удалось найти планету";
                }
            }

            return Tuple.Create(order, length, error);
        }
    }
}
