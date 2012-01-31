using System;
using System.Windows.Forms;
using BE;

namespace PLForms
{
    public partial class Agency_edit : Form
    {
        bool add;
        BL_ServiceReference.BL_SOAPClient myBL;
        public Agency_edit(BL_ServiceReference.BL_SOAPClient BLin)
        {
            myBL = BLin;
            add = true;
            InitializeComponent();
            typeListBox.DataSource = Enum.GetValues(typeof(AgencyType));
            agencyIDTextBox.Text = myBL.NextAgencyNumber().ToString();
        }
        public Agency_edit(BL_ServiceReference.BL_SOAPClient BLin, Tour_Agency a)
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
