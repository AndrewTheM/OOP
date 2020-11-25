using PetClinics.Helpers;
using PetClinics.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PetClinics.Collections
{
    public class Clinic : IEnumerable<Pet>
    {
        private string name;
        private readonly Pet[] roomsForPets;

        public Pet this[int roomNumber] => roomsForPets[roomNumber - 1];

        public string Name
        {
            get => name;
            set => name = PropertyCheck.StringNotEmpty(value, nameof(Name));
        }

        public bool HasEmptyRooms => roomsForPets.Any(p => p == null);

        public Clinic(string name, int roomsCount)
        {
            Name = name;

            if (roomsCount % 2 != 1)
                throw new ArgumentException("Invalid Operation!");

            roomsForPets = new Pet[roomsCount];
        }

        public bool Add(Pet pet)
        {
            int centralIndex = roomsForPets.Length / 2,
                step = 0;

            while (centralIndex + step >= 0 && centralIndex + step < roomsForPets.Length)
            {
                if (roomsForPets[centralIndex + step] == null)
                {
                    roomsForPets[centralIndex + step] = pet;
                    return true;
                }

                if (step > 0)
                    step = -(step + 1);
                else if (step < 0)
                    step *= -1;
                else
                    step = -1;
            }

            return false;
        }

        public bool Release()
        {
            int centralIndex = roomsForPets.Length / 2;

            for (int i = centralIndex; i < roomsForPets.Length; ++i)
                if (roomsForPets[i] != null)
                {
                    roomsForPets[i] = null;
                    return true;
                }

            for (int i = 0; i < centralIndex; ++i)
                if (roomsForPets[i] != null)
                {
                    roomsForPets[i] = null;
                    return true;
                }

            return false;
        }

        public IEnumerator<Pet> GetEnumerator()
        {
            foreach (var room in roomsForPets)
                yield return room;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
