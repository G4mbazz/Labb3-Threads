using Labb3_Threads.Controllers;
using Labb3_Threads.Models;

namespace Labb3_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyCar doULike = new MyCar(120,"DoYouLike?",0);
            MyCar katchow = new MyCar(120, "McQueen", 0);
            Thread car = new Thread(() => doULike.Race(doULike));
            Thread car1 = new Thread(() => katchow.Race(katchow));
            Thread track = new Thread(() => RaceStatus.TrackCars(MyCar.GetAllCars()));
            car.Start();
            car1.Start();
            track.Start();
            track.Join();

        }
    }
}