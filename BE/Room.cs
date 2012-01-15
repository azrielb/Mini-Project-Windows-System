using System;
using System.Collections.Generic;

namespace BE {
    public enum RoomType { Regular, Suite }

    public class Room : IComparable {
        //Properties
        public uint RoomID { get; private set; }
        public uint Beds { get; set; }
        public RoomType Type { get; set; }
        public bool SeaWatching { get; private set; }
        public uint Price { get; private set; }

        //Constructor
        public Room(uint ID, uint beds = 1, uint price = 100, RoomType type = RoomType.Regular, bool seaWatching = false) {
            Beds = beds;
            Type = type;
            SeaWatching = seaWatching;
            Price = price;
            RoomID = ID;
        }

        //Override function
        public override string ToString() {
            return String.Format("Room no. {0} is a {1}. It has {2} and it {3} the sea. Price: {4} NIS.",
                RoomID, Type, Beds == 1 ? "one bed" : Beds + " beds", SeaWatching ? "watches" : "do not watch", Price);
        }

        // Calculate how much beds exist in these rooms
        public static uint calculateBeds<T>(T rooms) where T : ICollection<Room> {
            uint beds = 0;
            foreach (Room room in rooms) {
                beds += room.Beds;
            }
            return beds;
        }

        public int CompareTo(object obj) {
            if (obj is Room)
                return RoomID.CompareTo(((Room)(obj)).RoomID);
            else if (obj is int)
                return RoomID.CompareTo(obj);
            else
                throw new ArgumentException("obj must be \"Room\"");
        }
    }
}
