using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BE;

namespace PLForms
{
   public partial class Reservations : Form
    {
        BL_ServiceReference.BL_SOAPClient myBL;
        public Reservations(BL_ServiceReference.BL_SOAPClient BLin)
        {
            myBL = BLin;
            InitializeComponent();
            reservationIDListBoxRefresh();
        }

        private void reservationIDListBoxRefresh()
        {
            reservationIDListBox.DataSource = null;
            reservationIDListBox.DataSource = myBL.Reservations();
            //      reservationIDListBox.DisplayMember = "Name";
            if (myBL.Reservations().Count == 0)   //Disable edit & delete buttons if no items.
            {
                btn_Delete.Enabled = false;
                btn_Edit.Enabled = false;
            }
            else
            {
                btn_Delete.Enabled = true;
                btn_Edit.Enabled = true;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form f = new Reservation_edit(myBL, (Reservation)reservationIDListBox.SelectedItem);
            f.ShowDialog();
            reservationIDListBoxRefresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            myBL.RemoveReservation(((Reservation)reservationIDListBox.SelectedItem).ReservationID);
            reservationIDListBoxRefresh();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form f = new Reservation_edit(myBL);
            f.ShowDialog();
            reservationIDListBoxRefresh();
        }
    }

}
