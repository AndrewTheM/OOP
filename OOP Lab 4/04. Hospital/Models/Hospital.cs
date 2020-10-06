using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Models
{
    public class Hospital
    {
        public List<Department> Departments { get; }

        public Hospital()
        {
            Departments = new List<Department>();
        }

        public void RegisterPatient(string patientName, string departmentName)
        {
            var department = Departments.Find(d => d.Name == departmentName);

            if (department == null)
                throw new ArgumentException($"Department \"{departmentName}\" was not found in the system.");


        }
    }
}
