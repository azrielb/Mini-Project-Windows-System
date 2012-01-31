using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BE {
    [DataContract]
    [KnownType(typeof(Single_Reservation))]
    [KnownType(typeof(Group_Reservation<IEnumerable<Room>>))]
    public abstract class Reservation : IComparable {
        // static Property
        [DataMember]
        public static CultureInfo CalendarType { get; set; }
        // static constructor
        static Reservation() {
            CalendarType = new CultureInfo("en-US");
        }

        // Properties
        [DataMember]
        public uint ReservationID { get; private set; }
        [DataMember]
        public uint AgencyID { get; private set; }
        [DataMember]
        public DateTime ReservationDate { get; private set; }
        [DataMember]
        public DateTime ArrivalDate { get; set; }
        [DataMember]
        public uint Days { get; set; }
        [DataMember]
        public DateTime LeavingDate {
            get { return ArrivalDate.AddDays(Days); }
            private set { throw new NotImplementedException(); }
        }
        [DataMember]
        public string ContactPerson { get; set; }
        [DataMember]
        public abstract uint Price { get; protected set; }
        [DataMember]
        public abstract uint Beds { get; protected set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">reservation ID</param>
        /// <param name="agency">Agency (The fields that are in use are agecyID and ContactPerson)</param>
        /// <param name="arrivalDate">arrival date</param>
        /// <param name="days">the amount of days</param>
        /// <param name="reservationDate">reservation date, null is current date</param>
        public Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, uint days = 1, DateTime? reservationDate = null) {
            ReservationID = ID;
            AgencyID = agency.AgencyID;
            ContactPerson = agency.ContactPerson;
            ArrivalDate = arrivalDate;
            Days = days;
            ReservationDate = reservationDate == null ? DateTime.Now : (DateTime)reservationDate;
        }

        // Override function
        public override string ToString() {
            return string.Format("{0} from agency no. {1} has created the reservation no. {2} in {3}. Arrival date: {4}. {5} for {6}. Price: {7} NIS.",
                ContactPerson,
                AgencyID,
                ReservationID,
                ReservationDate.ToString(CalendarType),
                ArrivalDate.ToString(CalendarType),
                Beds == 1 ? "One bed" : Beds + " beds",
                Days == 1 ? "one day" : Days + " days",
                Price);
        }

        /// <summary>
        /// the reservation can be comapred with another reservation or with integer
        /// </summary>
        public int CompareTo(object obj) {
            if (obj is Reservation)
                return ReservationID.CompareTo(((Reservation)(obj)).ReservationID);
            else if (obj is int)
                return ReservationID.CompareTo(obj);
            else
                throw new ArgumentException("obj must be \"Reservation\" or int.");
        }
    }
}
