using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Car
    {
        public string Model { get; set; }
        public int Score { get; set; }
        public int Speed { get; set; }

        #region ctor
        public Car(string model, int score, int speed)
        {
            Model = model;
            Score = score;
            Speed = speed;
        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public Car()
        {
            Score = 0;
        }
        #endregion
        #region Method
        public void Move()
        {
            Score = Score + Speed;
        }
        #endregion
    }
}
