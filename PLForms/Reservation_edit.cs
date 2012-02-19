using System;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using BE;

namespace PLForms {
    public partial class Reservation_edit : Form {
        bool add;
        BL_ServiceReference.BL_SOAPClient myBL;
        bool isSingle;
        public Reservation_edit(BL_ServiceReference.BL_SOAPClient BLin)
        {
            myBL = BLin;
            add = true;
            InitializeComponent();
            agencyIDComboBox.DataSource = myBL.Agencies();
            agencyIDComboBox.DisplayMember = "Name";
            agencyIDComboBox.ValueMember = "AgencyID";
            reservationIDTextBox.Text = (myBL.NextReservationNumber()).ToString();
            arrivalDateDateTimePicker.Value = DateTime.Today;
            leavingDateDateTimePicker.Value = DateTime.Today.AddDays(1);
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
                isSingle = true;
            }
            else if (r is Group_Reservation)
            {
                localRooms.AddRange(((Group_Reservation)r).Rooms);
                isSingle = false;
            }
            v.InsertRange(0, localRooms);
            roomsListBox.DataSource = (v);
            roomsListBox.DisplayMember = "RoomID";
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
            roomsListBox.DisplayMember = "RoomID";
            roomsListBox.ValueMember = "RoomID";
            for (int i = 0; i < checkedRooms.Count; i++)
                roomsListBox.SetItemChecked(i, true);
            bedsRefresh(checkedRooms);
            priceRefresh(checkedRooms);
        }

        private void arrivalDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            leavingDateDateTimePicker.MinDate = arrivalDateDateTimePicker.Value.AddDays(1);
            roomsListBoxRefresh();
        }

        private void leavingDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            arrivalDateDateTimePicker.MaxDate = leavingDateDateTimePicker.Value.AddDays(-1);
            roomsListBoxRefresh();
        }
        private void bedsRefresh(List<Room> roomsList)
        {
            bedsTextBox.Text = (from room in roomsList select (room.Beds * 1.0)).Sum().ToString();
        }
        private void priceRefresh(List<Room> roomsList)
        {
            priceTextBox.Text = (from room in roomsList select (room.Price * 1.0 * (leavingDateDateTimePicker.Value - arrivalDateDateTimePicker.Value).Days)).Sum().ToString();
        }

        private void roomsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<Room> checkedRooms = new List<Room>();
            checkedRooms.AddRange(from Room item in roomsListBox.CheckedItems select item);
            roomsListBox.SelectedIndex = e.Index;
            if (e.NewValue == CheckState.Checked)
            {
                if (isSingle == true)
                {
                    if (checkedRooms.Count > 0)
                    {
                        Room v = checkedRooms.FirstOrDefault();
                        roomsListBox.SetItemChecked((roomsListBox.Items.IndexOf(v)), false);
                        checkedRooms.Remove(v);
                        roomsListBox.SelectedIndex = e.Index;
                    }
                }
                checkedRooms.Add((Room)roomsListBox.SelectedItem);
            }
            else
            {
                checkedRooms.Remove((Room)roomsListBox.SelectedItem);
            }
            bedsRefresh(checkedRooms);
            priceRefresh(checkedRooms);
        }

        private void roomsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedRoomBedsField.Text = ((Room)roomsListBox.SelectedItem).Beds.ToString();
            selectedRoomPriceField.Text = ((Room)roomsListBox.SelectedItem).Price.ToString();
            selectedRoomTypeField.Text = ((Room)roomsListBox.SelectedItem).Type.ToString();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation r;
                if (roomsListBox.CheckedItems.Count == 1)
                {
                    r = new Single_Reservation
                    (
                        uint.Parse(reservationIDTextBox.Text),
                        (Tour_Agency)agencyIDComboBox.SelectedItem,
                        arrivalDateDateTimePicker.Value,
                        (Room)roomsListBox.CheckedItems[0],
                        (uint)(leavingDateDateTimePicker.Value - arrivalDateDateTimePicker.Value).Days,
                        (DateTime?)null
                    );
                }
                else
                {
                    List<Room> checkedRooms = new List<Room>();
                    checkedRooms.AddRange(from Room item in roomsListBox.CheckedItems select item);
                    r = new Group_Reservation
                    (
                        uint.Parse(reservationIDTextBox.Text),
                        (Tour_Agency)agencyIDComboBox.SelectedItem,
                        arrivalDateDateTimePicker.Value,
                        checkedRooms,
                        (uint)(leavingDateDateTimePicker.Value - arrivalDateDateTimePicker.Value).Days,
                        (DateTime?)null
                    );
                }
                if (add)
                {
                    if (!myBL.AddReservation(r)) throw new Exception();
                }
                else
                {
                    if (r is Group_Reservation)
                    {
                        if (!myBL.UpdateGroupReservation(r.ReservationID, ((Group_Reservation)r).Rooms, r.ArrivalDate, r.Days)) throw new Exception();
                    }
                    else if (r is Single_Reservation)
                    {
                        if (!myBL.UpdateSingleReservation(r.ReservationID, ((Single_Reservation)r).Room, r.ArrivalDate, r.Days)) throw new Exception();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("I am Error");
            }
        }

        private void agencyIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactPersonTextBox.Text = ((Tour_Agency)agencyIDComboBox.SelectedItem).ContactPerson;
        }

    }
}
