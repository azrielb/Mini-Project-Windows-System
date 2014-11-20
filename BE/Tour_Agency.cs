using System;
using System.Runtime.Serialization;

namespace BE {
    [DataContract]
    public enum AgencyType { 
        [EnumMember] 
        national,
        [EnumMember]
        international,
        [EnumMember]
        in_hotel_chain_ownership
    }

    [DataContract]
    public class Tour_Agency : IComparable {
        // Properties
        [DataMember]
        public uint AgencyID { get; private set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public AgencyType Type { get; private set; }
        [DataMember]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">id</param>
        /// <param name="name">name</param>
        /// <param name="contactPerson">contact person</param>
        /// <param name="type">AgencyType</param>
        public Tour_Agency(uint ID, string name, string contactPerson, AgencyType type = AgencyType.national) {
            AgencyID = ID;
            Name = name;
            ContactPerson = contactPerson;
            Type = type;
        }

        // Override function
        public override string ToString() {
            return String.Format("{0} (tour agency no. {1}) is {2}. Contact person: {3}.",
                Name, AgencyID, Type == AgencyType.in_hotel_chain_ownership ? "in hotel chain ownership" : Type.ToString(), ContactPerson);
        }

        /// <summary>
        /// Tour_Agency can be comapred with another Tour_Agency or with integer
        /// </summary>
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
