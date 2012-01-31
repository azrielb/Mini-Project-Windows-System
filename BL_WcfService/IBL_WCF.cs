using System;
using System.Collections.Generic;
using System.ServiceModel;
using BE;
using System.Runtime.Serialization;

namespace BL_WcfService {
    [ServiceContract]
    public interface IBL_WCF<RO, TO, RE>
        where RO : IEnumerable<Room>
        where TO : IEnumerable<Tour_Agency>
        where RE : IEnumerable<Reservation> {
        /// <summary>
        /// add a room to the collection
        /// </summary>
        /// <param name="room">room</param>
        /// <returns>true if success, false else</returns>
        [OperationContract]
        bool AddRoom(Room room);
        /// <summary>
        /// updating room by parameters
        /// </summary>
        /// <param name="ID">room's ID</param>
        /// <param name="Beds">Beds - optional</param>
        /// <param name="Type">Room Type - optional</param>
        /// <param name="Price">Price - optional</param>
        /// <returns>true if success, false else</returns>
        [OperationContract]
        bool UpdateRoom(uint ID, uint Beds = 0, RoomType? Type = null, uint Price = 0);
        /// <summary>
        /// remove a room from the collection
        /// </summary>
        /// <param name="ID">room's ID</param>
        /// <returns>true if success, false else</returns>
        [OperationContract]
        bool RemoveRoom(uint ID);
        // properties of rooms
        [DataMember]
        RO Rooms { get; }
        /// <summary>
        /// Return the number of the next room - for auto-increment.
        /// </summary>
        [DataMember]
        uint NextRoomNumber { get; }
        /// <summary>
        /// Find the all rooms that are reserved between these dates.
        /// All parameters are optional. The empty calling finds the all rooms that reserved anytime.
        /// </summary>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <returns>Enumerable of rooms' numbers</returns>
        [OperationContract]
        IEnumerable<uint> reservedRooms(DateTime? start = null, DateTime? end = null);
        /// <summary>
        /// Find the all rooms that are available between these dates, and suitable to the predicate.
        /// All parameters are optional. The empty calling finds the all rooms that available anytime.
        /// </summary>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <param name="predicate">a predicate that gets a Room and return bool</param>
        /// <returns>Enumerable of rooms</returns>
        [OperationContract]
        RO availableRooms(DateTime? start = null, DateTime? end = null, Predicate<Room> predicate = null);
        /// <summary>
        /// check whether this room is available between these dates.
        /// All parameters (excepct the ID) are optional. The empty calling checks whether this room is available anytime.
        /// </summary>
        /// <param name="ID">room ID</param>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <returns>checking result</returns>
        [OperationContract]
        bool roomIsAvailable(uint ID, DateTime? start = null, DateTime? end = null);

        /// <summary>
        /// add an agency to the collection
        /// </summary>
        /// <param name="agency">agency</param>
        /// <returns>true if success, false else</returns>
        [OperationContract]
        bool AddAgency(Tour_Agency agency);
        /// <summary>
        /// updating an agency by parameters
        /// </summary>
        /// <param name="ID">agency's ID</param>
        /// <param name="Name">agency's name - optional</param>
        /// <param name="ContactPerson">Contact person - optional</param>
        /// <returns>true if success, false else</returns>
        [OperationContract]
        bool UpdateAgency(uint ID, string Name = "", string ContactPerson = "");
        /// <summary>
        /// remove an agency from the collection
        /// </summary>
        /// <param name="ID">agency's ID</param>
        /// <returns>true if success, false else</returns>
        [OperationContract]
        bool RemoveAgency(uint ID);
        // properties of agencies
        [DataMember]
        TO Agencies { get; }
        /// <summary>
        /// Return the number of the next agency - for auto-increment.
        /// </summary>
        [DataMember]
        uint NextAgencyNumber { get; }

        /// <summary>
        /// add a reservation to the collection
        /// </summary>
        /// <param name="reservation">reservation</param>
        /// <returns>true if success, false else</returns>
        [OperationContract]
        bool AddReservation(Reservation reservation);
        /// <summary>
        /// updating a reservation by parameters
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="ArrivalDate">Arrival Date - optional</param>
        /// <param name="Days">Days - optional</param>
        /// <returns>true if success, false else</returns>
        [OperationContract]
        bool UpdateReservation(uint ReservationID, DateTime? ArrivalDate = null, uint Days = 0);
        /// <summary>
        /// updating a reservation by parameters
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="ArrivalDate">Arrival Date - optional</param>
        /// <param name="Days">Days - optional</param>
        /// <returns>true if success, false else</returns>
        [OperationContract(Name = "UpdateSingleReservation")]
        bool UpdateReservation(uint ReservationID, Room room, DateTime? ArrivalDate = null, uint Days = 0);
        /// <summary>
        /// updating a reservation by parameters
        /// </summary>
        /// <param name="ReservationID">ReservationID</param>
        /// <param name="rooms">collection of rooms - optional</param>
        /// <param name="ArrivalDate">Arrival Date - optional</param>
        /// <param name="Days">Days - optional</param>
        /// <returns>true if success, false else</returns>
        [OperationContract(Name = "UpdateGroupReservation")]
        bool UpdateReservation(uint ReservationID, RO rooms, DateTime? ArrivalDate = null, uint Days = 0);
        /// <summary>
        /// remove a reservation from the collection
        /// </summary>
        /// <param name="ID">reservation's ID</param>
        /// <returns>true if success, false else</returns>
        [OperationContract]
        bool RemoveReservation(uint ID);
        // properties of reservations
        [DataMember]
        RE Reservations { get; }
        /// <summary>
        /// Return the number of the next reservation - for auto-increment.
        /// </summary>
        [DataMember]
        uint NextReservationNumber { get; }
        /// <summary>
        /// Calculate the price of the all erservations.
        /// </summary>
        [DataMember]
        uint ReservationsPrice { get; }
        /// <summary>
        /// Cancel the all rservations between these dates
        /// </summary>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <returns>the count of canceled rservations</returns>
        [OperationContract]
        uint cancelReservations(DateTime start, DateTime end);
    }
}
