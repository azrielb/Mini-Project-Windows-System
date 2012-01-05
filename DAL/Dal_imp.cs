using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;


namespace DAL {
    public class Dal_imp : Idal<List<Room>, List<Tour_Agency>, List<Reservation>> {
        //Fields (this class does not have to have a constructor, because the all fields are initialized)
        private List<Room> rooms = new List<Room>();
        private List<Tour_Agency> agencies = new List<Tour_Agency>();
        private List<Reservation> reservations = new List<Reservation>();
        //Properties
        public List<Room> Rooms {
            get { return rooms.ToList(); }
        }
        public List<Tour_Agency> Agencies {
            get { return agencies.ToList(); }
        }
        public List<Reservation> Reservations {
            get { return reservations.ToList(); }
        }
        //Constructor

        //Implement functions of Idal
        public bool AddRoom(Room room) {
            if (rooms.Contains(room)) return false;
            rooms.Add(room);
            return rooms.Contains(room);
        }
        public bool UpdateRoom(Room room) {
            IEnumerable<Room> oldRooms = rooms.Where(item => item.RoomID == room.RoomID);
            if (oldRooms.Count() != 1)
                return false;
            oldRooms.Select(item => room);
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
        public bool UpdateAgency(Tour_Agency agency) {
            IEnumerable<Tour_Agency> oldAgencies = agencies.Where(item => item.AgencyID == agency.AgencyID);
            if (oldAgencies.Count() != 1)
                return false;
            oldAgencies.Select(item => agency);
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
        public bool UpdateReservation(Reservation reservation) {
            IEnumerable<Reservation> oldReservations = reservations.Where(item => item.ReservationID == reservation.ReservationID);
            if (oldReservations.Count() != 1)
                return false;
            oldReservations.Select(item => reservation);
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
