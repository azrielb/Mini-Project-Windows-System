using System;
using System.Collections.Generic;
using BE;

namespace DAL {
    public interface Idal<RO, TO, RE>
        where RO : IEnumerable<Room>
        where TO : IEnumerable<Tour_Agency>
        where RE : IEnumerable<Reservation> {
        /// <summary>
        /// add a room to the collection
        /// </summary>
        /// <param name="room">room</param>
        /// <returns>true if success, false else</returns>
        bool AddRoom(Room room);
        /// <summary>
        /// updating room by parameters
        /// </summary>
        /// <param name="ID">room's ID</param>
        /// <param name="Beds">Beds - optional</param>
        /// <param name="Type">Room Type - optional</param>
        /// <param name="Price">Price - optional</param>
        /// <returns>true if success, false else</returns>
        bool UpdateRoom(uint ID, uint Beds = 0, RoomType? Type = null, uint Price = 0);
        /// <summary>
        /// remove a room from the collection
        /// </summary>
        /// <param name="ID">room's ID</param>
        /// <returns>true if success, false else</returns>
        bool RemoveRoom(uint ID);
        // property
        RO Rooms { get; }

        /// <summary>
        /// add an agency to the collection
        /// </summary>
        /// <param name="Agency">Agency</param>
        /// <returns>true if success, false else</returns>
        bool AddAgency(Tour_Agency Agency);
        /// <summary>
        /// updating an agency by parameters
        /// </summary>
        /// <param name="AgencyID">agency's ID</param>
        /// <param name="Name">agency's name - optional</param>
        /// <param name="ContactPerson">Contact person - optional</param>
        /// <returns>true if success, false else</returns>
        bool UpdateAgency(uint AgencyID, string Name = "", string ContactPerson = "");
        /// <summary>
        /// remove an agency from the collection
        /// </summary>
        /// <param name="ID">agency's ID</param>
        /// <returns>true if success, false else</returns>
        bool RemoveAgency(uint ID);
        // property
        TO Agencies { get; }

        /// <summary>
        /// add a reservation to the collection
        /// </summary>
        /// <param name="reservation">reservation</param>
        /// <returns>true if success, false else</returns>
        bool AddReservation(Reservation reservation);
        /// <summary>
        /// updating an agency by parameters
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="ArrivalDate">Arrival Date - optional</param>
        /// <param name="Days">Days - optional</param>
        /// <returns>true if success, false else</returns>
        bool UpdateReservation(uint ReservationID, DateTime? ArrivalDate = null, uint Days = 0);
        /// <summary>
        /// updating an agency by parameters
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="room">room - optional</param>
        /// <param name="ArrivalDate">Arrival Date - optional</param>
        /// <param name="Days">Days - optional</param>
        /// <returns>true if success, false else</returns>
        bool UpdateReservation(uint ReservationID, Room room, DateTime? ArrivalDate = null, uint Days = 0);
        /// <summary>
        /// updating an agency by parameters
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="rooms">collection of rooms - optional</param>
        /// <param name="ArrivalDate">Arrival Date - optional</param>
        /// <param name="Days">Days - optional</param>
        /// <returns>true if success, false else</returns>
        bool UpdateReservation(uint ReservationID, RO rooms, DateTime? ArrivalDate = null, uint Days = 0);
        /// <summary>
        /// remove a reservation from the collection
        /// </summary>
        /// <param name="ID">reservation's ID</param>
        /// <returns>true if success, false else</returns>
        bool RemoveReservation(uint ID);
        // property
        RE Reservations { get; }
    }
}