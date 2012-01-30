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
            myBL = BLin;
            add = true;
            InitializeComponent();
            typeListBox.DataSource = Enum.GetValues(typeof(AgencyType));
            agencyIDTextBox.Text = myBL.NextAgencyNumber.ToString();
        }
        public Agency_edit(BL.IBL<List<Room>, List<Tour_Agency>, List<Reservation>> BLin, Tour_Agency a)
        {
            myBL = BLin;
            add = false;
            InitializeComponent();
            agencyIDTextBox.Text = a.AgencyID.ToString();
            agencyIDTextBox.Enabled = false;
            nameTextBox.Text = a.Name;
            typeListBox.DataSource = Enum.GetValues(typeof(AgencyType));
            typeListBox.SelectedItem = a.Type;
            typeListBox.Enabled = false;
            contactPersonTextBox.Text = a.ContactPerson;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                Tour_Agency a = new Tour_Agency
                (
                    uint.Parse(agencyIDTextBox.Text),
                    nameTextBox.Text,
                    contactPersonTextBox.Text,
                    (AgencyType)typeListBox.SelectedItem
                );
                if (add)
                {
                    myBL.AddAgency(a);
                }
                else
                {
                    myBL.UpdateAgency(a.AgencyID,a.Name,a.ContactPerson);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("I am Error");
            }

        }

    }
}
