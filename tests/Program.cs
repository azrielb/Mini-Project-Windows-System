using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            BE.Room room = new BE.Room(1,3,100,40);
            BE.Tour_Agency tourAgency = new BE.Tour_Agency(1, "Reuven Tour LTD", "Reuven", BE.AgencyType.in_hotel_chain_ownership);
            BE.Single_Reservation singleReservation = new BE.Single_Reservation(1, tourAgency, DateTime.Today, room);
            Console.WriteLine(room);
            Console.WriteLine(tourAgency);
            Console.WriteLine(singleReservation);
        }

    }
}
