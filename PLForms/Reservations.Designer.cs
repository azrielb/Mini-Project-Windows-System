namespace PLForms
{
    partial class Reservations
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
            System.Windows.Forms.Label reservationIDLabel;
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationIDListBox = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            reservationIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(BE.Reservation);
            // 
            // reservationIDLabel
            // 
            reservationIDLabel.AutoSize = true;
            reservationIDLabel.Location = new System.Drawing.Point(12, 9);
            reservationIDLabel.Name = "reservationIDLabel";
            reservationIDLabel.Size = new System.Drawing.Size(67, 13);
            reservationIDLabel.TabIndex = 0;
            reservationIDLabel.Text = "Reservation:";
            // 
            // reservationIDListBox
            // 
            this.reservationIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reservationBindingSource, "ReservationID", true));
            this.reservationIDListBox.FormattingEnabled = true;
            this.reservationIDListBox.Location = new System.Drawing.Point(89, 9);
            this.reservationIDListBox.Name = "reservationIDListBox";
            this.reservationIDListBox.Size = new System.Drawing.Size(120, 95);
            this.reservationIDListBox.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(15, 84);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(68, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add New";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(15, 54);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(68, 23);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(15, 25);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(68, 23);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 122);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(reservationIDLabel);
            this.Controls.Add(this.reservationIDListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reservations";
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.ListBox reservationIDListBox;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
    }
}