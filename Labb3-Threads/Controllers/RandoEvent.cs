using Labb3_Threads.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Threads.Controllers
{
    internal static class RandoEvent
    {
        public static void HandleEvent(MyCar car)
        {
            int speed = car.MySpeed;
            Random rando = new Random();
            int checkEvent = rando.Next(1, 51);
            if (checkEvent <= 10)
            {
                Console.WriteLine($"{car.MyName} har fått motorproblem och saktar ner lite");
                car.MySpeed--;
            }
            else if (checkEvent > 10 && checkEvent <= 15)
            {
                Console.WriteLine($"{car.MyName} har fått kört på en fågel och behöver stanna");
                car.MySpeed = 0;
                Thread.Sleep(10 *1000);
                car.MySpeed = speed;

            }
            else if (checkEvent > 15 && checkEvent <= 17)
            {
                Console.WriteLine($"{car.MyName} har fått punktering och måste byta däck");
                car.MySpeed = 0;
                Thread.Sleep(20*1000);
                car.MySpeed = speed;
            }
            else if (checkEvent == 50)
            {
                Console.WriteLine($"{car.MyName} har fått slut på bensin och måste tanka");
                car.MySpeed = 0;
                Thread.Sleep(30*1000);
                car.MySpeed = speed;

            }
        }
    }
}
