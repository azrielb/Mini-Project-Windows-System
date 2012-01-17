using System;
using System.Collections.Generic;

namespace BE {
    public enum RoomType { Regular, Suite }

    public class Room : IComparable {
        // Properties
        public uint RoomID { get; private set; }
        public uint Beds { get; set; }
        public RoomType Type { get; set; }
        public bool SeaWatching { get; private set; }
        public uint Price { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">room id</param>
        /// <param name="beds">amount of beds in room</param>
        /// <param name="price">price for 1 day</param>
        /// <param name="type">Regular or Suite</param>
        /// <param name="seaWatching">the room watchs of the sea?</param>
        public Room(uint ID, uint beds = 1, uint price = 100, RoomType type = RoomType.Regular, bool seaWatching = false) {
            Beds = beds;
            Type = type;
            SeaWatching = seaWatching;
            Price = price;
            RoomID = ID;
        }

        // Override function
        public override string ToString() {
            return String.Format("Room no. {0} is a {1}. It has {2} and it {3} the sea. Price: {4} NIS.",
                RoomID, Type, Beds == 1 ? "one bed" : Beds + " beds", SeaWatching ? "watches" : "do not watch", Price);
        }

        /// <summary>
        /// Calculate how much beds exist in these rooms.
        /// </summary>
        /// <typeparam name="T">type of collection</typeparam>
        /// <param name="rooms">collection of rooms</param>
        /// <returns>amount of beds that exist in these rooms</returns>
        public static uint calculateBeds<T>(T rooms) where T : IEnumerable<Room> {
            uint beds = 0;
            foreach (Room room in rooms) {
                beds += room.Beds;
            }
            return beds;
        }

        /// <summary>
        /// room can be comapred with another room or with integer
        /// </summary>
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
