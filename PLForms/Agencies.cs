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

        }
    }
}