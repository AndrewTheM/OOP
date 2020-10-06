using System.Collections.Generic;

namespace HospitalManagement.Models
{
    public class Department
    {
        public const int RoomLimit = 20;

        public string Name { get; set; }

        public List<Room> Rooms { get; set; }

        public Department(string name)
        {
            Name = name;
            Rooms = new List<Room>();
        }

        public bool AnyRoomAvailable
            => Rooms.Count < RoomLimit || Rooms[RoomLimit - 1].AnyBedAvailable;
    }
}
