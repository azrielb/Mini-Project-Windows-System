using System;

namespace BE {
    public enum AgencyType { national, international, in_hotel_chain_ownership }
    public class Tour_Agency : IComparable {
        //Properties
        public uint AgencyID { get; private set; }
        public string Name { get; set; }
        public AgencyType Type { get; private set; }
        public string ContactPerson { get; set; }

        //Constructor
        public Tour_Agency(uint ID, string name, string contactPerson, AgencyType type = AgencyType.national) {
            AgencyID = ID;
            Name = name;
            ContactPerson = contactPerson;
            Type = type;
        }

        //Override function
        public override string ToString() {
            return String.Format("{0} (tour agency no. {1}) is {2}. Contact person: {3}.",
                Name, AgencyID, Type == AgencyType.in_hotel_chain_ownership ? "in hotel chain ownership" : Type.ToString(), ContactPerson);
        }

        public int CompareTo(object obj) {
            if (obj is Tour_Agency)
                return AgencyID.CompareTo(((Tour_Agency)(obj)).AgencyID);
            else if (obj is int)
                return AgencyID.CompareTo(obj);
            else
                throw new ArgumentException("obj must be \"Tour_Agency\"");
        }
    }
}
