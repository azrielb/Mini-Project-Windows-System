using System;
using System.Collections.Generic;
using System.Linq;
using BE;

namespace BL {
    class BL_imp1 : IBL<List<Room>, List<Tour_Agency>, List<Reservation>> {
        //Fields
        private DAL.Idal<List<Room>, List<Tour_Agency>, List<Reservation>> myDal;
        private uint nextRoomNumber;
        private uint nextAgencyNumber;
        private uint nextReservationNumber;

        //Counstructor
        internal BL_imp1() {
            myDal = DAL.FactoryDAL.getDAL();
            nextRoomNumber = 1;
            nextAgencyNumber = 1;
            nextReservationNumber = 1;
        }

        //Implement functions and properties of IBL
        /// <summary>
        ///  Implement functions and properties of IBL
        /// </summary>
        /// <param name="room"> room ze cheder</param>
        /// <returns></returns>
        public bool AddRoom(Room room) {
            if (room.RoomID < nextRoomNumber || !myDal.AddRoom(room)) return false;
            nextRoomNumber = room.RoomID + 1;
            return true;
        }
        public bool UpdateRoom(uint ID, uint Beds = 0, RoomType? Type = null, uint Price = 0) {
            return roomIsAvailable(ID, DateTime.Now) ? myDal.UpdateRoom(ID, Beds, Type, Price) : false;
        }
        public bool RemoveRoom(uint ID) {
            return roomIsAvailable(ID, DateTime.Now) ? myDal.RemoveRoom(ID) : false;
        }
        public List<Room> Rooms {
            get { return myDal.Rooms; }
        }
        public uint NextRoomNumber {
            get { return nextRoomNumber; }
            set {
                if (nextRoomNumber < value)
                    nextRoomNumber = value;
            }
        }
        public IEnumerable<uint> reservedRooms(DateTime? start = null, DateTime? end = null) {
            List<uint> reservedRooms = new List<uint>();
            IEnumerable<Reservation> query;
            if (start.HasValue) {
                if (end.HasValue) {
                    query = from item in myDal.Reservations where item.LeavingDate >= start.Value where item.ArrivalDate <= end.Value select item;
                } else {
                    query = from item in myDal.Reservations where item.LeavingDate >= start.Value select item;
                }
            } else {
                if (end.HasValue) {
                    query = from item in myDal.Reservations where item.ArrivalDate <= end.Value select item;
                } else {
                    query = from item in myDal.Reservations select item;
                }
            }
            foreach (var reservation in query) {
                if (reservation is Single_Reservation)
                    reservedRooms.Add(((Single_Reservation)reservation).Room.RoomID);
                else if (reservation is Group_Reservation<IEnumerable<Room>>)
                    reservedRooms.AddRange(from item in ((Group_Reservation<IEnumerable<Room>>)reservation).Rooms select item.RoomID);
            }
            return reservedRooms.Distinct();
        }
        public List<Room> availableRooms(DateTime? start = null, DateTime? end = null, Predicate<Room> predicate = null) {
            List<Room> availableRooms = predicate == null ? myDal.Rooms : myDal.Rooms.FindAll(predicate);
            return availableRooms.FindAll(item => !(reservedRooms(start, end).Contains(item.RoomID)));
        }
        public bool roomIsAvailable(uint ID, DateTime? start = null, DateTime? end = null) {
            return !(reservedRooms(start, end).Contains(ID));
        }

        public bool AddAgency(Tour_Agency Agency) {
            if (Agency.AgencyID < nextAgencyNumber || !myDal.AddAgency(Agency)) return false;
            nextAgencyNumber = Agency.AgencyID + 1;
            return true;
        }
        public bool UpdateAgency(uint AgencyID, string Name = "", string ContactPerson = "") {
            if (!myDal.UpdateAgency(AgencyID, Name, ContactPerson)) return false;
            myDal.Reservations.ForEach(item => {
                if (item.AgencyID == AgencyID) {
                    item.ContactPerson = ContactPerson;
                }
            });
            return true;
        }
        public bool RemoveAgency(uint ID) {
            return !(myDal.Reservations.Exists(item => item.AgencyID == ID)) && myDal.RemoveAgency(ID);
        }
        public List<Tour_Agency> Agencies {
            get { return myDal.Agencies; }
        }
        public uint NextAgencyNumber {
            get { return nextAgencyNumber; }
            set {
                if (nextAgencyNumber < value)
                    nextAgencyNumber = value;
            }
        }

        public bool AddReservation(Reservation reservation) {
            if (reservation.ReservationID < nextReservationNumber || !myDal.AddReservation(reservation)) return false;
            nextReservationNumber = reservation.ReservationID + 1;
            return true;
        }
        public bool UpdateReservation(uint ReservationID, DateTime? ArrivalDate = null, uint Days = 0) {
            return myDal.UpdateReservation(ReservationID, ArrivalDate, Days);
        }
        public bool UpdateReservation(uint ReservationID, Room room, DateTime? ArrivalDate = null, uint Days = 0) {
            return myDal.UpdateReservation(ReservationID, room, ArrivalDate, Days);
        }
        public bool UpdateReservation(uint ReservationID, List<Room> rooms, DateTime? ArrivalDate = null, uint Days = 0) {
            return myDal.UpdateReservation(ReservationID, rooms, ArrivalDate, Days);
        }
        public bool RemoveReservation(uint ID) {
            return myDal.RemoveReservation(ID);
        }
        public List<Reservation> Reservations {
            get { return myDal.Reservations; }
        }
        public uint NextReservationNumber {
            get { return nextReservationNumber; }
            set {
                if (nextReservationNumber < value)
                    nextReservationNumber = value;
            }
        }
        public uint ReservationsPrice {
            get {
                uint reservationsPrice = 0;
                foreach (Reservation reservation in Reservations)
                    reservationsPrice += reservation.Price;
                return reservationsPrice;
            }
        }
        public uint cancelReservations(DateTime start, DateTime end) {
            uint canceled = 0;
            var query = from item in myDal.Reservations
                        where item.ReservationDate >= start
                        where item.ReservationDate <= end
                        select item.ReservationID;
            foreach (uint item in query)
                if (myDal.RemoveReservation(item))
                    ++canceled;
            return canceled;
        }
    }
}
