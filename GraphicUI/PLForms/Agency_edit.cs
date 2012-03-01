using System;
using System.Windows.Forms;
using PLForms.BL_ServiceReference;

namespace PLForms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Agency_edit : Form
    {
        bool add;
        BL_ServiceReference.BL_SOAPClient myBL;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BLin"></param>
        public Agency_edit(BL_ServiceReference.BL_SOAPClient BLin)
        {
            myBL = BLin;
            add = true;
            InitializeComponent();
            typeListBox.DataSource = Enum.GetValues(typeof(AgencyType));
            agencyIDTextBox.Text = myBL.NextAgencyNumber().ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BLin"></param>
        /// <param name="a"></param>
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
                Tour_Agency a = new Tour_Agency {
                    AgencyID = uint.Parse(agencyIDTextBox.Text),
                    Name = nameTextBox.Text,
                    ContactPerson = contactPersonTextBox.Text,
                    Type = (AgencyType)typeListBox.SelectedItem
                };
                if (add)
                {
                    if (!myBL.AddAgency(a)) throw new Exception();
                }
                else
                {
                    if (!myBL.UpdateAgency(a.AgencyID, a.Name, a.ContactPerson)) throw new Exception();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("I am Error");
            }

        }

    }
}
