using System;
using System.Collections.Generic;
using BE;

namespace tests {
    class Program {
        static void Main(string[] args) {
            DAL.Dal_imp myDal = new DAL.Dal_imp();
            myDal.AddRoom(new Room(1, 3, 100));
            myDal.AddRoom(new Room(2, 2, 300, RoomType.Suite, true));
            myDal.AddRoom(new Room(3, 2, 200, RoomType.Suite));
            myDal.AddRoom(new Room(4, 3, 100, seaWatching: true));
            myDal.AddRoom(new Room(5, 1, 70));
            myDal.AddRoom(new Room(6, 1, 200, RoomType.Suite, true));
            myDal.AddAgency(new Tour_Agency(1, "Reuven Tour LTD", "Reuven", AgencyType.in_hotel_chain_ownership));
            myDal.AddReservation(new Single_Reservation(1, myDal.Agencies[0], DateTime.Today, myDal.Rooms[1], 3));
            myDal.Agencies[0] = new Tour_Agency(2, "Shimon Tour LTD", "Shimon", AgencyType.in_hotel_chain_ownership);
            myDal.AddReservation(new Group_Reservation<List<Room>>(2, myDal.Agencies[0], DateTime.Today, myDal.Rooms));
            Console.WriteLine(myDal.Agencies[0]);
            Console.WriteLine();
            myDal.Reservations.ForEach(item => Console.WriteLine("{0}\n", item));
        }
    }
}