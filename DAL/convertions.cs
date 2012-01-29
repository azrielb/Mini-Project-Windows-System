using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using BE;

namespace DAL {
    internal static class convertions {
        public static XElement ToXML(this Room src) {
            return new XElement("room",
                new XElement("id", src.RoomID),
                new XElement("Beds", src.Beds),
                new XElement("SeaWatching", src.SeaWatching),
                new XElement("Type", src.Type),
                new XElement("Price", src.Price)
            );
        }
        public static XElement ToXML(this Tour_Agency src) {
            return new XElement("agency",
                new XElement("id", src.AgencyID),
                new XElement("ContactPerson", src.ContactPerson),
                new XElement("Name", src.Name),
                new XElement("Type", src.Type)
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
    }
}
