using System;
using System.Runtime.Serialization;

namespace BE {
    [DataContract]
    public class Single_Reservation : Reservation {
        // Property
        [DataMember]
        public Room Room { get; set; }
        // Override Properties
        [DataMember]
        public override uint Price {
            get { return Room.Price * Days; }
            protected set { 
                //throw new NotImplementedException(); 
            }
        }
        [DataMember]
        public override uint Beds {
            get { return Room.Beds; }
            protected set { 
                //throw new NotImplementedException(); 
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">reservation ID</param>
        /// <param name="agency">Agency (The fields that are in use are agecyID and ContactPerson)</param>
        /// <param name="arrivalDate">arrival date</param>
        /// <param name="room">The room</param>
        /// <param name="days">the amount of days</param>
        /// <param name="reservationDate">reservation date, null is current date</param>
        public Single_Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, Room room, uint days = 1, DateTime? reservationDate = null)
            : base(ID, agency, arrivalDate, days, reservationDate) {
            Room = room;

        }

        // Override function
        public override string ToString() {
            return string.Format("{0}\n{1}", base.ToString(), Room);
        }
    }
}
