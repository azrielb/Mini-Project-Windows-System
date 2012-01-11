using System;
using System.Collections.Generic;
using BE;

namespace PI {
    class Program {
        static void Main(string[] args) {
            BL.IBL<List<Room>, List<Tour_Agency>, List<Reservation>> myBL = BL.FactoryBL.getBL();
            myBL.AddRoom(new Room(myBL.NextRoomNumber, 3, 100));
            myBL.AddRoom(new Room(myBL.NextRoomNumber, 2, 300, RoomType.Suite, true));
            myBL.AddRoom(new Room(11, 2, 200, RoomType.Suite));
            myBL.AddRoom(new Room(myBL.NextRoomNumber, 3, 100, seaWatching: true));
            myBL.AddRoom(new Room(50, 1, 70));
            myBL.AddRoom(new Room(myBL.NextRoomNumber, 1, 200, RoomType.Suite, true));
            myBL.AddAgency(new Tour_Agency(myBL.NextAgencyNumber, "Reuven Tour LTD", "Reuven", AgencyType.in_hotel_chain_ownership));
            myBL.AddReservation(new Single_Reservation(myBL.NextReservationNumber, myBL.Agencies[0].AgencyID, DateTime.Today, myBL.Rooms[1], 3));
            myBL.Agencies[0] = new Tour_Agency(myBL.NextAgencyNumber, "Shimon Tour LTD", "Shimon", AgencyType.in_hotel_chain_ownership);
            myBL.AddReservation(new Group_Reservation<List<Room>>(myBL.NextReservationNumber, myBL.Agencies[0].AgencyID, DateTime.Today, myBL.Rooms));
            Console.WriteLine(myBL.Agencies[0]);
            Console.WriteLine();
            myBL.Reservations.ForEach(item => Console.WriteLine("{0}\n", item));
        }
    }
}
///
///
///