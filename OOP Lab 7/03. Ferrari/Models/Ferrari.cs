using System;

namespace ClassFerrari.Models
{
    public class Ferrari : ICar
    {
        private string model;
        private string driverName;

        public string Model
        {
            get => model;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Model cannot be empty.");
                model = value;
            }
        }

        public string DriverName
        {
            get => driverName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Driver name cannot be empty.");
                driverName = value;
            }
        }

        public Ferrari(string driverName)
        {
            Model = "488-Spider";
            DriverName = driverName;
        }

        public string UseBrakes() => "Brakes!";

        public string PushGasPedal() => "Zadu6avam sA!";
    }
}
