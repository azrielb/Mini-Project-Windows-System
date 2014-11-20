using System;
using System.Collections.Generic;
using System.Linq;
using ABClasses;
using BE;

namespace DAL {
    public class Dal_imp : Idal<List<Room>, List<Tour_Agency>, List<Reservation>> {
        /// <summary>
        /// singleton
        /// </summary>
        private static Dal_imp singleton = new Dal_imp();
        /// <summary>
        /// singleton. this is internal because the class have to be created by a factory.
        /// </summary>
        internal static Dal_imp Singleton { get { return singleton; } }

        /// <summary>
        /// private constructor - for singleton
        /// </summary>
        private Dal_imp() {
            Rooms = new List<Room>();
            Agencies = new List<Tour_Agency>();
            Reservations = new List<Reservation>();
        }
        // Properties
        public List<Room> Rooms { get; private set; }
        public List<Tour_Agency> Agencies { get; private set; }
        public List<Reservation> Reservations { get; private set; }

        // Implement functions of Idal
        /// <summary>
        /// add a room to the collection
        /// </summary>
        /// <param name="room">room</param>
        /// <returns>true if success, false else</returns>
        public bool AddRoom(Room room) {
            if (Rooms.Contains(room)) return false;
            Rooms.Add(room);
            return Rooms.Contains(room);
        }
        /// <summary>
        /// updating room by parameters
        /// </summary>
        /// <param name="ID">room's ID</param>
        /// <param name="Beds">Beds - optional</param>
        /// <param name="Type">Room Type - optional</param>
        /// <param name="Price">Price - optional</param>
        /// <returns>true if success, false else</returns>
        public bool UpdateRoom(uint ID, uint Beds = 0, RoomType? Type = null, uint Price = 0) {
            var Room = Rooms.Where(item => item.RoomID == ID);
            if (Room.Count() != 1)
                return false;
            Room.Update(item => {
                if (Beds > 0) item.Beds = Beds;
                if (Type.HasValue) item.Type = Type.Value;
                if (Price > 0) item.Price = Price;
            });
            return true;
        }
        /// <summary>
        /// remove a room from the collection
        /// </summary>
        /// <param name="ID">room's ID</param>
        /// <returns>true if success, false else</returns>
        public bool RemoveRoom(uint ID) {
            Room room = Rooms.SingleOrDefault(item => item.RoomID == ID);
            if (room == null)
                return false;
            Rooms.Remove(room);
            return true;
        }

        /// <summary>
        /// add an agency to the collection
        /// </summary>
        /// <param name="agency">agency</param>
        /// <returns>true if success, false else</returns>
        public bool AddAgency(Tour_Agency agency) {
            if (Agencies.Contains(agency)) return false;
            Agencies.Add(agency);
            return Agencies.Contains(agency);
        }
        /// <summary>
        /// updating an agency by parameters
        /// </summary>
        /// <param name="ID">agency's ID</param>
        /// <param name="Name">agency's name - optional</param>
        /// <param name="ContactPerson">Contact person - optional</param>
        /// <returns>true if success, false else</returns>
        public bool UpdateAgency(uint ID, string Name = "", string ContactPerson = "") {
            var Agency = Agencies.Where(item => item.AgencyID == ID);
            if (Agency.Count() != 1)
                return false;
            Agency.Update(item => {
                if (Name != "") item.Name = Name;
                if (ContactPerson != "") item.ContactPerson = ContactPerson;
            });
            return true;
        }
        /// <summary>
        /// remove an agency from the collection
        /// </summary>
        /// <param name="ID">agency's ID</param>
        /// <returns>true if success, false else</returns>
        public bool RemoveAgency(uint ID) {
            Tour_Agency agency = Agencies.SingleOrDefault(item => item.AgencyID == ID);
            if (agency == null)
                return false;
            Agencies.Remove(agency);
            return true;
        }

        /// <summary>
        /// add a reservation to the collection
        /// </summary>
        /// <param name="reservation">reservation</param>
        /// <returns>true if success, false else</returns>
        public bool AddReservation(Reservation reservation) {
            if (Reservations.Contains(reservation)) return false;
            Reservations.Add(reservation);
            return Reservations.Contains(reservation);
        }
        /// <summary>
        /// updating a reservation by functions
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="updates">some functions (at least one, or an array of functions) that get Reservation and return void (they can be lambda expressions)</param>
        /// <returns>true if success, false else</returns>
        protected bool UpdateReservation(uint ReservationID, params Action<Reservation>[] updates) {
            var Reservation = Reservations.Where(item => item.ReservationID == ReservationID);
            if (Reservation.Count() != 1)
                return false;
            Reservation.Update(updates);
            return true;
        }
        /// <summary>
        /// updating a reservation by parameters
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="ArrivalDate">Arrival Date - optional</param>
        /// <param name="Days">Days - optional</param>
        /// <returns>true if success, false else</returns>
        public bool UpdateReservation(uint ReservationID, DateTime? ArrivalDate = null, uint Days = 1) {
            return UpdateReservation(ReservationID, item => {
                if (ArrivalDate.HasValue) item.ArrivalDate = ArrivalDate.Value;
                if (Days > 0) item.Days = Days;
            });
        }
        /// <summary>
        /// updating a reservation by parameters
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="room">room - optional</param>
        /// <param name="ArrivalDate">Arrival Date - optional</param>
        /// <param name="Days">Days - optional</param>
        /// <returns>true if success, false else</returns>
        public bool UpdateReservation(uint ReservationID, Room room, DateTime? ArrivalDate = null, uint Days = 1) {
            return UpdateReservation(ReservationID, item => {
                if (!(item is Single_Reservation)) throw new ArgumentException("Reservation must be a Single_Reservation");
                (item as Single_Reservation).Room = room;
                if (ArrivalDate.HasValue) item.ArrivalDate = ArrivalDate.Value;
                if (Days > 0) item.Days = Days;
            });
        }
        /// <summary>
        /// updating a reservation by parameters
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="rooms">collection of rooms - optional</param>
        /// <param name="ArrivalDate">Arrival Date - optional</param>
        /// <param name="Days">Days - optional</param>
        /// <returns>true if success, false else</returns>
        public bool UpdateReservation(uint ReservationID, List<Room> rooms, DateTime? ArrivalDate = null, uint Days = 1) {
            return UpdateReservation(ReservationID, item => {
                if (!(item is Group_Reservation)) throw new ArgumentException("Reservation must be a Group_Reservation");
                (item as Group_Reservation).Rooms = rooms;
                if (ArrivalDate.HasValue) item.ArrivalDate = ArrivalDate.Value;
                if (Days > 0) item.Days = Days;
            });
        }
        /// <summary>
        /// remove a reservation from the collection
        /// </summary>
        /// <param name="ID">reservation's ID</param>
        /// <returns>true if success, false else</returns>
        public bool RemoveReservation(uint ID) {
            Reservation reservation = Reservations.SingleOrDefault(item => item.ReservationID == ID);
            if (reservation == null)
                return false;
            Reservations.Remove(reservation);
            return true;
        }
    }
}
