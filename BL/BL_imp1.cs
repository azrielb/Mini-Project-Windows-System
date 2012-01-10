using System;
using System.Collections.Generic;
using System.Linq;
using BE;

namespace BL {
    class BL_imp1 : IBL <List<Room>, List<Tour_Agency>, List<Reservation>> {
        public bool AddRoom(Room room) {
            throw new NotImplementedException();
        }
        public bool UpdateRoom(Room room) {
            throw new NotImplementedException();
        }
        public bool RemoveRoom(uint ID) {
            throw new NotImplementedException();
        }
        public List<Room> Rooms {
            get { throw new NotImplementedException(); }
        }
        public uint NextRoomNumber {
            get { throw new NotImplementedException(); }
        }
        public List<Room> availableRooms(DateTime start, DateTime end) {
            throw new NotImplementedException();
        }
        public List<Room> availableRooms(DateTime start, DateTime end, Func<Room, bool> predicate) {
            throw new NotImplementedException();
        }

        public bool AddAgency(Tour_Agency Agency) {
            throw new NotImplementedException();
        }

        public bool UpdateAgency(Tour_Agency Agency) {
            throw new NotImplementedException();
        }

        public bool RemoveAgency(uint ID) {
            throw new NotImplementedException();
        }

        public List<Tour_Agency> Agencies {
            get { throw new NotImplementedException(); }
        }

        public bool AddReservation(Reservation reservation) {
            throw new NotImplementedException();
        }

        public bool UpdateReservation(Reservation reservation) {
            throw new NotImplementedException();
        }

        public bool RemoveReservation(uint ID) {
            throw new NotImplementedException();
        }

        public List<Reservation> Reservations {
            get { throw new NotImplementedException(); }
        }

        public int ReservationsPrice {
            get { throw new NotImplementedException(); }
        }

        public int cancelReservations(DateTime start, DateTime end) {
            throw new NotImplementedException();
        }

    }
}
