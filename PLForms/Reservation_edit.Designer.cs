using PLForms.BL_ServiceReference;
namespace PLForms {
    /// <summary>
    /// 
    /// </summary>
    partial class Reservation_edit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label arrivalDateLabel;
            System.Windows.Forms.Label bedsLabel;
            System.Windows.Forms.Label contactPersonLabel;
            System.Windows.Forms.Label leavingDateLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label reservationIDLabel;
            System.Windows.Forms.Label agencyIDLabel1;
            System.Windows.Forms.Label selectedRoomTypeLabel;
            System.Windows.Forms.Label selectedRoomBedsLabel;
            System.Windows.Forms.Label selectedRoomPriceLabel;
            this.arrivalDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bedsTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.leavingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.reservationIDTextBox = new System.Windows.Forms.TextBox();
            this.agencyIDComboBox = new System.Windows.Forms.ComboBox();
            this.roomsListBox = new System.Windows.Forms.CheckedListBox();
            this.roomsLabel = new System.Windows.Forms.Label();
            this.selectedRoomTypeField = new System.Windows.Forms.Label();
            this.selectedRoomBedsField = new System.Windows.Forms.Label();
            this.selectedRoomPriceField = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.single_ReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            arrivalDateLabel = new System.Windows.Forms.Label();
            bedsLabel = new System.Windows.Forms.Label();
            contactPersonLabel = new System.Windows.Forms.Label();
            leavingDateLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            reservationIDLabel = new System.Windows.Forms.Label();
            agencyIDLabel1 = new System.Windows.Forms.Label();
            selectedRoomTypeLabel = new System.Windows.Forms.Label();
            selectedRoomBedsLabel = new System.Windows.Forms.Label();
            selectedRoomPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.single_ReservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // arrivalDateLabel
            // 
            arrivalDateLabel.AutoSize = true;
            arrivalDateLabel.Location = new System.Drawing.Point(12, 97);
            arrivalDateLabel.Name = "arrivalDateLabel";
            arrivalDateLabel.Size = new System.Drawing.Size(65, 13);
            arrivalDateLabel.TabIndex = 3;
            arrivalDateLabel.Text = "Arrival Date:";
            // 
            // bedsLabel
            // 
            bedsLabel.AutoSize = true;
            bedsLabel.Location = new System.Drawing.Point(12, 231);
            bedsLabel.Name = "bedsLabel";
            bedsLabel.Size = new System.Drawing.Size(61, 13);
            bedsLabel.TabIndex = 5;
            bedsLabel.Text = "Total Beds:";
            // 
            // contactPersonLabel
            // 
            contactPersonLabel.AutoSize = true;
            contactPersonLabel.Location = new System.Drawing.Point(12, 68);
            contactPersonLabel.Name = "contactPersonLabel";
            contactPersonLabel.Size = new System.Drawing.Size(83, 13);
            contactPersonLabel.TabIndex = 7;
            contactPersonLabel.Text = "Contact Person:";
            // 
            // leavingDateLabel
            // 
            leavingDateLabel.AutoSize = true;
            leavingDateLabel.Location = new System.Drawing.Point(12, 123);
            leavingDateLabel.Name = "leavingDateLabel";
            leavingDateLabel.Size = new System.Drawing.Size(74, 13);
            leavingDateLabel.TabIndex = 11;
            leavingDateLabel.Text = "Leaving Date:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(12, 257);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(61, 13);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Total Price:";
            // 
            // reservationIDLabel
            // 
            reservationIDLabel.AutoSize = true;
            reservationIDLabel.Location = new System.Drawing.Point(12, 15);
            reservationIDLabel.Name = "reservationIDLabel";
            reservationIDLabel.Size = new System.Drawing.Size(81, 13);
            reservationIDLabel.TabIndex = 17;
            reservationIDLabel.Text = "Reservation ID:";
            // 
            // agencyIDLabel1
            // 
            agencyIDLabel1.AutoSize = true;
            agencyIDLabel1.Location = new System.Drawing.Point(12, 41);
            agencyIDLabel1.Name = "agencyIDLabel1";
            agencyIDLabel1.Size = new System.Drawing.Size(46, 13);
            agencyIDLabel1.TabIndex = 18;
            agencyIDLabel1.Text = "Agency:";
            // 
            // selectedRoomTypeLabel
            // 
            selectedRoomTypeLabel.AutoSize = true;
            selectedRoomTypeLabel.Location = new System.Drawing.Point(217, 143);
            selectedRoomTypeLabel.Name = "selectedRoomTypeLabel";
            selectedRoomTypeLabel.Size = new System.Drawing.Size(34, 13);
            selectedRoomTypeLabel.TabIndex = 21;
            selectedRoomTypeLabel.Text = "Type:";
            // 
            // selectedRoomBedsLabel
            // 
            selectedRoomBedsLabel.AutoSize = true;
            selectedRoomBedsLabel.Location = new System.Drawing.Point(217, 166);
            selectedRoomBedsLabel.Name = "selectedRoomBedsLabel";
            selectedRoomBedsLabel.Size = new System.Drawing.Size(34, 13);
            selectedRoomBedsLabel.TabIndex = 22;
            selectedRoomBedsLabel.Text = "Beds:";
            // 
            // selectedRoomPriceLabel
            // 
            selectedRoomPriceLabel.AutoSize = true;
            selectedRoomPriceLabel.Location = new System.Drawing.Point(217, 189);
            selectedRoomPriceLabel.Name = "selectedRoomPriceLabel";
            selectedRoomPriceLabel.Size = new System.Drawing.Size(34, 13);
            selectedRoomPriceLabel.TabIndex = 23;
            selectedRoomPriceLabel.Text = "Price:";
            // 
            // arrivalDateDateTimePicker
            // 
            this.arrivalDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservationBindingSource, "ArrivalDate", true));
            this.arrivalDateDateTimePicker.Location = new System.Drawing.Point(111, 91);
            this.arrivalDateDateTimePicker.Name = "arrivalDateDateTimePicker";
            this.arrivalDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.arrivalDateDateTimePicker.TabIndex = 4;
            this.arrivalDateDateTimePicker.ValueChanged += new System.EventHandler(this.arrivalDateDateTimePicker_ValueChanged);
            // 
            // bedsTextBox
            // 
            this.bedsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "Beds", true));
            this.bedsTextBox.Enabled = false;
            this.bedsTextBox.Location = new System.Drawing.Point(111, 228);
            this.bedsTextBox.Name = "bedsTextBox";
            this.bedsTextBox.Size = new System.Drawing.Size(200, 20);
            this.bedsTextBox.TabIndex = 6;
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "ContactPerson", true));
            this.contactPersonTextBox.Enabled = false;
            this.contactPersonTextBox.Location = new System.Drawing.Point(111, 65);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(200, 20);
            this.contactPersonTextBox.TabIndex = 8;
            // 
            // leavingDateDateTimePicker
            // 
            this.leavingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservationBindingSource, "LeavingDate", true));
            this.leavingDateDateTimePicker.Location = new System.Drawing.Point(111, 117);
            this.leavingDateDateTimePicker.Name = "leavingDateDateTimePicker";
            this.leavingDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.leavingDateDateTimePicker.TabIndex = 12;
            this.leavingDateDateTimePicker.ValueChanged += new System.EventHandler(this.leavingDateDateTimePicker_ValueChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "Price", true));
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(111, 254);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 14;
            // 
            // reservationIDTextBox
            // 
            this.reservationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "ReservationID", true));
            this.reservationIDTextBox.Location = new System.Drawing.Point(111, 12);
            this.reservationIDTextBox.Name = "reservationIDTextBox";
            this.reservationIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.reservationIDTextBox.TabIndex = 18;
            // 
            // agencyIDComboBox
            // 
            this.agencyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "AgencyID", true));
            this.agencyIDComboBox.FormattingEnabled = true;
            this.agencyIDComboBox.Location = new System.Drawing.Point(111, 38);
            this.agencyIDComboBox.Name = "agencyIDComboBox";
            this.agencyIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.agencyIDComboBox.TabIndex = 19;
            this.agencyIDComboBox.SelectedIndexChanged += new System.EventHandler(this.agencyIDComboBox_SelectedIndexChanged);
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormatString = "Room \\#000";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(111, 143);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(100, 79);
            this.roomsListBox.TabIndex = 20;
            this.roomsListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.roomsListBox_ItemCheck);
            this.roomsListBox.SelectedValueChanged += new System.EventHandler(this.roomsListBox_SelectedValueChanged);
            // 
            // roomsLabel
            // 
            this.roomsLabel.AutoSize = true;
            this.roomsLabel.Location = new System.Drawing.Point(12, 143);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(43, 13);
            this.roomsLabel.TabIndex = 21;
            this.roomsLabel.Text = "Rooms:";
            // 
            // selectedRoomTypeField
            // 
            this.selectedRoomTypeField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Type", true));
            this.selectedRoomTypeField.Location = new System.Drawing.Point(257, 143);
            this.selectedRoomTypeField.Name = "selectedRoomTypeField";
            this.selectedRoomTypeField.Size = new System.Drawing.Size(54, 23);
            this.selectedRoomTypeField.TabIndex = 22;
            // 
            // selectedRoomBedsField
            // 
            this.selectedRoomBedsField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Beds", true));
            this.selectedRoomBedsField.Location = new System.Drawing.Point(257, 166);
            this.selectedRoomBedsField.Name = "selectedRoomBedsField";
            this.selectedRoomBedsField.Size = new System.Drawing.Size(54, 23);
            this.selectedRoomBedsField.TabIndex = 23;
            // 
            // selectedRoomPriceField
            // 
            this.selectedRoomPriceField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Price", true));
            this.selectedRoomPriceField.Location = new System.Drawing.Point(257, 189);
            this.selectedRoomPriceField.Name = "selectedRoomPriceField";
            this.selectedRoomPriceField.Size = new System.Drawing.Size(54, 23);
            this.selectedRoomPriceField.TabIndex = 24;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(187, 298);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 26;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(60, 298);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(Room);
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(Reservation);
            // 
            // single_ReservationBindingSource
            // 
            this.single_ReservationBindingSource.DataSource = typeof(Single_Reservation);
            // 
            // Reservation_edit
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(323, 333);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(selectedRoomPriceLabel);
            this.Controls.Add(this.selectedRoomPriceField);
            this.Controls.Add(selectedRoomBedsLabel);
            this.Controls.Add(this.selectedRoomBedsField);
            this.Controls.Add(selectedRoomTypeLabel);
            this.Controls.Add(this.selectedRoomTypeField);
            this.Controls.Add(this.roomsLabel);
            this.Controls.Add(this.roomsListBox);
            this.Controls.Add(agencyIDLabel1);
            this.Controls.Add(this.agencyIDComboBox);
            this.Controls.Add(arrivalDateLabel);
            this.Controls.Add(this.arrivalDateDateTimePicker);
            this.Controls.Add(bedsLabel);
            this.Controls.Add(this.bedsTextBox);
            this.Controls.Add(contactPersonLabel);
            this.Controls.Add(this.contactPersonTextBox);
            this.Controls.Add(leavingDateLabel);
            this.Controls.Add(this.leavingDateDateTimePicker);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(reservationIDLabel);
            this.Controls.Add(this.reservationIDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Reservation_edit";
            this.Text = "Reservation Details";
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.single_ReservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.DateTimePicker arrivalDateDateTimePicker;
        private System.Windows.Forms.TextBox bedsTextBox;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.DateTimePicker leavingDateDateTimePicker;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox reservationIDTextBox;
        private System.Windows.Forms.ComboBox agencyIDComboBox;
        private System.Windows.Forms.BindingSource single_ReservationBindingSource;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.CheckedListBox roomsListBox;
        private System.Windows.Forms.Label roomsLabel;
        private System.Windows.Forms.Label selectedRoomTypeField;
        private System.Windows.Forms.Label selectedRoomBedsField;
        private System.Windows.Forms.Label selectedRoomPriceField;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
    }
}