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
        public bool UpdateRoom(Room room) {
            return roomIsAvailable(room.RoomID, DateTime.Now) ? myDal.UpdateRoom(room) : false;
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
            var query = start == null
                ? end == null
                    ? from item in myDal.Reservations select item
                    : from item in myDal.Reservations where item.ArrivalDate <= end select item
                : end == null
                    ? from item in myDal.Reservations where item.LeavingDate >= start select item
                    : from item in myDal.Reservations where item.LeavingDate >= start where item.ArrivalDate <= end select item;
            foreach (var reservation in query) {
                if (reservation is Single_Reservation)
                    reservedRooms.Add(((Single_Reservation)reservation).Room.RoomID);
                else if (reservation is Group_Reservation<ICollection<Room>>)
                    reservedRooms.AddRange(from item in ((Group_Reservation<ICollection<Room>>)reservation).Rooms select item.RoomID);
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
        public bool UpdateAgency(Tour_Agency Agency) {
            if (!myDal.UpdateAgency(Agency)) return false;
            
            myDal.Reservations.ForEach(item => 
            {
                if (item.Agency.AgencyID == Agency.AgencyID)
                {
                    item.Agency = Agency;
                }
            });
            //myDal.Reservations.ForEach(delegate(Reservation item) {
            //    if (item.Agency.AgencyID == Agency.AgencyID)
            //        item.Agency = Agency;
            //});
            var x = (from item in myDal.Reservations
                    where item.Agency.AgencyID == Agency.AgencyID
                    select item);
            x.ToList().ForEach(item => item.Agency = Agency);
            return true;
        }
        public bool RemoveAgency(uint ID) {
            return !(myDal.Reservations.Exists(item => item.Agency.AgencyID == ID)) && myDal.RemoveAgency(ID);
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
        public bool UpdateReservation(Reservation reservation) {
            return myDal.UpdateReservation(reservation);
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
