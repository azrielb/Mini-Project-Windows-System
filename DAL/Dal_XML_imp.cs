using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using BE;

namespace DAL {
    class Dal_XML_imp : Idal<List<Room>, List<Tour_Agency>, List<Reservation>> {
        /// <summary>
        /// singleton
        /// </summary>
        private static Dal_XML_imp singleton = new Dal_XML_imp();
        /// <summary>
        /// singleton. this is internal because the class have to be created by a factory.
        /// </summary>
        internal static Dal_XML_imp Singleton { get { return singleton; } }
        // Fields
        private readonly string roomsFile = @"Xrooms.dat";
        private readonly string agenciesFile = @"Xagencies.dat";
        private readonly string reservationsFile = @"Xreservations.dat";
        private XElement Xrooms;
        private XElement Xagencies;
        private XElement Xreservations;
        /// <summary>
        /// private constructor - for singleton
        /// </summary>
        private Dal_XML_imp() {
            string localPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            roomsFile = localPath + @"/" + roomsFile;
            agenciesFile = localPath + @"/" + agenciesFile;
            reservationsFile = localPath + @"/" + reservationsFile;
            Xrooms = File.Exists(roomsFile) ? loadData<Room>(roomsFile) : new XElement("Rooms");
            Xagencies = File.Exists(agenciesFile) ? loadData<Tour_Agency>(agenciesFile) : new XElement("Agencies");
            Xreservations = File.Exists(reservationsFile) ? loadData<Reservation>(reservationsFile) : new XElement("Reservations");
        }

        private XElement loadData<T>(string FPath) {
            try {
                return XElement.Load(FPath);
            } catch {
                throw new NotImplementedException();
            }
        }

        // Properties
        public List<Room> Rooms {
            get { return Xrooms.ToList<Room>(); }
        }
        public List<Tour_Agency> Agencies {
            get { return Xagencies.ToList<Tour_Agency>(); }
        }
        public List<Reservation> Reservations {
            get {
                return Xreservations.ToList<Reservation>(
                    id => (from item in Xagencies.Elements("agency") where item.Element("id").Value == id.ToString() select item.ToAgency()).SingleOrDefault(),
                    id => (from item in Xrooms.Elements("room") where item.Element("id").Value == id.ToString() select item.ToRoom()).SingleOrDefault()
                );
            }
        }

        // Implement functions of Idal
        /// <summary>
        /// add a room to the collection
        /// </summary>
        /// <param name="room">room</param>
        /// <returns>true if success, false else</returns>
        public bool AddRoom(Room room) {
            if ((from item in Xrooms.Elements("room") where item.Element("id").Value == room.RoomID.ToString() select item).Count() > 0)
                return false;
            try {
                Xrooms.Add(room.ToXML());
                Xrooms.Save(roomsFile);
            } catch {
                return false;
            }
            return true;
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
            XElement roomToUpdate = (from item in Xrooms.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
            if (roomToUpdate == null)
                return false;
            try {
                if (Beds > 0) roomToUpdate.Element("Beds").Value = Beds.ToString();
                if (Type.HasValue) roomToUpdate.Element("Type").Value = Type.ToString();
                if (Price > 0) roomToUpdate.Element("Price").Value = Price.ToString();
                Xrooms.Save(roomsFile);
                return true;
            } catch {
                return false;
            }
        }
        /// <summary>
        /// remove a room from the collection
        /// </summary>
        /// <param name="ID">room's ID</param>
        /// <returns>true if success, false else</returns>
        public bool RemoveRoom(uint ID) {
            XElement room = (from item in Xrooms.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
            if (room == null)
                return false;
            try {
                room.Remove();
                Xrooms.Save(roomsFile);
                return true;
            } catch {
                return false;
            }
        }

        /// <summary>
        /// add an agency to the collection
        /// </summary>
        /// <param name="agency">agency</param>
        /// <returns>true if success, false else</returns>
        public bool AddAgency(Tour_Agency agency) {
            if ((from item in Xagencies.Elements() where (item.Element("id").Value == agency.AgencyID.ToString()) select item).Count() > 0)
                return false;
            try {
                Xagencies.Add(agency.ToXML());
                Xagencies.Save(agenciesFile);
            } catch {
                return false;
            }
            return true;
        }
        /// <summary>
        /// updating an agency by parameters
        /// </summary>
        /// <param name="ID">agency's ID</param>
        /// <param name="Name">agency's name - optional</param>
        /// <param name="ContactPerson">Contact person - optional</param>
        /// <returns>true if success, false else</returns>
        public bool UpdateAgency(uint ID, string Name = "", string ContactPerson = "") {
            XElement agencyToUpdate = (from item in Xagencies.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
            if (agencyToUpdate == null)
                return false;
            try {
                if (Name != "") agencyToUpdate.Element("Name").Value = Name;
                if (ContactPerson != "") agencyToUpdate.Element("ContactPerson").Value = ContactPerson;
                Xagencies.Save(agenciesFile);
                return true;
            } catch {
                return false;
            }
        }
        /// <summary>
        /// remove an agency from the collection
        /// </summary>
        /// <param name="ID">agency's ID</param>
        /// <returns>true if success, false else</returns>
        public bool RemoveAgency(uint ID) {
            XElement agency = (from item in Xagencies.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
            if (agency == null)
                return false;
            try {
                agency.Remove();
                Xagencies.Save(agenciesFile);
                return true;
            } catch {
                return false;
            }
        }

        /// <summary>
        /// add a reservation to the collection
        /// </summary>
        /// <param name="reservation">reservation</param>
        /// <returns>true if success, false else</returns>
        public bool AddReservation(Reservation reservation) {
            if ((from item in Xreservations.Elements() where (item.Element("id").Value == reservation.ReservationID.ToString()) select item).Count() > 0)
                return false;
            try {
                Xreservations.Add(reservation.ToXML());
                Xreservations.Save(reservationsFile);
            } catch {
                return false;
            }
            return true;
        }
        /// <summary>
        /// updating a reservation by functions
        /// </summary>
        /// <param name="ID">Reservation ID</param>
        /// <param name="updates">some functions (at least one, or an array of functions) that get Reservation and return void (they can be lambda expressions)</param>
        /// <returns>true if success, false else</returns>
        protected bool UpdateReservation(uint ID, params Action<XElement>[] updates) {
            if (updates == null)
                throw new ArgumentNullException("updates");
            XElement reservationToUpdate = (from item in Xreservations.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
            if (reservationToUpdate == null)
                return false;
            try {
                foreach (Action<XElement> update in updates)
                    update(reservationToUpdate);
                Xreservations.Save(reservationsFile);
                return true;
            } catch {
                return false;
            }
        }
        /// <summary>
        /// updating a reservation by parameters
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="ArrivalDate">Arrival Date - optional</param>
        /// <param name="Days">Days - optional</param>
        /// <returns>true if success, false else</returns>
        public bool UpdateReservation(uint ReservationID, DateTime? ArrivalDate = null, uint Days = 0) {
            return UpdateReservation(ReservationID, item => {
                if (ArrivalDate.HasValue) item.Element("ArrivalDate").Value = ArrivalDate.ToString();
                if (Days > 0) item.Element("Days").Value = Days.ToString();
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
        public bool UpdateReservation(uint ReservationID, Room room, DateTime? ArrivalDate = null, uint Days = 0) {
            return UpdateReservation(ReservationID, item => {
                {
                    if (item.Element("roomID") == null) throw new ArgumentException("Reservation must be a Single_Reservation");
                    else item.Element("roomID").Value = room.RoomID.ToString();
                }
                if (ArrivalDate.HasValue) item.Element("ArrivalDate").Value = ArrivalDate.ToString();
                if (Days > 0) item.Element("Days").Value = Days.ToString();
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
        public bool UpdateReservation(uint ReservationID, List<Room> rooms, DateTime? ArrivalDate = null, uint Days = 0) {
            return UpdateReservation(ReservationID, item => {
                {
                    if (item.Element("rooms") == null) throw new ArgumentException("Reservation must be a Single_Reservation");
                    else item.Element("rooms").ReplaceWith(new XElement("rooms", from room in rooms select new XElement("ID", room.RoomID)));
                }
                if (ArrivalDate.HasValue) item.Element("ArrivalDate").Value = ArrivalDate.ToString();
                if (Days > 0) item.Element("Days").Value = Days.ToString();
            });
        }
        /// <summary>
        /// remove a reservation from the collection
        /// </summary>
        /// <param name="ID">reservation's ID</param>
        /// <returns>true if success, false else</returns>
        public bool RemoveReservation(uint ID) {
            XElement reservation = (from item in Xreservations.Elements() where (item.Element("id").Value == ID.ToString()) select item).FirstOrDefault();
            if (reservation == null)
                return false;
            try {
                reservation.Remove();
                Xreservations.Save(reservationsFile);
                return true;
            } catch {
                return false;
            }
        }
    }
}
