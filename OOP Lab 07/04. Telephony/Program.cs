using System;
using System.Collections.Generic;
using Telephony.Models;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = new List<string>(Console.ReadLine().Split(' '));
            var urls = new List<string>(Console.ReadLine().Split(' '));

            Smartphone smartphone = new Smartphone();

            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    Console.WriteLine(smartphone.Call(phoneNumber));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(url));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
