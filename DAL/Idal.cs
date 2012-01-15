using System.Collections.Generic;
using BE;
using System;

namespace DAL {
    public interface Idal<RO, TO, RE>
        where RO : IEnumerable<Room>
        where TO : IEnumerable<Tour_Agency>
        where RE : IEnumerable<Reservation> {
        bool AddRoom(Room room);
        bool UpdateRoom(uint ID, uint Beds = 0, RoomType? Type = null, uint Price = 0);
        bool RemoveRoom(uint ID);
        RO Rooms { get; }

        bool AddAgency(Tour_Agency Agency);
        bool UpdateAgency(uint AgencyID, string Name = "", string ContactPerson = "");
        bool RemoveAgency(uint ID);
        TO Agencies { get; }

        bool AddReservation(Reservation reservation);
        bool UpdateReservation(uint ReservationID, DateTime? ArrivalDate = null, uint Days = 0);
        bool UpdateReservation(uint ReservationID, Room room, DateTime? ArrivalDate = null, uint Days = 0);
        bool UpdateReservation(uint ReservationID, RO rooms, DateTime? ArrivalDate = null, uint Days = 0);
        bool RemoveReservation(uint ID);
        RE Reservations { get; }
    }
}