using System;
using System.Collections.Generic;

namespace BE {
    public class Group_Reservation<T>
        : Reservation
        where T : ICollection<Room> {
        ///Properties
        public T Rooms { get; protected set; }
        //Override property
        public override uint Price {
            get {
                uint price = 0;
                foreach (Room room in Rooms)
                    price += room.Price * Days;
                return price;
            }
        }

        //Constructor
        public Group_Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, T rooms, uint days = 1)
            : base(ID, agency, arrivalDate, days, Room.calculateBeds(rooms)) {
            Rooms = rooms;
        }

        //Override function
        public override string ToString() {
            return string.Format("{0}\nRooms:\n{1}", base.ToString(), string.Join("\n", Rooms));
        }
    }
}
