namespace PLForms
{
    partial class Room_edit
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
            System.Windows.Forms.Label bedsLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label roomIDLabel;
            System.Windows.Forms.Label seaWatchingLabel;
            System.Windows.Forms.Label typeLabel;
            this.bedsTextBox = new System.Windows.Forms.TextBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.roomIDTextBox = new System.Windows.Forms.TextBox();
            this.seaWatchingCheckBox = new System.Windows.Forms.CheckBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.typeListBox = new System.Windows.Forms.ListBox();
            bedsLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            roomIDLabel = new System.Windows.Forms.Label();
            seaWatchingLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bedsLabel
            // 
            bedsLabel.AutoSize = true;
            bedsLabel.Location = new System.Drawing.Point(12, 35);
            bedsLabel.Name = "bedsLabel";
            bedsLabel.Size = new System.Drawing.Size(34, 13);
            bedsLabel.TabIndex = 1;
            bedsLabel.Text = "Beds:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(12, 61);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price:";
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Location = new System.Drawing.Point(12, 9);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new System.Drawing.Size(52, 13);
            roomIDLabel.TabIndex = 5;
            roomIDLabel.Text = "Room ID:";
            // 
            // seaWatchingLabel
            // 
            seaWatchingLabel.AutoSize = true;
            seaWatchingLabel.Location = new System.Drawing.Point(12, 89);
            seaWatchingLabel.Name = "seaWatchingLabel";
            seaWatchingLabel.Size = new System.Drawing.Size(78, 13);
            seaWatchingLabel.TabIndex = 7;
            seaWatchingLabel.Text = "Sea Watching:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(12, 113);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 12;
            typeLabel.Text = "Type:";
            // 
            // bedsTextBox
            // 
            this.bedsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Beds", true));
            this.bedsTextBox.Location = new System.Drawing.Point(96, 32);
            this.bedsTextBox.Name = "bedsTextBox";
            this.bedsTextBox.Size = new System.Drawing.Size(104, 20);
            this.bedsTextBox.TabIndex = 2;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(BE.Room);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Price", true));
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.roomBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(96, 58);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(104, 20);
            this.priceTextBox.TabIndex = 3;
            // 
            // roomIDTextBox
            // 
            this.roomIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "RoomID", true));
            this.roomIDTextBox.Location = new System.Drawing.Point(96, 6);
            this.roomIDTextBox.Name = "roomIDTextBox";
            this.roomIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.roomIDTextBox.TabIndex = 1;
            // 
            // seaWatchingCheckBox
            // 
            this.seaWatchingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.roomBindingSource, "SeaWatching", true));
            this.seaWatchingCheckBox.Location = new System.Drawing.Point(96, 84);
            this.seaWatchingCheckBox.Name = "seaWatchingCheckBox";
            this.seaWatchingCheckBox.Size = new System.Drawing.Size(104, 24);
            this.seaWatchingCheckBox.TabIndex = 4;
            this.seaWatchingCheckBox.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(15, 158);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(124, 158);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // typeListBox
            // 
            this.typeListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomBindingSource, "Type", true));
            this.typeListBox.DataSource = this.roomBindingSource;
            this.typeListBox.DisplayMember = "Type";
            this.typeListBox.FormattingEnabled = true;
            this.typeListBox.Location = new System.Drawing.Point(96, 113);
            this.typeListBox.Name = "typeListBox";
            this.typeListBox.Size = new System.Drawing.Size(104, 30);
            this.typeListBox.TabIndex = 5;
            this.typeListBox.SelectedIndexChanged += new System.EventHandler(this.typeListBox_SelectedIndexChanged);
            // 
            // Room_edit
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(219, 214);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeListBox);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(bedsLabel);
            this.Controls.Add(this.bedsTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(roomIDLabel);
            this.Controls.Add(this.roomIDTextBox);
            this.Controls.Add(seaWatchingLabel);
            this.Controls.Add(this.seaWatchingCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Room_edit";
            this.Text = "Room Details";
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.TextBox bedsTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox roomIDTextBox;
        private System.Windows.Forms.CheckBox seaWatchingCheckBox;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ListBox typeListBox;
    }
}