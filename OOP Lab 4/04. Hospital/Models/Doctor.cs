namespace HospitalManagement.Models
{
    public class Doctor : Person
    {
        public string Surname { get; set; }

        public Doctor(string name, string surname) : base(name)
        {
            Surname = surname;
        }
    }
}
