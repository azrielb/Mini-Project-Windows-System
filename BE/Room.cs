using System;

namespace BE
{
    public enum RoomType { Regular, Suite }
    public class Room
    {
        //Fields
        private readonly uint roomID;
        private uint beds;
        private RoomType type;
        private readonly bool seaWatching;
        private uint price;
        private uint bedPrice;

        //Properties
        public uint RoomID
        {
            get { return roomID; }
        }
        public uint Beds
        {
            get { return beds; }
            //set { beds = value; }
        }
        public RoomType Type
        {
            get { return type; }
        }
        public bool SeaWatching
        {
            get { return seaWatching; }
        }
        public uint Price
        {
            get { return price; }
            //set { price = value; }
        }
        public uint BedPrice
        {
            get { return bedPrice; }
            //set { bedPrice = value; }
        }

        //Constructor
        public Room(uint ID, uint beds = 1, uint price = 100, uint bedPrice = 0, RoomType type = RoomType.Regular, bool seaWatching = false)
        {
            this.beds = beds;
            this.type = type;
            this.seaWatching = seaWatching;
            this.price = price;
            this.roomID = ID;
            this.bedPrice = bedPrice;
        }

        //Override function
        public override string ToString()
        {
            return String.Format("Room no. {0} is a {1}. It has {2} and it {3} the sea. Price: {4} NIS. {5}.",
                roomID, type, beds == 1 ? "one bed" : beds + " beds", seaWatching ? "watches" : "do not watch", price,
                bedPrice == 0 ? "In this room you can't reserve single bed" : string.Format("Price of single bed: {0} NIS", bedPrice)
                );
        }

    }
}
