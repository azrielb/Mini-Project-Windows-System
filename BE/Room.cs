using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BE {
    [DataContract]
    public enum RoomType { 
        [EnumMember]
        Regular, 
        [EnumMember]
        Suite 
    }

    [DataContract]
    public class Room : IComparable {
        // Properties
        [DataMember]
        public uint RoomID { get; private set; }
        [DataMember]
        public uint Beds { get; set; }
        [DataMember]
        public RoomType Type { get; set; }
        [DataMember]
        public bool SeaWatching { get; private set; }
        [DataMember]
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
