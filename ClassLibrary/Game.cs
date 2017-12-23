using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Game
    {
        public List<Car> Car { get; set; }
        public int Finish { get; set; }
        public string Winner { get; set; }

        #region ctor
        public Game(List<Car> car)
        {
            Car = car;
            Winner = "-1";
            Finish = 100;
        }

        public Game()
        {
            Car = new List<Car>();
            Winner = "-1";
            Finish = 100;
        }
        #endregion

        #region Method
        public void MethodGame()
        {
            bool switchForWhile = true;
            while (switchForWhile)
            {
                for (int i = 0; i < Car.Count; i++)
                {
                    Car[i].Move();
                    Console.WriteLine(Car[i].Model + ": " + Car[i].Score);
                }
                for (int i = 0; i < Car.Count; i++)
                {
                    if (Car[i].Score >= Finish)
                    {
                        Winner = Car[i].Model;
                        switchForWhile = false;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Победитель: " + Winner);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
    }
}
