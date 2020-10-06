using System.Collections.Generic;

namespace HospitalManagement.Models
{
    public class Room
    {
        public const int BedsLimit = 3;

        public List<Patient> PatientsOnBeds { get; }

        public Room()
        {
            PatientsOnBeds = new List<Patient>();
        }

        public bool AnyBedAvailable => PatientsOnBeds.Count < BedsLimit;
    }
}
