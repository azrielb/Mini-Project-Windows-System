using System;
using System.Windows.Forms;
using BE;

namespace PLForms
{
    public partial class Agencies : Form
    {
        BL_ServiceReference.BL_SOAPClient myBL;
        
        public Agencies(BL_ServiceReference.BL_SOAPClient BLin)
        {
            myBL = BLin;
            InitializeComponent();
            agencyIDListBoxRefresh();
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
            try {
                if (!myBL.RemoveAgency(((Tour_Agency)agencyIDListBox.SelectedItem).AgencyID)) throw new Exception();
            } catch {
                MessageBox.Show("I am Error");
            }
            agencyIDListBoxRefresh();
        }

        private void agencyIDListBoxRefresh()
        {
            agencyIDListBox.DataSource = null;
            agencyIDListBox.DataSource = myBL.Agencies();
            agencyIDListBox.DisplayMember = "Name";
            if (myBL.Agencies().Count == 0)
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
    }
}
