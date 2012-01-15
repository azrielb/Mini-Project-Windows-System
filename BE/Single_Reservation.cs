using System;

namespace BE {
    public class Single_Reservation : Reservation {
        //Property
        public Room Room { get; set; }
        //Override Property
        public override uint Price { get { return Room.Price * Days; } }

        //Constructor
        public Single_Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, Room room, uint days = 1)
            : base(ID, agency, arrivalDate, days, room.Beds) {
            Room = room;
        }

        //Override function
        public override string ToString() {
            return string.Format("{0}\n{1}", base.ToString(), Room);
        }
    }
}
