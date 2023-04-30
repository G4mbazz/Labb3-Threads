using Labb3_Threads.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Threads.Models
{
    internal class MyCar
    {
        public int MySpeed { get; set; }
        public string MyName { get; set; }
        public int MyDistance { get; set; }
        public int MyPlacement { get; set; }
        public static int RacingCars { get; set; }
        
        public MyCar(int mySpeed, string myName, int myDistance)
        {
            MySpeed = mySpeed;
            MyName = myName;
            MyDistance = myDistance;
        }
        public static List<MyCar> myCars { get; set; } = new List<MyCar>();
        public static List<MyCar> GetAllCars() { return myCars; }
        public void Race(MyCar car)
        {
            myCars.Add(car);
            RacingCars++;
            Stopwatch eventTime = new Stopwatch();
            eventTime.Start();
            Console.WriteLine($"Tävlingen har börjat, {car.MyName} har lämnat startlinjen");
            while(car.MyDistance < 10000)
            {
                car.MyDistance += MySpeed;
                Thread.Sleep(1000);
                if (eventTime.Elapsed.TotalSeconds >= 8)
                {
                    RandoEvent.HandleEvent(car);
                    eventTime.Restart();
                }
            }
            eventTime.Stop();
            RacingCars--;
            if (RacingCars == 1)
            {
                car.MyPlacement = 1;
                Console.WriteLine($"{car.MyName} har vunnit!");
            }
            else
            {
                car.MyPlacement = 2;
                Console.WriteLine($"{car.MyName} har kommit i mål på {car.MyPlacement}:a plats! ");

            }
            if (RacingCars == 0)
            {
                Environment.Exit(0);
            }
        }
    }
}
