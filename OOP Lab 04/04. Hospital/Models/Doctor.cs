using System;
using System.Collections.Generic;

namespace HospitalManagement.Models
{
    public class Doctor : Person
    {
        private string surname;

        public string Surname
        {
            get => surname;
            set
            {
                if (value.Length <= 1 || value.Length > 20)
                    throw new ArgumentException("Surname must be 2-20 characters");
                surname = value;
            }
        }

        public List<Patient> Patients { get; }

        public Doctor(string name, string surname) : base(name)
        {
            Surname = surname;
            Patients = new List<Patient>();
        }

        public override string ToString()
            => $"{base.ToString()} {Surname}";
    }
}
