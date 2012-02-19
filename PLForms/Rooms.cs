using System;
using System.Windows.Forms;
using BE;

namespace PLForms {
    public partial class Rooms : Form {
        BL.BL_imp myBL;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BLin"></param>
        public Rooms(BL.BL_imp BLin) {
            myBL = BLin;
            InitializeComponent();
            roomIDListBoxRefresh();

        }
        private void btn_Edit_Click(object sender, EventArgs e) {
            Form f = new Room_edit(myBL, (Room)roomIDListBox.SelectedItem);
            f.ShowDialog();
            roomIDListBoxRefresh();
        }

        private void btn_Add_Click(object sender, EventArgs e) {
            Form f = new Room_edit(myBL);
            f.ShowDialog();
            roomIDListBoxRefresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e) {
            if (roomIDListBox.SelectedItem == null) return;
            try {
                if (!myBL.RemoveRoom(((Room)roomIDListBox.SelectedItem).RoomID)) throw new Exception();
            } catch {
                MessageBox.Show("I am Error");
            }
            roomIDListBoxRefresh();
        }

        private void roomIDListBoxRefresh() {
            roomIDListBox.DataSource = null;
            roomIDListBox.DataSource = myBL.Rooms;
            roomIDListBox.DisplayMember = "RoomID";
            if (myBL.Rooms.Count == 0) {
                btn_Delete.Enabled = false;
                btn_Edit.Enabled = false;
            } else {
                btn_Delete.Enabled = true;
                btn_Edit.Enabled = true;
            }
        }
    }
}
