using System;

namespace BorderControl.Models
{
    public class Robot : IIdentifiable
    {
        private string model;
        private string id;

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

        public string Id
        {
            get => id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Id cannot be empty.");
                id = value;
            }
        }

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}
