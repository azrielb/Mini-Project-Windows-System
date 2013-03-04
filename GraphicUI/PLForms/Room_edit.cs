using System;
using System.Windows.Forms;
using PLForms.BL_ServiceReference;

namespace PLForms
{
    public partial class Room_edit : Form
    {
        bool add;
        BL_ServiceReference.BL_SOAPClient myBL;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BLin"></param>
        public Room_edit(BL_ServiceReference.BL_SOAPClient BLin)
        {
            myBL = BLin;
            add = true;
            InitializeComponent();
            typeListBox.DataSource = Enum.GetValues(typeof(RoomType));
            roomIDTextBox.Text = myBL.NextRoomNumber().ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BLin"></param>
        /// <param name="r"></param>
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
            roomIDTextBox.Enabled = false;
        }

        private void btn_OK_Click(object sender, EventArgs e) {
            try {
                Room r = new Room {
                    RoomID = uint.Parse(roomIDTextBox.Text),
                    Beds = uint.Parse(bedsTextBox.Text),
                    Price = uint.Parse(priceTextBox.Text),
                    Type = (RoomType)typeListBox.SelectedItem,
                    SeaWatching = seaWatchingCheckBox.Checked
                };
                if (add) {
                    if (!myBL.AddRoom(r)) throw new Exception();
                } else {
                    if (!myBL.UpdateRoom(r.RoomID, r.Beds, r.Type, r.Price)) throw new Exception();
                }
            } catch (Exception) {
                MessageBox.Show("I am Error");
            }
        }
    }
}
