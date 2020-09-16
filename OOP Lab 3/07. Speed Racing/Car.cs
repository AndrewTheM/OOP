using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Car
    {
        //private static List<string> takenModels = new List<string>();

        //private string model;

        //public string Model
        //{
        //    get => model;
        //    set
        //    {
        //        if (takenModels.Contains(value))
        //            throw new ArgumentException($"Model {value} already exists");

        //        model = value;
        //        takenModels.Add(model);
        //    }
        //}

        public string Model { get; set; }
        
        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public int DistanceTraveled { get; private set; }


        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumption;
        }

        public bool HasEnoughFuelToMove(int kilometers)
            => kilometers * FuelConsumptionPerKm <= FuelAmount;

        public void Drive(int kilometers)
        {
            FuelAmount -= kilometers * FuelConsumptionPerKm;
            DistanceTraveled += kilometers;
        }
    }
}
