//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Xml.Linq;
//using ABClasses;
//using BE;

//namespace DAL {
//    class Dal_XML_imp : Idal<List<Room>, List<Tour_Agency>, List<Reservation>> {
//        /// <summary>
//        /// singleton
//        /// </summary>
//        private static Dal_XML_imp singleton = new Dal_XML_imp();
//        /// <summary>
//        /// singleton. this is internal because the class have to be created by a factory.
//        /// </summary>
//        internal static Dal_XML_imp Singleton { get { return singleton; } }
//        // Fields
//        //private List<Room> rooms;
//        //private List<Tour_Agency> agencies;
//        //private List<Reservation> reservations;
//        private readonly string roomsPath = @"Xrooms.xml";
//        private readonly string agenciesPath = @"Xagencies.xml";
//        private readonly string reservationsPath = @"Xreservations.xml";
//        private XElement Xrooms;
//        private XElement Xagencies;
//        private XElement Xreservations;
//        /// <summary>
//        /// private constructor - for singleton
//        /// </summary>
//        private Dal_XML_imp() {
//            Xrooms = File.Exists(roomsPath) ? loadData<Room>(roomsPath) : new XElement("Rooms");
//            Xagencies = File.Exists(agenciesPath) ? loadData<Tour_Agency>(agenciesPath) : new XElement("Agencies");
//            Xreservations = File.Exists(reservationsPath) ? loadData<Reservation>(reservationsPath) : new XElement("Reservations");
//            //rooms = xmlTOList<Room>(Xrooms);
//            //agencies = xmlTOList<Tour_Agency>(Xagencies);
//            //reservations = xmlTOList<Reservation>(Xreservations);
//        }

//        private List<T> xmlTOList<T>(XElement src) {
//            throw new NotImplementedException();
//        }

//        private XElement loadData<T>(string FPath) {
//            throw new NotImplementedException();
//        }

//        // Properties
//        public List<Room> Rooms {
//            get { return xmlTOList<Room>(Xrooms); }
//        }
//        public List<Tour_Agency> Agencies {
//            get { return xmlTOList<Tour_Agency>(Xagencies); }
//        }
//        public List<Reservation> Reservations {
//            get { return xmlTOList<Reservation>(Xreservations); }
//        }

//        // Implement functions of Idal
//        /// <summary>
//        /// add a room to the collection
//        /// </summary>
//        /// <param name="room">room</param>
//        /// <returns>true if success, false else</returns>
//        public bool AddRoom(Room room) {
//            if ((from item in Xrooms.Elements() where (item.Element("id").Value == room.RoomID.ToString()) select item).Count() > 0)
//                return false;
//            try {
//                Xrooms.Add(new XElement("room", room.ToXML()));
//                Xrooms.Save(roomsPath);
//            } catch {
//                return false;
//            }
//            return true;
//        }
//        /// <summary>
//        /// updating room by parameters
//        /// </summary>
//        /// <param name="ID">room's ID</param>
//        /// <param name="Beds">Beds - optional</param>
//        /// <param name="Type">Room Type - optional</param>
//        /// <param name="Price">Price - optional</param>
//        /// <returns>true if success, false else</returns>
//        public bool UpdateRoom(uint ID, uint Beds = 0, RoomType? Type = null, uint Price = 0) {
//            XElement roomToUpdate = (from item in Xrooms.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
//            if (roomToUpdate == null)
//                return false;
//            try {
//                if (Beds > 0) roomToUpdate.Element("Beds").Value = Beds.ToString();
//                if (Type.HasValue) roomToUpdate.Element("Type").Value = Type.ToString();
//                if (Price > 0) roomToUpdate.Element("Price").Value = Price.ToString();
//                Xrooms.Save(roomsPath);
//                return true;
//            } catch {
//                return false;
//            }
//        }
//        /// <summary>
//        /// remove a room from the collection
//        /// </summary>
//        /// <param name="ID">room's ID</param>
//        /// <returns>true if success, false else</returns>
//        public bool RemoveRoom(uint ID) {
//            XElement room = (from item in Xrooms.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
//            if (room == null)
//                return false;
//            try {
//            room.Remove();
//            Xrooms.Save(roomsPath);
//            return true;
//            } catch {
//                return false;
//            }
//        }

//        /// <summary>
//        /// add an agency to the collection
//        /// </summary>
//        /// <param name="agency">agency</param>
//        /// <returns>true if success, false else</returns>
//        public bool AddAgency(Tour_Agency agency) {
//            if ((from item in Xagencies.Elements() where (item.Element("id").Value == agency.AgencyID.ToString()) select item).Count() > 0)
//                return false;
//            try {
//                Xagencies.Add(new XElement("agency", agency.ToXML()));
//                Xagencies.Save(agenciesPath);
//            } catch {
//                return false;
//            }
//            return true;
//        }
//        /// <summary>
//        /// updating an agency by parameters
//        /// </summary>
//        /// <param name="ID">agency's ID</param>
//        /// <param name="Name">agency's name - optional</param>
//        /// <param name="ContactPerson">Contact person - optional</param>
//        /// <returns>true if success, false else</returns>
//        public bool UpdateAgency(uint ID, string Name = "", string ContactPerson = "") {
//            XElement agencyToUpdate = (from item in Xagencies.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
//            if (agencyToUpdate == null)
//                return false;
//            try {
//                if (Name != "") agencyToUpdate.Element("Name").Value = Name;
//                if (ContactPerson != "") agencyToUpdate.Element("ContactPerson").Value = ContactPerson;
//                Xagencies.Save(agenciesPath);
//                return true;
//            } catch {
//                return false;
//            }
//        }
//        /// <summary>
//        /// remove an agency from the collection
//        /// </summary>
//        /// <param name="ID">agency's ID</param>
//        /// <returns>true if success, false else</returns>
//        public bool RemoveAgency(uint ID) {
//            XElement agency = (from item in Xagencies.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
//            if (agency == null)
//                return false;
//            try {
//                agency.Remove();
//                Xagencies.Save(agenciesPath);
//                return true;
//            } catch {
//                return false;
//            }
//        }

//        /// <summary>
//        /// add a reservation to the collection
//        /// </summary>
//        /// <param name="reservation">reservation</param>
//        /// <returns>true if success, false else</returns>
//        public bool AddReservation(Reservation reservation) {
//            if ((from item in Xreservations.Elements() where (item.Element("id").Value == reservation.ReservationID.ToString()) select item).Count() > 0)
//                return false;
//            try {
//                Xreservations.Add(new XElement("reservaion", reservation.ToXML()));
//                Xreservations.Save(reservationsPath);
//            } catch {
//                return false;
//            }
//            return true;
//        }
//        /// <summary>
//        /// updating a reservation by functions
//        /// </summary>
//        /// <param name="ID">Reservation ID</param>
//        /// <param name="updates">some functions (at least one, or an array of functions) that get Reservation and return void (they can be lambda expressions)</param>
//        /// <returns>true if success, false else</returns>
//        protected bool UpdateReservation(uint ID, params Action<Reservation>[] updates) {
//            XElement reservationToUpdate = (from item in Xreservations.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
//            if (reservationToUpdate == null)
//                return false;
//            try {
//                if (Beds > 0) reservationToUpdate.Element("Beds").Value = Beds.ToString();
//                if (Type.HasValue) reservationToUpdate.Element("Type").Value = Type.ToString();
//                if (Price > 0) reservationToUpdate.Element("Price").Value = Price.ToString();
//                Xreservations.Save(reservationsPath);
//                return true;
//            } catch {
//                return false;
//            }






//            var Reservation = reservations.Where(item => item.ReservationID == ReservationID);
//            if (Reservation.Count() != 1)
//                return false;
//            Reservation.Update(updates);
//            return true;
//        }
//        /// <summary>
//        /// updating a reservation by parameters
//        /// </summary>
//        /// <param name="ReservationID">ReservationID</param>
//        /// <param name="ArrivalDate">Arrival Date - optional</param>
//        /// <param name="Days">Days - optional</param>
//        /// <returns>true if success, false else</returns>
//        public bool UpdateReservation(uint ReservationID, DateTime? ArrivalDate = null, uint Days = 0) {
//            return UpdateReservation(ReservationID, item => {
//                if (ArrivalDate.HasValue) item.ArrivalDate = ArrivalDate.Value;
//                if (Days > 0) item.Days = Days;
//            });
//        }
//        /// <summary>
//        /// updating a reservation by parameters
//        /// </summary>
//        /// <param name="ReservationID">ReservationID</param>
//        /// <param name="room">room - optional</param>
//        /// <param name="ArrivalDate">Arrival Date - optional</param>
//        /// <param name="Days">Days - optional</param>
//        /// <returns>true if success, false else</returns>
//        public bool UpdateReservation(uint ReservationID, Room room, DateTime? ArrivalDate = null, uint Days = 0) {
//            return UpdateReservation(ReservationID, item => {
//                if (!(item is Single_Reservation)) throw new ArgumentException("Reservation must be a Single_Reservation");
//                (item as Single_Reservation).Room = room;
//                if (ArrivalDate.HasValue) item.ArrivalDate = ArrivalDate.Value;
//                if (Days > 0) item.Days = Days;
//            });
//        }
//        /// <summary>
//        /// updating a reservation by parameters
//        /// </summary>
//        /// <param name="ReservationID">ReservationID</param>
//        /// <param name="rooms">collection of rooms - optional</param>
//        /// <param name="ArrivalDate">Arrival Date - optional</param>
//        /// <param name="Days">Days - optional</param>
//        /// <returns>true if success, false else</returns>
//        public bool UpdateReservation(uint ReservationID, List<Room> rooms, DateTime? ArrivalDate = null, uint Days = 0) {
//            return UpdateReservation(ReservationID, item => {
//                if (!(item is Group_Reservation<List<Room>>)) throw new ArgumentException("Reservation must be a Group_Reservation");
//                (item as Group_Reservation<List<Room>>).Rooms = rooms;
//                if (ArrivalDate.HasValue) item.ArrivalDate = ArrivalDate.Value;
//                if (Days > 0) item.Days = Days;
//            });
//        }
//        /// <summary>
//        /// remove a reservation from the collection
//        /// </summary>
//        /// <param name="ID">reservation's ID</param>
//        /// <returns>true if success, false else</returns>
//        public bool RemoveReservation(uint ID) {
//            XElement reservation = (from item in Xreservations.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
//            if (reservation == null)
//                return false;
//            try {
//                reservation.Remove();
//                Xreservations.Save(reservationsPath);
//                return true;
//            } catch {
//                return false;
//            }
//        }
//    }
//}
