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
            this.btn_Rooms = new System.Windows.Forms.Button();
            this.btn_Agencies = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Rooms
            // 
            this.btn_Rooms.Location = new System.Drawing.Point(12, 12);
            this.btn_Rooms.Name = "btn_Rooms";
            this.btn_Rooms.Size = new System.Drawing.Size(75, 75);
            this.btn_Rooms.TabIndex = 0;
            this.btn_Rooms.Text = "Rooms";
            this.btn_Rooms.UseVisualStyleBackColor = true;
            this.btn_Rooms.Click += new System.EventHandler(this.btn_Rooms_Click);
            // 
            // btn_Agencies
            // 
            this.btn_Agencies.Location = new System.Drawing.Point(93, 12);
            this.btn_Agencies.Name = "btn_Agencies";
            this.btn_Agencies.Size = new System.Drawing.Size(75, 75);
            this.btn_Agencies.TabIndex = 1;
            this.btn_Agencies.Text = "Travel Agencies";
            this.btn_Agencies.UseVisualStyleBackColor = true;
            this.btn_Agencies.Click += new System.EventHandler(this.btn_Agencies_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(175, 13);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(75, 75);
            this.btn_Order.TabIndex = 2;
            this.btn_Order.Text = "Order Room(s)";
            this.btn_Order.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 97);
            this.Controls.Add(this.btn_Order);
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
        private System.Windows.Forms.Button btn_Order;



    }
}

