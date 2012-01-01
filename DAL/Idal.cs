using System.Collections.Generic;
using BE;

namespace DAL
{
    public interface Idal<RO, TO, RE>
        where RO : IEnumerable<Room>
        where TO : IEnumerable<Tour_Agency>
        where RE : IEnumerable<Reservation>
    {
        bool AddRoom(Room room);
        bool UpdateRoom(Room room);
        bool RemoveRoom(uint ID);
        RO Rooms { get; }

        bool AddAgency(Tour_Agency Agency);
        bool UpdateAgency(Tour_Agency Agency);
        bool RemoveAgency(uint ID);
        TO Agencies { get; }

        bool AddReservation(Reservation reservation);
        bool UpdateReservation(Reservation reservation);
        bool RemoveReservation(uint ID);
        RE Reservations { get; }
    }
}
