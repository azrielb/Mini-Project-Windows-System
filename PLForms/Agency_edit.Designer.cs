namespace PLForms
{
    partial class Agency_edit
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
            System.Windows.Forms.Label agencyIDLabel;
            System.Windows.Forms.Label contactPersonLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label typeLabel;
            this.tour_AgencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencyIDTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.typeListBox = new System.Windows.Forms.ListBox();
            agencyIDLabel = new System.Windows.Forms.Label();
            contactPersonLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tour_AgencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agencyIDLabel
            // 
            agencyIDLabel.AutoSize = true;
            agencyIDLabel.Location = new System.Drawing.Point(12, 9);
            agencyIDLabel.Name = "agencyIDLabel";
            agencyIDLabel.Size = new System.Drawing.Size(60, 13);
            agencyIDLabel.TabIndex = 1;
            agencyIDLabel.Text = "Agency ID:";
            // 
            // contactPersonLabel
            // 
            contactPersonLabel.AutoSize = true;
            contactPersonLabel.Location = new System.Drawing.Point(12, 110);
            contactPersonLabel.Name = "contactPersonLabel";
            contactPersonLabel.Size = new System.Drawing.Size(83, 13);
            contactPersonLabel.TabIndex = 3;
            contactPersonLabel.Text = "Contact Person:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(12, 58);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 10;
            typeLabel.Text = "Type:";
            // 
            // tour_AgencyBindingSource
            // 
            this.tour_AgencyBindingSource.DataSource = typeof(BE.Tour_Agency);
            // 
            // agencyIDTextBox
            // 
            this.agencyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tour_AgencyBindingSource, "AgencyID", true));
            this.agencyIDTextBox.Location = new System.Drawing.Point(101, 6);
            this.agencyIDTextBox.Name = "agencyIDTextBox";
            this.agencyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.agencyIDTextBox.TabIndex = 2;
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tour_AgencyBindingSource, "ContactPerson", true));
            this.contactPersonTextBox.Location = new System.Drawing.Point(101, 107);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactPersonTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tour_AgencyBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(101, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(126, 143);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(15, 143);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // typeListBox
            // 
            this.typeListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tour_AgencyBindingSource, "Type", true));
            this.typeListBox.FormattingEnabled = true;
            this.typeListBox.Location = new System.Drawing.Point(101, 58);
            this.typeListBox.Name = "typeListBox";
            this.typeListBox.Size = new System.Drawing.Size(100, 43);
            this.typeListBox.TabIndex = 11;
            // 
            // Agency_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 181);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeListBox);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(agencyIDLabel);
            this.Controls.Add(this.agencyIDTextBox);
            this.Controls.Add(contactPersonLabel);
            this.Controls.Add(this.contactPersonTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Agency_edit";
            this.Text = "Agency Details";
            ((System.ComponentModel.ISupportInitialize)(this.tour_AgencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tour_AgencyBindingSource;
        private System.Windows.Forms.TextBox agencyIDTextBox;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ListBox typeListBox;
    }
}