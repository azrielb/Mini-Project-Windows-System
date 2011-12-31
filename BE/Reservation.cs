using System;

namespace BE
{
    public abstract class Reservation
    {
        //Fields
        private readonly uint reservationID;
        private readonly Tour_Agency agency;
        private readonly DateTime reservationDate;
        protected uint beds;
        protected DateTime arrivalDate;
        protected uint days;

        //Properties
        public uint ReservationID
        {
            get { return reservationID; }
        }
        public Tour_Agency Agency
        {
            get { return agency; }
        }
        public uint Beds
        {
            get { return beds; }
        }
        public DateTime ReservationDate
        {
            get { return reservationDate; }
        }
        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
        }
        public uint Days
        {
            get { return days; }
            //set { days = value; }
        }
        public string ContactPerson
        {
            get { return agency.ContactPerson; }
        }
        public abstract uint Price { get; }

        //Constructor
        public Reservation(uint ID, Tour_Agency agency, DateTime arrivalDate, uint days = 1, uint beds = 1)
        {
            this.agency = agency;
            this.arrivalDate = arrivalDate;
            this.beds = beds;
            this.days = days;
            this.reservationDate = DateTime.Now;
            this.reservationID = ID;
        }

        //Override function
        public override string ToString()
        {
            return string.Format("{0} from {1} has created the reservation no. {2} in {3}. Arrival date: {4}. {5} for {6}. Price: {7} NIS.",
                ContactPerson, agency.Name, reservationID, reservationDate, arrivalDate, beds == 1 ? "One bed" : beds + " beds", days == 1 ? "one day" : days + " days", Price);
        }

    }
}