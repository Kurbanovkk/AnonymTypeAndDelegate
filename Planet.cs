using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymType
{
    internal class Planet

    {
        public string Name { get; }
        public int OrderFromSun { get; }
        public string EquatorLength { get; }
        public Planet PreviousPlanet { get; set; }

        public Planet(string name, int orderFromSun, string equatorLength)
        {
            Name = name;
            OrderFromSun = orderFromSun;
            EquatorLength = equatorLength;
        }
    }
}
