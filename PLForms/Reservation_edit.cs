using System;
using System.Windows.Forms;
using BE;

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
            reservationDateDateTimePicker.Value = 
                arrivalDateDateTimePicker.Value = 
                leavingDateDateTimePicker.Value = DateTime.Today;

        }
        public Reservation_edit(BL_ServiceReference.BL_SOAPClient BLin, Reservation r)
        {
            myBL = BLin;
            add = false;
            InitializeComponent();
            reservationIDTextBox.Text = r.ReservationID.ToString();
            reservationIDTextBox.Enabled = false;
            reservationDateDateTimePicker.Value = r.ReservationDate;
            reservationDateDateTimePicker.Enabled = false;
            agencyIDComboBox.DataSource = myBL.Agencies();
            agencyIDComboBox.DisplayMember = "Name";
            agencyIDComboBox.ValueMember = "AgencyID";
            agencyIDComboBox.SelectedValue = r.AgencyID;
            agencyIDComboBox.Enabled = false;
            contactPersonTextBox.Text = r.ContactPerson;
            bedsTextBox.Text = r.Beds.ToString();
            daysNumericUpDown.Value = r.Days;
            arrivalDateDateTimePicker.Value = r.ArrivalDate;
            arrivalDateDateTimePicker.MaxDate = r.LeavingDate;
            leavingDateDateTimePicker.Value = r.LeavingDate;
            leavingDateDateTimePicker.MinDate = r.ArrivalDate;
            priceTextBox.Text = r.Price.ToString();
        }
        private void daysNumericUpDown_Refresh()
        {
            daysNumericUpDown.Value = (leavingDateDateTimePicker.Value - arrivalDateDateTimePicker.Value).Days;
        }

        private void arrivalDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            leavingDateDateTimePicker.MinDate = arrivalDateDateTimePicker.Value;
            daysNumericUpDown_Refresh();
        }

        private void leavingDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            arrivalDateDateTimePicker.MaxDate = leavingDateDateTimePicker.Value;
            daysNumericUpDown_Refresh();
        }

        private void daysNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            leavingDateDateTimePicker.Value = (arrivalDateDateTimePicker.Value).AddDays((double)daysNumericUpDown.Value);
        }
    }
}
