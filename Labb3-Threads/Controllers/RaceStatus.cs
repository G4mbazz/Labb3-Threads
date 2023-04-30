using Labb3_Threads.Models;

namespace Labb3_Threads.Controllers
{
    internal class RaceStatus
    {
        public static void TrackCars(List<MyCar> cars)
        {
            while (true)
            {
                Console.ReadLine();
                foreach (var car in cars)
                {
                    if (car.MySpeed == 0)
                    {
                        Console.WriteLine($"{car.MyName} har {10000 - car.MyDistance} meter kvar innan målet och står för tillfället stilla");
                    }
                    else if (car.MyDistance >= 10000)
                    {
                        Console.WriteLine($"{car.MyName} Är redan i mål på {car.MyPlacement}:a plats");
                    }
                    else
                    {
                        Console.WriteLine($"{car.MyName} färdas i {car.MySpeed}Km/h och har {10000 - car.MyDistance} meter kvar innan målet!");
                    }

                }
            }

        }
    }
}
