using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.Models
{
   public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed(Driver objecet )
        {
            int score;
            score = objecet.Skill * Speed;
            return score;
        }
    }
}
