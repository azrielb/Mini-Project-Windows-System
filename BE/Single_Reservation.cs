using System;

namespace BE {
    public class Single_Reservation : Reservation {
        //Field
        private Room room;
        //Property
        public Room Room {
            get { return room; }
            //set { room = value; }
        }
        //Override Property
        public override uint Price {
            get { return room.Price * Days; }
        }

        //Constructor
        public Single_Reservation(uint ID, uint agencyID, DateTime arrivalDate, Room room, uint days = 1)
            : base(ID, agencyID, arrivalDate, days, room.Beds) {
            this.room = room;
        }

        //Override function
        public override string ToString() {
            return string.Format("{0}\n{1}", base.ToString(), room);
        }
    }
}
