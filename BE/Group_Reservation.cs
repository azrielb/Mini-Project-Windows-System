using System;
using System.Collections.Generic;

namespace BE {
    public class Group_Reservation<T>
        : Reservation
        where T : ICollection<Room> {
        //Field
        private T rooms;

        ///Properties
        public T Rooms {
            get { return rooms; }
            set {
                rooms = value;
                Beds = Room.calculateBeds<T>(rooms);
            }
        }
        //Override property
        public override uint Price {
            get {
                uint price = 0;
                foreach (Room room in rooms)
                    price += room.Price * Days;
                return price;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">reservation ID</param>
        /// <param name="agency">Agency (The fields that are in use are agecyID and ContactPerson)</param>
        /// <param name="arrivalDate">arrival date</param>
        /// <param name="myRooms">collection of rooms</param>
        /// <param name="days">the amount of days</param>
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
