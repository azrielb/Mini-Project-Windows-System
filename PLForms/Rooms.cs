﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BE;

namespace PLForms {
    public partial class Rooms : Form {
        BL_ServiceReference.BL_SOAPClient myBL;

        public Rooms(BL_ServiceReference.BL_SOAPClient BLin) {
            myBL = BLin;
            InitializeComponent();
            roomIDListBoxRefresh();

        }
        private void btn_Edit_Click(object sender, EventArgs e) {
            Form f = new Room_edit(myBL, (Room)roomIDListBox.SelectedItem);
            f.ShowDialog();
            roomIDListBoxRefresh();
        }

        private void btn_Add_Click(object sender, EventArgs e) {
            Form f = new Room_edit(myBL);
            f.ShowDialog();
            roomIDListBoxRefresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e) {
            if (roomIDListBox.SelectedItem == null) return;
            myBL.RemoveRoom(((Room)roomIDListBox.SelectedItem).RoomID);
            roomIDListBoxRefresh();
        }

        private void roomIDListBoxRefresh() {
            roomIDListBox.DataSource = null;
            roomIDListBox.DataSource = myBL.Rooms();
            roomIDListBox.DisplayMember = "RoomID";
            if (myBL.Rooms().Count == 0) {
                btn_Delete.Enabled = false;
                btn_Edit.Enabled = false;
            } else {
                btn_Delete.Enabled = true;
                btn_Edit.Enabled = true;
            }
        }
    }
}
