namespace AnonymType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solsys = new TheSolarSystem();
            solsys.SolSys();

            Console.WriteLine(  );
            Console.WriteLine("*********************************************************");
            Console.WriteLine();

            var catalog = new PlanetCatalog();

            Console.WriteLine("Запрос 1:");
            var (order1, equator1, error1) = catalog.GetPlanet("Earth");
            Console.WriteLine($"Планета: Земля, Порядковый номер:: {order1}, Длина экватора: {equator1}, Ошибка: {error1}");

            Console.WriteLine("Запрос 2:");
            var (order2, equator2, error2) = catalog.GetPlanet("Lemonia");
            Console.WriteLine($"Планета: Лемония, Порядковый номер:: {order2}, Длина экватора: {equator2}, Ошибка: {error2}");

            Console.WriteLine("Запрос 3:");
            var (order3, equator3, error3) = catalog.GetPlanet("Mars");
            Console.WriteLine($"Планета: Марс, Порядковый номер:: {order3}, Длина экватора: {equator3}, Ошибка: {error3}");

            Console.WriteLine("Запрос 4:");
            var (order4, equator4, error4) = catalog.GetPlanet("Venus");
            Console.WriteLine($"Планета: Венера, Порядковый номер:: {order4}, Длина экватора: {equator4}, Ошибка: {error4}");


            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine();

            Func<string, string> planetValidator = (planetName) =>
            {
                if (planetName == "Lemonia")
                {
                    return "Это запретная планета";
                }
                return null;
            };
            var catalog2 = new PlanetCatalog2(planetValidator);
            int count = 0;

            Console.WriteLine("Запрос 1:");
            var (order5, equator5, error5) = catalog2.GetPlanet2("Earth", name => 
            {
                count++;
                if (name.Equals("Lemonia"))  return "Это запретная планета";
                else if (count % 3 == 0) return "Вы спрашиваете слишком часто";
                else return null;
            });
            Console.WriteLine($"Планета: Земля, Порядковый номер:: {order5}, Длина экватора: {equator5}, Ошибка: {error5}");

            Console.WriteLine("Запрос 2:");
            var (order6, equator6, error6) = catalog2.GetPlanet2("Lemonia", name =>
            {
                count++;
                if (name.Equals("Lemonia")) return "Это запретная планета";
                else if (count % 3 == 0) return "Вы спрашиваете слишком часто";
                else return null;
            });
            Console.WriteLine($"Планета: Лемония, Порядковый номер:: {order6}, Длина экватора: {equator6}, Ошибка: {error6}");

            Console.WriteLine("Запрос 3:");
            var (order7, equator7, error7) = catalog2.GetPlanet2("Mars", name =>
            {
                count++;
                if (name.Equals("Lemonia")) return "Это запретная планета";
                else if (count % 3 == 0) return "Вы спрашиваете слишком часто";
                else return null;
            });
            Console.WriteLine($"Планета: Марс, Порядковый номер:: {order7}, Длина экватора: {equator7}, Ошибка: {error7}");

            Console.WriteLine("Запрос 4:");
            var (order8, equator8, error8) = catalog2.GetPlanet2("Venus", name =>
            {
                count++;
                if (name.Equals("Lemonia")) return "Это запретная планета";
                else if (count % 3 == 0) return "Вы спрашиваете слишком часто";
                else return null;
            });
            Console.WriteLine($"Планета: Венера, Порядковый номер:: {order8}, Длина экватора: {equator8}, Ошибка: {error8}");

        }


    }
}