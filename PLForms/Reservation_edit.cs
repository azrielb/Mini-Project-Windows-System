using System;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using BE;
using System.Collections.Generic;

namespace PLForms {
    public partial class Reservation_edit : Form {
        bool add;
        BL_ServiceReference.BL_SOAPClient myBL;
        public Reservation_edit(BL_ServiceReference.BL_SOAPClient BLin) {
            myBL = BLin;
            add = true;
            InitializeComponent();
            agencyIDComboBox.DataSource = myBL.Agencies();
            agencyIDComboBox.DisplayMember = "Name";
            reservationIDTextBox.Text = myBL.NextReservationNumber().ToString();
            arrivalDateDateTimePicker.Value =
            leavingDateDateTimePicker.Value = DateTime.Today;
            roomsListBoxRefresh();
        }
        public Reservation_edit(BL_ServiceReference.BL_SOAPClient BLin, Reservation r) {
            myBL = BLin;
            add = false;
            InitializeComponent();
            reservationIDTextBox.Text = r.ReservationID.ToString();
            reservationIDTextBox.Enabled = false;
            agencyIDComboBox.DataSource = myBL.Agencies();
            agencyIDComboBox.DisplayMember = "Name";
            agencyIDComboBox.ValueMember = "AgencyID";
            agencyIDComboBox.SelectedValue = r.AgencyID;
            agencyIDComboBox.Enabled = false;
            contactPersonTextBox.Text = ((Tour_Agency)agencyIDComboBox.SelectedItem).ContactPerson;
            arrivalDateDateTimePicker.Value = r.ArrivalDate;
            arrivalDateDateTimePicker.MaxDate = r.LeavingDate;
            leavingDateDateTimePicker.Value = r.LeavingDate;
            leavingDateDateTimePicker.MinDate = r.ArrivalDate;
            var v = myBL.availableRooms(arrivalDateDateTimePicker.Value, leavingDateDateTimePicker.Value, null);
            List<Room> localRooms = new List<Room>();
            if (r is Single_Reservation)
            {
                localRooms.Add(((Single_Reservation)r).Room);
            }
            else if (r is Group_Reservation)
            {
                localRooms.AddRange(((Group_Reservation)r).Rooms);
            }
            v.InsertRange(0, localRooms);
            roomsListBox.DataSource = (v);
            roomsListBox.ValueMember = "RoomID";
            for (int i = 0; i < localRooms.Count; i++)
                roomsListBox.SetItemChecked(i, true);
            bedsRefresh(localRooms);
            priceRefresh(localRooms);
        }
        private void roomsListBoxRefresh()
        {
            var v = myBL.availableRooms(arrivalDateDateTimePicker.Value, leavingDateDateTimePicker.Value, null);
            List<Room> checkedRooms = new List<Room>();
            checkedRooms.AddRange(from Room item in roomsListBox.CheckedItems select item);
            v.InsertRange(0, checkedRooms);
            roomsListBox.DataSource = (v);
            roomsListBox.ValueMember = "RoomID";
            for (int i = 0; i < checkedRooms.Count; i++)
                roomsListBox.SetItemChecked(i, true);
            bedsRefresh(checkedRooms);
            priceRefresh(checkedRooms);
        }

        private void arrivalDateDateTimePicker_ValueChanged(object sender, EventArgs e) {
            leavingDateDateTimePicker.MinDate = arrivalDateDateTimePicker.Value;
            roomsListBoxRefresh();
        }

        private void leavingDateDateTimePicker_ValueChanged(object sender, EventArgs e) {
            arrivalDateDateTimePicker.MaxDate = leavingDateDateTimePicker.Value;
            roomsListBoxRefresh();
        }
        private void bedsRefresh(List<Room> roomsList)
        {
            bedsTextBox.Text = (from room in roomsList select (room.Beds * 1.0)).Sum().ToString();
        }
        private void priceRefresh(List<Room> roomsList)
        {
            priceTextBox.Text = (from room in roomsList select (room.Price * 1.0)).Sum().ToString();
        }

        private void roomsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<Room> checkedRooms = new List<Room>();
            checkedRooms.AddRange(from Room item in roomsListBox.CheckedItems select item);
            roomsListBox.SelectedIndex = e.Index;
            checkedRooms.Add((Room)roomsListBox.SelectedItem);
            bedsRefresh(checkedRooms);
            priceRefresh(checkedRooms);
        }
    }
}
