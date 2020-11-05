using LinqProblems.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Problem ");
            int number = int.Parse(Console.ReadLine());

            // Виклик статичного методу за номером
            typeof(Program).GetMethod($"Problem{number}")?.Invoke(null, null);

            Console.ReadKey();
        }

        #region Problem 1. Students by Group

        // Print all students from group number 2. Use LINQ. Order the students by FirstName
        public static void Problem1()
        {
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(inputs[0], inputs[1])
                {
                    GroupNumber = int.Parse(inputs[2])
                };
                students.Add(student);
            }

            students.Where(s => s.GroupNumber == 2)
                    .OrderBy(s => s.FirstName)
                    .ToList()
                    .ForEach(Console.WriteLine);
        }

        #endregion

        #region Problem 2. Students by First and Last Name

        // Using the same input as above print all students whose first name is before their
        // last name lexicographically. Use LINQ. Print them in order of appearance.
        public static void Problem2()
        {
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(inputs[0], inputs[1]);
                students.Add(student);
            }

            students.Where(s => string.Compare(s.FirstName, s.LastName) < 0)
                    .ToList()
                    .ForEach(Console.WriteLine);
        }

        #endregion

        #region Problem 3. Students by Age

        // Write a LINQ function that finds the first name and last name of all students
        // with age between 18 and 24. The query should return the first name, last name
        // and age. Print them in order of appearance.
        public static void Problem3()
        {
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(inputs[0], inputs[1])
                {
                    Age = int.Parse(inputs[2])
                };
                students.Add(student);
            }

            students.Where(s => s.Age >= 18 && s.Age <= 24)
                    .ToList()
                    .ForEach(s => Console.WriteLine($"{s} {s.Age}"));
        }

        #endregion

        #region Problem 4. Sort Students

        // Using the lambda expressions with LINQ syntax sort the students first
        // by last name in ascending order and then by first name in descending order.
        public static void Problem4()
        {
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(inputs[0], inputs[1]);
                students.Add(student);
            }

            students.OrderBy(s => s.LastName)
                    .ThenByDescending(s => s.FirstName)
                    .ToList()
                    .ForEach(Console.WriteLine);
        }

        #endregion

        #region Problem 5. Filter Students by Email Domain

        // Print all students that have email @gmail.com in the order of appearance. Use LINQ.
        public static void Problem5()
        {
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(inputs[0], inputs[1])
                {
                    Email = inputs[2]
                };
                students.Add(student);
            }

            students.Where(s => s.Email.EndsWith("@gmail.com"))
                    .ToList()
                    .ForEach(Console.WriteLine);
        }

        #endregion

        #region Problem 6. Filter Students by Phone

        // Print all students with phones starting with Sofia’s phone prefix
        // (starting with 02 / +3592). Use LINQ.
        public static void Problem6()
        {
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(inputs[0], inputs[1])
                {
                    Phone = inputs[2]
                };
                students.Add(student);
            }

            students.Where(s => s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592"))
                    .ToList()
                    .ForEach(Console.WriteLine);
        }

        #endregion

        #region Problem 7. Excellent Students

        // Print all students that have at least one mark Excellent(6). Use LINQ.
        public static void Problem7()
        {
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(inputs[0], inputs[1]);

                var marks = inputs.Skip(2)
                                  .Select(int.Parse)
                                  .ToList();

                student.Marks.AddRange(marks);
                students.Add(student);
            }

            students.Where(s => s.Marks.Contains(6))
                    .ToList()
                    .ForEach(Console.WriteLine);
        }

        #endregion

        #region Problem 8. Weak Students

        // Write a similar program to the previous one to extract
        // the students with at least 2 marks under or equal to "3". Use LINQ.
        public static void Problem8()
        {
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(inputs[0], inputs[1]);

                var marks = inputs.Skip(2)
                                  .Select(int.Parse)
                                  .ToList();

                student.Marks.AddRange(marks);
                students.Add(student);
            }

            students.Where(s => s.Marks.Count(m => m <= 3) >= 2)
                    .ToList()
                    .ForEach(Console.WriteLine);
        }

        #endregion

        #region Problem 9. Students Enrolled in 2014 or 2015

        // Using LINQ, extract and print the Marks of the students that enrolled in 2014 or 2015
        // (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber,
        // those from 2015 have 15).
        public static void Problem9()
        {
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(int.Parse(inputs[0]));

                var marks = inputs.Skip(1)
                                  .Select(int.Parse)
                                  .ToList();

                student.Marks.AddRange(marks);
                students.Add(student);
            }

            students
                .Where(s =>
                {
                    var digits = s.FacultyNumber.ToString().Skip(4).Take(2).ToArray();
                    string facNum = new string(digits);
                    return facNum == "14" || facNum == "15";
                })
                .Select(s => string.Join(' ', s.Marks))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        #endregion

        #region Problem 10. Group by Group

        // Write a program that extracts all students, grouped by GroupNumber
        // and then prints them on the console. Print all group numbers along with the
        // students in each group. Use the group by query in LINQ.
        public static void Problem10()
        {
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(inputs[0], inputs[1])
                {
                    GroupNumber = int.Parse(inputs[2])
                };
                students.Add(student);
            }

            students.GroupBy(s => s.GroupNumber)
                    .OrderBy(gr => gr.Key)
                    .ToList()
                    .ForEach(gr => Console.WriteLine($"{gr.Key} - {string.Join(", ", gr)}"));
        }

        #endregion

        #region Problem 11. Students Joined to Specialties

        // Print all student names alphabetically along with their faculty number
        // and specialty name. Use the "join" LINQ operator.
        public static void Problem11()
        {
            var specialties = new List<StudentSpecialty>();
            var students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Students:")
                    break;

                int index = line.LastIndexOf(' ');
                string name = new string(line.Take(index).ToArray());
                int facultyNumber = int.Parse(line.Split(name).Last());

                var specialty = new StudentSpecialty(name, facultyNumber);
                specialties.Add(specialty);
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                var inputs = line.Split(' ');
                var student = new Student(inputs[1], inputs[2])
                {
                    FacultyNumber = int.Parse(inputs[0])
                };
                students.Add(student);
            }

            students.OrderBy(st => st.FirstName)
                    .ThenBy(st => st.LastName)
                    .Join(specialties,
                          st => st.FacultyNumber,
                          sp => sp.FacultyNumber,
                          (st, sp) => new { Student = st, Specialty = sp })
                    .ToList()
                    .ForEach(j => Console.WriteLine($"{j.Student} {j.Specialty.FacultyNumber} {j.Specialty.Name}"));
        }

        #endregion

        #region Problem 12. Office Stuff

        // Write a program that prints all companies in alphabetical order.
        // For each company print the product type and their aggregated
        // ordered amounts. Order the products by order of appearance.
        public static void Problem12()
        {
            var orders = new List<CompanyOrder>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; ++i)
            {
                string line = Console.ReadLine();
                var inputs = new string(line.Skip(1).SkipLast(1).ToArray()).Split(" - ");

                var order = new CompanyOrder(inputs[0], int.Parse(inputs[1]), inputs[2]);
                orders.Add(order);
            }

            orders.GroupBy(or => or.Company)
                    .OrderBy(gr => gr.Key)
                    .ToList()
                    .ForEach(gr =>
                    {
                        var productLines = gr.GroupBy(or => or.Product)
                                            .Select(sgr => $"{sgr.Key} - {sgr.Sum(or => or.Amount)}");

                        Console.WriteLine($"{gr.Key}: {string.Join(", ", productLines)}");
                    });
        }

        #endregion
    }
}
