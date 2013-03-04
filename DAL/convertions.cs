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
        public static Room ToRoom(this XElement item) {
            uint id, Beds, Price, theType;
            uint.TryParse(item.Element("id").Value, out id);
            uint.TryParse(item.Element("Beds").Value, out Beds);
            uint.TryParse(item.Element("Price").Value, out Price);
            uint.TryParse(item.Element("Type").Value, out theType);
            RoomType Type = (RoomType)theType;
            bool SeaWatching = item.Element("SeaWatching").Value == "T";
            return new Room(id, Beds, Price, Type, SeaWatching);
        }
        public static XElement ToXML(this Tour_Agency src) {
            return new XElement("agency",
                new XElement("id", src.AgencyID),
                new XElement("Name", src.Name),
                new XElement("ContactPerson", src.ContactPerson),
                new XElement("Type", (uint)src.Type)
            );
        }
        public static Tour_Agency ToAgency(this XElement item) {
            uint id, Type;
            uint.TryParse(item.Element("id").Value, out id);
            uint.TryParse(item.Element("Type").Value, out Type);
            return new Tour_Agency(id, item.Element("Name").Value, item.Element("ContactPerson").Value, (AgencyType)Type);
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
                    : (src is Group_Reservation
                        ? new XElement("rooms",
                            from room in (src as Group_Reservation).Rooms
                            select new XElement("id", room.RoomID)
                        )
                        : null
                    )
                )
            );
        }
        public static Reservation ToReservation(this XElement item, Func<uint, Tour_Agency> intToAgency, Func<uint, Room> intToRoom) {
            uint id, agencyID, Days;
            DateTime ArrivalDate, ReservationDate;
            uint.TryParse(item.Element("id").Value, out id);
            uint.TryParse(item.Element("AgencyID").Value, out agencyID);
            uint.TryParse(item.Element("Days").Value, out Days);
            DateTime.TryParse(item.Element("ArrivalDate").Value, out ArrivalDate);
            DateTime.TryParse(item.Element("ReservationDate").Value, out ReservationDate);
            Tour_Agency agency = intToAgency(agencyID);
            if (item.Element("roomID") != null) {
                uint roomID;
                uint.TryParse(item.Element("roomID").Value, out roomID);
                Room room = intToRoom(roomID);
                return (Reservation)new Single_Reservation(id, agency, ArrivalDate, room, Days, ReservationDate);
            }
            if (item.Element("rooms") != null) {
                List<Room> rooms = new List<Room>();
                foreach (XElement XroomID in item.Element("rooms").Elements("id")) {
                    uint roomID;
                    uint.TryParse(XroomID.Value, out roomID);
                    rooms.Add(intToRoom(roomID));
                }
                return (Reservation)new Group_Reservation(id, agency, ArrivalDate, rooms, Days, ReservationDate);
            }
            return null;
        }
        public static List<T> ToList<T>(this XElement src, Func<uint, Tour_Agency> intToAgency = null, Func<uint, Room> intToRoom = null) {
            if (typeof(T) == typeof(Room)) {
                return (List<T>)Convert.ChangeType((from item in src.Elements("room") select item.ToRoom()).ToList<Room>(), typeof(List<T>));
            }
            if (typeof(T) == typeof(Tour_Agency)) {
                return (List<T>)Convert.ChangeType((from item in src.Elements("agency") select item.ToAgency()).ToList<Tour_Agency>(), typeof(List<T>));
            }
            if (typeof(T) == typeof(Reservation) && intToAgency != null && intToRoom != null) {
                return (List<T>)Convert.ChangeType(
                    (from item in src.Elements("reservation") select item.ToReservation(intToAgency, intToRoom)).ToList<Reservation>(),
                    typeof(List<T>)
                );
            }
            throw new NotImplementedException();
        }
    }
}
