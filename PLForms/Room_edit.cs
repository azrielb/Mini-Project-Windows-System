using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BE;

namespace PLForms
{
    public partial class Room_edit : Form
    {
        bool add;
        BL_ServiceReference.BL_SOAPClient myBL;
        public Room_edit(BL_ServiceReference.BL_SOAPClient BLin)
        {
            myBL = BLin;
            add = true;
            InitializeComponent();
            typeListBox.DataSource = Enum.GetValues(typeof(RoomType));
            roomIDTextBox.Text = myBL.NextRoomNumber().ToString();
        }
        public Room_edit(BL_ServiceReference.BL_SOAPClient BLin, Room r)
        {
            myBL = BLin;
            add = false;
            InitializeComponent();
            roomIDTextBox.Text = r.RoomID.ToString();
            bedsTextBox.Text = r.Beds.ToString();
            priceTextBox.Text = r.Price.ToString();
            seaWatchingCheckBox.Checked = r.SeaWatching;
            typeListBox.DataSource = Enum.GetValues(typeof(RoomType));
            typeListBox.SelectedItem = r.Type;
            seaWatchingCheckBox.Enabled = false;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                Room r = new Room
                (
                    uint.Parse(roomIDTextBox.Text),
                    uint.Parse(bedsTextBox.Text),
                    uint.Parse(priceTextBox.Text),
                    (BE.RoomType)typeListBox.SelectedItem,
                    seaWatchingCheckBox.Checked
                );
                if (add)
                {
                    myBL.AddRoom(r);
                }
                else
                {
                    myBL.UpdateRoom(r.RoomID, r.Beds, r.Type, r.Price);
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("I am Error");
            }
        
        }

        private void typeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
