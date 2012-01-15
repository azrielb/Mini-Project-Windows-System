using System;
using System.Collections.Generic;
using BE;

namespace BL {
    public interface IBL<RO, TO, RE>
        where RO : IEnumerable<Room>
        where TO : IEnumerable<Tour_Agency>
        where RE : IEnumerable<Reservation> {
        bool AddRoom(Room room);
        bool UpdateRoom(uint ID, uint Beds = 0, RoomType? Type = null, uint Price = 0);
        bool RemoveRoom(uint ID);
        RO Rooms { get; }
        //Return the number of the next room - for auto-increment.
        uint NextRoomNumber { get; }
        //Return a collection of all rooms that are available between these dates, and suitable to the predicate.
        //All parameters are optional. The empty calling returns the rooms that available anytime.
        RO availableRooms(DateTime? start = null, DateTime? end = null, Predicate<Room> predicate = null);
        IEnumerable<uint> reservedRooms(DateTime? start = null, DateTime? end = null);
        bool roomIsAvailable(uint ID, DateTime? start = null, DateTime? end = null);

        bool AddAgency(Tour_Agency Agency);
        bool UpdateAgency(uint AgencyID, string Name = "", string ContactPerson = "");
        bool RemoveAgency(uint ID);
        TO Agencies { get; }
        //Return the number of the next agency - for auto-increment.
        uint NextAgencyNumber { get; }

        bool AddReservation(Reservation reservation);
        bool UpdateReservation(uint ReservationID, DateTime? ArrivalDate = null, uint Days = 0);
        bool UpdateReservation(uint ReservationID, Room room, DateTime? ArrivalDate = null, uint Days = 0);
        bool UpdateReservation(uint ReservationID, RO rooms, DateTime? ArrivalDate = null, uint Days = 0);
        bool RemoveReservation(uint ID);
        RE Reservations { get; }
        //Return the number of the next reservation - for auto-increment.
        uint NextReservationNumber { get; }
        //Calculate the price of the all erservations.
        uint ReservationsPrice { get; }
        //Cancel the all rservations between these dates. return the count of canceled rservations.
        uint cancelReservations(DateTime start, DateTime end);
    }
}