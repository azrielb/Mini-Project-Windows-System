using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using BE;

namespace DAL {
    internal static class convertions {
        public static XElement ToXML(this Room src) {
            return new XElement("room",
                new XElement("id", src.RoomID),
                new XElement("Beds", src.Beds),
                new XElement("Price", src.Price),
                new XElement("Type", (uint)src.Type),
                new XElement("SeaWatching", src.SeaWatching ? "T" : "F")
            );
        }
        public static XElement ToXML(this Tour_Agency src) {
            return new XElement("agency",
                new XElement("id", src.AgencyID),
                new XElement("Name", src.Name),
                new XElement("ContactPerson", src.ContactPerson),
                new XElement("Type", (uint)src.Type)
            );
        }
        public static XElement ToXML(this Reservation src) {
            return new XElement("reservation",
                new XElement("id", src.ReservationID),
                new XElement("AgencyID", src.AgencyID),
                new XElement("ArrivalDate", src.ArrivalDate),
                new XElement("Days", src.Days),
                new XElement("ReservationDate", src.ReservationDate),
                (src is Single_Reservation
                    ? new XElement("roomID", (src as Single_Reservation).Room.RoomID)
                    : (src is Group_Reservation<IEnumerable<Room>>
                        ? new XElement("rooms",
                            from room in (src as Group_Reservation<IEnumerable<Room>>).Rooms
                            select new XElement("ID", room.RoomID)
                        )
                        : null
                    )
                )
            );
        }
        public static Room ToRoom(this XElement item) {
            return new Room(
                uint.Parse(item.Element("id").Value),
                uint.Parse(item.Element("Beds").Value),
                uint.Parse(item.Element("Price").Value),
                (RoomType)uint.Parse(item.Element("Type").Value),
                item.Element("SeaWatching").Value == "T"
            );
        }
        public static List<Room> ToRoomList(this XElement src) {
            return (from item in src.Elements("room") select item.ToRoom()).ToList<Room>();
        }
        public static Tour_Agency ToAgency(this XElement item) {
            return new Tour_Agency(
                uint.Parse(item.Element("id").Value),
                item.Element("Name").Value,
                item.Element("ContactPerson").Value,
                (AgencyType)uint.Parse(item.Element("Type").Value)
            );
        }
        public static List<Tour_Agency> ToAgencyList(this XElement src) {
            return (from item in src.Elements("agency") select item.ToAgency()).ToList<Tour_Agency>();
        }
        public static Reservation ToReservation(this XElement item, Func<uint, Tour_Agency> intToAgency, Func<uint, Room> intToRoom) {
            return item.Element("roomID") != null
                ? (Reservation)new Single_Reservation(
                    uint.Parse(item.Element("id").Value),
                    intToAgency(uint.Parse(item.Element("AgencyID").Value)),
                    DateTime.Parse(item.Element("ArrivalDate").Value),
                    intToRoom(uint.Parse(item.Element("roomID").Value)),
                    uint.Parse(item.Element("Days").Value),
                    DateTime.Parse(item.Element("ReservationDate").Value)
                )
                : item.Element("rooms") != null
                ? (Reservation)new Group_Reservation<List<Room>>(
                    uint.Parse(item.Element("id").Value),
                    intToAgency(uint.Parse(item.Element("AgencyID").Value)),
                    DateTime.Parse(item.Element("ArrivalDate").Value),
                    (from room in item.Element("rooms").Elements("id") select intToRoom(uint.Parse(room.Value))).ToList(),
                    uint.Parse(item.Element("Days").Value),
                    DateTime.Parse(item.Element("ReservationDate").Value)
                )
                : null;
        }
        public static List<Reservation> ToReservationList(this XElement src, Func<uint, Tour_Agency> intToAgency, Func<uint, Room> intToRoom) {
            return (from item in src.Elements("reservation")
                    select item.ToReservation(intToAgency, intToRoom)).ToList<Reservation>();
        }
    }
}
