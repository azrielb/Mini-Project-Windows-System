using System;
using System.Collections.Generic;

namespace BE {
    public enum RoomType { Regular, Suite }
    public class Room : IComparable {
        //Fields
        private readonly uint roomID;
        private uint beds;
        private RoomType type;
        private readonly bool seaWatching;
        private uint price;

        //Properties
        public uint RoomID {
            get { return roomID; }
        }
        public uint Beds {
            get { return beds; }
            //set { beds = value; }
        }
        public RoomType Type {
            get { return type; }
        }
        public bool SeaWatching {
            get { return seaWatching; }
        }
        public uint Price {
            get;
            private set;
        }
                         
        //Constructor
        public Room(uint ID, uint beds = 1, uint price = 100, RoomType type = RoomType.Regular, bool seaWatching = false) {
            this.beds = beds;
            this.type = type;
            this.seaWatching = seaWatching;
            Price = price;
            this.roomID = ID;
        }

        //Override function
        public override string ToString() {
            return String.Format("Room no. {0} is a {1}. It has {2} and it {3} the sea. Price: {4} NIS.",
                roomID, type, beds == 1 ? "one bed" : beds + " beds", seaWatching ? "watches" : "do not watch", price);
        }

        // Calculate how much beds exist in these rooms
        public static uint calculateBeds<T>(T rooms) where T : IEnumerable<Room> {
            uint beds = 0;
            foreach (Room room in rooms) {
                beds += room.beds;
            }
            return beds;
        }

        public int CompareTo(object obj) {
            if (obj is Room)
                return roomID.CompareTo(((Room)(obj)).roomID);
            else if (obj is int)
                return roomID.CompareTo(obj);
            else
                throw new ArgumentException("obj must be \"Room\"");
        }
    }
}
