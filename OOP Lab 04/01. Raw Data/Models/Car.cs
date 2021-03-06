﻿namespace RawData.Models
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; }

        public Cargo Cargo { get; }

        public Tire[] Tires { get; }

        public Car(string model)
        {
            Model = model;
            Engine = new Engine();
            Cargo = new Cargo();
            Tires = new Tire[4]
            {
                new Tire(),
                new Tire(),
                new Tire(),
                new Tire()
            };
        }
    }
}
