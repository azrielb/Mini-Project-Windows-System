using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BE;
using System.Collections;


namespace PLForms
{
    public partial class Reservation_edit : Form
    {
        bool add;
        BL_ServiceReference.BL_SOAPClient myBL;
        public Reservation_edit(BL_ServiceReference.BL_SOAPClient BLin)
        {
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
        public Reservation_edit(BL_ServiceReference.BL_SOAPClient BLin, Reservation r)
        {
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
            ArrayList localRooms = new ArrayList();
            if (r is Single_Reservation)
            {
                localRooms.Add(((Single_Reservation)r).Room);
                v.Insert(0, ((Single_Reservation)r).Room);
            }
            else if (r is Group_Reservation)
            {
                localRooms.AddRange(((Group_Reservation)r).Rooms);
                v.InsertRange(0, ((Group_Reservation)r).Rooms);
            }
            roomsListBox.DataSource = (v);
            roomsListBox.ValueMember = "RoomID";
            for (int i = 0; i < localRooms.Count; i++)
                roomsListBox.SetItemChecked(i, true);
            uint totalBeds = 0;
            foreach (Room x in roomsListBox.CheckedItems)
                totalBeds += x.Beds;
            priceTextBox.Text = r.Price.ToString();
        }
        private void roomsListBoxRefresh()
        {
            roomsListBox.DataSource = myBL.availableRooms(arrivalDateDateTimePicker.Value, leavingDateDateTimePicker.Value, null);
        }
        
        private void arrivalDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            leavingDateDateTimePicker.MinDate = arrivalDateDateTimePicker.Value;
            roomsListBoxRefresh();
        }

        private void leavingDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            arrivalDateDateTimePicker.MaxDate = leavingDateDateTimePicker.Value;
            roomsListBoxRefresh();
        }
    }
}
