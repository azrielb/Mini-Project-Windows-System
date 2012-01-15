using System;
using System.Globalization;

namespace BE {
    public abstract class Reservation : IComparable {
        //static field
        protected static CultureInfo calendarType = new CultureInfo("en-US");

        //Properties
        public uint ReservationID { get; private set; }
        public uint Beds { get; set; }
        public DateTime ReservationDate { get; private set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime LeavingDate { get { return ArrivalDate.AddDays(Days); } }
        public uint Days { get; set; }
        public uint AgencyID { get; set; }
        public string ContactPerson { get; set; }
        public abstract uint Price { get; }

        //Constructor
        public Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, uint days = 1, uint beds = 1) {
            AgencyID = agency.AgencyID;
            ContactPerson = agency.ContactPerson;
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
                ReservationDate.ToString(calendarType),
                ArrivalDate.ToString(calendarType),
                Beds == 1 ? "One bed" : Beds + " beds",
                Days == 1 ? "one day" : Days + " days",
                Price);
        }

        public int CompareTo(object obj) {
            if (obj is Reservation)
                return ReservationID.CompareTo(((Reservation)(obj)).ReservationID);
            else if (obj is int)
                return ReservationID.CompareTo(obj);
            else
                throw new ArgumentException("obj must be \"Reservation\"");
        }
    }
}
