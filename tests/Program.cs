using System;
using System.Collections.Generic;


namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BE.Room> rooms = new List<BE.Room>();
            rooms.Add(new BE.Room(1, 3, 100));
            rooms.Add(new BE.Room(2, 2, 300, BE.RoomType.Suite, true));
            rooms.Add(new BE.Room(3, 2, 200, BE.RoomType.Suite));
            rooms.Add(new BE.Room(4, 3, 100, seaWatching: true));
            rooms.Add(new BE.Room(5, 1, 70));
            rooms.Add(new BE.Room(6, 1, 200, BE.RoomType.Suite, true));
            DAL.Dal_imp myDal = new DAL.Dal_imp();
            myDal.AddAgency(new BE.Tour_Agency(1, "Reuven Tour LTD", "Reuven", BE.AgencyType.in_hotel_chain_ownership));
            BE.Single_Reservation singleReservation = new BE.Single_Reservation(1, myDal.Agencies[0], DateTime.Today, rooms[1], 3);
            myDal.Agencies[0] = new BE.Tour_Agency(2, "Shimon Tour LTD", "Shimon", BE.AgencyType.in_hotel_chain_ownership);
            BE.Group_Reservation<List<BE.Room>> groupReservation = new BE.Group_Reservation<List<BE.Room>>(2, myDal.Agencies[0], DateTime.Today, rooms);
            Console.WriteLine(myDal.Agencies[0]);
            Console.WriteLine();
            Console.WriteLine(singleReservation);
            Console.WriteLine();
            Console.WriteLine(groupReservation);
        }
    }
}
