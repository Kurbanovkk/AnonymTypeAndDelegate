using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AnonymType
{
    internal class TheSolarSystem
    {
        public void SolSys()
        {
                var venus1 = new
                {
                    Name = "Венера",
                    OrderFromSun = 2,
                    EquatorLength = "38,025 км",
                    PreviousPlanet = (string)null
                };

                var earth = new
                {
                    Name = "Земля",
                    OrderFromSun = 3,
                    EquatorLength = "40,075 км",
                    PreviousPlanet = venus1.Name
                };

                var mars = new
                {
                    Name = "Марс",
                    OrderFromSun = 4,
                    EquatorLength = "33,867 км",
                    PreviousPlanet = earth.Name
                };

                var venus2 = new
                {
                    Name = "Венера",
                    OrderFromSun = 2,
                    EquatorLength = "38,025 км",
                    PreviousPlanet = mars.Name
                };

                Console.WriteLine("Информация о планетах в Солнечной системе:");
                Console.WriteLine($"1. Название: {venus1.Name}, Порядковый номер: {venus1.OrderFromSun}, Длина экватора: {venus1.EquatorLength}, Предыдущая планета: {venus1.PreviousPlanet}, Эквивалентность Венере {venus1.Equals(venus1)}");
                Console.WriteLine($"2. Название: {earth.Name}, Порядковый номер: {earth.OrderFromSun}, Длина экватора: {earth.EquatorLength}, Предыдущая планета: {earth.PreviousPlanet}, Эквивалентность Венере {venus1.Equals(earth)}");
                Console.WriteLine($"3. Название: {mars.Name}, Порядковый номер: {mars.OrderFromSun}, Длина экватора: {mars.EquatorLength}, Предыдущая планета: {mars.PreviousPlanet}, Эквивалентность Венере {venus1.Equals(mars)}");
                Console.WriteLine($"4. Название: {venus2.Name}, Порядковый номер: {venus2.OrderFromSun}, Длина экватора: {venus2.EquatorLength}, Предыдущая планета: {venus2.PreviousPlanet}, Эквивалентность Венере {venus2.Equals(venus2)}");

        }
    }
}
