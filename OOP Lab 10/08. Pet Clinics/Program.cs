using PetClinics.Collections;
using PetClinics.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetClinics
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<Pet>();
            var clinics = new List<Clinic>();

            int operationCount;
            while (!int.TryParse(Console.ReadLine(), out operationCount) || operationCount < 1)
                Console.WriteLine("Number of operations should be a positive integer.");

            for (int i = 0; i < operationCount; ++i)
            {
                try
                {
                    var inputs = Console.ReadLine().Split(' ');
                    string command = inputs[0];

                    switch (command)
                    {
                        case "Create":
                            {
                                string type = inputs[1],
                                        name = inputs[2];

                                if (type == nameof(Pet))
                                {
                                    if (pets.Any(p => p.Name == name))
                                        throw new ArgumentException("Pet with this name already exists.");

                                    int age = int.Parse(inputs[3]);
                                    string kind = inputs[4];
                                    var pet = new Pet(name, age, kind);
                                    pets.Add(pet);
                                }
                                else if (type == nameof(Clinic))
                                {
                                    if (clinics.Any(c => c.Name == name))
                                        throw new ArgumentException("Clinic with this name already exists.");

                                    int rooms = int.Parse(inputs[3]);
                                    var clinic = new Clinic(name, rooms);
                                    clinics.Add(clinic);
                                }
                                else
                                    throw new ArgumentException("Invalid type of Create command.");

                                break;
                            }
                        case "Add":
                            {
                                string petName = inputs[1],
                                        clinicName = inputs[2];

                                var pet = pets.SingleOrDefault(p => p.Name == petName);
                                if (pet == null)
                                    throw new ArgumentException("This pet does not exist.");

                                var clinic = FindClinicbyName(clinicName, clinics);
                                bool added = clinic.Add(pet);
                                Console.WriteLine(added);
                                break;
                            }
                        case "Release":
                            {
                                string clinicName = inputs[1];
                                var clinic = FindClinicbyName(clinicName, clinics);

                                bool released = clinic.Release();
                                Console.WriteLine(released);
                                break;
                            }
                        case "HasEmptyRooms":
                            {
                                string clinicName = inputs[1];
                                var clinic = FindClinicbyName(clinicName, clinics);

                                Console.WriteLine(clinic.HasEmptyRooms);
                                break;
                            }
                        case "Print":
                            {
                                string clinicName = inputs[1];
                                var clinic = FindClinicbyName(clinicName, clinics);

                                if (inputs.Length == 2)
                                {
                                    foreach (var roomPet in clinic)
                                        if (roomPet == null)
                                            Console.WriteLine("Room is empty");
                                        else
                                            Console.WriteLine(roomPet);
                                }
                                else if (inputs.Length == 3)
                                {
                                    int roomNumber = int.Parse(inputs[2]);
                                    var roomPet = clinic[roomNumber];

                                    if (roomPet == null)
                                        Console.WriteLine("Room is empty");
                                    else
                                        Console.WriteLine(roomPet);
                                }

                                break;
                            }
                        default: throw new InvalidOperationException("Invalid command.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    --i;
                }
            }

            Console.ReadKey();
        }

        static Clinic FindClinicbyName(string name, List<Clinic> clinics)
        {
            var clinic = clinics.SingleOrDefault(c => c.Name == name);
            if (clinic == null)
                throw new ArgumentException("This clinic does not exist.");
            return clinic;
        }
    }
}
