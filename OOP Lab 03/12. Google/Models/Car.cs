﻿namespace Google.Models
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

        public override string ToString()
            => $"{Model} {Speed}";
    }
}
