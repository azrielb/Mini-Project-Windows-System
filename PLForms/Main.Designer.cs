namespace PLForms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_Reservations = new System.Windows.Forms.Button();
            this.btn_Agencies = new System.Windows.Forms.Button();
            this.btn_Rooms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Reservations
            // 
            this.btn_Reservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Reservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reservations.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reservations.ForeColor = System.Drawing.Color.White;
            this.btn_Reservations.Image = global::PLForms.Properties.Resources.concierge;
            this.btn_Reservations.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Reservations.Location = new System.Drawing.Point(224, 12);
            this.btn_Reservations.Name = "btn_Reservations";
            this.btn_Reservations.Size = new System.Drawing.Size(200, 100);
            this.btn_Reservations.TabIndex = 2;
            this.btn_Reservations.Text = "Reservations";
            this.btn_Reservations.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Reservations.UseVisualStyleBackColor = false;
            this.btn_Reservations.Click += new System.EventHandler(this.btn_Reservations_Click);
            // 
            // btn_Agencies
            // 
            this.btn_Agencies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Agencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agencies.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agencies.ForeColor = System.Drawing.Color.White;
            this.btn_Agencies.Image = global::PLForms.Properties.Resources.w_airport;
            this.btn_Agencies.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Agencies.Location = new System.Drawing.Point(12, 133);
            this.btn_Agencies.Name = "btn_Agencies";
            this.btn_Agencies.Size = new System.Drawing.Size(200, 100);
            this.btn_Agencies.TabIndex = 1;
            this.btn_Agencies.Text = "Travel Agencies";
            this.btn_Agencies.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Agencies.UseVisualStyleBackColor = false;
            this.btn_Agencies.Click += new System.EventHandler(this.btn_Agencies_Click);
            // 
            // btn_Rooms
            // 
            this.btn_Rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rooms.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rooms.ForeColor = System.Drawing.Color.White;
            this.btn_Rooms.Image = global::PLForms.Properties.Resources.bed_hi_copy;
            this.btn_Rooms.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Rooms.Location = new System.Drawing.Point(12, 12);
            this.btn_Rooms.Name = "btn_Rooms";
            this.btn_Rooms.Size = new System.Drawing.Size(200, 100);
            this.btn_Rooms.TabIndex = 0;
            this.btn_Rooms.Text = "Rooms";
            this.btn_Rooms.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Rooms.UseVisualStyleBackColor = false;
            this.btn_Rooms.Click += new System.EventHandler(this.btn_Rooms_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 245);
            this.Controls.Add(this.btn_Reservations);
            this.Controls.Add(this.btn_Agencies);
            this.Controls.Add(this.btn_Rooms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Hotel Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Rooms;
        private System.Windows.Forms.Button btn_Agencies;
        private System.Windows.Forms.Button btn_Reservations;



    }
}

