namespace Aviation
{
    partial class appbody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appbody));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.Slidingpanel = new System.Windows.Forms.Panel();
            this.ticketinfo_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.AandA_buttton = new System.Windows.Forms.Button();
            this.passengerinfo_button = new System.Windows.Forms.Button();
            this.flightinfo_button = new System.Windows.Forms.Button();
            this.slidingpanel_togglebutton = new System.Windows.Forms.Button();
            this.slidingpanel_timer = new System.Windows.Forms.Timer(this.components);
            this.contentpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Slidingpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.closebutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 28);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // logout
            // 
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.logout.Location = new System.Drawing.Point(931, 0);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(35, 30);
            this.logout.TabIndex = 2;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.minimize.Location = new System.Drawing.Point(973, 0);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(35, 30);
            this.minimize.TabIndex = 3;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // closebutton
            // 
            this.closebutton.ForeColor = System.Drawing.Color.Black;
            this.closebutton.Image = global::Aviation.Properties.Resources.icons8_close_window_24;
            this.closebutton.Location = new System.Drawing.Point(1016, 0);
            this.closebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closebutton.Name = "closebutton";
            this.closebutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.closebutton.Size = new System.Drawing.Size(35, 30);
            this.closebutton.TabIndex = 1;
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // Slidingpanel
            // 
            this.Slidingpanel.BackColor = System.Drawing.Color.SlateBlue;
            this.Slidingpanel.Controls.Add(this.ticketinfo_button);
            this.Slidingpanel.Controls.Add(this.about_button);
            this.Slidingpanel.Controls.Add(this.AandA_buttton);
            this.Slidingpanel.Controls.Add(this.passengerinfo_button);
            this.Slidingpanel.Controls.Add(this.flightinfo_button);
            this.Slidingpanel.Controls.Add(this.slidingpanel_togglebutton);
            this.Slidingpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Slidingpanel.Location = new System.Drawing.Point(0, 28);
            this.Slidingpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Slidingpanel.Name = "Slidingpanel";
            this.Slidingpanel.Size = new System.Drawing.Size(240, 526);
            this.Slidingpanel.TabIndex = 1;
            this.Slidingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Slidingpanel_Paint);
            // 
            // ticketinfo_button
            // 
            this.ticketinfo_button.BackColor = System.Drawing.Color.Transparent;
            this.ticketinfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketinfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketinfo_button.Image = global::Aviation.Properties.Resources.icons8_two_tickets_241;
            this.ticketinfo_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ticketinfo_button.Location = new System.Drawing.Point(0, 220);
            this.ticketinfo_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ticketinfo_button.Name = "ticketinfo_button";
            this.ticketinfo_button.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.ticketinfo_button.Size = new System.Drawing.Size(240, 64);
            this.ticketinfo_button.TabIndex = 7;
            this.ticketinfo_button.Text = "TICKET INFO";
            this.ticketinfo_button.UseVisualStyleBackColor = false;
            this.ticketinfo_button.Click += new System.EventHandler(this.ticketinfo_button_Click);
            // 
            // about_button
            // 
            this.about_button.BackColor = System.Drawing.Color.Transparent;
            this.about_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_button.Image = global::Aviation.Properties.Resources.icons8_about_24;
            this.about_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about_button.Location = new System.Drawing.Point(0, 276);
            this.about_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.about_button.Name = "about_button";
            this.about_button.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.about_button.Size = new System.Drawing.Size(240, 60);
            this.about_button.TabIndex = 6;
            this.about_button.Text = "ABOUT";
            this.about_button.UseVisualStyleBackColor = false;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // AandA_buttton
            // 
            this.AandA_buttton.BackColor = System.Drawing.Color.Transparent;
            this.AandA_buttton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AandA_buttton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AandA_buttton.Image = global::Aviation.Properties.Resources.icons8_luggage_trolley_24;
            this.AandA_buttton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AandA_buttton.Location = new System.Drawing.Point(0, 151);
            this.AandA_buttton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AandA_buttton.Name = "AandA_buttton";
            this.AandA_buttton.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.AandA_buttton.Size = new System.Drawing.Size(240, 71);
            this.AandA_buttton.TabIndex = 5;
            this.AandA_buttton.Text = "AIRPORT AND AIRLINES";
            this.AandA_buttton.UseVisualStyleBackColor = false;
            this.AandA_buttton.Click += new System.EventHandler(this.settings_buttton_Click);
            // 
            // passengerinfo_button
            // 
            this.passengerinfo_button.BackColor = System.Drawing.Color.Transparent;
            this.passengerinfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passengerinfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerinfo_button.Image = global::Aviation.Properties.Resources.icons8_user_30;
            this.passengerinfo_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passengerinfo_button.Location = new System.Drawing.Point(0, 50);
            this.passengerinfo_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passengerinfo_button.Name = "passengerinfo_button";
            this.passengerinfo_button.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.passengerinfo_button.Size = new System.Drawing.Size(240, 54);
            this.passengerinfo_button.TabIndex = 4;
            this.passengerinfo_button.Text = "PASSENGER ";
            this.passengerinfo_button.UseVisualStyleBackColor = false;
            this.passengerinfo_button.Click += new System.EventHandler(this.passengerinfo_button_Click);
            // 
            // flightinfo_button
            // 
            this.flightinfo_button.BackColor = System.Drawing.Color.Transparent;
            this.flightinfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flightinfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightinfo_button.Image = global::Aviation.Properties.Resources.icons8_airplane_mode_on_24;
            this.flightinfo_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flightinfo_button.Location = new System.Drawing.Point(0, 101);
            this.flightinfo_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flightinfo_button.Name = "flightinfo_button";
            this.flightinfo_button.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.flightinfo_button.Size = new System.Drawing.Size(240, 54);
            this.flightinfo_button.TabIndex = 3;
            this.flightinfo_button.Text = "FLIGHT ";
            this.flightinfo_button.UseVisualStyleBackColor = false;
            this.flightinfo_button.Click += new System.EventHandler(this.flightinfo_button_Click);
            // 
            // slidingpanel_togglebutton
            // 
            this.slidingpanel_togglebutton.BackColor = System.Drawing.Color.Transparent;
            this.slidingpanel_togglebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slidingpanel_togglebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slidingpanel_togglebutton.Image = global::Aviation.Properties.Resources.icons8_double_left_24;
            this.slidingpanel_togglebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slidingpanel_togglebutton.Location = new System.Drawing.Point(0, 0);
            this.slidingpanel_togglebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slidingpanel_togglebutton.Name = "slidingpanel_togglebutton";
            this.slidingpanel_togglebutton.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.slidingpanel_togglebutton.Size = new System.Drawing.Size(240, 54);
            this.slidingpanel_togglebutton.TabIndex = 2;
            this.slidingpanel_togglebutton.Text = "SLIDE";
            this.slidingpanel_togglebutton.UseVisualStyleBackColor = false;
            this.slidingpanel_togglebutton.Click += new System.EventHandler(this.slidingpanel_togglebutton_Click);
            // 
            // slidingpanel_timer
            // 
            this.slidingpanel_timer.Interval = 30;
            this.slidingpanel_timer.Tick += new System.EventHandler(this.slidingpanel_timer_Tick);
            // 
            // contentpanel
            // 
            this.contentpanel.BackgroundImage = global::Aviation.Properties.Resources.welcome5;
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentpanel.Location = new System.Drawing.Point(238, 28);
            this.contentpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(829, 526);
            this.contentpanel.TabIndex = 2;
            this.contentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentpanel_Paint);
            // 
            // appbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.Slidingpanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "appbody";
            this.Text = "appbody";
            this.Load += new System.EventHandler(this.appbody_Load);
            this.panel1.ResumeLayout(false);
            this.Slidingpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Panel Slidingpanel;
        private System.Windows.Forms.Button slidingpanel_togglebutton;
        private System.Windows.Forms.Timer slidingpanel_timer;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button AandA_buttton;
        private System.Windows.Forms.Button passengerinfo_button;
        private System.Windows.Forms.Button flightinfo_button;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Button ticketinfo_button;
    }
}