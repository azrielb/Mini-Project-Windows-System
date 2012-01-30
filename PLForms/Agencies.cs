﻿using System;
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
    public partial class Agencies : Form
    {
        BL.IBL<List<Room>, List<Tour_Agency>, List<Reservation>> myBL;
        
        public Agencies(BL.IBL<List<Room>, List<Tour_Agency>, List<Reservation>> BLin)
        {
            myBL = BLin;
            InitializeComponent();
            agencyIDListBox.DataSource = myBL.Agencies;
            agencyIDListBox.DisplayMember = "Name";
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form f = new Agency_edit(myBL, (Tour_Agency)agencyIDListBox.SelectedItem);
            f.ShowDialog();
            agencyIDListBoxRefresh();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form f = new Agency_edit(myBL);
            f.ShowDialog();
            agencyIDListBoxRefresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            myBL.RemoveAgency(((Tour_Agency)agencyIDListBox.SelectedItem).AgencyID);
            agencyIDListBoxRefresh();
        }

        private void agencyIDListBoxRefresh()
        {
            agencyIDListBox.DataSource = null;
            agencyIDListBox.DataSource = myBL.Agencies;
//          agencyIDListBox.DisplayMember = "Name";
        }

    }
}
