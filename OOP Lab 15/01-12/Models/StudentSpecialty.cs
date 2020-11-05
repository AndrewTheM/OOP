namespace LinqProblems.Models
{
    public class StudentSpecialty
    {
        public string Name { get; set; }

        public int FacultyNumber { get; set; }

        public StudentSpecialty(string name, int facultyNumber)
        {
            Name = name;
            FacultyNumber = facultyNumber;
        }
    }
}
