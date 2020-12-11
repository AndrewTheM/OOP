using Mankind.Models;
using System;

namespace Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var studentInputs = Console.ReadLine().Split(' ');
                var workerInputs = Console.ReadLine().Split(' ');

                string studentFirstName = studentInputs[0];
                string studentLastName = studentInputs[1];
                string studentFacultyNumber = studentInputs[2];

                string workerFirstName = workerInputs[0];
                string workerLastName = workerInputs[1];
                decimal workerSalary = decimal.Parse(workerInputs[2].Replace('.', ','));
                int workerHoursPerDay = int.Parse(workerInputs[3]);

                Student student = new Student(studentFirstName, studentLastName, studentFacultyNumber);
                Worker worker = new Worker(workerFirstName, workerLastName, workerSalary, workerHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
