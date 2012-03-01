using System;
using System.Windows.Forms;

namespace PLForms {
    public partial class Main : Form {
        BL_ServiceReference.BL_SOAPClient myBL;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BLin"></param>
        public Main(BL_ServiceReference.BL_SOAPClient BLin) {
            myBL = BLin;
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rooms_Click(object sender, EventArgs e) {
            Form f = new Rooms(myBL);
            f.Show();
        }

        private void btn_Agencies_Click(object sender, EventArgs e) {
            Form f = new Agencies(myBL);
            f.Show();
        }

        private void btn_Reservations_Click(object sender, EventArgs e) {
            Form f = new Reservations(myBL);
            f.Show();
        }

    }
}
