using System;
using System.Globalization;

namespace BE {
    public abstract class Reservation : IComparable {
        //static field
        public static CultureInfo CalendarType = new CultureInfo("en-US");

        //Properties
        public uint ReservationID { get; private set; }
        public uint AgencyID { get; private set; }
        public DateTime ReservationDate { get; private set; }
        public DateTime ArrivalDate { get; set; }
        public uint Days { get; set; }
        public DateTime LeavingDate { get { return ArrivalDate.AddDays(Days); } }
        public uint Beds { get; protected set; }
        public string ContactPerson { get; set; }
        public abstract uint Price { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">reservation ID</param>
        /// <param name="agencyID">agency ID</param>
        /// <param name="arrivalDate">arrival date</param>
        /// <param name="days">the amount of days</param>
        /// <param name="beds">the amount of beds</param>
        public Reservation(uint ID, uint agencyID, DateTime arrivalDate, uint days = 1, uint beds = 1) {
            AgencyID = agencyID;
            ArrivalDate = arrivalDate;
            Beds = beds;
            Days = days;
            ReservationDate = DateTime.Now;
            ReservationID = ID;
        }

        //Override function
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
        /// <param name="obj"></param>
        /// <returns></returns>
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
