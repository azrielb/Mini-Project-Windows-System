using System;
using System.Collections.Generic;
using BE;

namespace BL {
    public interface IBL<RO, TO, RE>
        where RO : IEnumerable<Room>
        where TO : IEnumerable<Tour_Agency>
        where RE : IEnumerable<Reservation> {
        bool AddRoom(Room room);
        bool UpdateRoom(Room room);
        bool RemoveRoom(uint ID);
        RO Rooms { get; }
        //Return the number of the next room - for auto-increment.
        uint NextRoomNumber { get; }

        //Return a collection of all rooms that are available between these dates.
        RO availableRooms(DateTime start, DateTime end);
        //Return a collection of all rooms that are available between these dates, and suitable to the predicate.
        RO availableRooms(DateTime start, DateTime end, Func<Room, bool> predicate);

        bool AddAgency(Tour_Agency Agency);
        bool UpdateAgency(Tour_Agency Agency);
        bool RemoveAgency(uint ID);
        TO Agencies { get; }

        bool AddReservation(Reservation reservation);
        bool UpdateReservation(Reservation reservation);
        bool RemoveReservation(uint ID);
        RE Reservations { get; }
        //Calculate the price of the all erservations.
        int ReservationsPrice { get; }
        //Cancel the all rservations between these dates. return the count of canceled rservations, or negative number when failure
        int cancelReservations(DateTime start, DateTime end);


        //More 2 functions...

    }
}