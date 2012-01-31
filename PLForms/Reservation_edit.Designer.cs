namespace PLForms
{
    partial class Reservation_edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label arrivalDateLabel;
            System.Windows.Forms.Label bedsLabel;
            System.Windows.Forms.Label contactPersonLabel;
            System.Windows.Forms.Label leavingDateLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label reservationDateLabel;
            System.Windows.Forms.Label reservationIDLabel;
            System.Windows.Forms.Label agencyIDLabel1;
            System.Windows.Forms.Label daysLabel;
            System.Windows.Forms.Label roomIDLabel;
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arrivalDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bedsTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.leavingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.reservationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservationIDTextBox = new System.Windows.Forms.TextBox();
            this.agencyIDComboBox = new System.Windows.Forms.ComboBox();
            this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.single_ReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomIDListBox = new System.Windows.Forms.ListBox();
            arrivalDateLabel = new System.Windows.Forms.Label();
            bedsLabel = new System.Windows.Forms.Label();
            contactPersonLabel = new System.Windows.Forms.Label();
            leavingDateLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            reservationDateLabel = new System.Windows.Forms.Label();
            reservationIDLabel = new System.Windows.Forms.Label();
            agencyIDLabel1 = new System.Windows.Forms.Label();
            daysLabel = new System.Windows.Forms.Label();
            roomIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.single_ReservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // arrivalDateLabel
            // 
            arrivalDateLabel.AutoSize = true;
            arrivalDateLabel.Location = new System.Drawing.Point(12, 147);
            arrivalDateLabel.Name = "arrivalDateLabel";
            arrivalDateLabel.Size = new System.Drawing.Size(65, 13);
            arrivalDateLabel.TabIndex = 3;
            arrivalDateLabel.Text = "Arrival Date:";
            // 
            // bedsLabel
            // 
            bedsLabel.AutoSize = true;
            bedsLabel.Location = new System.Drawing.Point(12, 120);
            bedsLabel.Name = "bedsLabel";
            bedsLabel.Size = new System.Drawing.Size(34, 13);
            bedsLabel.TabIndex = 5;
            bedsLabel.Text = "Beds:";
            // 
            // contactPersonLabel
            // 
            contactPersonLabel.AutoSize = true;
            contactPersonLabel.Location = new System.Drawing.Point(12, 94);
            contactPersonLabel.Name = "contactPersonLabel";
            contactPersonLabel.Size = new System.Drawing.Size(83, 13);
            contactPersonLabel.TabIndex = 7;
            contactPersonLabel.Text = "Contact Person:";
            // 
            // leavingDateLabel
            // 
            leavingDateLabel.AutoSize = true;
            leavingDateLabel.Location = new System.Drawing.Point(12, 173);
            leavingDateLabel.Name = "leavingDateLabel";
            leavingDateLabel.Size = new System.Drawing.Size(74, 13);
            leavingDateLabel.TabIndex = 11;
            leavingDateLabel.Text = "Leaving Date:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(12, 224);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Price:";
            // 
            // reservationDateLabel
            // 
            reservationDateLabel.AutoSize = true;
            reservationDateLabel.Location = new System.Drawing.Point(12, 42);
            reservationDateLabel.Name = "reservationDateLabel";
            reservationDateLabel.Size = new System.Drawing.Size(93, 13);
            reservationDateLabel.TabIndex = 15;
            reservationDateLabel.Text = "Reservation Date:";
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
            agencyIDLabel1.Location = new System.Drawing.Point(12, 67);
            agencyIDLabel1.Name = "agencyIDLabel1";
            agencyIDLabel1.Size = new System.Drawing.Size(46, 13);
            agencyIDLabel1.TabIndex = 18;
            agencyIDLabel1.Text = "Agency:";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(BE.Reservation);
            // 
            // arrivalDateDateTimePicker
            // 
            this.arrivalDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservationBindingSource, "ArrivalDate", true));
            this.arrivalDateDateTimePicker.Location = new System.Drawing.Point(111, 143);
            this.arrivalDateDateTimePicker.Name = "arrivalDateDateTimePicker";
            this.arrivalDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.arrivalDateDateTimePicker.TabIndex = 4;
            this.arrivalDateDateTimePicker.ValueChanged += new System.EventHandler(this.arrivalDateDateTimePicker_ValueChanged);
            // 
            // bedsTextBox
            // 
            this.bedsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "Beds", true));
            this.bedsTextBox.Location = new System.Drawing.Point(111, 117);
            this.bedsTextBox.Name = "bedsTextBox";
            this.bedsTextBox.Size = new System.Drawing.Size(200, 20);
            this.bedsTextBox.TabIndex = 6;
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "ContactPerson", true));
            this.contactPersonTextBox.Location = new System.Drawing.Point(111, 91);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(200, 20);
            this.contactPersonTextBox.TabIndex = 8;
            // 
            // leavingDateDateTimePicker
            // 
            this.leavingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservationBindingSource, "LeavingDate", true));
            this.leavingDateDateTimePicker.Location = new System.Drawing.Point(111, 169);
            this.leavingDateDateTimePicker.Name = "leavingDateDateTimePicker";
            this.leavingDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.leavingDateDateTimePicker.TabIndex = 12;
            this.leavingDateDateTimePicker.ValueChanged += new System.EventHandler(this.leavingDateDateTimePicker_ValueChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(111, 221);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 14;
            // 
            // reservationDateDateTimePicker
            // 
            this.reservationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservationBindingSource, "ReservationDate", true));
            this.reservationDateDateTimePicker.Location = new System.Drawing.Point(111, 38);
            this.reservationDateDateTimePicker.Name = "reservationDateDateTimePicker";
            this.reservationDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.reservationDateDateTimePicker.TabIndex = 16;
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
            this.agencyIDComboBox.Location = new System.Drawing.Point(111, 64);
            this.agencyIDComboBox.Name = "agencyIDComboBox";
            this.agencyIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.agencyIDComboBox.TabIndex = 19;
            // 
            // daysLabel
            // 
            daysLabel.AutoSize = true;
            daysLabel.Location = new System.Drawing.Point(12, 197);
            daysLabel.Name = "daysLabel";
            daysLabel.Size = new System.Drawing.Size(34, 13);
            daysLabel.TabIndex = 19;
            daysLabel.Text = "Days:";
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservationBindingSource, "Days", true));
            this.daysNumericUpDown.Location = new System.Drawing.Point(111, 195);
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.daysNumericUpDown.TabIndex = 20;
            this.daysNumericUpDown.ValueChanged += new System.EventHandler(this.daysNumericUpDown_ValueChanged);
            // 
            // single_ReservationBindingSource
            // 
            this.single_ReservationBindingSource.DataSource = typeof(BE.Single_Reservation);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(BE.Room);
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Location = new System.Drawing.Point(12, 247);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new System.Drawing.Size(52, 13);
            roomIDLabel.TabIndex = 20;
            roomIDLabel.Text = "Room ID:";
            // 
            // roomIDListBox
            // 
            this.roomIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomBindingSource, "RoomID", true));
            this.roomIDListBox.FormattingEnabled = true;
            this.roomIDListBox.Location = new System.Drawing.Point(111, 247);
            this.roomIDListBox.Name = "roomIDListBox";
            this.roomIDListBox.Size = new System.Drawing.Size(200, 82);
            this.roomIDListBox.TabIndex = 21;
            // 
            // Reservation_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 410);
            this.Controls.Add(roomIDLabel);
            this.Controls.Add(this.roomIDListBox);
            this.Controls.Add(daysLabel);
            this.Controls.Add(this.daysNumericUpDown);
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
            this.Controls.Add(reservationDateLabel);
            this.Controls.Add(this.reservationDateDateTimePicker);
            this.Controls.Add(reservationIDLabel);
            this.Controls.Add(this.reservationIDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Reservation_edit";
            this.Text = "Reservation Details";
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.single_ReservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
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
        private System.Windows.Forms.DateTimePicker reservationDateDateTimePicker;
        private System.Windows.Forms.TextBox reservationIDTextBox;
        private System.Windows.Forms.ComboBox agencyIDComboBox;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.BindingSource single_ReservationBindingSource;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.ListBox roomIDListBox;
    }
}