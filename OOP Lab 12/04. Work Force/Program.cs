using System;
using System.Collections.Generic;
using System.Linq;
using WorkForce.Collections;
using WorkForce.Models;

namespace WorkForce
{
    class Program
    {
        static void Main(string[] args)
        {
            var jobs = new JobList();
            var employees = new List<Employee>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                try
                {
                    var inputs = line.Split(' ');
                    string command = inputs[0];

                    switch (command)
                    {
                        case nameof(Job):
                            {
                                string name = inputs[1];
                                int hours = int.Parse(inputs[2]);
                                string employeeName = inputs[3];

                                var employee = employees.SingleOrDefault(e => e.Name == employeeName);
                                if (employee == null)
                                    throw new Exception($"Employee {employeeName} could not be found.");

                                var job = new Job(name, hours, employee);
                                jobs.Add(job);
                                break;
                            }
                        case nameof(StandardEmployee):
                            {
                                var employee = new StandardEmployee(inputs[1]);
                                employees.Add(employee);
                                break;
                            }
                        case nameof(PartTimeEmployee):
                            {
                                var employee = new PartTimeEmployee(inputs[1]);
                                employees.Add(employee);
                                break;
                            }
                        case "Pass":
                            {
                                if (inputs[1] == "Week")
                                    jobs.RequireUpdate();
                                else
                                    throw new Exception("Invalid period.");

                                break;
                            }
                        case "Status":
                            {
                                jobs.ForEach(j => Console.WriteLine($"Job: {j.Name} " +
                                                        $"Hours Remaining: {j.HoursRequired}"));
                                break;
                            }
                        default: throw new Exception("Invalid command.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
