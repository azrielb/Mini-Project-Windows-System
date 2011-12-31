using System;

namespace BE
{
    public enum AgencyType { national, international, in_hotel_chain_ownership }
    public class Tour_Agency
    {
        //Fields
        private readonly uint agencyID;
        private readonly AgencyType type;
        private readonly string contactPerson;
        private string name;

        //Properties
        public uint AgencyID
        {
            get { return agencyID; }
        }
        public string Name
        {
            get { return name; }
            internal set { name = value; }
        }
        public AgencyType Type
        {
            get { return type; }
        }
        public string ContactPerson
        {
            get { return contactPerson; }
        }

        //Constructor
        public Tour_Agency(uint ID, string name, string contactPerson, AgencyType type = AgencyType.national)
        {
            this.agencyID = ID;
            this.name = name;
            this.contactPerson = contactPerson;
            this.type = type;
        }

        //Override function
        public override string ToString()
        {
            return String.Format("{0} (tour agency no. {1}) is {2}. Contact person: {3}.",
                name, AgencyID, type == AgencyType.in_hotel_chain_ownership ? "in hotel chain ownership" : type.ToString(), contactPerson);
        }
    }
}
