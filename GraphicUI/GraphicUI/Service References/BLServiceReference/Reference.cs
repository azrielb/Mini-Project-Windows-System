﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraphicUI.BLServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="http://schemas.datacontract.org/2004/07/BE")]
    [System.SerializableAttribute()]
    public partial class Room : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint BedsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint RoomIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SeaWatchingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GraphicUI.BLServiceReference.RoomType TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint Beds {
            get {
                return this.BedsField;
            }
            set {
                if ((this.BedsField.Equals(value) != true)) {
                    this.BedsField = value;
                    this.RaisePropertyChanged("Beds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint RoomID {
            get {
                return this.RoomIDField;
            }
            set {
                if ((this.RoomIDField.Equals(value) != true)) {
                    this.RoomIDField = value;
                    this.RaisePropertyChanged("RoomID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SeaWatching {
            get {
                return this.SeaWatchingField;
            }
            set {
                if ((this.SeaWatchingField.Equals(value) != true)) {
                    this.SeaWatchingField = value;
                    this.RaisePropertyChanged("SeaWatching");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GraphicUI.BLServiceReference.RoomType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomType", Namespace="http://schemas.datacontract.org/2004/07/BE")]
    public enum RoomType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Regular = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Suite = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tour_Agency", Namespace="http://schemas.datacontract.org/2004/07/BE")]
    [System.SerializableAttribute()]
    public partial class Tour_Agency : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint AgencyIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactPersonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GraphicUI.BLServiceReference.AgencyType TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint AgencyID {
            get {
                return this.AgencyIDField;
            }
            set {
                if ((this.AgencyIDField.Equals(value) != true)) {
                    this.AgencyIDField = value;
                    this.RaisePropertyChanged("AgencyID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactPerson {
            get {
                return this.ContactPersonField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactPersonField, value) != true)) {
                    this.ContactPersonField = value;
                    this.RaisePropertyChanged("ContactPerson");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GraphicUI.BLServiceReference.AgencyType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgencyType", Namespace="http://schemas.datacontract.org/2004/07/BE")]
    public enum AgencyType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        national = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        international = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        in_hotel_chain_ownership = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reservation", Namespace="http://schemas.datacontract.org/2004/07/BE")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GraphicUI.BLServiceReference.Group_Reservation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GraphicUI.BLServiceReference.Single_Reservation))]
    public partial class Reservation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint AgencyIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ArrivalDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint BedsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactPersonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint DaysField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LeavingDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReservationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint ReservationIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint AgencyID {
            get {
                return this.AgencyIDField;
            }
            set {
                if ((this.AgencyIDField.Equals(value) != true)) {
                    this.AgencyIDField = value;
                    this.RaisePropertyChanged("AgencyID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ArrivalDate {
            get {
                return this.ArrivalDateField;
            }
            set {
                if ((this.ArrivalDateField.Equals(value) != true)) {
                    this.ArrivalDateField = value;
                    this.RaisePropertyChanged("ArrivalDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint Beds {
            get {
                return this.BedsField;
            }
            set {
                if ((this.BedsField.Equals(value) != true)) {
                    this.BedsField = value;
                    this.RaisePropertyChanged("Beds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactPerson {
            get {
                return this.ContactPersonField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactPersonField, value) != true)) {
                    this.ContactPersonField = value;
                    this.RaisePropertyChanged("ContactPerson");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint Days {
            get {
                return this.DaysField;
            }
            set {
                if ((this.DaysField.Equals(value) != true)) {
                    this.DaysField = value;
                    this.RaisePropertyChanged("Days");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LeavingDate {
            get {
                return this.LeavingDateField;
            }
            set {
                if ((this.LeavingDateField.Equals(value) != true)) {
                    this.LeavingDateField = value;
                    this.RaisePropertyChanged("LeavingDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReservationDate {
            get {
                return this.ReservationDateField;
            }
            set {
                if ((this.ReservationDateField.Equals(value) != true)) {
                    this.ReservationDateField = value;
                    this.RaisePropertyChanged("ReservationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint ReservationID {
            get {
                return this.ReservationIDField;
            }
            set {
                if ((this.ReservationIDField.Equals(value) != true)) {
                    this.ReservationIDField = value;
                    this.RaisePropertyChanged("ReservationID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Group_Reservation", Namespace="http://schemas.datacontract.org/2004/07/BE")]
    [System.SerializableAttribute()]
    public partial class Group_Reservation : GraphicUI.BLServiceReference.Reservation {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<GraphicUI.BLServiceReference.Room> RoomsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<GraphicUI.BLServiceReference.Room> Rooms {
            get {
                return this.RoomsField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomsField, value) != true)) {
                    this.RoomsField = value;
                    this.RaisePropertyChanged("Rooms");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Single_Reservation", Namespace="http://schemas.datacontract.org/2004/07/BE")]
    [System.SerializableAttribute()]
    public partial class Single_Reservation : GraphicUI.BLServiceReference.Reservation {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GraphicUI.BLServiceReference.Room RoomField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GraphicUI.BLServiceReference.Room Room {
            get {
                return this.RoomField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomField, value) != true)) {
                    this.RoomField = value;
                    this.RaisePropertyChanged("Room");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLServiceReference.IBL_SOAP")]
    public interface IBL_SOAP {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/AddRoom", ReplyAction="http://tempuri.org/IBL_SOAP/AddRoomResponse")]
        bool AddRoom(GraphicUI.BLServiceReference.Room room);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/UpdateRoom", ReplyAction="http://tempuri.org/IBL_SOAP/UpdateRoomResponse")]
        bool UpdateRoom(uint ID, uint Beds, System.Nullable<GraphicUI.BLServiceReference.RoomType> Type, uint Price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/RemoveRoom", ReplyAction="http://tempuri.org/IBL_SOAP/RemoveRoomResponse")]
        bool RemoveRoom(uint ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/Rooms", ReplyAction="http://tempuri.org/IBL_SOAP/RoomsResponse")]
        System.Collections.Generic.List<GraphicUI.BLServiceReference.Room> Rooms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/NextRoomNumber", ReplyAction="http://tempuri.org/IBL_SOAP/NextRoomNumberResponse")]
        uint NextRoomNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/reservedRooms", ReplyAction="http://tempuri.org/IBL_SOAP/reservedRoomsResponse")]
        System.Collections.Generic.List<uint> reservedRooms(System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/availableRooms", ReplyAction="http://tempuri.org/IBL_SOAP/availableRoomsResponse")]
        System.Collections.Generic.List<GraphicUI.BLServiceReference.Room> availableRooms(System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end, System.Predicate<GraphicUI.BLServiceReference.Room> predicate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/roomIsAvailable", ReplyAction="http://tempuri.org/IBL_SOAP/roomIsAvailableResponse")]
        bool roomIsAvailable(uint ID, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/AddAgency", ReplyAction="http://tempuri.org/IBL_SOAP/AddAgencyResponse")]
        bool AddAgency(GraphicUI.BLServiceReference.Tour_Agency agency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/UpdateAgency", ReplyAction="http://tempuri.org/IBL_SOAP/UpdateAgencyResponse")]
        bool UpdateAgency(uint ID, string Name, string ContactPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/RemoveAgency", ReplyAction="http://tempuri.org/IBL_SOAP/RemoveAgencyResponse")]
        bool RemoveAgency(uint ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/Agencies", ReplyAction="http://tempuri.org/IBL_SOAP/AgenciesResponse")]
        System.Collections.Generic.List<GraphicUI.BLServiceReference.Tour_Agency> Agencies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/NextAgencyNumber", ReplyAction="http://tempuri.org/IBL_SOAP/NextAgencyNumberResponse")]
        uint NextAgencyNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/AddReservation", ReplyAction="http://tempuri.org/IBL_SOAP/AddReservationResponse")]
        bool AddReservation(GraphicUI.BLServiceReference.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/UpdateReservation", ReplyAction="http://tempuri.org/IBL_SOAP/UpdateReservationResponse")]
        bool UpdateReservation(uint ReservationID, System.Nullable<System.DateTime> ArrivalDate, uint Days);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/UpdateSingleReservation", ReplyAction="http://tempuri.org/IBL_SOAP/UpdateSingleReservationResponse")]
        bool UpdateSingleReservation(uint ReservationID, GraphicUI.BLServiceReference.Room room, System.Nullable<System.DateTime> ArrivalDate, uint Days);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/UpdateGroupReservation", ReplyAction="http://tempuri.org/IBL_SOAP/UpdateGroupReservationResponse")]
        bool UpdateGroupReservation(uint ReservationID, System.Collections.Generic.List<GraphicUI.BLServiceReference.Room> rooms, System.Nullable<System.DateTime> ArrivalDate, uint Days);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/RemoveReservation", ReplyAction="http://tempuri.org/IBL_SOAP/RemoveReservationResponse")]
        bool RemoveReservation(uint ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/Reservations", ReplyAction="http://tempuri.org/IBL_SOAP/ReservationsResponse")]
        System.Collections.Generic.List<GraphicUI.BLServiceReference.Reservation> Reservations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/NextReservationNumber", ReplyAction="http://tempuri.org/IBL_SOAP/NextReservationNumberResponse")]
        uint NextReservationNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/ReservationsPrice", ReplyAction="http://tempuri.org/IBL_SOAP/ReservationsPriceResponse")]
        uint ReservationsPrice();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBL_SOAP/cancelReservations", ReplyAction="http://tempuri.org/IBL_SOAP/cancelReservationsResponse")]
        uint cancelReservations(System.DateTime start, System.DateTime end);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBL_SOAPChannel : GraphicUI.BLServiceReference.IBL_SOAP, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BL_SOAPClient : System.ServiceModel.ClientBase<GraphicUI.BLServiceReference.IBL_SOAP>, GraphicUI.BLServiceReference.IBL_SOAP {
        
        public BL_SOAPClient() {
        }
        
        public BL_SOAPClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BL_SOAPClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BL_SOAPClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BL_SOAPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddRoom(GraphicUI.BLServiceReference.Room room) {
            return base.Channel.AddRoom(room);
        }
        
        public bool UpdateRoom(uint ID, uint Beds, System.Nullable<GraphicUI.BLServiceReference.RoomType> Type, uint Price) {
            return base.Channel.UpdateRoom(ID, Beds, Type, Price);
        }
        
        public bool RemoveRoom(uint ID) {
            return base.Channel.RemoveRoom(ID);
        }
        
        public System.Collections.Generic.List<GraphicUI.BLServiceReference.Room> Rooms() {
            return base.Channel.Rooms();
        }
        
        public uint NextRoomNumber() {
            return base.Channel.NextRoomNumber();
        }
        
        public System.Collections.Generic.List<uint> reservedRooms(System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end) {
            return base.Channel.reservedRooms(start, end);
        }
        
        public System.Collections.Generic.List<GraphicUI.BLServiceReference.Room> availableRooms(System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end, System.Predicate<GraphicUI.BLServiceReference.Room> predicate) {
            return base.Channel.availableRooms(start, end, predicate);
        }
        
        public bool roomIsAvailable(uint ID, System.Nullable<System.DateTime> start, System.Nullable<System.DateTime> end) {
            return base.Channel.roomIsAvailable(ID, start, end);
        }
        
        public bool AddAgency(GraphicUI.BLServiceReference.Tour_Agency agency) {
            return base.Channel.AddAgency(agency);
        }
        
        public bool UpdateAgency(uint ID, string Name, string ContactPerson) {
            return base.Channel.UpdateAgency(ID, Name, ContactPerson);
        }
        
        public bool RemoveAgency(uint ID) {
            return base.Channel.RemoveAgency(ID);
        }
        
        public System.Collections.Generic.List<GraphicUI.BLServiceReference.Tour_Agency> Agencies() {
            return base.Channel.Agencies();
        }
        
        public uint NextAgencyNumber() {
            return base.Channel.NextAgencyNumber();
        }
        
        public bool AddReservation(GraphicUI.BLServiceReference.Reservation reservation) {
            return base.Channel.AddReservation(reservation);
        }
        
        public bool UpdateReservation(uint ReservationID, System.Nullable<System.DateTime> ArrivalDate, uint Days) {
            return base.Channel.UpdateReservation(ReservationID, ArrivalDate, Days);
        }
        
        public bool UpdateSingleReservation(uint ReservationID, GraphicUI.BLServiceReference.Room room, System.Nullable<System.DateTime> ArrivalDate, uint Days) {
            return base.Channel.UpdateSingleReservation(ReservationID, room, ArrivalDate, Days);
        }
        
        public bool UpdateGroupReservation(uint ReservationID, System.Collections.Generic.List<GraphicUI.BLServiceReference.Room> rooms, System.Nullable<System.DateTime> ArrivalDate, uint Days) {
            return base.Channel.UpdateGroupReservation(ReservationID, rooms, ArrivalDate, Days);
        }
        
        public bool RemoveReservation(uint ID) {
            return base.Channel.RemoveReservation(ID);
        }
        
        public System.Collections.Generic.List<GraphicUI.BLServiceReference.Reservation> Reservations() {
            return base.Channel.Reservations();
        }
        
        public uint NextReservationNumber() {
            return base.Channel.NextReservationNumber();
        }
        
        public uint ReservationsPrice() {
            return base.Channel.ReservationsPrice();
        }
        
        public uint cancelReservations(System.DateTime start, System.DateTime end) {
            return base.Channel.cancelReservations(start, end);
        }
    }
}
