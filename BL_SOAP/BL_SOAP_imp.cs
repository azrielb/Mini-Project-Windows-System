﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using BE;

namespace BL_SOAP {
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class BL_SOAP_imp : IBL_SOAP {
        private DAL.Idal<List<Room>, List<Tour_Agency>, List<Reservation>> myDal;
        private uint nextRoomNumber;
        private uint nextAgencyNumber;
        private uint nextReservationNumber;
        /// <summary>
        /// constructor
        /// </summary>
        public BL_SOAP_imp() {
            myDal = DAL.FactoryDAL.getDAL;
            nextRoomNumber = Rooms().Count > 0 ? (from item in Rooms() select item.RoomID).Max() + 1 : 1;
            nextAgencyNumber = Agencies().Count > 0 ? (from item in Agencies() select item.AgencyID).Max() + 1 : 1;
            nextReservationNumber = Reservations().Count > 0 ? (from item in Reservations() select item.ReservationID).Max() + 1 : 1;
        }

        // Implement functions and properties of IBL
        /// <summary>
        /// add a room to the collection
        /// </summary>
        /// <param name="room">room</param>
        /// <returns>true if success, false else</returns>
        public bool AddRoom(Room room) {
            if (room.RoomID < nextRoomNumber) return false;
            if (!myDal.AddRoom(room)) return false;
            nextRoomNumber = room.RoomID + 1;
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
            return roomIsAvailable(ID, DateTime.Now) ? myDal.UpdateRoom(ID, Beds, Type, Price) : false;
        }
        /// <summary>
        /// remove a room from the collection
        /// </summary>
        /// <param name="ID">room's ID</param>
        /// <returns>true if success, false else</returns>
        public bool RemoveRoom(uint ID) {
            return roomIsAvailable(ID, DateTime.Now) ? myDal.RemoveRoom(ID) : false;
        }
        // properties of rooms
        public List<Room> Rooms() { return myDal.Rooms; }
        /// <summary>
        /// Return the number of the next room - for auto-increment.
        /// </summary>
        public uint NextRoomNumber() {
            return nextRoomNumber;
        }

        /// <summary>
        /// Find the all rooms that are reserved between these dates.
        /// All parameters are optional. The empty calling finds the all rooms that reserved anytime.
        /// </summary>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <returns>Enumerable of rooms' numbers</returns>
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
                else if (reservation is Group_Reservation)
                    reservedRooms.AddRange(from item in ((Group_Reservation)reservation).Rooms select item.RoomID);
            }
            return reservedRooms.Distinct();
        }
        /// <summary>
        /// Find the all rooms that are available between these dates, and suitable to the predicate.
        /// All parameters are optional. The empty calling finds the all rooms that available anytime.
        /// </summary>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <param name="predicate">a predicate that gets a Room and return bool</param>
        /// <returns>Enumerable of rooms</returns>
        public List<Room> availableRooms(DateTime? start = null, DateTime? end = null, Predicate<Room> predicate = null) {
            List<Room> availableRooms = predicate == null ? myDal.Rooms : myDal.Rooms.FindAll(predicate);
            return availableRooms.FindAll(item => !(reservedRooms(start, end).Contains(item.RoomID)));
        }
        /// <summary>
        /// check whether this room is available between these dates.
        /// All parameters (excepct the ID) are optional. The empty calling checks whether this room is available anytime.
        /// </summary>
        /// <param name="ID">room ID</param>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <returns>checking result</returns>
        public bool roomIsAvailable(uint ID, DateTime? start = null, DateTime? end = null) {
            return !(reservedRooms(start, end).Contains(ID));
        }

        /// <summary>
        /// add an agency to the collection
        /// </summary>
        /// <param name="agency">agency</param>
        /// <returns>true if success, false else</returns>
        public bool AddAgency(Tour_Agency agency) {
            if (agency.AgencyID < nextAgencyNumber) return false;
            if (!myDal.AddAgency(agency)) return false;
            nextAgencyNumber = agency.AgencyID + 1;
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
            if (!myDal.UpdateAgency(ID, Name, ContactPerson)) return false;
            myDal.Reservations.ForEach(item => {
                if (item.AgencyID == ID) {
                    item.ContactPerson = ContactPerson;
                }
            });
            return true;
        }
        /// <summary>
        /// remove an agency from the collection
        /// </summary>
        /// <param name="ID">agency's ID</param>
        /// <returns>true if success, false else</returns>
        public bool RemoveAgency(uint ID) {
            return (myDal.Reservations.Exists(item => item.AgencyID == ID)) ? false : myDal.RemoveAgency(ID);
        }
        // properties of agencies
        public List<Tour_Agency> Agencies() { return myDal.Agencies; }
        /// <summary>
        /// Return the number of the next agency - for auto-increment.
        /// </summary>
        public uint NextAgencyNumber() {
            return nextAgencyNumber;
        }

        /// <summary>
        /// add a reservation to the collection
        /// </summary>
        /// <param name="reservation">reservation</param>
        /// <returns>true if success, false else</returns>
        public bool AddReservation(Reservation reservation) {
            if (reservation.Days < 1 || reservation.ReservationID < nextReservationNumber) return false;
            if (!myDal.AddReservation(reservation)) return false;
            nextReservationNumber = reservation.ReservationID + 1;
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
            if (Days < 1) return false;
            return myDal.UpdateReservation(ReservationID, ArrivalDate, Days);
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
            if (Days < 1) return false;
            return myDal.UpdateReservation(ReservationID, room, ArrivalDate, Days);
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
            if (Days < 1) return false;
            return myDal.UpdateReservation(ReservationID, rooms, ArrivalDate, Days);
        }
        /// <summary>
        /// remove a reservation from the collection
        /// </summary>
        /// <param name="ID">reservation's ID</param>
        /// <returns>true if success, false else</returns>
        public bool RemoveReservation(uint ID) {
            return myDal.RemoveReservation(ID);
        }
        // properties of reservations
        public List<Reservation> Reservations() { return myDal.Reservations; }
        /// <summary>
        /// Return the number of the next reservation - for auto-increment.
        /// </summary>
        public uint NextReservationNumber() { return nextReservationNumber; }
        /// <summary>
        /// Calculate the price of the all erservations.
        /// </summary>
        public uint ReservationsPrice() {

            uint reservationsPrice = 0;
            foreach (Reservation reservation in Reservations())
                reservationsPrice += reservation.Price;
            return reservationsPrice;
        }
        /// <summary>
        /// Cancel the all rservations between these dates
        /// </summary>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <returns>the count of canceled rservations</returns>
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
