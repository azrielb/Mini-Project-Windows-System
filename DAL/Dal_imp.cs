using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using ABClasses;

namespace DAL {
    public class Dal_imp : Idal<List<Room>, List<Tour_Agency>, List<Reservation>> {
        private static Dal_imp singleton = new Dal_imp();
        internal static Dal_imp Singleton() {
            return singleton;
        }
        private Dal_imp() {}
        //Fields
        private List<Room> rooms = new List<Room>();
        private List<Tour_Agency> agencies = new List<Tour_Agency>();
        private List<Reservation> reservations = new List<Reservation>();
        //Properties
        public List<Room> Rooms {
            get { return rooms; }
        }
        public List<Tour_Agency> Agencies {
            get { return agencies; }
        }
        public List<Reservation> Reservations {
            get { return reservations; }
        }

        //Implement functions of Idal
        public bool AddRoom(Room room) {
            if (rooms.Contains(room)) return false;
            rooms.Add(room);
            return rooms.Contains(room);
        }
        public bool UpdateRoom(uint ID, uint Beds = 0, RoomType? Type = null, uint Price = 0) {
            var Room = rooms.Where(item => item.RoomID == ID);
            if (Room.Count() != 1)
                return false;
            Room.Update(item => {
                if (Beds > 0) item.Beds = Beds;
                if (Type.HasValue) item.Type = Type.Value;
                if (Price > 0) item.Price = Price;
            });
            return true;
        }
        public bool RemoveRoom(uint ID) {
            Room room = rooms.SingleOrDefault(item => item.RoomID == ID);
            if (room == null)
                return false;
            rooms.Remove(room);
            return true;
        }

        public bool AddAgency(Tour_Agency agency) {
            if (agencies.Contains(agency)) return false;
            agencies.Add(agency);
            return agencies.Contains(agency);
        }
        public bool UpdateAgency(uint ID, string Name = "", string ContactPerson = "") {
            var Agency = agencies.Where(item => item.AgencyID == ID);
            if (Agency.Count() != 1)
                return false;
            Agency.Update(item => {
                if (Name != "") item.Name = Name;
                if (ContactPerson != "") item.ContactPerson = ContactPerson;
            });
            return true;
        }
        public bool RemoveAgency(uint ID) {
            Tour_Agency agency = agencies.SingleOrDefault(item => item.AgencyID == ID);
            if (agency == null)
                return false;
            agencies.Remove(agency);
            return true;
        }

        public bool AddReservation(Reservation reservation) {
            if (reservations.Contains(reservation)) return false;
            reservations.Add(reservation);
            return reservations.Contains(reservation);
        }
        protected bool UpdateReservation(uint ReservationID, params Action<Reservation>[] updates) {
            var Reservation = reservations.Where(item => item.ReservationID == ReservationID);
            if (Reservation.Count() != 1)
                return false;
            Reservation.Update(updates);
            return true;
        }
        public bool UpdateReservation(uint ReservationID, DateTime? ArrivalDate = null, uint Days = 0) {
            UpdateReservation(ReservationID, item => {
                if (ArrivalDate.HasValue) item.ArrivalDate = ArrivalDate.Value;
                if (Days > 0) item.Days = Days;
            });
            return true;
        }
        public bool UpdateReservation(uint ReservationID, Room room, DateTime? ArrivalDate = null, uint Days = 0) {
            UpdateReservation(ReservationID, item => {
                if (!(item is Single_Reservation)) throw new ArgumentException("Reservation must be a Single_Reservation");
                (item as Single_Reservation).Room = room;
                if (ArrivalDate.HasValue) item.ArrivalDate = ArrivalDate.Value;
                if (Days > 0) item.Days = Days;
            });
            return true;
        }
        public bool UpdateReservation(uint ReservationID, List<Room> rooms, DateTime? ArrivalDate = null, uint Days = 0) {
            UpdateReservation(ReservationID, item => {
                if (!(item is Group_Reservation<List<Room>>)) throw new ArgumentException("Reservation must be a Group_Reservation");
                (item as Group_Reservation<List<Room>>).Rooms = rooms;
                if (ArrivalDate.HasValue) item.ArrivalDate = ArrivalDate.Value;
                if (Days > 0) item.Days = Days;
            });
            return true;
        }
        public bool RemoveReservation(uint ID) {
            Reservation reservation = reservations.SingleOrDefault(item => item.ReservationID == ID);
            if (reservation == null)
                return false;
            reservations.Remove(reservation);
            return true;
        }
    }
}
