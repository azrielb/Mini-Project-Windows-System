using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BE {
    [DataContract]
    public class Group_Reservation : Reservation {
        [DataMember]
        public List<Room> Rooms { get; set; }
        [DataMember]
        public override uint Beds {
            get { return Room.calculateBeds(Rooms); }
            protected set {
                //throw new NotImplementedException(); 
            }
        }
        // Override property
        [DataMember]
        public override uint Price {
            get {
                uint price = 0;
                foreach (Room room in Rooms)
                    price += room.Price * Days;
                return price;
            }
            protected set {
                //throw new NotImplementedException(); 
            }
        }

        /// <summary>
        /// Constructor - by days (default: one day)
        /// </summary>
        /// <param name="ID">reservation ID</param>
        /// <param name="agency">Agency (The fields that are in use are agecyID and ContactPerson)</param>
        /// <param name="arrivalDate">arrival date</param>
        /// <param name="myRooms">collection of rooms</param>
        /// <param name="days">the amount of days</param>
        /// <param name="reservationDate">reservation date, null is current date</param>
        public Group_Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, List<Room> rooms, uint days = 1, DateTime? reservationDate = null)
            : base(ID, agency, arrivalDate, days, reservationDate) {
            Rooms = rooms;
        }
        /// <summary>
        /// Constructor - by leaving date
        /// </summary>
        /// <param name="ID">reservation ID</param>
        /// <param name="agency">Agency (The fields that are in use are agecyID and ContactPerson)</param>
        /// <param name="arrivalDate">arrival date</param>
        /// <param name="myRooms">collection of rooms</param>
        /// <param name="leavingDate">leaving Date</param>
        /// <param name="reservationDate">reservation date, null is current date</param>
        public Group_Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, List<Room> rooms, DateTime leavingDate, DateTime? reservationDate = null)
            : base(ID, agency, arrivalDate, (uint)((leavingDate - arrivalDate).Days), reservationDate) {
            Rooms = rooms;
        }

        // Override function
        public override string ToString() {
            return string.Format("{0}\nRooms:\n{1}", base.ToString(), string.Join("\n", Rooms));
        }
    }
}
