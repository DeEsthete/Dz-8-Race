using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            {
                List<Car> car = new List<Car>();
                Car carTemp1 = new Car("SAmens", 0, 1);
                car.Add(carTemp1);
                Car carTemp2 = new Car("BMW", 0, 3);
                car.Add(carTemp2);
                Car carTemp3 = new Car("GHT", 0, 2);
                car.Add(carTemp3);
                game.Car = car;
            }
            game.MethodGame();
            Console.ReadLine();
        }
    }
}
