using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;


namespace DAL
{
    public class Dal_imp : Idal<List<Room>, List<Tour_Agency>, List<Reservation>>
    {
        //Fields
        private List<Room> rooms = new List<Room>();
        private List<Tour_Agency> agencies = new List<Tour_Agency>();
        private List<Reservation> reservations = new List<Reservation>();
        //Properties
        public List<Room> Rooms
        {
            get { return rooms.ToList(); }
        }
        public List<Tour_Agency> Agencies
        {
            get { return agencies.ToList(); }
        }
        public List<Reservation> Reservations
        {
            get { return reservations.ToList(); }
        }
        //Constructor
        //Override function


        public bool AddRoom(Room room)
        {
            if (rooms.Contains(room)) return false;
            rooms.Add(room);
            return rooms.Contains(room);
        }

        public bool UpdateRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public bool RemoveRoom(uint ID)
        {
            throw new NotImplementedException();
        }


        public bool AddAgency(Tour_Agency Agency)
        {
            if (agencies.Contains(Agency)) return false;
            agencies.Add(Agency);
            return agencies.Contains(Agency);
        }

        public bool UpdateAgency(Tour_Agency Agency)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAgency(uint ID)
        {
            throw new NotImplementedException();
        }


        public bool AddReservation(Reservation reservation)
        {
            if (reservations.Contains(reservation)) return false;
            reservations.Add(reservation);
            return reservations.Contains(reservation);
        }

        public bool UpdateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public bool RemoveReservation(uint ID)
        {
            throw new NotImplementedException();
        }

    }
}