using System;
using System.Collections.Generic;

namespace BE {
    public class Group_Reservation<T>
        : Reservation
        where T : IEnumerable<Room> {
        //Field
        protected T rooms;

        ///Properties
        public T Rooms {
            get { return rooms; }
        }
        //Read-only indexer
        public Room this[int indexer] {
            get {
                foreach (Room room in rooms) {
                    if (--indexer == -1) return room;
                }
                return null;
            }
        }
        //Override property
        public override uint Price {
            get {
                uint price = 0;
                foreach (Room room in rooms)
                    price += room.Price * days;
                return price;
            }
        }

        //Constructor
        public Group_Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, T rooms, uint days = 1)
            : base(ID, agency, arrivalDate, days, Room.calculateBeds(rooms)) {
            this.rooms = rooms;
        }

        //Override function
        public override string ToString() {
            return string.Format("{0}\nRooms:\n{1}", base.ToString(), string.Join("\n", rooms));
        }

    }
}
