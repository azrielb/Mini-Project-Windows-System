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
    public partial class Main : Form
    {
        BL_ServiceReference.BL_SOAPClient myBL;

        public Main(BL_ServiceReference.BL_SOAPClient BLin)
        {
            myBL = BLin;
            InitializeComponent();
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            Form f = new Rooms(myBL);
            f.Show();
        }

        private void btn_Agencies_Click(object sender, EventArgs e)
        {
            Form f = new Agencies(myBL);
            f.Show();
        }

        private void btn_Reservations_Click(object sender, EventArgs e)
        {
            Form f = new Reservations(myBL);
            f.Show();
        }

    }
}
