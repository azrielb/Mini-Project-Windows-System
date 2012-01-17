using System;

namespace BE {
    public class Single_Reservation : Reservation {
        // Property
        public Room Room { get; set; }
        // Override Properties
        public override uint Price { get { return Room.Price * Days; } }
        public override uint Beds { get { return Room.Beds; } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">reservation ID</param>
        /// <param name="agency">Agency (The fields that are in use are agecyID and ContactPerson)</param>
        /// <param name="arrivalDate">arrival date</param>
        /// <param name="room">The room</param>
        /// <param name="days">the amount of days</param>
        public Single_Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, Room room, uint days = 1)
            : base(ID, agency, arrivalDate, days) {
            Room = room;
            
        }

        // Override function
        public override string ToString() {
            return string.Format("{0}\n{1}", base.ToString(), Room);
        }

    }
}
