﻿namespace PLForms
{
    /// <summary>
    /// 
    /// </summary>
    partial class Agencies
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
            this.tour_AgencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencyIDListBox = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            agencyIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tour_AgencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agencyIDLabel
            // 
            agencyIDLabel.AutoSize = true;
            agencyIDLabel.Location = new System.Drawing.Point(12, 9);
            agencyIDLabel.Name = "agencyIDLabel";
            agencyIDLabel.Size = new System.Drawing.Size(46, 13);
            agencyIDLabel.TabIndex = 0;
            agencyIDLabel.Text = "Agency:";
            // 
            // tour_AgencyBindingSource
            // 
            this.tour_AgencyBindingSource.DataSource = typeof(BL_ServiceReference.Tour_Agency);
            // 
            // agencyIDListBox
            // 
            this.agencyIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tour_AgencyBindingSource, "AgencyID", true));
            this.agencyIDListBox.FormattingEnabled = true;
            this.agencyIDListBox.Location = new System.Drawing.Point(89, 9);
            this.agencyIDListBox.Name = "agencyIDListBox";
            this.agencyIDListBox.Size = new System.Drawing.Size(120, 95);
            this.agencyIDListBox.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(15, 84);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(68, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add New";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(15, 54);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(68, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(15, 25);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(68, 23);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Agencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 122);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(agencyIDLabel);
            this.Controls.Add(this.agencyIDListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Agencies";
            this.Text = "Agencies";
            ((System.ComponentModel.ISupportInitialize)(this.tour_AgencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tour_AgencyBindingSource;
        private System.Windows.Forms.ListBox agencyIDListBox;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
    }
}