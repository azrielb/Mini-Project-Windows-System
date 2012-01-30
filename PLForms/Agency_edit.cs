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
    public partial class Agency_edit : Form
    {
        bool add;
        BL.IBL<List<Room>, List<Tour_Agency>, List<Reservation>> myBL;
        public Agency_edit(BL.IBL<List<Room>, List<Tour_Agency>, List<Reservation>> BLin)
        {
            InitializeComponent();
            typeListBox.DataSource = Enum.GetValues(typeof());

        }
    }
}
