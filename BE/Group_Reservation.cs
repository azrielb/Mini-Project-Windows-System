using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    class Group_Reservation : Reservation
    {
         //Field
        private List<Room> rooms;
        //Property
        //Override Property
        public override uint Price
        {
            get { return 0;/* (room.BedPrice == 0 ? room.Price : room.BedPrice) * days; */}
        }

        //Constructor
        public Group_Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, Room room, uint days = 1)
            : base(ID, agency, arrivalDate, days, 1)
        {
            //this.room = room;
        }

   }
}
